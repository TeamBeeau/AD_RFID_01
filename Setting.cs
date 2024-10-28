using Core;
using HalconDotNet;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_RFID
{
    public partial class Setting : Form
    {
                       // ch:获取到的帧信息, 用于保存图像 | en:Frame for save image
        private readonly object saveImageLock = new object();
    

        bool IsOpen = false;

     
      




        public Setting()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }
        private HFramegrabber AcqHandle = new HFramegrabber();
        private void Set_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void btnSaveCameraPra_Click(object sender, EventArgs e)
        {
            //string file = Global.ProjectNo + "CameraConfig.xml";
            ////CRecipeCamera.instance.LoadConfig(file);
            //CRecipeCamera.instance.config.iniUpCameraTime =(int) numeUpGrabDelay.Value;
            //CRecipeCamera.instance.config.iniUpExposureTime = (int)numeUpGrabDelay.Value;
            //CRecipeCamera.instance.config.iniUpCameraGain = Convert.ToDouble(txtUpCameraGain.Text.ToString());
            //CRecipeCamera.instance.config.iniDelaySendTime = Convert.ToInt32(txtDelaySendTime.Text.ToString());
            //CRecipeCamera.instance.SaveConfig(file);
            //Global.UpCameraTime = numeUpGrabDelay.Value.ToString();
            //Global.UpExposureTime = numeUpGrabDelay.Value.ToString();
            //Global.UpCameraGain = txtUpCameraGain.Text;
            //Global.DelaySendTime = txtDelaySendTime.Text;
            //G.FormMain.SetParaCam();
        }

        private void btnSaveCheckPra_Click(object sender, EventArgs e)
        {
            // CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            CRecipeCamera.instance.config.iniUpOffset = Convert.ToDouble(txtUpOffset.Text.ToString());
            CRecipeCamera.instance.config.iniDownOffset = Convert.ToDouble(txtDownOffset.Text.ToString());
            CRecipeCamera.instance.config.iniLeftOffset = Convert.ToDouble(txtLeftOffset.Text.ToString());
            CRecipeCamera.instance.config.iniRightOffset = Convert.ToDouble(txtRightOffset.Text.ToString());
            CRecipeCamera.instance.config.iniAngleOffset = Convert.ToDouble(txtAngleOffset.Text.ToString());
            CRecipeCamera.instance.config.iniMatchValue = Convert.ToDouble(txtMatchValue.Text.ToString());
            CRecipeCamera.instance.config.iniThresholdValue = Convert.ToInt32(txtThresholdValue.Text.ToString());
            CRecipeCamera.instance.config.iniScale = Convert.ToDouble(txtScale.Text.ToString());
            CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
            //Global.UpOffset = txtUpOffset.Text;
            //Global.DownOffset = txtDownOffset.Text;
            //Global.LeftOffset = txtLeftOffset.Text;
            //Global.RightOffset = txtRightOffset.Text;
            //Global.AngleOffset = txtAngleOffset.Text;
            //Global.MatchValue = txtMatchValue.Text;
            //Global.ThresholdValue = txtThresholdValue.Text;
            //Global.Scale = txtScale.Text;
        }

        private void Set_Load(object sender, EventArgs e)
        {
            //numeUpGrabDelay.Value =Convert.ToInt32( Global.UpCameraTime.Trim());
            //numUpExposureTime.Value = Convert.ToInt32(Global.UpExposureTime);
            //txtUpCameraGain.Text = Global.UpCameraGain;
            //txtDelaySendTime.Text = Global.DelaySendTime;
            //txtUpOffset.Text = Global.UpOffset;
            //txtDownOffset.Text = Global.DownOffset;
            //txtLeftOffset.Text = Global.LeftOffset;
            //txtRightOffset.Text = Global.RightOffset;
            //txtAngleOffset.Text = Global.AngleOffset;
            //txtMatchValue.Text = Global.MatchValue;
            //txtThresholdValue.Text = Global.ThresholdValue;
            //txtScale.Text = Global.Scale;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUpCameraTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
