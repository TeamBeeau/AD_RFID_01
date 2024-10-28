using Core.include;
using Core;
using HalconDotNet;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using libuser;
using static System.Net.Mime.MediaTypeNames;

using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Collections.Generic;
using System.Linq;

using Application = System.Windows.Forms.Application;

namespace AD_RFID
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            G.FormMain = this;
        }
        public string check;
        public bool RunStop = false;
        private HFramegrabber AcqHandleDown = new HFramegrabber();
        private HWindow hWindow02 = new HWindow();
        private static FormMain _instance;
        public char[] chReMagnetNum;
        private int iUpCameraDelayGrabTime = 100;
        public bool bUnEnbleUpCamera = false;
        public bool bExit = false;
        public bool bUpCameraCheckNG = false;
        public bool bMarkCheckStart = false;
        private Thread scanIOCardThread;
        private Thread upCameraAutoThread;
        private Thread threadUpCamera;
        public bool m_bRunFlg = false;
        public bool bUpCameraOK = false;
        public bool bUnEnbleDownCamera = false;
        public int iOffsetPosNum = 0;
        public bool bEnbleShow = false;
        public HTuple hv_AllMarkCol = null;
        public HTuple hv_AllMarkRow = null;
        public int iDoubleNum = 0;
        public string strDealTime = "";
        public int iMissNum = 0;
        public HTuple hv_MarkModelID = null;
        public HObject ho_Chambers = null;
        public delegate void pfnAddText(Control ctl, string str);
        public short m_dev;
        public bool bUpCameraLive = false;
        public bool bModelIsOK = false;
        private HWindow hWindow = new HWindow();

        private IntPtr IntPtr;
        private readonly HalconDotNet.HWindowControl hwindowctl = new HWindowControl();//note1
        private readonly HalconDotNet.HWindowControl hwindowctl02 = new HWindowControl();
        private int hv_imageWidth;
        private int hv_imageHeight;
        private HTuple hv_StartTime;
        public bool bIOCarkOK = false;
        private HTuple hv_EndTime;
        private HFramegrabber AcqHandle = new HFramegrabber();
        public int iAllNum = 0;
        public HTuple hv_ModelPageRow = null;
        public HTuple hv_ModelPageCol = null;
        public HTuple hv_ModelPageAngle = null;
        public HTuple hv_AllMarkArea = null;
        public HTuple hvDownModelID = null;
        public HObject ho_MarkModelRegion = null;
        public bool TriggerMode = false;
        Thread LiveThread;
       
     
       
       
     
     
        
        private void btnSet_Click(object sender, EventArgs e)
        {
            //if (SettingCam == null)
            //    SettingCam = new SettingCam();
            //Global.ProjectNo = txtProjectNo.Text;
            //SettingCam.ShowDialog();


          
            G.Setting.ShowDialog(this);
        }
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (G.imgRaw == null || !G.imgRaw.IsInitialized())
            {
                MessageBox.Show("Error save G.imgRaw. Please load/grab G.imgRaw first.");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP Image|*.bmp";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                G.imgRaw.WriteImage("bmp", 0, saveFileDialog.FileName);
            }
            catch
            {
            }
        }
        HTuple w, h;
        HTuple type;
        private void btnFolder_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            //if (openFileDialog.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}
            //try
            //{
            //    G.imgRaw.ReadImage(openFileDialog.FileName);
            //    if (G.imgRaw.IsInitialized())
            //    {
            //        hwindowctl.HalconWindow.ClearWindow();//note1
            //        G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
            //        hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);//note1
            //        hwindowctl.HalconWindow.DispObj(G.imgRaw);//note1
            //    }
            //}
            //catch
            //{
            //}
            if (!bModelIsOK)
            {
                MessageBox.Show("ERROR: Please load project model before loading an G.imgRaw!");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                G.imgRaw.ReadImage(openFileDialog.FileName);

                // IntPtr IntPtr2 = G.imgRaw.GetImagePointer1(out type, out w, out h);

                //Mat mat = Cv2.ImRead(openFileDialog.FileName);
                //Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
                //IntPtr = mat.Data;
                //byte[] bytes = new byte[mat.Total() * mat.Channels()];

                //G.imgRaw = new HImage("byte", mat.Width, mat.Height, IntPtr);
                if (G.imgRaw.IsInitialized())
                {
                    hwindowctl.HalconWindow.ClearWindow();
                    G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl.HalconWindow.DispObj(G.imgRaw);
                    FindMark(G.imgRaw, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR: Failed to initialize the G.imgRaw!");
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Failed to read the G.imgRaw!");
            }
        }
        private void btnContinous_Click(object sender, EventArgs e)
        {
            if (!bUpCameraLive)
            {
                DASK.DO_WritePort((ushort)m_dev, 0, 128u);
                bUpCameraLive = true;
            }
        }

        private void btnTrig_Click(object sender, EventArgs e)
        {
            if(hwindowctl.Parent!=imgView)
            {
                imgView.Controls.Add(hwindowctl);//note1
            }
       
           
            uint out_value = 128u;
            if (bUpCameraLive)
            {
                bUpCameraLive = false;
            }
            else if (bIOCarkOK)
            {

                short ret = DASK.DO_WritePort((ushort)m_dev, 0, out_value);
                if (ret < 0)
                {
                    MessageBox.Show("DO_WritePort error!");
                }
                HOperatorSet.CountSeconds(out hv_StartTime);
                G.imgRaw = Trigger();
                if (G.imgRaw.IsInitialized())
                {
                    hwindowctl.HalconWindow.ClearWindow();
                    G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl.HalconWindow.DispObj(G.imgRaw);
                    FindMark(G.imgRaw, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR: Failed to initialize the G.imgRaw!");
                }
                HOperatorSet.CountSeconds(out hv_EndTime);
                ret = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                HTuple hv_ActTime = hv_EndTime - hv_StartTime;
                double fActiveTime = hv_ActTime;
                lbCycleTime.Text = Convert.ToString(fActiveTime);
            }
            //else if (bIOCarkOK)
            //{
            //    short num = DASK.DO_WritePort((ushort)m_dev, 0, value);
            //    if (num < 0)
            //    {
            //        MessageBox.Show("DO_WritePort error!");
            //    }
            //    DASK.DO_WritePort((ushort)m_dev, 0, 0u);
            //    //HOperatorSet.CountSeconds(out hv_StartTime);
            //    //GrapeImage1();
            //    //HOperatorSet.CountSeconds(out hv_EndTime);
            //    //num = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
            //    //HTuple hTuple = hv_EndTime - hv_StartTime;
            //    //double num2 = hTuple;
            //    // txtGrapImageTime.Text = Convert.ToString(num2);
            //}
            //HOperatorSet.CountSeconds(out hv_StartTime);
            //G.imgRaw = Trigger();
            ////
            ////GrapeImage1();
            ////
            ////  num = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
            //if (G.imgRaw.IsInitialized())
            //{
            //    hwindowctl.HalconWindow.ClearWindow();
            //    G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
            //    hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
            //    hwindowctl.HalconWindow.DispObj(G.imgRaw);
            //    FindMark(G.imgRaw, hWindow);
            //}
            //else
            //{
            //    MessageBox.Show("ERROR: Failed to initialize the G.imgRaw!");
            //}
            //HOperatorSet.CountSeconds(out hv_EndTime);

            //HTuple hTuple = hv_EndTime - hv_StartTime;
            //double num2 = hTuple;
            //lbCycleTime.Text = Convert.ToString(num2) + "ms";
         
           // SetCtrlWhenStartGrab();
        }
        private void SetCtrlWhenStartGrab()
        {
        }
        public void GrapeImage1()
        {
            try
            {
                if (G.frameOut == null) return;
                Thread.Sleep(50);
                HOperatorSet.CountSeconds(out hv_StartTime);
                //  G.imgRaw.GrabImage(AcqHandle);
                G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);//note1
                hwindowctl.HalconWindow.DispObj(G.imgRaw);//note1
                HOperatorSet.SetTposition(hWindow, 10, 10);
                HOperatorSet.WriteString(hWindow, "UpCamera");
                //History_message(txtboxHistory, "Camera triggered, got G.imgRaw.");
                HOperatorSet.CountSeconds(out hv_EndTime);
                HTuple stringVal = hv_EndTime - hv_StartTime;
                HOperatorSet.SetTposition(hWindow, 100, 100);
                HOperatorSet.WriteString(hWindow, stringVal);
            }
            catch (Exception)
            {
                //  History_message(txtboxHistory, "Camera Grab False!!");
            }
        }
        private void History_message(Control ctl, string str)
        {
            if (ctl.InvokeRequired)
            {
                pfnAddText method = History_message;
                ctl.Invoke(method, ctl, str);
                return;
            }
            ctl.Text = ctl.Text + DateTime.Now.ToString("HH:mm:ss") + " " + str + "\r\n";
            if (ctl.Text.Length > 1000000)
            {
                ctl.Text = "";
            }
            if (ctl.GetType().Name == "TextBox")
            {
                ((System.Windows.Forms.TextBox)ctl).ScrollBars = ScrollBars.Both;
                ((System.Windows.Forms.TextBox)ctl).SelectionStart = ((System.Windows.Forms.TextBox)ctl).Text.Length - 1;
                ((System.Windows.Forms.TextBox)ctl).ScrollToCaret();
            }
        }

        public bool FindMark(HImage checkImage, HTuple hv_WindowID)
        {
            HObject[] array = new HObject[20];
            HObject emptyObject = null;
            HObject emptyObject2 = null;
            HObject emptyObject3 = null;
            HObject emptyObject4 = null;
            HObject emptyObject5 = null;
            HObject emptyObject6 = null;
            HTuple hTuple = null;
            HTuple hTuple2 = null;
            HTuple hTuple3 = null;
            HTuple hTuple4 = null;
            HTuple hTuple5 = null;
            HTuple hTuple6 = null;
            HTuple hTuple7 = null;
            HTuple hTuple8 = null;
            HTuple hTuple9 = null;
            HTuple hTuple10 = null;
            HTuple hTuple11 = new HTuple();
            HTuple measureHandle = new HTuple();
            HTuple rowEdge = new HTuple();
            HTuple columnEdge = new HTuple();
            HTuple amplitude = new HTuple();
            HTuple distance = new HTuple();
            HTuple rowBegin = null;
            HTuple colBegin = null;
            HTuple rowEnd = null;
            HTuple colEnd = null;
            HTuple nr = null;
            HTuple nc = null;
            HTuple dist = null;
            HTuple hTuple12 = null;
            HTuple hTuple13 = null;
            HTuple hTuple14 = null;
            HTuple hTuple15 = null;
            HTuple hTuple16 = null;
            HTuple hTuple17 = null;
            HTuple hTuple18 = null;
            HTuple hTuple19 = new HTuple();
            HTuple measureHandle2 = new HTuple();
            HTuple rowEdge2 = new HTuple();
            HTuple columnEdge2 = new HTuple();
            HTuple amplitude2 = new HTuple();
            HTuple distance2 = new HTuple();
            HTuple rowBegin2 = null;
            HTuple colBegin2 = null;
            HTuple rowEnd2 = null;
            HTuple colEnd2 = null;
            HTuple isParallel = null;
            HTuple hTuple20 = new HTuple();
            HTuple hTuple21 = new HTuple();
            HTuple hTuple22 = new HTuple();
            HTuple seconds = new HTuple();
            HTuple angle = new HTuple();
            HTuple row = new HTuple();
            HTuple column = new HTuple();
            HTuple homMat2D = new HTuple();
            HTuple number = new HTuple();
            HTuple hTuple23 = new HTuple();
            HTuple row2 = new HTuple();
            HTuple column2 = new HTuple();
            HTuple angle2 = new HTuple();
            HTuple score = new HTuple();
            HTuple hTuple24 = new HTuple();
            HTuple seconds2 = new HTuple();
            HTuple hTuple25 = null;
            HTuple hTuple26 = null;
            HTuple hTuple27 = null;
            HTuple hTuple28 = null;
            HTuple hTuple29 = null;
            HTuple hTuple30 = null;
            HTuple hTuple31 = null;
            HObject emptyObject7 = null;
            HObject objectSelected = null;
            HTuple hTuple32 = null;
            HOperatorSet.GenEmptyObj(out emptyObject7);
            HOperatorSet.GenEmptyObj(out var emptyObject8);
            HOperatorSet.GenEmptyObj(out var emptyObject9);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var emptyObject11);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out emptyObject);
            HOperatorSet.GenEmptyObj(out emptyObject2);
            HOperatorSet.GenEmptyObj(out emptyObject3);
            HOperatorSet.GenEmptyObj(out emptyObject4);
            HOperatorSet.GenEmptyObj(out emptyObject5);
            HOperatorSet.GenEmptyObj(out emptyObject6);
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            hTuple5 = CRecipeCamera.instance.config.iniDownRow;
            hTuple6 = CRecipeCamera.instance.config.iniDownCol;
            hTuple7 = CRecipeCamera.instance.config.iniDownPhi;
            hTuple8 = CRecipeCamera.instance.config.iniDownLength11;
            hTuple9 = CRecipeCamera.instance.config.iniDownLength21;
            hTuple14 = CRecipeCamera.instance.config.iniLeftRow;
            hTuple15 = CRecipeCamera.instance.config.iniLeftCol;
            hTuple16 = CRecipeCamera.instance.config.iniLeftPhi;
            hTuple17 = CRecipeCamera.instance.config.iniLeftLength11;
            hTuple18 = CRecipeCamera.instance.config.iniLeftLength21;
            double iniScale = CRecipeCamera.instance.config.iniScale;
            string value = "-" + Convert.ToString(CRecipeCamera.instance.config.iniUpOffset);
            HTuple hTuple33 = Convert.ToDouble(value) * iniScale;
            HTuple hTuple34 = Convert.ToDouble(CRecipeCamera.instance.config.iniDownOffset) * iniScale;
            string value2 = "-" + Convert.ToString(CRecipeCamera.instance.config.iniLeftOffset);
            HTuple hTuple35 = Convert.ToDouble(value2) * iniScale;
            HTuple hTuple36 = Convert.ToDouble(CRecipeCamera.instance.config.iniRightOffset) * iniScale;
            HTuple hTuple37 = Convert.ToDouble(CRecipeCamera.instance.config.iniAngleOffset);
            string value3 = "-" + Convert.ToDouble(CRecipeCamera.instance.config.iniAngleOffset);
            HTuple hTuple38 = Convert.ToDouble(value3);
            HTuple hTuple39 = CRecipeCamera.instance.config.iniAreaOffset;
            HTuple minScore = Convert.ToDouble(CRecipeCamera.instance.config.iniMatchValue);
            HTuple hTuple40 = CRecipeCamera.instance.config.iniThresholdValue;
            try
            {
                iAllNum++;
                HOperatorSet.CountSeconds(out seconds);
                HOperatorSet.GetImageSize(checkImage, out hTuple, out hTuple2);
                hTuple3 = new HTuple();
                hTuple4 = new HTuple();
                hTuple10 = 0;
                while ((int)hTuple10 <= 20)
                {
                    hTuple11 = hTuple6 + hTuple10 * 50;
                    emptyObject8.Dispose();
                    HOperatorSet.GenMeasureRectangle2(hTuple5, hTuple11, hTuple7, hTuple8, hTuple9, hTuple, hTuple2, "nearest_neighbor", out measureHandle);
                    HOperatorSet.MeasurePos(checkImage, measureHandle, 1, 40, "positive", "first", out rowEdge, out columnEdge, out amplitude, out distance);
                    hTuple3 = hTuple3.TupleConcat(rowEdge);
                    hTuple4 = hTuple4.TupleConcat(columnEdge);
                    HOperatorSet.CloseMeasure(measureHandle);
                    hTuple10 = (int)hTuple10 + 1;
                }
                emptyObject9.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject9, hTuple3, hTuple4);
                HOperatorSet.FitLineContourXld(emptyObject9, "tukey", -1, 0, 5, 1.345, out rowBegin, out colBegin, out rowEnd, out colEnd, out nr, out nc, out dist);
                hTuple12 = new HTuple();
                hTuple13 = new HTuple();
                hTuple10 = 0;
                while ((int)hTuple10 <= 20)
                {
                    hTuple19 = hTuple14 + hTuple10 * 30;
                    HOperatorSet.GenMeasureRectangle2(hTuple19, hTuple15, hTuple16, hTuple17, hTuple18, hTuple, hTuple2, "nearest_neighbor", out measureHandle2);
                    HOperatorSet.MeasurePos(checkImage, measureHandle2, 1, 40, "positive", "first", out rowEdge2, out columnEdge2, out amplitude2, out distance2);
                    hTuple12 = hTuple12.TupleConcat(rowEdge2);
                    hTuple13 = hTuple13.TupleConcat(columnEdge2);
                    HOperatorSet.CloseMeasure(measureHandle2);
                    hTuple10 = (int)hTuple10 + 1;
                }
                emptyObject11.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject11, hTuple12, hTuple13);
                HOperatorSet.FitLineContourXld(emptyObject11, "tukey", -1, 0, 5, 1.345, out rowBegin2, out colBegin2, out rowEnd2, out colEnd2, out nr, out nc, out dist);
                HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out angle);
                HOperatorSet.IntersectionLl(rowBegin, colBegin, rowEnd, colEnd, rowBegin2, colBegin2, rowEnd2, colEnd2, out row, out column, out isParallel);
                HOperatorSet.VectorAngleToRigid(row, column, angle, hv_ModelPageRow, hv_ModelPageCol, hv_ModelPageAngle, out homMat2D);
                emptyObject2.Dispose();
                HOperatorSet.AffineTransImage(checkImage, out emptyObject2, homMat2D, "constant", "false");
                HOperatorSet.ClearWindow(hv_WindowID);
                HOperatorSet.DispObj(emptyObject2, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispCross(hv_WindowID, row, column, 100, 0);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 200, hv_ModelPageAngle);
                HOperatorSet.CountObj(ho_Chambers, out number);
                emptyObject3.Dispose();
                HOperatorSet.GenEmptyObj(out emptyObject3);
                emptyObject4.Dispose();
                HOperatorSet.GenEmptyObj(out emptyObject4);
                HTuple final_value = number;
                HTuple hTuple41 = 1;
                HTuple area = null;
                HTuple row3 = null;
                HTuple column3 = null;
                HOperatorSet.FindShapeModel(emptyObject2, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(4).TupleConcat(1), 0.75, out row2, out column2, out angle2, out score);//note 50 đổi thành 60 
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "red");



                int markCount = score.Length;
                List<(double row, double col, int index)> markList = new List<(double, double, int)>();//note counter số lượng 
                for (int i = 0; i < markCount; i++)
                {
                    markList.Add((row2[i].D, column2[i].D, i));
                }
                markList = markList.OrderBy(mark => mark.row).ThenBy(mark => mark.col).ToList();
                for (int i = 0; i < markList.Count; i++)
                {
                    double markRow = markList[i].row;
                    double markCol = markList[i].col;
                    string markLabel = (i + 1).ToString();
                    HOperatorSet.SetTposition(hv_WindowID, markRow, markCol);
                    HOperatorSet.SetColor(hv_WindowID, "#228B22");
                    HOperatorSet.WriteString(hv_WindowID, markLabel);
                }



                if (number > score.Length)
                {
                    set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.WriteString(hv_WindowID, "MISS");
                    CImage.instance.SaveBMPImage(G.imgRaw, "MISS");
                    iMissNum++;
                    HOperatorSet.CountSeconds(out seconds2);
                    hTuple32 = seconds2 - seconds;
                    strDealTime = hTuple32[0].D.ToString("0.000");
                    check = "MISS";
                    HandleMessage("MISS");
                    return false;
                }
                if (number < score.Length)
                {
                    set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.WriteString(hv_WindowID, "MORE");
                    CImage.instance.SaveBMPImage(G.imgRaw, "MORE");
                    iDoubleNum++;
                    HOperatorSet.CountSeconds(out seconds2);
                    hTuple32 = seconds2 - seconds;
                    strDealTime = hTuple32[0].D.ToString("0.000");
                    HandleMessage("MORE");
                    return false;
                }
                hTuple23 = 1;
                while (hTuple23.Continue(final_value, hTuple41))
                {
                    HOperatorSet.SelectObj(ho_Chambers, out objectSelected, hTuple23);
                    HOperatorSet.AreaCenter(objectSelected, out area, out row3, out column3);
                    emptyObject5.Dispose();
                    HOperatorSet.ReduceDomain(emptyObject2, objectSelected, out emptyObject5);
                    HOperatorSet.FindShapeModel(emptyObject5, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 1, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row2, out column2, out angle2, out score);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(objectSelected, hv_WindowID);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, row2, column2, 20, angle2);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispCross(hv_WindowID, hv_AllMarkRow[hTuple23 - 1], hv_AllMarkCol[hTuple23 - 1], 20, angle2);
                    hTuple25 = row2 - hv_AllMarkRow[hTuple23 - 1];
                    hTuple26 = column2 - hv_AllMarkCol[hTuple23 - 1];
                    hTuple27 = new HTuple(angle2).TupleDeg();
                    string text = hTuple25[0].D.ToString("0.0");
                    string text2 = hTuple26[0].D.ToString("0.0");
                    string text3 = hTuple27[0].D.ToString("0.0");
                    if (bEnbleShow)
                    {
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        set_display_font(hv_WindowID, 12, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, row3 - 90, column3);
                        HOperatorSet.WriteString(hv_WindowID, text);
                        HOperatorSet.SetTposition(hv_WindowID, row3 - 60, column3);
                        HOperatorSet.WriteString(hv_WindowID, text2);
                        HOperatorSet.SetTposition(hv_WindowID, row3 - 30, column3);
                        HOperatorSet.WriteString(hv_WindowID, text3);
                    }
                    if (hTuple34 < hTuple25 || hTuple25 < hTuple33)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, row3, column3);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(Dislocation)");
                        CImage.instance.SaveBMPImage(G.imgRaw, "dislocation");
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out seconds2);
                        hTuple32 = seconds2 - seconds;
                        strDealTime = hTuple32[0].D.ToString("0.000");
                        return false;
                    }
                    if (hTuple36 < hTuple26 || hTuple26 < hTuple35)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, row3, column3);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(Dislocation)");
                        CImage.instance.SaveBMPImage(G.imgRaw, "dislocation");
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out seconds2);
                        hTuple32 = seconds2 - seconds;
                        strDealTime = hTuple32[0].D.ToString("0.000");
                        return false;
                    }
                    if (hTuple37 < hTuple27 || hTuple27 < hTuple38)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, row3, column3);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(AngleDislocation)");
                        CImage.instance.SaveBMPImage(G.imgRaw, "dislocation");
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out seconds2);
                        hTuple32 = seconds2 - seconds;
                        strDealTime = hTuple32[0].D.ToString("0.000");
                        return false;
                    }
                    hTuple23 = hTuple23.TupleAdd(hTuple41);
                }
                set_display_font(hv_WindowID, 30, "mono", "true", "false");
                HOperatorSet.SetTposition(hv_WindowID, 100, 100);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.WriteString(hv_WindowID, "OK");
                HOperatorSet.CountSeconds(out seconds2);
                hTuple32 = seconds2 - seconds;
                strDealTime = hTuple32[0].D.ToString("0.000");//noteee
                check = "OK";
                HandleMessage(check);
                return true;
            }
            catch (Exception)
            {
                set_display_font(hv_WindowID, 20, "mono", "true", "false");
                HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.WriteString(hv_WindowID, "MISS");
                CImage.instance.SaveBMPImage(G.imgRaw, "MISS");
                iMissNum++;
                check = "MISS";
                HandleMessage(check);
                return false;
            }
        }
      
        private void HandleMessage(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(HandleMessage), new object[] { value });
                return;
            }
            btnCHECK.Text += value;
            if (value == "OK")
            {
                btnCHECK.ForeColor = Color.White;
               
                btnCHECK.BackColor = Color.FromArgb(0, 255, 0);
            }
          else   if (value == "MORE")
            {
                btnCHECK.ForeColor = Color.White;

                btnCHECK.BackColor = Color.FromArgb(0, 255, 0);
            } 
            else if (value == "MISS")
            {
                btnCHECK.ForeColor = Color.White;
             
                btnCHECK.BackColor = Color.FromArgb(255, 0, 0);
            }
        }
        public void set_display_font(HTuple hv_WindowHandle, HTuple hv_Size, HTuple hv_Font, HTuple hv_Bold, HTuple hv_Slant)
        {
            HTuple information = null;
            HTuple hTuple = null;
            HTuple exception = new HTuple();
            HTuple hTuple2 = new HTuple();
            HTuple hTuple3 = new HTuple();
            HTuple hTuple4 = new HTuple();
            HTuple hTuple5 = new HTuple();
            HTuple indices = new HTuple();
            HTuple font = new HTuple();
            HTuple hTuple6 = new HTuple();
            HTuple hTuple7 = new HTuple();
            HTuple hTuple8 = hv_Bold.Clone();
            HTuple hTuple9 = hv_Font.Clone();
            HTuple hTuple10 = hv_Size.Clone();
            HTuple hTuple11 = hv_Slant.Clone();
            HOperatorSet.GetSystem("operating_system", out information);
            if ((int)new HTuple(hTuple10.TupleEqual(new HTuple())).TupleOr(new HTuple(hTuple10.TupleEqual(-1))) != 0)
            {
                hTuple10 = 16;
            }
            if ((int)new HTuple(information.TupleSubstr(0, 2).TupleEqual("Win")) != 0)
            {
                if ((int)new HTuple(new HTuple(hTuple9.TupleEqual("mono")).TupleOr(new HTuple(hTuple9.TupleEqual("Courier")))).TupleOr(new HTuple(hTuple9.TupleEqual("courier"))) != 0)
                {
                    hTuple9 = "Courier New";
                }
                else if ((int)new HTuple(hTuple9.TupleEqual("sans")) != 0)
                {
                    hTuple9 = "Arial";
                }
                else if ((int)new HTuple(hTuple9.TupleEqual("serif")) != 0)
                {
                    hTuple9 = "Times New Roman";
                }
                if ((int)new HTuple(hTuple8.TupleEqual("true")) != 0)
                {
                    hTuple8 = 1;
                }
                else
                {
                    if ((int)new HTuple(hTuple8.TupleEqual("false")) == 0)
                    {
                        exception = "Wrong value of control parameter Bold";
                        throw new HalconException(exception);
                    }
                    hTuple8 = 0;
                }
                if ((int)new HTuple(hTuple11.TupleEqual("true")) != 0)
                {
                    hTuple11 = 1;
                }
                else
                {
                    if ((int)new HTuple(hTuple11.TupleEqual("false")) == 0)
                    {
                        exception = "Wrong value of control parameter Slant";
                        throw new HalconException(exception);
                    }
                    hTuple11 = 0;
                }
                try
                {
                    HOperatorSet.SetFont(hv_WindowHandle, "-" + hTuple9 + "-" + hTuple10 + "-*-" + hTuple11 + "-*-*-" + hTuple8 + "-");
                    return;
                }
                catch (HalconException ex)
                {
                    ex.ToHTuple(out exception);
                    return;
                }
            }
            if ((int)new HTuple(information.TupleSubstr(0, 2).TupleEqual("Dar")) != 0)
            {
                if ((int)new HTuple(hTuple8.TupleEqual("true")) != 0)
                {
                    hTuple2 = "Bold";
                }
                else
                {
                    if ((int)new HTuple(hTuple8.TupleEqual("false")) == 0)
                    {
                        exception = "Wrong value of control parameter Bold";
                        throw new HalconException(exception);
                    }
                    hTuple2 = "";
                }
                if ((int)new HTuple(hTuple11.TupleEqual("true")) != 0)
                {
                    hTuple3 = "Italic";
                }
                else
                {
                    if ((int)new HTuple(hTuple11.TupleEqual("false")) == 0)
                    {
                        exception = "Wrong value of control parameter Slant";
                        throw new HalconException(exception);
                    }
                    hTuple3 = "";
                }
                if ((int)new HTuple(new HTuple(hTuple9.TupleEqual("mono")).TupleOr(new HTuple(hTuple9.TupleEqual("Courier")))).TupleOr(new HTuple(hTuple9.TupleEqual("courier"))) != 0)
                {
                    hTuple9 = "CourierNewPS";
                }
                else if ((int)new HTuple(hTuple9.TupleEqual("sans")) != 0)
                {
                    hTuple9 = "Arial";
                }
                else if ((int)new HTuple(hTuple9.TupleEqual("serif")) != 0)
                {
                    hTuple9 = "TimesNewRomanPS";
                }
                if ((int)new HTuple(hTuple8.TupleEqual("true")).TupleOr(new HTuple(hTuple11.TupleEqual("true"))) != 0)
                {
                    hTuple9 = hTuple9 + "-" + hTuple2 + hTuple3;
                }
                hTuple9 += "MT";
                try
                {
                    HOperatorSet.SetFont(hv_WindowHandle, hTuple9 + "-" + hTuple10);
                    return;
                }
                catch (HalconException ex2)
                {
                    ex2.ToHTuple(out exception);
                    return;
                }
            }
            hTuple10 *= 1.25;
            hTuple4 = new HTuple();
            hTuple4[0] = 11;
            hTuple4[1] = 14;
            hTuple4[2] = 17;
            hTuple4[3] = 20;
            hTuple4[4] = 25;
            hTuple4[5] = 34;
            if ((int)new HTuple(hTuple4.TupleFind(hTuple10).TupleEqual(-1)) != 0)
            {
                hTuple5 = (hTuple4 - hTuple10).TupleAbs();
                HOperatorSet.TupleSortIndex(hTuple5, out indices);
                hTuple10 = hTuple4.TupleSelect(indices.TupleSelect(0));
            }
            if ((int)new HTuple(hTuple9.TupleEqual("mono")).TupleOr(new HTuple(hTuple9.TupleEqual("Courier"))) != 0)
            {
                hTuple9 = "courier";
            }
            else if ((int)new HTuple(hTuple9.TupleEqual("sans")) != 0)
            {
                hTuple9 = "helvetica";
            }
            else if ((int)new HTuple(hTuple9.TupleEqual("serif")) != 0)
            {
                hTuple9 = "times";
            }
            if ((int)new HTuple(hTuple8.TupleEqual("true")) != 0)
            {
                hTuple8 = "bold";
            }
            else
            {
                if ((int)new HTuple(hTuple8.TupleEqual("false")) == 0)
                {
                    exception = "Wrong value of control parameter Bold";
                    throw new HalconException(exception);
                }
                hTuple8 = "medium";
            }
            if ((int)new HTuple(hTuple11.TupleEqual("true")) != 0)
            {
                hTuple11 = (((int)new HTuple(hTuple9.TupleEqual("times")) == 0) ? ((HTuple)"o") : ((HTuple)"i"));
            }
            else
            {
                if ((int)new HTuple(hTuple11.TupleEqual("false")) == 0)
                {
                    exception = "Wrong value of control parameter Slant";
                    throw new HalconException(exception);
                }
                hTuple11 = "r";
            }
            try
            {
                HOperatorSet.SetFont(hv_WindowHandle, "-adobe-" + hTuple9 + "-" + hTuple8 + "-" + hTuple11 + "-normal-*-" + hTuple10 + "-*-*-*-*-*-*-*");
            }
            catch (HalconException ex3)
            {
                ex3.ToHTuple(out exception);
                if ((int)new HTuple(information.TupleSubstr(0, 4).TupleEqual("Linux")).TupleAnd(new HTuple(hTuple9.TupleEqual("courier"))) == 0)
                {
                    return;
                }
                HOperatorSet.QueryFont(hv_WindowHandle, out font);
                hTuple6 = "^-[^-]*-[^-]*[Cc]ourier[^-]*-" + hTuple8 + "-" + hTuple11;
                hTuple7 = font.TupleRegexpSelect(hTuple6).TupleRegexpMatch(hTuple6);
                if ((int)new HTuple(new HTuple(hTuple7.TupleLength()).TupleEqual(0)) != 0)
                {
                    exception = "Wrong font name";
                    return;
                }
                try
                {
                    HOperatorSet.SetFont(hv_WindowHandle, hTuple7.TupleSelect(0) + "-normal-*-" + hTuple10 + "-*-*-*-*-*-*-*");
                }
                catch (HalconException ex4)
                {
                    ex4.ToHTuple(out exception);
                }
            }
        }

        private void btnSetModelPagePOS_Click(object sender, EventArgs e)
        {

            if (G.imgRaw != null && G.imgRaw.IsInitialized())
            {
                SetModelPagePOS(G.imgRaw, hWindow);
            }
            else
            {
                MessageBox.Show("ERROR:Please load G.imgRaw！");
            }
        }
        public bool SetModelPagePOS(HImage ho_ModelImage, HTuple hv_WindowID)
        {
            HTuple hTuple = null;
            HTuple hTuple2 = null;
            HTuple hTuple3 = null;
            HTuple hTuple4 = null;
            HTuple row = null;
            HTuple column = null;
            HTuple phi = null;
            HTuple length = null;
            HTuple length2 = null;
            HTuple hTuple5 = null;
            HTuple hTuple6 = new HTuple();
            HTuple measureHandle = new HTuple();
            HTuple rowEdge = new HTuple();
            HTuple columnEdge = new HTuple();
            HTuple amplitude = new HTuple();
            HTuple distance = new HTuple();
            HTuple rowBegin = null;
            HTuple colBegin = null;
            HTuple rowEnd = null;
            HTuple colEnd = null;
            HTuple nr = null;
            HTuple nc = null;
            HTuple dist = null;
            HTuple hTuple7 = null;
            HTuple hTuple8 = null;
            HTuple row2 = null;
            HTuple column2 = null;
            HTuple phi2 = null;
            HTuple length3 = null;
            HTuple length4 = null;
            HTuple hTuple9 = new HTuple();
            HTuple measureHandle2 = new HTuple();
            HTuple rowEdge2 = new HTuple();
            HTuple columnEdge2 = new HTuple();
            HTuple amplitude2 = new HTuple();
            HTuple distance2 = new HTuple();
            HTuple rowBegin2 = null;
            HTuple colBegin2 = null;
            HTuple rowEnd2 = null;
            HTuple colEnd2 = null;
            HTuple angle = null;
            HTuple row3 = null;
            HTuple column3 = null;
            HTuple angle2 = null;
            HTuple isParallel = null;
            HTuple hTuple10 = new HTuple();
            HTuple hTuple11 = new HTuple();
            HTuple hTuple12 = new HTuple();
            HTuple hTuple13 = new HTuple();
            HTuple hTuple14 = new HTuple();
            HTuple hTuple15 = new HTuple();
            HTuple hTuple16 = new HTuple();
            HTuple hTuple17 = new HTuple();
            HTuple hTuple18 = new HTuple();
            HTuple hTuple19 = new HTuple();
            HTuple hTuple20 = new HTuple();
            HOperatorSet.GenEmptyObj(out var emptyObject);
            HOperatorSet.GenEmptyObj(out var emptyObject2);
            HOperatorSet.GenEmptyObj(out var emptyObject3);
            HOperatorSet.GenEmptyObj(out var emptyObject4);
            HOperatorSet.GenEmptyObj(out var _);
            try
            {
                HOperatorSet.GetImageSize(ho_ModelImage, out hTuple, out hTuple2);
                hTuple3 = new HTuple();
                hTuple4 = new HTuple();
                HOperatorSet.DrawRectangle2Mod(hv_WindowID, hTuple2 / 2, hTuple / 2, new HTuple(90).TupleRad(), 180, 20, out row, out column, out phi, out length, out length2);
                emptyObject.Dispose();
                HOperatorSet.GenRectangle2(out emptyObject, row, column, phi, length, length2);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(emptyObject, hv_WindowID);
                hTuple5 = 0;
                while ((int)hTuple5 <= 20)
                {
                    hTuple6 = column + hTuple5 * 50;
                    emptyObject.Dispose();
                    HOperatorSet.GenRectangle2(out emptyObject, row, hTuple6, phi, length, length2);
                    HOperatorSet.GenMeasureRectangle2(row, hTuple6, phi, length, length2, hTuple, hTuple2, "nearest_neighbor", out measureHandle);
                    HOperatorSet.MeasurePos(ho_ModelImage, measureHandle, 1, 40, "positive", "first", out rowEdge, out columnEdge, out amplitude, out distance);
                    hTuple3 = hTuple3.TupleConcat(rowEdge);
                    hTuple4 = hTuple4.TupleConcat(columnEdge);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, rowEdge, columnEdge, 20, 45);
                    HOperatorSet.CloseMeasure(measureHandle);
                    hTuple5 = (int)hTuple5 + 1;
                }
                emptyObject2.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject2, hTuple3, hTuple4);
                HOperatorSet.FitLineContourXld(emptyObject2, "tukey", -1, 0, 5, 1.345, out rowBegin, out colBegin, out rowEnd, out colEnd, out nr, out nc, out dist);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, rowBegin, colBegin, rowEnd, colEnd);
                hTuple7 = new HTuple();
                hTuple8 = new HTuple();
                HOperatorSet.DrawRectangle2Mod(hv_WindowID, hTuple / 2, hTuple2 / 2, new HTuple(180).TupleRad(), 180, 20, out row2, out column2, out phi2, out length3, out length4);
                emptyObject3.Dispose();
                HOperatorSet.GenRectangle2(out emptyObject3, row2, column2, phi2, length3, length4);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(emptyObject3, hv_WindowID);
                hTuple5 = 0;
                while ((int)hTuple5 <= 20)
                {
                    hTuple9 = row2 + hTuple5 * 30;
                    emptyObject3.Dispose();
                    HOperatorSet.GenRectangle2(out emptyObject3, hTuple9, column2, phi2, length3, length4);
                    HOperatorSet.GenMeasureRectangle2(hTuple9, column2, phi2, length3, length4, hTuple, hTuple2, "nearest_neighbor", out measureHandle2);
                    HOperatorSet.MeasurePos(ho_ModelImage, measureHandle2, 1, 40, "positive", "first", out rowEdge2, out columnEdge2, out amplitude2, out distance2);
                    hTuple7 = hTuple7.TupleConcat(rowEdge2);
                    hTuple8 = hTuple8.TupleConcat(columnEdge2);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, rowEdge2, columnEdge2, 20, 45);
                    hTuple5 = (int)hTuple5 + 1;
                }
                HOperatorSet.CloseMeasure(measureHandle2);
                emptyObject4.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject4, hTuple7, hTuple8);
                HOperatorSet.FitLineContourXld(emptyObject4, "tukey", -1, 0, 5, 1.345, out rowBegin2, out colBegin2, out rowEnd2, out colEnd2, out nr, out nc, out dist);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, rowBegin2, colBegin2, rowEnd2, colEnd2);
                HOperatorSet.AngleLx(rowBegin2, colBegin2, rowEnd2, colEnd2, out angle);
                HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out angle2);
                HOperatorSet.IntersectionLl(rowBegin, colBegin, rowEnd, colEnd, rowBegin2, colBegin2, rowEnd2, colEnd2, out row3, out column3, out isParallel);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispCross(hv_WindowID, row3, column3, 30, 0);
                HOperatorSet.SetTposition(hv_WindowID, 20, 20);
                HTuple stringVal = "Model Position：" + row3 + " ;" + column3 + " ;" + angle2;
                HOperatorSet.WriteString(hv_WindowID, stringVal);
                CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                CRecipeCamera.instance.config.iniDownRow = row;
                CRecipeCamera.instance.config.iniDownCol = column;
                CRecipeCamera.instance.config.iniDownPhi = phi;
                CRecipeCamera.instance.config.iniDownLength11 = length;
                CRecipeCamera.instance.config.iniDownLength21 = length2;
                CRecipeCamera.instance.config.iniLeftRow = row2;
                CRecipeCamera.instance.config.iniLeftCol = column2;
                CRecipeCamera.instance.config.iniLeftPhi = phi2;
                CRecipeCamera.instance.config.iniLeftLength11 = length3;
                CRecipeCamera.instance.config.iniLeftLength21 = length4;
                CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                MessageBox.Show("Set Page Position finish ！");
                return true;
            }
            catch (Exception)
            {
                CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                MessageBox.Show("Set Page Position fail！");
                return false;
            }
        }

        private void btnCreateMarkModel_Click(object sender, EventArgs e)
        {
            if (G.imgRaw != null && G.imgRaw.IsInitialized())
            {
                CreateMarkModel(G.imgRaw, hWindow);
            }
            else
            {
                MessageBox.Show("ERROR:Please load G.imgRaw！");
            }
        }
        public bool CreateMarkModel(HImage ho_ModelImage, HTuple hv_WindowID)
        {
            HObject[] array = new HObject[20];
            HTuple hTuple = null;
            HTuple hTuple2 = null;
            HTuple row = null;
            HTuple column = null;
            HTuple phi = null;
            HTuple length = null;
            HTuple length2 = null;
            HTuple modelID = null;
            HTuple row2 = null;
            HTuple column2 = null;
            HTuple angle = null;
            HTuple score = null;
            HTuple area = null;
            HTuple row3 = null;
            HTuple column3 = null;
            HTuple homMat2D = null;
            HOperatorSet.GenEmptyObj(out var emptyObject);
            HOperatorSet.GenEmptyObj(out var emptyObject2);
            HOperatorSet.GenEmptyObj(out var emptyObject3);
            HOperatorSet.GenEmptyObj(out var emptyObject4);
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            HTuple minScore = Convert.ToDouble(CRecipeCamera.instance.config.iniMatchValue);
            try
            {
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.GetImageSize(ho_ModelImage, out hTuple, out hTuple2);
                HOperatorSet.DrawRectangle2Mod(hv_WindowID, hTuple2 / 2, hTuple / 2, new HTuple(90).TupleRad(), 180, 60, out row, out column, out phi, out length, out length2);
                emptyObject.Dispose();
                HOperatorSet.GenRectangle2(out emptyObject, row, column, phi, length, length2);
                emptyObject2.Dispose();
                HOperatorSet.ReduceDomain(ho_ModelImage, emptyObject, out emptyObject2);
                HOperatorSet.CreateShapeModel(emptyObject2, 5, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), new HTuple(0.7).TupleRad(), new HTuple("point_reduction_high").TupleConcat("no_pregeneration"), "use_polarity", new HTuple(10).TupleConcat(16).TupleConcat(23), 3, out modelID);
                HOperatorSet.FindShapeModel(emptyObject2, modelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row2, out column2, out angle, out score);//note 48 => 60
                emptyObject3.Dispose();
                HOperatorSet.GetShapeModelContours(out emptyObject3, modelID, 1);
                HOperatorSet.AreaCenter(emptyObject, out area, out row3, out column3);
                HOperatorSet.VectorAngleToRigid(0, 0, 0, row3, column3, 0, out homMat2D);
                emptyObject4.Dispose();
                HOperatorSet.AffineTransContourXld(emptyObject3, out emptyObject4, homMat2D);
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(emptyObject4, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispObj(emptyObject, hv_WindowID);
                if (hWindow != null)
                {
                    if (!FindAllMark(ho_ModelImage, hWindow, modelID, emptyObject))
                    {
                        MessageBox.Show("Create Model fail！");
                        return false;
                    }
                    bModelIsOK = true;
                }
                string text = System.Windows.Forms.Application.StartupPath + "\\Project\\UpCameraModel\\" + txtProjectNo.Text;
                string text2 = text + "\\Model.shm";
                string text3 = text + "\\ModelRegion.reg";
                string text4 = text + "\\ModelImage.bmp";
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                HOperatorSet.WriteShapeModel(modelID, text2);
                HOperatorSet.ClearShapeModel(modelID);
                HOperatorSet.WriteRegion(emptyObject, text3);
                HOperatorSet.WriteImage(ho_ModelImage, "bmp", 0, text4);
                MessageBox.Show("Create Model finish！");
                return true;
            }
            catch (Exception)
            {
                CLogAssistant.instance.log_message("Create Model Fail!", ELogLevel.Error);
                MessageBox.Show("Create Model fail！");
                return false;
            }
        }
        public bool FindAllMark(HObject ho_ModelImage, HTuple hv_WindowID, HTuple hv_MarkModelID, HObject ho_MarkModelRegion)
        {
            HObject[] array = new HObject[20];
            HObject emptyObject = null;
            HTuple row = null;
            HTuple column = null;
            HTuple row2 = null;
            HTuple column2 = null;
            HTuple angle = null;
            HTuple score = null;
            HTuple angle2 = null;
            HTuple hTuple = null;
            HTuple homMat2D = new HTuple();
            HTuple hTuple2 = null;
            HTuple hTuple3 = null;
            HOperatorSet.GenEmptyObj(out var emptyObject2);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out emptyObject);
            HTuple hTuple4 = null;
            HTuple hTuple5 = null;
            HTuple hTuple6 = null;
            HTuple hTuple7 = null;
            HTuple hTuple8 = null;
            HTuple hTuple9 = null;
            HTuple hTuple10 = null;
            HTuple hTuple11 = null;
            HTuple hTuple12 = new HTuple();
            HTuple measureHandle = new HTuple();
            HTuple rowEdge = new HTuple();
            HTuple columnEdge = new HTuple();
            HTuple amplitude = new HTuple();
            HTuple distance = new HTuple();
            HTuple rowBegin = null;
            HTuple colBegin = null;
            HTuple rowEnd = null;
            HTuple colEnd = null;
            HTuple nr = null;
            HTuple nc = null;
            HTuple dist = null;
            HTuple hTuple13 = null;
            HTuple hTuple14 = null;
            HTuple hTuple15 = null;
            HTuple hTuple16 = null;
            HTuple hTuple17 = null;
            HTuple hTuple18 = null;
            HTuple hTuple19 = null;
            HTuple hTuple20 = new HTuple();
            HTuple measureHandle2 = new HTuple();
            HTuple rowEdge2 = new HTuple();
            HTuple columnEdge2 = new HTuple();
            HTuple amplitude2 = new HTuple();
            HTuple distance2 = new HTuple();
            HTuple rowBegin2 = null;
            HTuple colBegin2 = null;
            HTuple rowEnd2 = null;
            HTuple colEnd2 = null;
            HTuple angle3 = null;
            HTuple isParallel = null;
            HTuple hTuple21 = new HTuple();
            HTuple hTuple22 = new HTuple();
            HTuple hTuple23 = new HTuple();
            HTuple hTuple24 = new HTuple();
            HTuple hTuple25 = new HTuple();
            HTuple hTuple26 = new HTuple();
            HTuple hTuple27 = new HTuple();
            HTuple hTuple28 = new HTuple();
            HTuple hTuple29 = new HTuple();
            HTuple hTuple30 = new HTuple();
            HTuple hTuple31 = new HTuple();
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var emptyObject6);
            HOperatorSet.GenEmptyObj(out var emptyObject7);
            HOperatorSet.GenEmptyObj(out var emptyObject8);
            HOperatorSet.GenEmptyObj(out var emptyObject9);
            HOperatorSet.GenEmptyObj(out var emptyObject10);
            HOperatorSet.GenEmptyObj(out var emptyObject11);
            HTuple minScore = CRecipeCamera.instance.config.iniMatchValue;
            HTuple maxGray = CRecipeCamera.instance.config.iniThresholdValue;
            try
            {
                HOperatorSet.GetImageSize(ho_ModelImage, out hTuple2, out hTuple3);
                HOperatorSet.SetPart(hv_WindowID, 0, 0, hTuple3 - 1, hTuple2 - 1);
                HOperatorSet.ReduceDomain(ho_ModelImage, ho_MarkModelRegion, out emptyObject2);
                HOperatorSet.DispObj(emptyObject2, hv_WindowID);
                HOperatorSet.FindShapeModel(emptyObject2, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row2, out column2, out angle, out score);//note số lượng mark 
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.FindShapeModel(ho_ModelImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row, out column, out angle2, out score);//note số lượng mark 
                HOperatorSet.GenEmptyObj(out ho_Chambers);
                hv_AllMarkArea = new HTuple();
                hv_AllMarkRow = new HTuple();
                hv_AllMarkCol = new HTuple();
                hTuple = 0;
                while ((int)hTuple <= (int)(new HTuple(score.TupleLength()) - 1))
                {
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispCross(hv_WindowID, row.TupleSelect(hTuple), column.TupleSelect(hTuple), 10, angle2.TupleSelect(hTuple));
                    HOperatorSet.VectorAngleToRigid(row2, column2, 0, row.TupleSelect(hTuple), column.TupleSelect(hTuple), 0, out homMat2D);
                    emptyObject.Dispose();
                    HOperatorSet.AffineTransRegion(ho_MarkModelRegion, out emptyObject, homMat2D, "false");
                    HOperatorSet.ConcatObj(ho_Chambers, emptyObject, out array[0]);
                    HOperatorSet.ReduceDomain(ho_ModelImage, emptyObject, out emptyObject10);
                    HOperatorSet.Threshold(emptyObject10, out emptyObject11, 0, maxGray);
                    HOperatorSet.AreaCenter(emptyObject11, out var area, out var row3, out var column3);
                    hv_AllMarkArea = hv_AllMarkArea.TupleConcat(area);
                    hv_AllMarkRow = hv_AllMarkRow.TupleConcat(row[hTuple]);
                    hv_AllMarkCol = hv_AllMarkCol.TupleConcat(column[hTuple]);
                    set_display_font(hv_WindowID, 10, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, row3, column3);
                    HOperatorSet.WriteString(hv_WindowID, area);
                    HOperatorSet.SetTposition(hv_WindowID, row3 - 50, column3);
                    HOperatorSet.WriteString(hv_WindowID, score[hTuple]);
                    ho_Chambers.Dispose();
                    ho_Chambers = array[0];
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(emptyObject, hv_WindowID);
                    HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispObj(emptyObject11, hv_WindowID);
                    hTuple = (int)hTuple + 1;
                }
                hTuple6 = CRecipeCamera.instance.config.iniDownRow;
                hTuple7 = CRecipeCamera.instance.config.iniDownCol;
                hTuple8 = CRecipeCamera.instance.config.iniDownPhi;
                hTuple9 = CRecipeCamera.instance.config.iniDownLength11;
                hTuple10 = CRecipeCamera.instance.config.iniDownLength21;
                hTuple15 = CRecipeCamera.instance.config.iniLeftRow;
                hTuple16 = CRecipeCamera.instance.config.iniLeftCol;
                hTuple17 = CRecipeCamera.instance.config.iniLeftPhi;
                hTuple18 = CRecipeCamera.instance.config.iniLeftLength11;
                hTuple19 = CRecipeCamera.instance.config.iniLeftLength21;
                hTuple4 = new HTuple();
                hTuple5 = new HTuple();
                HOperatorSet.GenRectangle2(out emptyObject6, hTuple6, hTuple7, hTuple8, hTuple9, hTuple10);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(emptyObject6, hv_WindowID);
                hTuple11 = 0;
                while ((int)hTuple11 <= 20)
                {
                    hTuple12 = hTuple7 + hTuple11 * 50;
                    emptyObject6.Dispose();
                    HOperatorSet.GenRectangle2(out emptyObject6, hTuple6, hTuple12, hTuple8, hTuple9, hTuple10);
                    HOperatorSet.GenMeasureRectangle2(hTuple6, hTuple12, hTuple8, hTuple9, hTuple10, hTuple2, hTuple3, "nearest_neighbor", out measureHandle);
                    HOperatorSet.MeasurePos(ho_ModelImage, measureHandle, 1, 40, "positive", "first", out rowEdge, out columnEdge, out amplitude, out distance);
                    hTuple4 = hTuple4.TupleConcat(rowEdge);
                    hTuple5 = hTuple5.TupleConcat(columnEdge);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, rowEdge, columnEdge, 20, 45);
                    HOperatorSet.CloseMeasure(measureHandle);
                    hTuple11 = (int)hTuple11 + 1;
                }
                emptyObject7.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject7, hTuple4, hTuple5);
                HOperatorSet.FitLineContourXld(emptyObject7, "tukey", -1, 0, 5, 1.345, out rowBegin, out colBegin, out rowEnd, out colEnd, out nr, out nc, out dist);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, rowBegin, colBegin, rowEnd, colEnd);
                hTuple13 = new HTuple();
                hTuple14 = new HTuple();
                emptyObject8.Dispose();
                HOperatorSet.GenRectangle2(out emptyObject8, hTuple15, hTuple16, hTuple17, hTuple18, hTuple19);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(emptyObject8, hv_WindowID);
                hTuple11 = 0;
                while ((int)hTuple11 <= 20)
                {
                    hTuple20 = hTuple15 + hTuple11 * 30;
                    emptyObject8.Dispose();
                    HOperatorSet.GenRectangle2(out emptyObject8, hTuple20, hTuple16, hTuple17, hTuple18, hTuple19);
                    HOperatorSet.GenMeasureRectangle2(hTuple20, hTuple16, hTuple17, hTuple18, hTuple19, hTuple2, hTuple3, "nearest_neighbor", out measureHandle2);
                    HOperatorSet.MeasurePos(ho_ModelImage, measureHandle2, 1, 40, "positive", "first", out rowEdge2, out columnEdge2, out amplitude2, out distance2);
                    hTuple13 = hTuple13.TupleConcat(rowEdge2);
                    hTuple14 = hTuple14.TupleConcat(columnEdge2);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, rowEdge2, columnEdge2, 20, 45);
                    hTuple11 = (int)hTuple11 + 1;
                }
                HOperatorSet.CloseMeasure(measureHandle2);
                emptyObject9.Dispose();
                HOperatorSet.GenContourPolygonXld(out emptyObject9, hTuple13, hTuple14);
                HOperatorSet.FitLineContourXld(emptyObject9, "tukey", -1, 0, 5, 1.345, out rowBegin2, out colBegin2, out rowEnd2, out colEnd2, out nr, out nc, out dist);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, rowBegin2, colBegin2, rowEnd2, colEnd2);
                HOperatorSet.AngleLx(rowBegin2, colBegin2, rowEnd2, colEnd2, out angle3);
                HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out hv_ModelPageAngle);
                HOperatorSet.IntersectionLl(rowBegin, colBegin, rowEnd, colEnd, rowBegin2, colBegin2, rowEnd2, colEnd2, out hv_ModelPageRow, out hv_ModelPageCol, out isParallel);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 30, 0);
                set_display_font(hv_WindowID, 20, "mono", "true", "false");
                HTuple stringVal = "Mark Number：" + score.Length;
                HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                HOperatorSet.WriteString(hv_WindowID, stringVal);
                return true;
            }
            catch (Exception)
            {
                CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                MessageBox.Show("Mark Number Error！");
                return false;
            }
        }

        private void btnSelectZoomRegion_Click(object sender, EventArgs e)
        {
            try
            {
                if (hWindow != null && G.imgRaw != null)
                {
                    HOperatorSet.GetImageSize(G.imgRaw, out var _, out var _);
                    HOperatorSet.SetColor(hWindow, "red");
                    if (!panel1.Focused)
                    {
                        panel1.Focus();
                    }
                    HOperatorSet.DrawRectangle1(hWindow, out var row, out var column, out var row2, out var column2);
                    HOperatorSet.SetPart(hWindow, row, column, row2, column2);
                    HOperatorSet.ClearWindow(hWindow);
                    HOperatorSet.DispObj(G.imgRaw, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR:请先加载图片！");
                }
            }
            catch
            {
            }
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (hWindow != null && G.imgRaw != null)
                {
                    HOperatorSet.GetImageSize(G.imgRaw, out var hTuple, out var hTuple2);
                    HOperatorSet.SetPart(hWindow, 0, 0, hTuple2 - 1, hTuple - 1);
                    HOperatorSet.DispObj(G.imgRaw, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR:请先加载图片！");
                }
            }
            catch
            {
            }
        }

        private void btnLoadProjectModel_Click(object sender, EventArgs e)
        {
            if (hWindow != null)
            {
                _instance = this;
                //CheckSofewareSecurity();
                imgView.Controls.Add(hwindowctl);//note1
                string text = System.Windows.Forms.Application.StartupPath + "Project\\UpCameraModel\\";//note bỏ \\ trước Project 
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "please select folder";
                folderBrowserDialog.SelectedPath = text;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {

                    if (CreateMarkRegion(hWindow, folderBrowserDialog.SelectedPath))
                    {
                        bModelIsOK = true;
                    }
                    else
                    {
                        MessageBox.Show("ERROR:load model fail！");
                    }
                }
            }
            
        }
        public void LoadProgram()
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");

            CRecipeCamera.instance.config.iniProjectNO = txtProjectNo.Text.ToString();
            // CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
            string file = txtProjectNo.Text + "CameraConfig.xml";
            CRecipeCamera.instance.LoadConfig(file);
        }
        public void SetParaCam()
        {
           
            Global.UpCameraTime = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraTime);//note Set giá trị cho from Set 
            Global.UpExposureTime = Convert.ToString(CRecipeCamera.instance.config.iniUpExposureTime);//note Set giá trị cho from Set 
            Global.UpCameraGain = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraGain);//note Set giá trị cho from Set 
            Global.DelaySendTime = Convert.ToString(CRecipeCamera.instance.config.iniDelaySendTime);//note Set giá trị cho from Set 
            double num2 = Convert.ToDouble(Global.UpExposureTime.ToString());//note Set giá trị cho from Set 
            double iniUpCameraGain = CRecipeCamera.instance.config.iniUpCameraGain;
            try
            {
                SetPara(Convert.ToSingle(Global.UpExposureTime.ToString()), (float)CRecipeCamera.instance.config.iniUpCameraGain);
                //  HOperatorSet.SetFramegrabberParam(AcqHandle, "ExposureTime", num2);
                //  HOperatorSet.SetFramegrabberParam(AcqHandle, "Gain", iniUpCameraGain);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR:UpCamera set ExposureTime fail!");
            }
        }
        public bool CreateMarkRegion(HTuple hv_WindowID ,String Path)
        {
            HObject[] array = new HObject[20];
            HObject emptyObject = null;
            HObject emptyObject2 = null;
            HTuple row = null;
            HTuple column = null;
            HTuple row2 = null;
            HTuple column2 = null;
            HTuple angle = null;
            HTuple score = null;
            HTuple angle2 = null;
            HTuple hTuple = null;
            HTuple homMat2D = new HTuple();
            HTuple hTuple2 = null;
            HTuple hTuple3 = null;
            HOperatorSet.GenEmptyObj(out emptyObject2);
            HOperatorSet.GenEmptyObj(out var emptyObject3);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out emptyObject);
            HTuple hTuple4 = null;
            HTuple hTuple5 = null;
            HTuple hTuple6 = null;
            HTuple hTuple7 = null;
            HTuple hTuple8 = null;
            HTuple hTuple9 = null;
            HTuple hTuple10 = null;
            HTuple hTuple11 = null;
            HTuple hTuple12 = new HTuple();
            HTuple measureHandle = new HTuple();
            HTuple rowEdge = new HTuple();
            HTuple columnEdge = new HTuple();
            HTuple amplitude = new HTuple();
            HTuple distance = new HTuple();
            HTuple rowBegin = null;
            HTuple colBegin = null;
            HTuple rowEnd = null;
            HTuple colEnd = null;
            HTuple nr = null;
            HTuple nc = null;
            HTuple dist = null;
            HTuple hTuple13 = null;
            HTuple hTuple14 = null;
            HTuple hTuple15 = null;
            HTuple hTuple16 = null;
            HTuple hTuple17 = null;
            HTuple hTuple18 = null;
            HTuple hTuple19 = null;
            HTuple hTuple20 = new HTuple();
            HTuple measureHandle2 = new HTuple();
            HTuple rowEdge2 = new HTuple();
            HTuple columnEdge2 = new HTuple();
            HTuple amplitude2 = new HTuple();
            HTuple distance2 = new HTuple();
            HTuple rowBegin2 = null;
            HTuple colBegin2 = null;
            HTuple rowEnd2 = null;
            HTuple colEnd2 = null;
            HTuple angle3 = null;
            HTuple isParallel = null;
            HTuple hTuple21 = new HTuple();
            HTuple hTuple22 = new HTuple();
            HTuple hTuple23 = new HTuple();
            HTuple hTuple24 = new HTuple();
            HTuple hTuple25 = new HTuple();
            HTuple hTuple26 = new HTuple();
            HTuple hTuple27 = new HTuple();
            HTuple hTuple28 = new HTuple();
            HTuple hTuple29 = new HTuple();
            HTuple hTuple30 = new HTuple();
            HTuple hTuple31 = new HTuple();
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var emptyObject7);
            HOperatorSet.GenEmptyObj(out var emptyObject8);
            HOperatorSet.GenEmptyObj(out var emptyObject9);
            HOperatorSet.GenEmptyObj(out var emptyObject10);
            HOperatorSet.GenEmptyObj(out var emptyObject11);
            HOperatorSet.GenEmptyObj(out var emptyObject12);
            string text = System.Windows.Forms.Application.StartupPath + "Project\\UpCameraModel\\";//note bỏ \\ trước Project 
        
            string text2 = "";
            string text3 = "";
            string text4 = "";
            string text5 = "";
           
                try
                {
                    text2 = Path;
                    int num = text2.Length - text.Length;
                    int startIndex = text2.Length - num;
                    txtProjectNo.Text = text2.Substring(startIndex, num);
                    text3 = text2 + "\\Model.shm";
                    text4 = text2 + "\\ModelRegion.reg";
                    text5 = text2 + "\\ModelImage.bmp";
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR:please select correct project file!");
                }
                CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                HTuple minScore = CRecipeCamera.instance.config.iniMatchValue;
                HTuple maxGray = CRecipeCamera.instance.config.iniThresholdValue;
                CRecipeCamera.instance.config.iniProjectNO = txtProjectNo.Text.ToString();
                CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                string file = txtProjectNo.Text + "CameraConfig.xml";
                CRecipeCamera.instance.LoadConfig(file);
                Global.UpCameraTime = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraTime);//note Set giá trị cho from Set 
                Global.UpExposureTime = Convert.ToString(CRecipeCamera.instance.config.iniUpExposureTime);//note Set giá trị cho from Set 
                Global.UpCameraGain = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraGain);//note Set giá trị cho from Set 
                Global.DelaySendTime = Convert.ToString(CRecipeCamera.instance.config.iniDelaySendTime);//note Set giá trị cho from Set 
                double num2 = Convert.ToDouble(Global.UpExposureTime.ToString());//note Set giá trị cho from Set 
                double iniUpCameraGain = CRecipeCamera.instance.config.iniUpCameraGain;
                //try
                //{
                //    HOperatorSet.SetFramegrabberParam(AcqHandle, "ExposureTime", num2);
                //    HOperatorSet.SetFramegrabberParam(AcqHandle, "Gain", iniUpCameraGain);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("ERROR:UpCamera set ExposureTime fail!");
                //}
                //if (!bUnEnbleDownCamera)
                //{
                //    string text6 = System.Windows.Forms.Application.StartupPath + "Project\\DownCameraModel\\" + txtProjectNo.Text;//hủy bỏ \\ trước project 
                //    string text7 = text6 + "\\Model.shm";
                //    try
                //    {
                //        HOperatorSet.ReadShapeModel(text7, out hvDownModelID);//note hủy load camera down 
                //    }
                //    catch (Exception)
                //    {
                //        CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                //        MessageBox.Show("Error:Down camrea load model fail ！");
                //        return false;
                //    }
                //}
                try
                {
                    HOperatorSet.ReadImage(out emptyObject2, text5);
                    HOperatorSet.GetImageSize(emptyObject2, out hTuple2, out hTuple3);
                    HOperatorSet.SetPart(hv_WindowID, 0, 0, hTuple3 - 1, hTuple2 - 1);
                    HOperatorSet.ReadRegion(out ho_MarkModelRegion, text4);
                    HOperatorSet.ReadShapeModel(text3, out hv_MarkModelID);
                    emptyObject3.Dispose();
                    HOperatorSet.ReduceDomain(emptyObject2, ho_MarkModelRegion, out emptyObject3);
                    HOperatorSet.DispObj(emptyObject3, hv_WindowID);
                    HOperatorSet.FindShapeModel(emptyObject3, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row2, out column2, out angle, out score);//note 48 => 60
                    HOperatorSet.DispObj(emptyObject2, hv_WindowID);
                    HOperatorSet.FindShapeModel(emptyObject2, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), minScore, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out row, out column, out angle2, out score);//note 48 => 60
                    HOperatorSet.GenEmptyObj(out ho_Chambers);
                    hv_AllMarkArea = new HTuple();
                    hv_AllMarkRow = new HTuple();
                    hv_AllMarkCol = new HTuple();
                    hTuple = 0;
                    while ((int)hTuple <= (int)(new HTuple(score.TupleLength()) - 1))
                    {
                        HOperatorSet.SetColor(hv_WindowID, "green");
                        HOperatorSet.DispCross(hv_WindowID, row.TupleSelect(hTuple), column.TupleSelect(hTuple), 10, angle2.TupleSelect(hTuple));
                        HOperatorSet.VectorAngleToRigid(row2, column2, 0, row.TupleSelect(hTuple), column.TupleSelect(hTuple), 0, out homMat2D);
                        emptyObject.Dispose();
                        HOperatorSet.AffineTransRegion(ho_MarkModelRegion, out emptyObject, homMat2D, "false");
                        HOperatorSet.ConcatObj(ho_Chambers, emptyObject, out array[0]);
                        HOperatorSet.ReduceDomain(emptyObject2, emptyObject, out emptyObject11);
                        HOperatorSet.Threshold(emptyObject11, out emptyObject12, 0, maxGray);
                        HOperatorSet.AreaCenter(emptyObject12, out var area, out var row3, out var column3);
                        hv_AllMarkArea = hv_AllMarkArea.TupleConcat(area);
                        hv_AllMarkRow = hv_AllMarkRow.TupleConcat(row[hTuple]);
                        hv_AllMarkCol = hv_AllMarkCol.TupleConcat(column[hTuple]);
                        string text8 = area[0].D.ToString("0.0");
                        string text9 = score[hTuple].D.ToString("0.0");
                        set_display_font(hv_WindowID, 12, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, row3, column3);
                        HOperatorSet.WriteString(hv_WindowID, text8);
                        HOperatorSet.SetTposition(hv_WindowID, row3 - 50, column3);
                        HOperatorSet.WriteString(hv_WindowID, text9);
                        ho_Chambers.Dispose();
                        ho_Chambers = array[0];
                        HOperatorSet.SetColor(hv_WindowID, "green");
                        HOperatorSet.DispObj(emptyObject, hv_WindowID);
                        HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispObj(emptyObject12, hv_WindowID);
                        hTuple = (int)hTuple + 1;
                    }
                    CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                    hTuple6 = CRecipeCamera.instance.config.iniDownRow;
                    hTuple7 = CRecipeCamera.instance.config.iniDownCol;
                    hTuple8 = CRecipeCamera.instance.config.iniDownPhi;
                    hTuple9 = CRecipeCamera.instance.config.iniDownLength11;
                    hTuple10 = CRecipeCamera.instance.config.iniDownLength21;
                    hTuple15 = CRecipeCamera.instance.config.iniLeftRow;
                    hTuple16 = CRecipeCamera.instance.config.iniLeftCol;
                    hTuple17 = CRecipeCamera.instance.config.iniLeftPhi;
                    hTuple18 = CRecipeCamera.instance.config.iniLeftLength11;
                    hTuple19 = CRecipeCamera.instance.config.iniLeftLength21;
                    hTuple4 = new HTuple();
                    hTuple5 = new HTuple();
                    HOperatorSet.GenRectangle2(out emptyObject7, hTuple6, hTuple7, hTuple8, hTuple9, hTuple10);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(emptyObject7, hv_WindowID);
                    hTuple11 = 0;
                    while ((int)hTuple11 <= 20)
                    {
                        hTuple12 = hTuple7 + hTuple11 * 50;
                        emptyObject7.Dispose();
                        HOperatorSet.GenRectangle2(out emptyObject7, hTuple6, hTuple12, hTuple8, hTuple9, hTuple10);
                        HOperatorSet.GenMeasureRectangle2(hTuple6, hTuple12, hTuple8, hTuple9, hTuple10, hTuple2, hTuple3, "nearest_neighbor", out measureHandle);
                        HOperatorSet.MeasurePos(emptyObject2, measureHandle, 1, 40, "positive", "first", out rowEdge, out columnEdge, out amplitude, out distance);
                        hTuple4 = hTuple4.TupleConcat(rowEdge);
                        hTuple5 = hTuple5.TupleConcat(columnEdge);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispCross(hv_WindowID, rowEdge, columnEdge, 20, 45);
                        HOperatorSet.CloseMeasure(measureHandle);
                        hTuple11 = (int)hTuple11 + 1;
                    }
                    emptyObject8.Dispose();
                    HOperatorSet.GenContourPolygonXld(out emptyObject8, hTuple4, hTuple5);
                    HOperatorSet.FitLineContourXld(emptyObject8, "tukey", -1, 0, 5, 1.345, out rowBegin, out colBegin, out rowEnd, out colEnd, out nr, out nc, out dist);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispLine(hv_WindowID, rowBegin, colBegin, rowEnd, colEnd);
                    hTuple13 = new HTuple();
                    hTuple14 = new HTuple();
                    emptyObject9.Dispose();
                    HOperatorSet.GenRectangle2(out emptyObject9, hTuple15, hTuple16, hTuple17, hTuple18, hTuple19);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(emptyObject9, hv_WindowID);
                    hTuple11 = 0;
                    while ((int)hTuple11 <= 20)
                    {
                        hTuple20 = hTuple15 + hTuple11 * 30;
                        emptyObject9.Dispose();
                        HOperatorSet.GenRectangle2(out emptyObject9, hTuple20, hTuple16, hTuple17, hTuple18, hTuple19);
                        HOperatorSet.GenMeasureRectangle2(hTuple20, hTuple16, hTuple17, hTuple18, hTuple19, hTuple2, hTuple3, "nearest_neighbor", out measureHandle2);
                        HOperatorSet.MeasurePos(emptyObject2, measureHandle2, 1, 40, "positive", "first", out rowEdge2, out columnEdge2, out amplitude2, out distance2);
                        hTuple13 = hTuple13.TupleConcat(rowEdge2);
                        hTuple14 = hTuple14.TupleConcat(columnEdge2);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispCross(hv_WindowID, rowEdge2, columnEdge2, 20, 45);
                        hTuple11 = (int)hTuple11 + 1;
                    }
                    HOperatorSet.CloseMeasure(measureHandle2);
                    emptyObject10.Dispose();
                    HOperatorSet.GenContourPolygonXld(out emptyObject10, hTuple13, hTuple14);
                    HOperatorSet.FitLineContourXld(emptyObject10, "tukey", -1, 0, 5, 1.345, out rowBegin2, out colBegin2, out rowEnd2, out colEnd2, out nr, out nc, out dist);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispLine(hv_WindowID, rowBegin2, colBegin2, rowEnd2, colEnd2);
                    HOperatorSet.AngleLx(rowBegin2, colBegin2, rowEnd2, colEnd2, out angle3);
                    HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out hv_ModelPageAngle);
                    HOperatorSet.IntersectionLl(rowBegin, colBegin, rowEnd, colEnd, rowBegin2, colBegin2, rowEnd2, colEnd2, out hv_ModelPageRow, out hv_ModelPageCol, out isParallel);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 30, 0);
                    //set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    //HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    //HOperatorSet.WriteString(hv_WindowID, "Load model finish!");
                    //HTuple stringVal = "Mark Number：" + score.Length;
                    //HOperatorSet.SetTposition(hv_WindowID, 120, 50);
                    //HOperatorSet.WriteString(hv_WindowID, stringVal);
                    return true;
                }
                catch (Exception)
                {
                    CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                    MessageBox.Show("Error:Load project fail ！");
                    return false;
                }
            
            MessageBox.Show("please select project file !");
            return false;
        }
        private void btnAutoStart_Click(object sender, EventArgs e)
        {

        }
        private void set_to_stop_status()
        {
            CLogAssistant.instance.log_message("Set to STOP mode", ELogLevel.Event);
            btnSetModelPagePOS.Enabled = false;
            btnCreateMarkModel.Enabled = false;
        }
        private void ThreadUpCameraRun()
        {
            bool flag = false;
            bool flag2 = false;
            int num = 0;
            bMarkCheckStart = false;
            bUpCameraCheckNG = false;
            while (!bExit)
            {
                if (bIOCarkOK)
                {
                    short num2 = DASK.DI_ReadPort((ushort)m_dev, 0, out var Value);
                    if (num2 < 0)
                    {
                        break;
                    }
                    if (Value == 1)
                    {
                        num = 1;
                        flag2 = false;
                    }
                    if (num == 1 && Value == 0)
                    {
                        flag2 = true;
                        num = 0;
                    }
                    if (flag2)
                    {
                        bMarkCheckStart = true;
                        flag2 = false;
                        num2 = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                        if (!bUnEnbleUpCamera)
                        {
                            num2 = DASK.DO_WritePort((ushort)m_dev, 0, 128u);
                            if (num2 < 0)
                            {
                                break;
                            }
                            GrapeImageDelay();//note chèn ảnh vào biến G.imgRaw 
                            num2 = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                            if (!FindMark(G.imgRaw, hWindow))
                            {
                                bUpCameraCheckNG = true;
                                Thread.Sleep(Convert.ToInt32( Global.DelaySendTime));
                                num2 = DASK.DO_WritePort((ushort)m_dev, 0, 256u);
                            }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }
        public void GrapeImageDelay()
        {
            Thread.Sleep(Convert.ToInt32(Global.UpCameraTime.Trim()));
            try
            {
                G.imgRaw= Trigger();
                G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);//note1
                hwindowctl.HalconWindow.DispObj(G.imgRaw);//note1
            }
            catch (Exception)
            {
            }
        }

        private void btnAutoStop_Click(object sender, EventArgs e)
        {

        }
        private void set_to_run_status()
        {
            CLogAssistant.instance.log_message("Set to RUN mode", ELogLevel.Event);
            // History_message(txtboxHistory, "RUNNINTG");
            btnSaveImage.Enabled = true;
            btnSetModelPagePOS.Enabled = true;
            btnCreateMarkModel.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dev = DASK.Register_Card(6, 0);
            if (m_dev < 0)
            {
                lbPCI.Text = "PCI fail connect";
                lbPCI.ForeColor = Color.Red;
            }
            else
            {
                lbPCI.Text = "PCI connected";
                lbPCI.ForeColor = Color.Green;
                bIOCarkOK = true;
            }
            chReMagnetNum = new char[100];
            CLogAssistant.instance.log_message("Loading system config");
            CSystemConfig.instance.LoadConfig("system.xml");
            CLogAssistant.instance.log_message("Application start");
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            // int num = CImage.instance.IniImage("GigEVision", "UpCamera");
            // AcqHandle = CImage.instance.AcqHandle1;
            //if (num == 1)
            //{
            //    bUpCameraOK = true;
            //}
            //else
            //{
            //    bUpCameraOK = false;
            //    }
            LoadParameter();
            workLoading.RunWorkerAsync();
           // threadUpCamera = new Thread(threadUpCameraLive);
          //  threadUpCamera.Start();
         
            timer1.Enabled = true;
        }

        private void threadUpCameraLive()
        {
            System.Windows.Forms.Application.DoEvents();
            while (!bExit)
            {
                try
                {
                    if (bUpCameraLive)
                    {
                        GrapeImage1();
                    }
                }
                catch (Exception)
                {
                }
                Thread.Sleep(20);
            }
            bUpCameraLive = false;
        }
        private void LoadParameter()
        {
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            //txtDownCameraTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDownCameraTime);//note phải load dữ liệu khi nhấn Setting 
            //txtDownExposureTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDownExposureTime);
            // cmbSaveNgDay.SelectedIndex = CRecipeCamera.instance.config.iniSaveNGDayCmbIndex;
            //nStartSaveDay = CRecipeCamera.instance.config.iniStartSaveDay;
            // nStartSaveMonth = CRecipeCamera.instance.config.iniStartSaveMonth;
            txtProjectNo.Text = CRecipeCamera.instance.config.iniProjectNO;
            Global.UpOffset = Convert.ToString(CRecipeCamera.instance.config.iniUpOffset);
            Global.DownOffset = Convert.ToString(CRecipeCamera.instance.config.iniDownOffset);
            Global.LeftOffset = Convert.ToString(CRecipeCamera.instance.config.iniLeftOffset);
            Global.RightOffset = Convert.ToString(CRecipeCamera.instance.config.iniRightOffset);
            Global.AngleOffset = Convert.ToString(CRecipeCamera.instance.config.iniAngleOffset);
            Global.MatchValue = Convert.ToString(CRecipeCamera.instance.config.iniMatchValue);
            Global.ThresholdValue = Convert.ToString(CRecipeCamera.instance.config.iniThresholdValue);
            Global.Scale = Convert.ToString(CRecipeCamera.instance.config.iniScale);
            //  nSaveNGimageDay = Convert.ToInt32(cmbSaveNgDay.SelectedItem);
            string file = txtProjectNo.Text + "CameraConfig.xml";
            CRecipeCamera.instance.LoadConfig(file);
            Global.UpCameraTime = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraTime);
            Global.UpExposureTime = Convert.ToString(CRecipeCamera.instance.config.iniUpExposureTime);
            Global.UpCameraGain = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraGain);
            Global.DelaySendTime = Convert.ToString(CRecipeCamera.instance.config.iniDelaySendTime);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                _instance = this;
                //CheckSofewareSecurity();
                //  imgView.Controls.Add(hwindowctl);//note1
                //chkboxUnEnbleDownCamera.Checked = true;
                hwindowctl.Dock = DockStyle.Fill;//note1
                hwindowctl.HalconWindow.SetDraw("margin");//note1
                hwindowctl.HalconWindow.SetLineWidth(1);//note1
                hwindowctl.HalconWindow.SetColor("green");//note1
                hWindow = hwindowctl.HalconWindow;//note1
                //panel36.Controls.Add(hwindowctl02);//note2
                hwindowctl02.Dock = DockStyle.Fill;
                hwindowctl02.HalconWindow.SetDraw("margin");
                hwindowctl02.HalconWindow.SetColor("green");
                hWindow02 = hwindowctl02.HalconWindow;
            }
            catch
            {
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (threadUpCamera != null)//note kiểm tra 
            //{
            //    threadUpCamera.Abort();
            //}
            //if (threadDownCamera != null)
            //{
            //    threadDownCamera.Abort();
            //}
            //if (upCameraAutoThread != null)
            //{
            //    upCameraAutoThread.Abort();
            //}
            //// if (downCameraAutoThread != null)
            ////      {
            ////      downCameraAutoThread.Abort();
            ////   }
            //if (scanIOCardThread != null)
            //{
            //    scanIOCardThread.Abort();
            //}

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            RunStop = !RunStop;
            if (RunStop)
            {
                if (!bUpCameraOK)
                {
                    MessageBox.Show("EEROR:Camera is closed !");
                    RunStop = false;
                    return;
                }
                else if (hv_MarkModelID == null)
                {
                    MessageBox.Show("EEROR:Please load model !");
                    RunStop = false;
                    return;
                }
                else if (!m_bRunFlg)
                {
                    m_bRunFlg = true;
                    BtnRun.BackColor = Color.Green;
                    BtnRun.Text = "Run";
                    BtnRun.ForeColor = Color.White;
                    set_to_stop_status();
                    upCameraAutoThread = new Thread(ThreadUpCameraRun);
                    upCameraAutoThread.Start();
                }
            }
            else
            {
                if (m_bRunFlg)
                {
                    bMarkCheckStart = false;
                    m_bRunFlg = false;
                    BtnRun.BackColor = Color.Red;
                    BtnRun.Text = "Stop";
                    BtnRun.ForeColor = Color.White;
                    set_to_run_status();
                    if (upCameraAutoThread != null)
                    {
                        upCameraAutoThread.Abort();
                    }
                    if (scanIOCardThread != null)
                    {
                        scanIOCardThread.Abort();
                    }
                }
            }
        }
        bool Lang;
        private void btnLang_Click(object sender, EventArgs e)
        {
            Lang = !Lang;
            if (!Lang)
            {
                btnLang.Text = "ENG";
                btnTrig.Text = "Trigger";
                btnContinous.Text = "Continous";
                btnSaveImage.Text = "SaveImage";
                btnFolder.Text = "Test";
                btnLive.Text = "Live";
                //btnResetIndex.Text = "ResetIndex";
                btnCreateMarkModel.Text = "CreateMarkModel";
                btnResetImage.Text = "ResetImage";
                btnSelectZoomRegion.Text = "SelectZoomRegion";
                btnSetModelPagePOS.Text = "CreatePagePosition";
                lbOI.Text = "OutputIndex";
                lbPC.Text = "ProjectControl";
                lbPN.Text = "ProjectNo";
            }
            else
            {
                btnLang.Text = "VN";
                btnTrig.Text = "Chụp ảnh";
                btnContinous.Text = "Chụp liên tiếp";
                btnSaveImage.Text = "Lưu hình ảnh";
                btnFolder.Text = "Kiểm tra";
                btnLive.Text = "Trực tiếp";
                //btnResetIndex.Text = "Đặt lại Index";
                btnCreateMarkModel.Text = "Dạy mẫu";
                btnResetImage.Text = "Đặt lại hình ảnh";
                btnSelectZoomRegion.Text = "Phóng to";
                btnSetModelPagePOS.Text = "Thiết lập vùng kiểm";
                lbOI.Text = "Thông số đầu ra";
                lbPC.Text = "Quản lý dự án";
                lbPN.Text = "Mã số dự án";
            }
        }

        private void btnCloseImage_Click(object sender, EventArgs e)
        {
            bUpCameraLive = false;
            DASK.DO_WritePort((ushort)m_dev, 0, 0u);
        }

        private void btnResetIndex_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            m_bRunFlg = false;
            bExit = true; G.isGrabbing = false;
            CloseCamera();
            if (AcqHandle != null)
            {
                AcqHandle.Dispose();
            }
            if (AcqHandleDown != null)
            {
                AcqHandleDown.Dispose();
            }
            if (hv_MarkModelID != null)
            {
                try
                {
                    HOperatorSet.ClearShapeModel(hv_MarkModelID);
                }
                catch(Exception ex)
                {

                }
               
            }
            int value = 0;
            if (bIOCarkOK)
            {
                short num = DASK.DO_WritePort((ushort)m_dev, 0, (uint)value);
                if (num < 0)
                {
                    MessageBox.Show("DO_WritePort error!");
                }
            }
       
        }
        List<String> listCamera = new List<String>();
        private void workLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            listCamera = G.Setting.RefreshDeviceList();
            if (listCamera.Count() > 0)
            {

                bUpCameraOK = G.Setting.ConnectCCD(0);
                if(bUpCameraOK )
                    
                SetParaCam();
                //
            }
            else
                bUpCameraOK = false;
        }
     
        private void workLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bUpCameraOK)
            {
                lbCam.Text = "Camera connected";
                lbCam.ForeColor = Color.Green;
                // lbCam.Image = Resources.Camera;

                //  SettingCam.Live(false);
                //  G.imgRaw = SettingCam.ReadImg();
                string text = System.Windows.Forms.Application.StartupPath + "Project\\UpCameraModel\\";//note bỏ \\ trước Project 
                text += txtProjectNo.Text.Trim();
                if (hwindowctl.Parent != imgView)
                {
                    imgView.Controls.Add(hwindowctl);//note1
                }
                //if (G.imgRaw.IsInitialized())
                //{
                //    hwindowctl.HalconWindow.ClearWindow();//note1
                //    G.imgRaw.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                //    hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);//note1
                //    hwindowctl.HalconWindow.DispObj(G.imgRaw);//note1
                //}
                if (CreateMarkRegion(hWindow, text))
                {
                    bModelIsOK = true;
                }
                else
                {
                    MessageBox.Show("ERROR:load model fail！");
                }
                // btnTrig.PerformClick();
                // SettingCam.SetCtrlWhenOpen();
                // SettingCam.SetCtrlWhenStartGrab();
            }
            else
                lbCam.ForeColor = Color.Red;
        }
       
        private void btnLive_Click(object sender, EventArgs e)
        {
            if(m_bRunFlg)
            {
                MessageBox.Show("Stop Run Mode");
                return;
            }    
            bUpCameraLive = !bUpCameraLive;
            if (!bUpCameraLive)
            {
                _instance = this;
                //CheckSofewareSecurity();
                imgView.Controls.Add(hwindowctl);//note1

            }
            else
            {
                imgView.Controls.Remove(hwindowctl);

            }
           Live(bUpCameraLive);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSet_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtProjectNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
