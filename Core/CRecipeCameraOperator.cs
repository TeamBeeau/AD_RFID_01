using System.IO;
using System.Xml.Serialization;

namespace Core
{
public abstract class CRecipeCameraOperator
{
	private object _obj;

	public object config
	{
		get
		{
			return _obj;
		}
		set
		{
			_obj = value;
		}
	}

	public virtual int LoadConfig(string file)
	{
		_obj = null;
		try
		{
			using FileStream stream = new FileStream(file, FileMode.Open);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(object));
			_obj = xmlSerializer.Deserialize(stream);
		}
		catch
		{
			_obj = new object();
			return -1;
		}
		return 0;
	}

	public virtual int SaveConfig(string file)
	{
		try
		{
			try
			{
				File.Delete(file);
			}
			catch
			{
				return -1;
			}
			using FileStream stream = new FileStream(file, FileMode.Create);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(object));
			xmlSerializer.Serialize(stream, _obj);
		}
		catch
		{
			return -1;
		}
		return 0;
	}
}
}
