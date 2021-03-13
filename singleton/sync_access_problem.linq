<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

void Main()
{
	int size = 10;
	Task[] tasks = new Task[size];
	for (int i = 0; i < size; i++)
	{
		tasks[i] = Task.Run(() =>
		{
			var c = MemoryCache.Create();
			if (c.AquireKey("job_id", "job1"))
			{
				"Big Operation".Dump();
			}
		});
	}
	Task.WaitAll(tasks);
}


public class MemoryCache
{
	private static MemoryCache cache;
	private static object cacheLock = new object();

	private readonly Dictionary<string, string> _registry;

	private MemoryCache() => _registry = new Dictionary<string, string>();

	public static MemoryCache Create()
	{
		if (cache == null)
		{
			lock (cacheLock)
			{
				if (cache == null)
				{
					return cache = new MemoryCache();
				}
			}
		}

		return cache;
	}

	public bool Contains(string key, string value)
	{
		return _registry.Contains(KeyValuePair.Create(key, value));
	}

	public void Write(string key, string value)
	{
		_registry[key] = value;
	}


	public bool AquireKey(string key, string value)
	{
		lock (cacheLock)
		{
			if (Contains("job_id", "job1"))
			{
				return false;
			}
			Write("job_id", "job1");
			
			return true;
		}
	}
}