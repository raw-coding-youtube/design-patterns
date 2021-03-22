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

public class ProtectedSettings : ISettings
{
	AuthService _auth;
	Settings _config;

	public ProtectedSettings(AuthService auth)
	{
		_auth = auth;
		_config = new Settings("config");
	}

	public string GetConfig()
	{
		if (!_auth.Allowed)
		{
			throw new Exception("not allowed");
		}
		return _config.GetConfig();
	}
}

public class AuthService
{
	public bool Allowed => false;
}