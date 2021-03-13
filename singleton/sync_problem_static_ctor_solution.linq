<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int size = 8;
	Task[] tasks = new Task[size];
	for (int i = 0; i < size; i++){
		tasks[i] = Task.Run(() => MemoryCache.Create());
	}
	Task.WaitAll(tasks);
	//MemoryCache.Create();
}


public class MemoryCache
{
	private static int i = 0;
	private static MemoryCache _instance;
	
	static MemoryCache(){
		_instance = new MemoryCache();
	}

	private MemoryCache()
	{
		$"Created {i++}".Dump();
	}
	
	public static MemoryCache Create() {
		return _instance;
	}
}