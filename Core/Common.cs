using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Core
{
    internal class Common
    {
        [DllImport("DLL.dll")]
        public static extern IntPtr ScanCCD(); 

        [DllImport("DLL.dll")]
        public static extern IntPtr Connect();  

        [DllImport("DLL.dll")]
        public static extern IntPtr CapCCD(); 

        [DllImport("DLL.dll")]
        public static extern IntPtr ReadImage(string filePath); 

        [DllImport("DLL.dll")]
        public static extern IntPtr SetPara(string parameter, string value); 

        [DllImport("DLL.dll")]
        public static extern IntPtr GetPara(string parameter); 
    }
}
