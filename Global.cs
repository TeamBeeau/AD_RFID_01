using HalconDotNet;

using System;
using System.Collections.Generic;
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
        public static HImage imgRaw = new HImage();
    }
    internal class Global
    {
        private static string _ProjectNo;
        private static string _UpExposureTime;
        private static string _UpCameraTime;
        private static string _UpCameraGain;
        private static string _DelaySendTime;

        private static string _UpOffset;
        private static string _LeftOffset;
        private static string _DownOffset;
        private static string _RightOffset;
        private static string _AngleOffset;
        private static string _MatchValue;
        private static string _ThresholdValue;
        private static string _Scale;
       
       public static string ProjectNo
        {
            get { return _ProjectNo; }
            set { _ProjectNo = value; }
        }
        public static string UpExposureTime
        {
            get { return _UpExposureTime; }
            set { _UpExposureTime = value; }
        }
        public static string UpCameraTime
        {
            get { return _UpCameraTime; }
            set { _UpCameraTime = value; }
        }
        public static string UpCameraGain
        {
            get { return _UpCameraGain; }
            set { _UpCameraGain = value; }
        }
        public static string DelaySendTime
        {
            get { return _DelaySendTime; }
            set { _DelaySendTime = value; }
        }
        public static string UpOffset
        {
            get { return _UpOffset; }
            set { _UpOffset = value; }
        }
        public static string LeftOffset
        {
            get { return _LeftOffset; }
            set { _LeftOffset = value; }
        }
        public static string DownOffset
        {
            get { return _DownOffset; }
            set { _DownOffset = value; }
        }
        public static string RightOffset
        {
            get { return _RightOffset; }
            set { _RightOffset = value; }
        }
        public static string AngleOffset
        {
            get { return _AngleOffset; }
            set { _AngleOffset = value; }
        }
        public static string MatchValue
        {
            get { return _MatchValue; }
            set { _MatchValue = value; }
        }
        public static string ThresholdValue
        {
            get { return _ThresholdValue; }
            set { _ThresholdValue = value; }
        }
        public static string Scale
        {
            get { return _Scale; }
            set { _Scale = value; }
        }
    }
}
