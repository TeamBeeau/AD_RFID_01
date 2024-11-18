using Core;
using HalconDotNet;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            //  string strFileNamel = G.FormMain.txtProjectNo.Text + "CameraConfig.xml";
            //  CRecipeCamera.instance.LoadConfig(strFileNamel);
            //  CRecipeCamera.instance.config.iniUpCameraTime = Convert.ToInt32(txtUpCameraTime.Text.ToString());

            // // CRecipeCamera.instance.config.iniDelaySendTime = Convert.ToInt32(txtDelaySendTime.Text.ToString());
            //  String[] sp = cbReSolution.Text.Split(' ');
            //  String[] sp2 = sp[0].Split('x');

            //int colCCD = Convert.ToInt32(sp2[0]);
            // int rowCCD = Convert.ToInt32(sp2[1]);
            //  CRecipeCamera.instance.config.hvDwCameraResRow = Convert.ToInt32(rowCCD);
            //  CRecipeCamera.instance.config.hvDwCameraResCol= Convert.ToInt32(colCCD);
            //  CRecipeCamera.instance.SaveConfig(strFileNamel);
             CRecipeCamera.instance.config.iniUpExposureTime = Convert.ToInt32(txtUpExposureTime.Text.ToString());
            CRecipeCamera.instance.config.iniUpCameraGain = Convert.ToDouble(txtUpCameraGain.Text.ToString());
            double exposureTime = CRecipeCamera.instance.config.iniUpExposureTime;
            double UpCameraGain = CRecipeCamera.instance.config.iniUpCameraGain;
            try
            {
               
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "ExposureTime", exposureTime);
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Gain", UpCameraGain);
               
               // HOperatorSet.GetFramegrabberParam(G.FormMain.G.FormMain.AcqHandle, "WidthMax", out MaxWidth);
               // HOperatorSet.GetFramegrabberParam(G.FormMain.AcqHandle, "HeightMax", out MaxHeight);
               //  HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetY", (int)((MaxHeight.I - CRecipeCamera.instance.config.hvDwCameraResRow) / 2));
               // HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetX", (int)((MaxWidth.I - CRecipeCamera.instance.config.hvDwCameraResCol) / 2));
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtThresholdValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {

        }
        int MaxWidth = 0, MaxHeight = 0;
        private void Setting_Load(object sender, EventArgs e)
        {
            string strFileName2 =G.FormMain.txtProjectNo.Text + "CameraConfig.xml";

            
            CRecipeCamera.instance.LoadConfig(strFileName2);
            //try
            //{

            //    HTuple MaxW=0, MaxH=0;
            //    HOperatorSet.GetFramegrabberParam(G.FormMain.AcqHandle, "WidthMax", out MaxW);
            //    HOperatorSet.GetFramegrabberParam(G.FormMain.AcqHandle, "HeightMax", out MaxH);
            //    MaxHeight = MaxH;
            //    MaxWidth = MaxW;
            //}
            //catch(Exception ex)
            //{

            //}
            //trackWidth.Maximum = MaxWidth;
            //trackHeight.Maximum = MaxHeight;
          //  trackWidth.Value =(int) CRecipeCamera.instance.config.hvUpCameraResCol;
          //  trackHeight.Value = (int)CRecipeCamera.instance.config.hvUpCameraResRow;
            //trackOffSetX.Maximum = (int)MaxWidth - trackWidth.Value;
            //trackOffSetY.Maximum = (int)MaxHeight - trackHeight.Value;
            //trackOffSetX.Value = (int)CRecipeCamera.instance.config.hvUpROI_COL1;
            //trackOffSetY.Value = (int)CRecipeCamera.instance.config.hvUpROI_ROW1;

            //trackWidth.Maximum = (int)MaxWidth - trackOffSetX.Value;
            //trackHeight.Maximum = (int)MaxHeight - trackOffSetY.Value;

            // cbReSolution.Text = CRecipeCamera.instance.config.hvDwCameraResCol + "x" + CRecipeCamera.instance.config.hvDwCameraResRow;
            btnRaw.IsCLick = G.Config.IsSaveRaw;
            btnNG.IsCLick=G.Config.IsSaveNG;
            trackDay.Value = G.Config.LimitDateSave;
            lbDay.Text = G.Config.LimitDateSave + "";
            switch (G.Config.TypeSave)
            {
                case 0: btnSmall.IsCLick=true; 
                     break;
                case 1: btnMedium.IsCLick = true;  break;
                case 2: btnBig.IsCLick = true;  break;
            }    
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strFileNamel = G.FormMain.txtProjectNo.Text + "CameraConfig.xml";
                CRecipeCamera.instance.LoadConfig(strFileNamel);
                CRecipeCamera.instance.config.iniUpCameraTime = Convert.ToInt32(txtUpCameraTime.Text.ToString());
                CRecipeCamera.instance.config.iniUpExposureTime = (int)txtUpExposureTime.Value;
                CRecipeCamera.instance.config.iniUpCameraGain = (int)txtUpCameraGain.Value;
                CRecipeCamera.instance.config.hvUpCameraResRow = trackHeight.Value;//  Convert.ToInt32(rowCCD);
                CRecipeCamera.instance.config.hvUpCameraResCol = trackWidth.Value;// Convert.ToInt32(colCCD);
                CRecipeCamera.instance.config.hvUpROI_COL1 = trackOffSetX.Value;//  Convert.ToInt32(rowCCD);
                CRecipeCamera.instance.config.hvUpROI_ROW1 = trackOffSetY.Value;// Convert.ToInt32(colCCD);
                CRecipeCamera.instance.SaveConfig(strFileNamel);
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            G.Config.IsSaveOK = btnOK.IsCLick;
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            G.Config.IsSaveNG = btnNG.IsCLick;
        }

        private void btnRaw_Click(object sender, EventArgs e)
        {
            G.Config.IsSaveRaw = btnRaw.IsCLick;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            G.Config.IsSaveRS = btnResult.IsCLick;
        }

        private void trackDay_ValueChanged(object sender, EventArgs e)
        {
            G.Config.LimitDateSave = trackDay.Value;
            lbDay.Text = G.Config.LimitDateSave + "";
        }

        private void btnSet3_Click(object sender, EventArgs e)
        {
            if (File.Exists("Default.config"))
                File.Delete("Default.config");
            Access.SaveConfig("Default.config", G.Config);
        }

        private void trackWidth_ValueChanged(object sender, EventArgs e)
        {
           
            if (!G.FormMain.bUpCameraLive)
            {
                CRecipeCamera.instance.config.hvUpCameraResCol = trackWidth.Value;
                trackOffSetX.Maximum = (int)MaxWidth - (int)CRecipeCamera.instance.config.hvUpCameraResCol;
                lbWidth.Text = trackWidth.Value + "";
                try
                {
                   // HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetX", (int)0);
                    HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Width", (int)(CRecipeCamera.instance.config.hvUpCameraResCol));
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
          
        }

        private void trackHeight_ValueChanged(object sender, EventArgs e)
        {
          
            if (!G.FormMain.bUpCameraLive)
            {
                CRecipeCamera.instance.config.hvUpCameraResRow = trackHeight.Value;
                trackOffSetY.Maximum = (int)MaxHeight - (int)CRecipeCamera.instance.config.hvUpCameraResRow;
                lbHeight.Text = trackHeight.Value + "";
                try
                {
                    //  HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetY", (int)0);
                    HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Height", (int)(CRecipeCamera.instance.config.hvUpCameraResRow));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {

            }
        }

        private void trackOffSetX_ValueChanged(object sender, EventArgs e)
        {
            CRecipeCamera.instance.config.hvUpROI_COL1 = trackOffSetX.Value;
            trackWidth.Maximum = (int)MaxWidth - trackOffSetX.Value;
            lbX.Text = trackOffSetX.Value + "";
            try
            {
                 HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetX", trackOffSetX.Value);
               // HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Width", (int)(CRecipeCamera.instance.config.hvDwCameraResCol));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void trackOffSetY_ValueChanged(object sender, EventArgs e)
        {
            CRecipeCamera.instance.config.hvUpROI_ROW1 = trackOffSetY.Value;
            trackHeight.Maximum = (int)MaxHeight - (int)trackOffSetY.Value;
            lbY.Text = trackOffSetY.Value + "";
            try
            {
                 HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "OffsetY", trackOffSetY.Value);
               // HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Height", (int)(CRecipeCamera.instance.config.hvDwCameraResRow));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtUpCameraGain_ValueChanged(object sender, EventArgs e)
        {
            CRecipeCamera.instance.config.iniUpCameraGain = (int)txtUpCameraGain.Value;
            try
            {
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "Gain", CRecipeCamera.instance.config.iniUpCameraGain);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Set Gain  Error");
            }
        }

        private void txtUpExposureTime_ValueChanged(object sender, EventArgs e)
        {
            CRecipeCamera.instance.config.iniUpExposureTime = (int)txtUpExposureTime.Value;
            try
            {
                HOperatorSet.SetFramegrabberParam(G.FormMain.AcqHandle, "ExposureTime", CRecipeCamera.instance.config.iniUpExposureTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Set Exposure Time Error");
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackWidth_Scroll(object sender, EventArgs e)
        {

        }

        private void trackDay_Scroll(object sender, EventArgs e)
        {

        }
    }
}
