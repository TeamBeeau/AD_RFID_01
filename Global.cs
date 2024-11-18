using HalconDotNet;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeeUi.Commons;
using BeeUi;
namespace AD_RFID
{
    public struct G
    {
        public static System.Windows.Forms.ListBox listProgram = new System.Windows.Forms.ListBox();
        public static string[] sKeys;
        public static String addMac="", sActive, sKey, Licence;
        public static KeyAcitve keys = new KeyAcitve();
        public static bool IsActive, IsLockTrial=false;
        public static Setting Setting=new Setting();
         public static FormMain FormMain;
        public static FormActive FormActive;
        public static FormLoad FormLoad;
      public static string _pathSqlMaster;
        public static SqlConnection cnn = new SqlConnection();
        public static SqlConnection cnnPO = new SqlConnection();
        public static Config Config;
        public static WebCam WebCam=new WebCam();
        public static Report Report =new Report();
        public static SqlServer Server=new SqlServer();
    }
}
