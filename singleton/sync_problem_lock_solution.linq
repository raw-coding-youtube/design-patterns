<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int size = 8;
	Task[] tasks = new Task[size];
	for (int i = 0; i < size; i++)
	{
		tasks[i] = Task.Run(() => MemoryCache.Create());
	}
	Task.WaitAll(tasks);
	//MemoryCache.Create();
}


public class MemoryCache
{
	private static int i = 0;
	private static MemoryCache _instance;
	private static object _cacheLock = new object();

	private MemoryCache()
	{
		$"Created {i++}".Dump();
	}

	public static MemoryCache Create()
	{
		if (_instance == null)
		{
			lock (_cacheLock)
			{
				if (_instance == null)
				{
					return _instance = new MemoryCache();
				}
			}
		}

		return _instance;
	}
}