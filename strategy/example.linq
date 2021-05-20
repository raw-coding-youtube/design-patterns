<Query Kind="Program" />

void Main()
{
	
}

public class FileController
{
	IFileStorage filestorage;
	public FileController(IFileStorage filestorage) => this.filestorage = filestorage;
}


public interface IFileStorage
{
	byte[] GetFile(string id);
	void SaveFile();
}

public class Local : IFileStorage
{
	public byte[] GetFile(string id)
	{
		throw new NotImplementedException();
	}

	public void SaveFile()
	{
		throw new NotImplementedException();
	}
}

public class S3 : IFileStorage
{
	public byte[] GetFile(string id)
	{
		throw new NotImplementedException();
	}

	public void SaveFile()
	{
		throw new NotImplementedException();
	}
}

public class Bespoke : IFileStorage
{
	public byte[] GetFile(string id)
	{
		throw new NotImplementedException();
	}

	public void SaveFile()
	{
		throw new NotImplementedException();
	}
}