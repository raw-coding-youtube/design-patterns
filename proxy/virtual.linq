<Query Kind="Program" />

void Main()
{
	var a = new Lazy<string>(() => "Hello World".Dump("a"));
	var b = a.Value;
	var c = a.Value;
}

public interface ISettings
{
	string GetConfig();
}

public class Settings : ISettings
{
	string _config;
	
	public Settings(string config) => _config = config;
	
	public string GetConfig() => _config;
}

public class LazyRemoteSettings : ISettings
{
	Settings _config;

	public LazyRemoteSettings(string address)
	{
		// prepare some http/db
	}

	public string GetConfig()
	{
		if (_config == null)
		{
			// fetch from appsettings/db/registry etc...
			_config = new Settings("config");
		}
		return "";
	}
}