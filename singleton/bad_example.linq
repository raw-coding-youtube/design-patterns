<Query Kind="Program" />

void Main()
{
	MemoryCache.Create();
	MemoryCache.Create();
	MemoryCache.Create();
	MemoryCache.Create();
	MemoryCache.Create();
}

public class MemoryCache
{
	private static MemoryCache _instance;
	
	private MemoryCache() {
		"Created".Dump();
	}
	
	public static MemoryCache Create() {
		return _instance ?? (_instance = new MemoryCache());
	}	
}