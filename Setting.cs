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
        public Setting()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }
        private void btnSaveCameraPra_Click_1(object sender, EventArgs e)
        {
            string strFileNamel = G.FormMain.txtProjectNo.Text + "CameraConfig.xml";
            CRecipeCamera.instance.LoadConfig(strFileNamel);
            CRecipeCamera.instance.config.iniUpCameraTime = Convert.ToInt32(txtUpCameraTime.Text.ToString());
            CRecipeCamera.instance.config.iniUpExposureTime = Convert.ToInt32(txtUpExposureTime.Text.ToString());
            CRecipeCamera.instance.config.iniUpCameraGain = Convert.ToDouble(txtUpCameraGain.Text.ToString());
            CRecipeCamera.instance.config.iniDelaySendTime = Convert.ToInt32(txtDelaySendTime.Text.ToString());
            CRecipeCamera.instance.SaveConfig(strFileNamel);
            double exposureTime = Convert.ToDouble(txtUpExposureTime.Text.ToString());
            double UpCameraGain = CRecipeCamera.instance.config.iniUpCameraGain;
            try
            {
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "ExposureTime", exposureTime);
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Gain", UpCameraGain);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR:UpCamera set ExposureTime or Gain fail!");
            }
        }

        private void btnSaveCheckPra_Click(object sender, EventArgs e)
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            CRecipeCamera.instance.config.iniUpOffset = Convert.ToDouble(txtUpOffset.Text.ToString());
            CRecipeCamera.instance.config.iniDownOffset = Convert.ToDouble(txtDownOffset.Text.ToString());
            CRecipeCamera.instance.config.iniLeftOffset = Convert.ToDouble(txtLeftOffset.Text.ToString());
            CRecipeCamera.instance.config.iniRightOffset = Convert.ToDouble(txtRightOffset.Text.ToString());
            CRecipeCamera.instance.config.iniAngleOffset = Convert.ToDouble(txtAngleOffset.Text.ToString());
            CRecipeCamera.instance.config.iniMatchValue = Convert.ToDouble(txtMatchValue.Text.ToString());
            CRecipeCamera.instance.config.iniThresholdValue = Convert.ToInt32(txtThresholdValue.Text.ToString());
            CRecipeCamera.instance.config.iniScale = Convert.ToDouble(txtScale.Text.ToString());
            CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
        }

        private void chkboxUnEnbleDownCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxUnEnbleDownCamera.Checked)
            {
                G.FormMain.bUnEnbleDownCamera = true;
            }
            else
            {
                G.FormMain.bUnEnbleDownCamera = false;
            }
        }

        private void chkboxUnEnbleUpCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxUnEnbleUpCamera.Checked)
            {
                G.FormMain.bUnEnbleUpCamera = true;
            }
            else
            {
                G.FormMain.bUnEnbleUpCamera = false;
            }
        }

        private void chkShowEable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowEable.Checked)
            {
                G.FormMain.bEnbleShow = true;
            }
            else
            {
                G.FormMain.bEnbleShow = false;
            }
        }

        private void btnSaveDownCameraPra_Click(object sender, EventArgs e)
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            CRecipeCamera.instance.config.iniDownCameraTime = Convert.ToInt32(txtDownCameraTime.Text.ToString());
            CRecipeCamera.instance.config.iniDownExposureTime = Convert.ToInt32(txtDownExposureTime.Text.ToString());
            CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
            double exposureTime = Convert.ToDouble(txtDownExposureTime.Text.ToString());
            try
            {
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandleDown, "ExposureTime", exposureTime);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR:Down camrea set ExposureTime fail !");
            }
        }

        private void btnResetDay_Click(object sender, EventArgs e)
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            txtCurrentSaveDay.Text = "0";
            G.FormMain.nStartSaveMonth = DateTime.Now.Month;
            G.FormMain.nStartSaveDay = DateTime.Now.Day;
            CRecipeCamera.instance.config.iniStartSaveMonth = DateTime.Now.Month;
            CRecipeCamera.instance.config.iniStartSaveDay = DateTime.Now.Day;
            CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
        }

        private void cmbSaveNgDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            G.FormMain.nSaveNGimageDay = Convert.ToInt32(cmbSaveNgDay.SelectedItem);
            CRecipeCamera.instance.config.iniSaveNGDayCmbIndex = cmbSaveNgDay.SelectedIndex;
            CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
        }
    }
}
