using System;
using System.IO;
using System.Windows.Forms;
using HalconDotNet;
using System.Runtime.InteropServices;
using AD_RFID;

namespace Core
{

	internal class CImage
	{
		private static CImage _ints = new CImage();

		public HFramegrabber AcqHandle1 = new HFramegrabber();

		public HImage image1 = new HImage();

		public HFramegrabber AcqHandleDW = new HFramegrabber();

		public HImage imageDW = new HImage();

		public HFramegrabber AcqHandleCK = new HFramegrabber();

		public HImage imageCK = new HImage();
        
        public static CImage instance => _ints;
		public int IniImage(string strCameraPort, string strCameraType)
		{
	
			try
			{
				AcqHandle1.OpenFramegrabber(strCameraPort, 0, 0, 0, 0, 0, 0, "progressive", -1, "default", -1.0, "false", "default", strCameraType, 0, -1);
				HOperatorSet.SetFramegrabberParam(AcqHandle1, "ExposureTime", CRecipeCamera.instance.config.iniUpExposureTime);
				HOperatorSet.SetFramegrabberParam(AcqHandle1, "Gain", CRecipeCamera.instance.config.iniUpCameraGain);
			}
			catch (Exception)
			{
				G.FormMain.lbCam.Text = "Camera Disconnected";
				//MessageBox.Show("UpCamera initializtion fail！");
				return 0;
			}
            G.FormMain.lbCam.Text = "Camera Connected";
            return 1;
		}

		public int IniImageDW(string strCameraPort, string strCameraType)
		{
			try
			{
				AcqHandleDW.OpenFramegrabber(strCameraPort, 0, 0, 0, 0, 0, 0, "progressive", -1, "default", -1.0, "false", "default", strCameraType, 0, -1);
				HOperatorSet.SetFramegrabberParam(AcqHandleDW, "GainAuto", "Off");
			}
			catch (Exception)
			{
				MessageBox.Show("DownCamera initializtion fail！");
				return 0;
			}
			return 1;
		}

		public int IniImageCK(string strCameraType)
		{
			try
			{
				AcqHandleCK.OpenFramegrabber("GenICamTL", 0, 0, 0, 0, 0, 0, "progressive", -1, "default", -1.0, "false", "default", strCameraType, 0, -1);
			}
			catch (Exception)
			{
				return 0;
			}
			return 1;
		}

		public void DeleteDir(string dirPath)
		{
			if (Directory.Exists(dirPath))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
				directoryInfo.Delete(recursive: true);
			}
		}

		public long GetDirLength(string dirPath)
		{
			if (Directory.Exists(dirPath))
			{
				long num = 0L;
				DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					num += fileInfo.Length;
				}
				return num / 1024;
			}
			return 0L;
		}

		public void SaveBMPImage(HImage image, string strImageName)
		{
			string text = Application.StartupPath + "\\" + strImageName;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			text += "\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			DateTime now = DateTime.Now;
			string text2 = strImageName + "_" + now.ToString("yyyy_MM_dd-hh_mm_ss") + "_" + now.Millisecond + ".BMP";
			string fileName = text + text2;
			image.WriteImage("bmp", 0, fileName);
		}
	}
}