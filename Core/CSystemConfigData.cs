using System;
using System.Xml.Serialization;

namespace Core
{

	[Serializable]
	[XmlRoot("data")]
	public class CSystemConfigData
	{
		private bool IsExternalTriggerMode_ = true;

		private string DefaultPartname_ = "default";

		private bool SkipNGImageSave_ = false;

		private bool SkipNormalImageSave_ = false;

		private int Freediskspace_ = 5;

		[XmlElement]
		public int NGImageStoragePeriod = 21;

		private string strFileName_ = "0";

		private int SerialPortNumber_ = 1;

		private int BaudRate_ = 115200;

		private int Stopbit_ = 0;

		private int DataBits_ = 8;

		private int Parity_ = 0;

		private double manual_offset_dx_ = 0.0;

		private double manual_offset_dy_ = 0.0;

		private double manual_offset_dw_ = 0.0;

		private bool offsetX_minus_ = false;

		private bool offsetY_minus_ = false;

		private bool offsetW_minus_ = false;

		[XmlElement]
		public bool IsExternalTriggerMode
		{
			get
			{
				return IsExternalTriggerMode_;
			}
			set
			{
				IsExternalTriggerMode_ = value;
			}
		}

		[XmlElement]
		public string DefaultPartname
		{
			get
			{
				return DefaultPartname_;
			}
			set
			{
				DefaultPartname_ = value;
			}
		}

		[XmlElement]
		public bool SkipNGImageSave
		{
			get
			{
				return SkipNGImageSave_;
			}
			set
			{
				SkipNGImageSave_ = value;
			}
		}

		[XmlElement]
		public bool SkipNormalImageSave
		{
			get
			{
				return SkipNormalImageSave_;
			}
			set
			{
				SkipNormalImageSave_ = value;
			}
		}

		[XmlElement]
		public int Freediskspace
		{
			get
			{
				return Freediskspace_;
			}
			set
			{
				Freediskspace_ = value;
			}
		}

		[XmlElement]
		public string strFileName
		{
			get
			{
				return strFileName_;
			}
			set
			{
				strFileName_ = value;
			}
		}

		[XmlElement]
		public int SerialPortNumber
		{
			get
			{
				return SerialPortNumber_;
			}
			set
			{
				SerialPortNumber_ = value;
			}
		}

		[XmlElement]
		public int BaudRate
		{
			get
			{
				return BaudRate_;
			}
			set
			{
				BaudRate_ = value;
			}
		}

		[XmlElement]
		public int Stopbit
		{
			get
			{
				return Stopbit_;
			}
			set
			{
				Stopbit_ = value;
			}
		}

		[XmlElement]
		public int DataBits
		{
			get
			{
				return DataBits_;
			}
			set
			{
				DataBits_ = value;
			}
		}

		[XmlElement]
		public int Parity
		{
			get
			{
				return Parity_;
			}
			set
			{
				Parity_ = value;
			}
		}

		[XmlElement]
		public double manual_offset_dx
		{
			get
			{
				return manual_offset_dx_;
			}
			set
			{
				manual_offset_dx_ = value;
			}
		}

		[XmlElement]
		public double manual_offset_dy
		{
			get
			{
				return manual_offset_dy_;
			}
			set
			{
				manual_offset_dy_ = value;
			}
		}

		[XmlElement]
		public double manual_offset_dw
		{
			get
			{
				return manual_offset_dw_;
			}
			set
			{
				manual_offset_dw_ = value;
			}
		}

		public bool offsetX_minus
		{
			get
			{
				return offsetX_minus_;
			}
			set
			{
				offsetX_minus_ = value;
			}
		}

		public bool offsetY_minus
		{
			get
			{
				return offsetY_minus_;
			}
			set
			{
				offsetY_minus_ = value;
			}
		}

		public bool offsetW_minus
		{
			get
			{
				return offsetW_minus_;
			}
			set
			{
				offsetW_minus_ = value;
			}
		}
	}
}
