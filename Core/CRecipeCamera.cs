using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Core
{

	public class CRecipeCamera : CRecipeCameraOperator
	{
		public CRecipeCameraData _obj = new CRecipeCameraData();

		private static CRecipeCamera _instance = null;

		public new CRecipeCameraData config
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

		public static CRecipeCamera instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new CRecipeCamera();
				}
				return _instance;
			}
		}

		private CRecipeCamera()
		{
		}

		public override int LoadConfig(string file)
		{
			_obj = null;
			string path = Application.StartupPath + "\\partname\\" + file;
			try
			{
				using FileStream stream = new FileStream(path, FileMode.Open);
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(CRecipeCameraData));
				_obj = xmlSerializer.Deserialize(stream) as CRecipeCameraData;
				if (_obj == null)
				{
					_obj = new CRecipeCameraData();
				}
			}
			catch
			{
				_obj = new CRecipeCameraData();
				return -1;
			}
			return 0;
		}

		public override int SaveConfig(string file)
		{
			try
			{
				string path = Application.StartupPath + "\\partname\\" + file;
				try
				{
					File.Delete(path);
				}
				catch
				{
					return -1;
				}
				using FileStream stream = new FileStream(path, FileMode.Create);
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(CRecipeCameraData));
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
