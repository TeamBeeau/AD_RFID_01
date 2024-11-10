using HalconDotNet;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AD_RFID
{
    public struct G
    {
        public static Setting Setting=new Setting();
         public static FormMain FormMain;
        public static string _pathSqlMaster;
        public static SqlConnection cnn = new SqlConnection();
        public static SqlConnection cnnPO = new SqlConnection();
        public static Config Config;
        public static WebCam WebCam=new WebCam();
        public static Report Report =new Report();
        public static SqlServer Server=new SqlServer();
    }
}
