#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Core.include;

namespace Core
{

	internal class CLogAssistant : ICLogAssistant
	{
		private static CLogAssistant m_instance = null;

		private string m_szLogFilePath;

		private string m_szCatalog;

		private Mutex m_writeFileMutex;

		private static string[] m_strLevel = new string[5] { "System", "Alarm", "Recipe", "Event", "Error" };

		public static CLogAssistant instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new CLogAssistant();
				}
				return m_instance;
			}
		}

		private CLogAssistant()
		{
			try
			{
				m_writeFileMutex = new Mutex();
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error: CLogAssistant.CLogAssistant: " + ex.Message);
			}
		}

		private int verify_log_dir(ELogLevel log_level = ELogLevel.System)
		{
			try
			{
				string text = Application.StartupPath + "\\Log";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				text = text + "\\" + m_strLevel[(int)log_level];
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string text2 = "Log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";
				m_szLogFilePath = text + "\\" + text2;
			}
			catch (Exception ex)
			{
				m_writeFileMutex.ReleaseMutex();
				Debug.WriteLine("Error: CLogAssistant.verify_log_dir: " + ex.Message);
				return -1;
			}
			return 0;
		}

		public void log_message(string szMessage, ELogLevel log_level = ELogLevel.System)
		{
			string text = string.Empty;
			try
			{
				text = m_strLevel[(int)log_level];
			}
			catch
			{
			}
			string text2 = DateTime.Now.ToString("[HH:mm:ss.fff][yyyy-MM-dd]");
			try
			{
				if (verify_log_dir(log_level) != 0)
				{
					throw new Exception("create log dir fail");
				}
				m_writeFileMutex.WaitOne();
				StreamWriter streamWriter = (File.Exists(m_szLogFilePath) ? File.AppendText(m_szLogFilePath) : File.CreateText(m_szLogFilePath));
				string value = text2 + " " + text + "  " + szMessage + "\r\n";
				streamWriter.Write(value);
				streamWriter.Flush();
				streamWriter.Close();
				m_writeFileMutex.ReleaseMutex();
			}
			catch (Exception ex)
			{
				m_writeFileMutex.ReleaseMutex();
				Debug.WriteLine("Error: CLogAssistant.logMsg: " + ex.Message);
			}
		}

		public void read_log(out string logContent, ELogLevel log_level = ELogLevel.System)
		{
			string empty = string.Empty;
			DateTime now = DateTime.Now;
			empty = "Log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";
			logContent = "Empty";
			try
			{
				if (verify_log_dir(log_level) != 0)
				{
					throw new Exception("create log dir fail");
				}
				m_writeFileMutex.WaitOne();
				if (File.Exists(m_szLogFilePath))
				{
					logContent = File.ReadAllText(m_szLogFilePath, Encoding.Default);
				}
				else
				{
					logContent = "Logfile not found";
				}
				m_writeFileMutex.ReleaseMutex();
			}
			catch (Exception ex)
			{
				m_writeFileMutex.ReleaseMutex();
				Debug.WriteLine("Error: CLogAssistant.read_log: " + ex.Message);
			}
		}
	}
}
