using System;
using System.IO;
using System.Management;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace Core
{

	internal class CSecurityOperation
	{
		private static CSecurityOperation _instance = null;

		public int iSofewareRegeditType = 0;

		public int[] intCode = new int[127];

		public int[] intNumber = new int[25];

		public char[] Charcode = new char[25];

		public static CSecurityOperation instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new CSecurityOperation();
				}
				return _instance;
			}
		}

		public int CheckSecurityCode()
		{
			try
			{
				string strOriginalPassword = GetCPUID() + GetDiskVolumeSerialNumber();
				string text = CreateSecurityCode(strOriginalPassword, "JianYiVision");
				if (text == "error")
				{
					return 0;
				}
				string text2 = CreateSecurityCode(strOriginalPassword, "JianYiTest");
				if (text2 == "error")
				{
					return 0;
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).CreateSubKey("JianYiSoftWare").CreateSubKey("SecurityCode");
				string text3 = (string)registryKey.GetValue("Code");
				registryKey.Close();
				if (text3 == text)
				{
					return 1;
				}
				if (text3 == text2)
				{
					return 2;
				}
				return 0;
			}
			catch
			{
				return 0;
			}
		}

		public int MathUseDate()
		{
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				DateTime now = DateTime.Now;
				int year = now.Year;
				int month = now.Month;
				int day = now.Day;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).CreateSubKey("JianYiSoftWare").CreateSubKey("SecurityCode");
				int num5 = (int)registryKey.GetValue("Year");
				int num6 = (int)registryKey.GetValue("Month");
				int num7 = (int)registryKey.GetValue("Day");
				registryKey.Close();
				num = year - num5;
				if (month < num6)
				{
					num--;
					num2 = month + 12 - num6;
				}
				else
				{
					num2 = month - num6;
				}
				if (day < num7)
				{
					num2--;
					num3 = day + 30 - num7;
				}
				else
				{
					num3 = day - num7;
				}
				return num * 365 + num2 * 30 + num3;
			}
			catch
			{
				return 0;
			}
		}

		public string GetCPUID()
		{
			try
			{
				string result = "";
				ManagementClass managementClass = new ManagementClass("Win32_Processor");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						result = managementObject.Properties["ProcessorId"].Value.ToString();
					}
				}
				return result;
			}
			catch
			{
				return "error";
			}
		}

		public string GetBoardID()
		{
			try
			{
				string result = "";
				ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						result = managementObject.Properties["SerialNumber"].Value.ToString();
					}
				}
				return result;
			}
			catch
			{
				return "error";
			}
		}

		public string GetDiskVolumeSerialNumber()
		{
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
				managementObject.Get();
				return managementObject.GetPropertyValue("VolumeSerialNumber").ToString();
			}
			catch
			{
				return "error";
			}
		}

		public string GetBiosID()
		{
			try
			{
				string result = "";
				ManagementClass managementClass = new ManagementClass("Win32_BIOS");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						result = managementObject.Properties["SerialNumber"].Value.ToString();
					}
				}
				return result;
			}
			catch
			{
				return "error";
			}
		}

		public string GetDiskID()
		{
			try
			{
				string result = "";
				ManagementClass managementClass = new ManagementClass("Win32_PhysicalMedia");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						result = managementObject.Properties["SerialNumber"].Value.ToString();
					}
				}
				return result;
			}
			catch
			{
				return "error";
			}
		}

		public string CreateSecurityCode(string strOriginalPassword, string strAddCharacter)
		{
			try
			{
				if (strOriginalPassword.Length >= 5)
				{
					string[] array = new string[strOriginalPassword.Length];
					for (int i = 0; i < strOriginalPassword.Length; i++)
					{
						array[i] = strOriginalPassword.Substring(i, 1);
					}
					string text = "";
					for (int j = 0; j < strOriginalPassword.Length; j++)
					{
						text += array[(j + 5 >= strOriginalPassword.Length) ? j : (j + 5)];
					}
					return MD5Encrypt(text + strAddCharacter);
				}
				return "error";
			}
			catch
			{
				return "error";
			}
		}

		public void setIntCode()
		{
			for (int i = 1; i < intCode.Length; i++)
			{
				intCode[i] = ((i + 3 <= 9) ? (i + 3) : 0);
			}
		}

		public string GetCode(string code)
		{
			if (code != "")
			{
				setIntCode();
				for (int i = 1; i < Charcode.Length; i++)
				{
					Charcode[i] = Convert.ToChar(code.Substring(i - 1, 1));
				}
				for (int j = 1; j < intNumber.Length; j++)
				{
					intNumber[j] = intCode[Convert.ToInt32(Charcode[j])] + Convert.ToInt32(Charcode[j]);
				}
				string text = null;
				for (int k = 1; k < intNumber.Length; k++)
				{
					text = ((intNumber[k] >= 48 && intNumber[k] <= 57) ? (text + Convert.ToChar(intNumber[k])) : ((intNumber[k] >= 65 && intNumber[k] <= 90) ? (text + Convert.ToChar(intNumber[k])) : ((intNumber[k] >= 97 && intNumber[k] <= 122) ? (text + Convert.ToChar(intNumber[k])) : ((intNumber[k] <= 122) ? (text + Convert.ToChar(intNumber[k] - 9)) : (text + Convert.ToChar(intNumber[k] - 10))))));
				}
				return text;
			}
			return "";
		}

		public string MD5Encrypt(string strPassword)
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(strPassword);
				byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
				return BitConverter.ToString(array).Replace("-", "");
			}
			catch
			{
				return "error";
			}
		}

		public bool WriteTxtFile(string strFileName, string strMessage)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(strFileName, append: false, Encoding.Unicode);
				streamWriter.WriteLine(strMessage);
				streamWriter.Dispose();
				streamWriter.Close();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public string ReadServerFile(string strFileName)
		{
			string text = "";
			try
			{
				if (File.Exists(strFileName))
				{
					string[] array = new string[100];
					int num = 0;
					StreamReader streamReader = new StreamReader(strFileName, Encoding.Default);
					string text2 = "";
					string[] array2 = new string[100];
					string text3;
					while ((text3 = streamReader.ReadLine()) != null)
					{
						if (num > 0)
						{
							text2 += "\r\n";
						}
						text2 += text3;
						array2[num] = text3;
						array[num] = text3;
						num++;
					}
					text = text2;
					streamReader.Dispose();
					streamReader.Close();
				}
				else
				{
					text = "ERROR:文件找不到!";
				}
				return text;
			}
			catch (Exception)
			{
				return text = "ERROR:读文件失败!";
			}
		}

		public bool ClearRegeditCode()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl).CreateSubKey("JianYiSoftWare").CreateSubKey("SecurityCode");
				registryKey.SetValue("Code", "");
				registryKey.Close();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
