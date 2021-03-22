<Query Kind="Program" />

void Main()
{

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

public class RemoteSettings : ISettings
{
	Settings _config;
	
	public RemoteSettings(string address)
	{
		// fetch from appsettings/db/registry etc...
		_config = new Settings("config");
	}

	public string GetConfig() {
		
		return "";
	}
}