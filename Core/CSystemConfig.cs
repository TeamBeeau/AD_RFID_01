using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Core
{

	public class CSystemConfig : CConfigOperator
	{
		public CSystemConfigData _obj = new CSystemConfigData();

		private static CSystemConfig _instance = null;

		public new CSystemConfigData config
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

		public static CSystemConfig instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new CSystemConfig();
				}
				return _instance;
			}
		}

		private CSystemConfig()
		{
		}

		public override int LoadConfig(string file)
		{
			_obj = null;
			try
			{
                //using FileStream stream = new FileStream(file, FileMode.Open);
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(CSystemConfigData));
                //_obj = xmlSerializer.Deserialize(stream) as CSystemConfigData;
                //if (_obj == null)
                //{
                //	_obj = new CSystemConfigData();
                //}
                using (FileStream stream = new FileStream(file, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(CSystemConfigData));
                    _obj = xmlSerializer.Deserialize(stream) as CSystemConfigData;

                    if (_obj == null)
                    {
                        _obj = new CSystemConfigData();
                    }
                }
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				_obj = new CSystemConfigData();
				return -1;
			}
			return 0;
		}

		public override int SaveConfig(string file)
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
				using (FileStream stream = new FileStream(file, FileMode.Create))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(CSystemConfigData));
					xmlSerializer.Serialize(stream, _obj);
				}
			}
			catch
			{
				return -1;
			}
			return 0;
		}
	}
}
