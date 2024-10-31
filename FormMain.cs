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
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace AD_RFID
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            G.FormMain = this;
        }
        public bool bDWCameraLive = false;
        public bool UpDown = true;
        private HWindow hWindow01 = new HWindow();
        private readonly HWindowControl hwindowctl01 = new HWindowControl();
        private readonly HWindowControl hwindowctl03 = new HWindowControl();
        private readonly HWindowControl hwindowctl04 = new HWindowControl();
        private HWindow hWindow03 = new HWindow();
        private HWindow hWindow04 = new HWindow();
        public int iDownCameraNgNum = 0;
        public bool bDownCameraCheckNG = false;
        private HTuple hv_Row01;
        private HTuple hv_Col01;
        private HTuple hv_Row02;
        private HTuple hv_Col02;
        private HObject ho_Rect;
        private HImage imageDown = new HImage();
        public int nSaveNGimageDay = 0;
        public int nStartSaveMonth;
        public int nStartSaveDay;
        public string check;
        public bool RunStop = false;
        public HFramegrabber AcqHandleDown = new HFramegrabber();
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
        private Thread threadDownCamera;
        private Thread downCameraAutoThread;
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
        private HImage image = new HImage();
        private IntPtr IntPtr;
        private readonly HalconDotNet.HWindowControl hwindowctl = new HWindowControl();//note1
        private readonly HalconDotNet.HWindowControl hwindowctl02 = new HWindowControl();
        private int hv_imageWidth;
        private int hv_imageHeight;
        private HTuple hv_StartTime;
        public bool bIOCarkOK = false;
        private HTuple hv_EndTime;
        public HFramegrabber AcqHandle = new HFramegrabber();
        public int iAllNum = 0;
        public HTuple hv_ModelPageRow = null;
        public HTuple hv_ModelPageCol = null;
        public HTuple hv_ModelPageAngle = null;
        public HTuple hv_AllMarkArea = null;
        public HTuple hvDownModelID = null;
        public HObject ho_MarkModelRegion = null;
        public bool TriggerMode = false;
        Thread LiveThread;
       
        public void GrapeImage1()
        {
            try
            {
                Thread.Sleep(50);
                HOperatorSet.CountSeconds(out hv_StartTime);
                image.GrabImage(AcqHandle);
                image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                hwindowctl.HalconWindow.DispObj(image);
                HOperatorSet.SetTposition(hWindow, 10, 10);
                HOperatorSet.WriteString(hWindow, "UpCamera");
                History_message(txtboxHistory, "Camera triggered, got image.");
                HOperatorSet.CountSeconds(out hv_EndTime);
                HTuple hv_ActTime = hv_EndTime - hv_StartTime;
                HOperatorSet.SetTposition(hWindow, 100, 100);
                HOperatorSet.WriteString(hWindow, hv_ActTime);
            }
            catch (Exception)
            {
                History_message(txtboxHistory, "Camera Grab False!!");
            }
        }
        private void History_message(Control ctl, string str)
        {
            if (ctl.InvokeRequired)
            {
                pfnAddText callback = History_message;
                ctl.Invoke(callback, ctl, str);
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
                if (hWindow != null && image != null)
                {
                    HOperatorSet.GetImageSize(image, out var hvWidth, out var hvHeight);
                    HOperatorSet.SetPart(hWindow, 0, 0, hvHeight - 1, hvWidth - 1);
                    HOperatorSet.DispObj(image, hWindow);
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
        public bool CreateMarkRegion(HTuple hv_WindowID)
        {
            HObject[] OTemp = new HObject[20];
            HObject ho_ALLMarkRegionAffineTrans = null;
            HObject ho_ModelImage = null;
            HTuple hv_MarkRow = null;
            HTuple hv_MarkCol = null;
            HTuple hv_MarkModelRow = null;
            HTuple hv_MarkModelCol = null;
            HTuple hv_MarkModelAngle = null;
            HTuple hv_MarkScore = null;
            HTuple hv_MarkAngle = null;
            HTuple hv_I = null;
            HTuple hv_MarkHomMat2D2 = new HTuple();
            HTuple hv_imageWidth = null;
            HTuple hv_imageHeight = null;
            HOperatorSet.GenEmptyObj(out ho_ModelImage);
            HOperatorSet.GenEmptyObj(out var ho_MarkTemplateImage);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out ho_ALLMarkRegionAffineTrans);
            HTuple hv_FindA_RowLine1 = null;
            HTuple hv_FindA_ColLine1 = null;
            HTuple hv_DownRow = null;
            HTuple hv_DownCol = null;
            HTuple hv_DownPhi = null;
            HTuple hv_DownLength11 = null;
            HTuple hv_DownLength21 = null;
            HTuple hv_i = null;
            HTuple hv_Col = new HTuple();
            HTuple hv_MeasureHandleA = new HTuple();
            HTuple hv_RowEdgeA1 = new HTuple();
            HTuple hv_ColumnEdgeA1 = new HTuple();
            HTuple hv_AmplitudeA1 = new HTuple();
            HTuple hv_DistanceA1 = new HTuple();
            HTuple hv_RowBeginA = null;
            HTuple hv_ColBeginA = null;
            HTuple hv_RowEndA = null;
            HTuple hv_ColEndA = null;
            HTuple hv_Nr1 = null;
            HTuple hv_Nc1 = null;
            HTuple hv_Dist1 = null;
            HTuple hv_FindB_RowLine = null;
            HTuple hv_FindB_ColLine = null;
            HTuple hv_LeftRow = null;
            HTuple hv_LeftCol = null;
            HTuple hv_LeftPhi = null;
            HTuple hv_LeftLength11 = null;
            HTuple hv_LeftLength21 = null;
            HTuple hv_RowB = new HTuple();
            HTuple hv_MeasureHandleB = new HTuple();
            HTuple hv_RowEdgeB = new HTuple();
            HTuple hv_ColumnEdgeB = new HTuple();
            HTuple hv_AmplitudeB = new HTuple();
            HTuple hv_DistanceB = new HTuple();
            HTuple hv_RowBeginB = null;
            HTuple hv_ColBeginB = null;
            HTuple hv_RowEndB = null;
            HTuple hv_ColEndB = null;
            HTuple hv_AngleB = null;
            HTuple hv_IsParallel = null;
            HTuple hv_TimeJustProcess = new HTuple();
            HTuple hv_Start = new HTuple();
            HTuple hv_PageAngle = new HTuple();
            HTuple hv_PageRow = new HTuple();
            HTuple hv_PageCol = new HTuple();
            HTuple hv_HomMat2D1 = new HTuple();
            HTuple hv_Number = new HTuple();
            HTuple hv_n = new HTuple();
            HTuple hv_Row = new HTuple();
            HTuple hv_Column = new HTuple();
            HTuple hv_Angle = new HTuple();
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var ho_Rectangle);
            HOperatorSet.GenEmptyObj(out var ho_ContourA);
            HOperatorSet.GenEmptyObj(out var ho_LeftRectangle);
            HOperatorSet.GenEmptyObj(out var ho_ContourB);
            HOperatorSet.GenEmptyObj(out var ho_ReduceImage);
            HOperatorSet.GenEmptyObj(out var ho_Threshold);
            string szPath = Application.StartupPath + "\\Project\\UpCameraModel\\";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "please select folder";
            dialog.SelectedPath = szPath;
            string foldPath = "";
            string ModelPath = "";
            string ModelRegionPath = "";
            string modelImagePath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foldPath = dialog.SelectedPath;
                    int delectLength = foldPath.Length - szPath.Length;
                    int needLength = foldPath.Length - delectLength;
                    txtProjectNo.Text = foldPath.Substring(needLength, delectLength);
                    ModelPath = foldPath + "\\Model.shm";
                    ModelRegionPath = foldPath + "\\ModelRegion.reg";
                    modelImagePath = foldPath + "\\ModelImage.bmp";
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR:please select correct project file!");
                }
                CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                HTuple hvMatchValue = CRecipeCamera.instance.config.iniMatchValue;
                HTuple hvThreshold = CRecipeCamera.instance.config.iniThresholdValue;
                CRecipeCamera.instance.config.iniProjectNO = txtProjectNo.Text.ToString();
                CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                string strFileName2 = txtProjectNo.Text + "CameraConfig.xml";
                CRecipeCamera.instance.LoadConfig(strFileName2);
                G.Setting.txtUpCameraTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraTime);
                G.Setting.txtUpExposureTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpExposureTime);
                G.Setting.txtUpCameraGain.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraGain);
                G.Setting.txtDelaySendTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDelaySendTime);
                double exposureTime = Convert.ToDouble(G.Setting.txtUpExposureTime.Text.ToString());
                double UpCameraGain = CRecipeCamera.instance.config.iniUpCameraGain;
                try
                {
                    HOperatorSet.SetFramegrabberParam(AcqHandle, "ExposureTime", exposureTime);
                    HOperatorSet.SetFramegrabberParam(AcqHandle, "Gain", UpCameraGain);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR:UpCamera set ExposureTime fail!");
                }
                if (!bUnEnbleDownCamera)
                {
                    string strDownPath = Application.StartupPath + "\\Project\\DownCameraModel\\" + txtProjectNo.Text;
                    string DownModelPath = strDownPath + "\\Model.shm";
                    try
                    {
                        HOperatorSet.ReadShapeModel(DownModelPath, out hvDownModelID);
                    }
                    catch (Exception)
                    {
                        CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                        MessageBox.Show("Error:Down camrea load model fail ！");
                        return false;
                    }
                }
                try
                {
                    HOperatorSet.ReadImage(out ho_ModelImage, modelImagePath);
                    HOperatorSet.GetImageSize(ho_ModelImage, out hv_imageWidth, out hv_imageHeight);
                    HOperatorSet.SetPart(hv_WindowID, 0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    HOperatorSet.ReadRegion(out ho_MarkModelRegion, ModelRegionPath);
                    HOperatorSet.ReadShapeModel(ModelPath, out hv_MarkModelID);
                    ho_MarkTemplateImage.Dispose();
                    HOperatorSet.ReduceDomain(ho_ModelImage, ho_MarkModelRegion, out ho_MarkTemplateImage);
                    HOperatorSet.DispObj(ho_MarkTemplateImage, hv_WindowID);
                    HOperatorSet.FindShapeModel(ho_MarkTemplateImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_MarkModelRow, out hv_MarkModelCol, out hv_MarkModelAngle, out hv_MarkScore);//đổi từ 48 sang 60 
                    HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                    HOperatorSet.FindShapeModel(ho_ModelImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_MarkRow, out hv_MarkCol, out hv_MarkAngle, out hv_MarkScore);//đổi từ 48 sang 60 
                    HOperatorSet.GenEmptyObj(out ho_Chambers);
                    hv_AllMarkArea = new HTuple();
                    hv_AllMarkRow = new HTuple();
                    hv_AllMarkCol = new HTuple();
                    hv_I = 0;
                    while ((int)hv_I <= (int)(new HTuple(hv_MarkScore.TupleLength()) - 1))
                    {
                        HOperatorSet.SetColor(hv_WindowID, "green");
                        HOperatorSet.DispCross(hv_WindowID, hv_MarkRow.TupleSelect(hv_I), hv_MarkCol.TupleSelect(hv_I), 10, hv_MarkAngle.TupleSelect(hv_I));
                        HOperatorSet.VectorAngleToRigid(hv_MarkModelRow, hv_MarkModelCol, 0, hv_MarkRow.TupleSelect(hv_I), hv_MarkCol.TupleSelect(hv_I), 0, out hv_MarkHomMat2D2);
                        ho_ALLMarkRegionAffineTrans.Dispose();
                        HOperatorSet.AffineTransRegion(ho_MarkModelRegion, out ho_ALLMarkRegionAffineTrans, hv_MarkHomMat2D2, "false");
                        HOperatorSet.ConcatObj(ho_Chambers, ho_ALLMarkRegionAffineTrans, out OTemp[0]);
                        HOperatorSet.ReduceDomain(ho_ModelImage, ho_ALLMarkRegionAffineTrans, out ho_ReduceImage);
                        HOperatorSet.Threshold(ho_ReduceImage, out ho_Threshold, 0, hvThreshold);
                        HOperatorSet.AreaCenter(ho_Threshold, out var hv_ModelArea, out var hv_ModelRow, out var hv_ModelCol);
                        hv_AllMarkArea = hv_AllMarkArea.TupleConcat(hv_ModelArea);
                        hv_AllMarkRow = hv_AllMarkRow.TupleConcat(hv_MarkRow[hv_I]);
                        hv_AllMarkCol = hv_AllMarkCol.TupleConcat(hv_MarkCol[hv_I]);
                        string strModelArea = hv_ModelArea[0].D.ToString("0.0");
                        string strMarkScore = hv_MarkScore[hv_I].D.ToString("0.0");
                        set_display_font(hv_WindowID, 12, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, hv_ModelRow, hv_ModelCol);
                        HOperatorSet.WriteString(hv_WindowID, strModelArea);
                        HOperatorSet.SetTposition(hv_WindowID, hv_ModelRow - 50, hv_ModelCol);
                        HOperatorSet.WriteString(hv_WindowID, strMarkScore);
                        ho_Chambers.Dispose();
                        ho_Chambers = OTemp[0];
                        HOperatorSet.SetColor(hv_WindowID, "green");
                        HOperatorSet.DispObj(ho_ALLMarkRegionAffineTrans, hv_WindowID);
                        HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispObj(ho_Threshold, hv_WindowID);
                        hv_I = (int)hv_I + 1;
                    }
                    CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                    hv_DownRow = CRecipeCamera.instance.config.iniDownRow;
                    hv_DownCol = CRecipeCamera.instance.config.iniDownCol;
                    hv_DownPhi = CRecipeCamera.instance.config.iniDownPhi;
                    hv_DownLength11 = CRecipeCamera.instance.config.iniDownLength11;
                    hv_DownLength21 = CRecipeCamera.instance.config.iniDownLength21;
                    hv_LeftRow = CRecipeCamera.instance.config.iniLeftRow;
                    hv_LeftCol = CRecipeCamera.instance.config.iniLeftCol;
                    hv_LeftPhi = CRecipeCamera.instance.config.iniLeftPhi;
                    hv_LeftLength11 = CRecipeCamera.instance.config.iniLeftLength11;
                    hv_LeftLength21 = CRecipeCamera.instance.config.iniLeftLength21;
                    hv_FindA_RowLine1 = new HTuple();
                    hv_FindA_ColLine1 = new HTuple();
                    HOperatorSet.GenRectangle2(out ho_Rectangle, hv_DownRow, hv_DownCol, hv_DownPhi, hv_DownLength11, hv_DownLength21);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(ho_Rectangle, hv_WindowID);
                    hv_i = 0;
                    while ((int)hv_i <= 20)
                    {
                        hv_Col = hv_DownCol + hv_i * 50;
                        ho_Rectangle.Dispose();
                        HOperatorSet.GenRectangle2(out ho_Rectangle, hv_DownRow, hv_Col, hv_DownPhi, hv_DownLength11, hv_DownLength21);
                        HOperatorSet.GenMeasureRectangle2(hv_DownRow, hv_Col, hv_DownPhi, hv_DownLength11, hv_DownLength21, hv_imageWidth, hv_imageHeight, "nearest_neighbor", out hv_MeasureHandleA);
                        HOperatorSet.MeasurePos(ho_ModelImage, hv_MeasureHandleA, 1, 40, "positive", "first", out hv_RowEdgeA1, out hv_ColumnEdgeA1, out hv_AmplitudeA1, out hv_DistanceA1);
                        hv_FindA_RowLine1 = hv_FindA_RowLine1.TupleConcat(hv_RowEdgeA1);
                        hv_FindA_ColLine1 = hv_FindA_ColLine1.TupleConcat(hv_ColumnEdgeA1);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispCross(hv_WindowID, hv_RowEdgeA1, hv_ColumnEdgeA1, 20, 45);
                        HOperatorSet.CloseMeasure(hv_MeasureHandleA);
                        hv_i = (int)hv_i + 1;
                    }
                    ho_ContourA.Dispose();
                    HOperatorSet.GenContourPolygonXld(out ho_ContourA, hv_FindA_RowLine1, hv_FindA_ColLine1);
                    HOperatorSet.FitLineContourXld(ho_ContourA, "tukey", -1, 0, 5, 1.345, out hv_RowBeginA, out hv_ColBeginA, out hv_RowEndA, out hv_ColEndA, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispLine(hv_WindowID, hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA);
                    hv_FindB_RowLine = new HTuple();
                    hv_FindB_ColLine = new HTuple();
                    ho_LeftRectangle.Dispose();
                    HOperatorSet.GenRectangle2(out ho_LeftRectangle, hv_LeftRow, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(ho_LeftRectangle, hv_WindowID);
                    hv_i = 0;
                    while ((int)hv_i <= 20)
                    {
                        hv_RowB = hv_LeftRow + hv_i * 30;
                        ho_LeftRectangle.Dispose();
                        HOperatorSet.GenRectangle2(out ho_LeftRectangle, hv_RowB, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21);
                        HOperatorSet.GenMeasureRectangle2(hv_RowB, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21, hv_imageWidth, hv_imageHeight, "nearest_neighbor", out hv_MeasureHandleB);
                        HOperatorSet.MeasurePos(ho_ModelImage, hv_MeasureHandleB, 1, 40, "positive", "first", out hv_RowEdgeB, out hv_ColumnEdgeB, out hv_AmplitudeB, out hv_DistanceB);
                        hv_FindB_RowLine = hv_FindB_RowLine.TupleConcat(hv_RowEdgeB);
                        hv_FindB_ColLine = hv_FindB_ColLine.TupleConcat(hv_ColumnEdgeB);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.DispCross(hv_WindowID, hv_RowEdgeB, hv_ColumnEdgeB, 20, 45);
                        hv_i = (int)hv_i + 1;
                    }
                    HOperatorSet.CloseMeasure(hv_MeasureHandleB);
                    ho_ContourB.Dispose();
                    HOperatorSet.GenContourPolygonXld(out ho_ContourB, hv_FindB_RowLine, hv_FindB_ColLine);
                    HOperatorSet.FitLineContourXld(ho_ContourB, "tukey", -1, 0, 5, 1.345, out hv_RowBeginB, out hv_ColBeginB, out hv_RowEndB, out hv_ColEndB, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispLine(hv_WindowID, hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB);
                    HOperatorSet.AngleLx(hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB, out hv_AngleB);
                    HOperatorSet.AngleLx(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, out hv_ModelPageAngle);
                    HOperatorSet.IntersectionLl(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB, out hv_ModelPageRow, out hv_ModelPageCol, out hv_IsParallel);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 30, 0);
                    set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    HOperatorSet.WriteString(hv_WindowID, "Load model finish!");
                    HTuple hvMarkNum = "Mark Number：" + hv_MarkScore.Length;
                    HOperatorSet.SetTposition(hv_WindowID, 120, 50);
                    HOperatorSet.WriteString(hv_WindowID, hvMarkNum);
                    return true;
                }
                catch (Exception)
                {
                    CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                    MessageBox.Show("Error:Load project fail ！");
                    return false;
                }
            }
            MessageBox.Show("please select project file !");
            return false;
        }
        public void GrapeImageDelay()
        {

            Thread.Sleep(iUpCameraDelayGrabTime);
            try
            {
                image.GrabImage(AcqHandle);
                image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                hwindowctl.HalconWindow.DispObj(image);
            }
            catch (Exception)
            {
            }
        }
        private void threadDWCameraLive()
        {
            Application.DoEvents();
            while (!bExit)
            {
                try
                {
                    if (bDWCameraLive)
                    {
                        GrapeImageDown();
                    }
                    else
                    {
                        Thread.Sleep(5);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("mainform:timer_tick:" + ex.Message);
                }
            }
            bDWCameraLive = false;
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
            G.Setting.txtDownCameraTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDownCameraTime);
            G.Setting.txtDownExposureTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDownExposureTime);
            G.Setting.cmbSaveNgDay.SelectedIndex = CRecipeCamera.instance.config.iniSaveNGDayCmbIndex;
            nStartSaveDay = CRecipeCamera.instance.config.iniStartSaveDay;
            nStartSaveMonth = CRecipeCamera.instance.config.iniStartSaveMonth;
            txtProjectNo.Text = CRecipeCamera.instance.config.iniProjectNO;
            G.Setting.txtUpOffset.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpOffset);
            G.Setting.txtDownOffset.Text = Convert.ToString(CRecipeCamera.instance.config.iniDownOffset);
            G.Setting.txtLeftOffset.Text = Convert.ToString(CRecipeCamera.instance.config.iniLeftOffset);
            G.Setting.txtRightOffset.Text = Convert.ToString(CRecipeCamera.instance.config.iniRightOffset);
            G.Setting.txtAngleOffset.Text = Convert.ToString(CRecipeCamera.instance.config.iniAngleOffset);
            G.Setting.txtMatchValue.Text = Convert.ToString(CRecipeCamera.instance.config.iniMatchValue);
            G.Setting.txtThresholdValue.Text = Convert.ToString(CRecipeCamera.instance.config.iniThresholdValue);
            G.Setting.txtScale.Text = Convert.ToString(CRecipeCamera.instance.config.iniScale);
            nSaveNGimageDay = Convert.ToInt32(G.Setting.cmbSaveNgDay.SelectedItem);
            string strFileName2 = txtProjectNo.Text + "CameraConfig.xml";
            CRecipeCamera.instance.LoadConfig(strFileName2);
            G.Setting.txtUpCameraTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraTime);
            G.Setting.txtUpExposureTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpExposureTime);
            G.Setting.txtUpCameraGain.Text = Convert.ToString(CRecipeCamera.instance.config.iniUpCameraGain);
            G.Setting.txtDelaySendTime.Text = Convert.ToString(CRecipeCamera.instance.config.iniDelaySendTime);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            m_dev = DASK.Register_Card(6, 0);
            if (m_dev < 0)
            {
             //   MessageBox.Show("Register_IO_Card error!");
                lbPCI.Text = "Card PCI Disconnected";
            }
            else
            {
                bIOCarkOK = true;
                lbPCI.Text = "Card PCI Connected";
            }
            chReMagnetNum = new char[100];
            CLogAssistant.instance.log_message("Loading system config");
            CSystemConfig.instance.LoadConfig("system.xml");
            CLogAssistant.instance.log_message("Application start");
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            int upCamera = CImage.instance.IniImage("GigEVision", "UpCamera");
            AcqHandle = CImage.instance.AcqHandle1;
            if (upCamera == 1)
            {
                bUpCameraOK = true;
            }
            else
            {
                bUpCameraOK = false;
            }
            threadUpCamera = new Thread(threadUpCameraLive);
            threadUpCamera.Start();
            LoadParameter();
            timer1.Enabled = true;
            btnUp.Enabled = false;
            btnUp.BackColor= Color.Transparent;
            G.FormMain.bUnEnbleDownCamera = G.Setting.chkboxUnEnbleDownCamera.Checked;
            G.FormMain.bUnEnbleUpCamera = G.Setting.chkboxUnEnbleUpCamera.Checked; 
            G.FormMain.bEnbleShow = G.Setting.chkShowEable.Checked;
           // BlockNGCon();
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (threadUpCamera != null)
            {
                threadUpCamera.Abort();
            }
            if (threadDownCamera != null)
            {
                threadDownCamera.Abort();
            }
            if (upCameraAutoThread != null)
            {
                upCameraAutoThread.Abort();
            }
            if (downCameraAutoThread != null)
            {
                downCameraAutoThread.Abort();
            }
            if (scanIOCardThread != null)
            {
                scanIOCardThread.Abort();
            }
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
                HOperatorSet.ClearShapeModel(hv_MarkModelID);
            }
            int out_value = 0;
            if (bIOCarkOK)
            {
                short ret = DASK.DO_WritePort((ushort)m_dev, 0, (uint)out_value);
                if (ret < 0)
                {
                    MessageBox.Show("DO_WritePort error!");
                }
            }
        }

        private void btnCreateMarkModel_Click(object sender, EventArgs e)
        {
            if (UpDown)
            {
                
                if (image != null && image.IsInitialized())
                {
                    CreateMarkModel(image, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR:Please load image！");
                }
            }
            else
            {
                
                if (imageDown == null || !imageDown.IsInitialized())
                {
                    MessageBox.Show(" Please load/grab image first.");
                }
                else
                {
                    CreateModelDN(hWindow02, imageDown);
                }
            }
        }
        public bool CreateMarkModel(HImage ho_ModelImage, HTuple hv_WindowID)
        {
            HObject[] OTemp = new HObject[20];
            HTuple hv_Width = null;
            HTuple hv_Height = null;
            HTuple hv_MarkRow = null;
            HTuple hv_MarkCol = null;
            HTuple hv_MarkPhi = null;
            HTuple hv_MarkLength11 = null;
            HTuple hv_MarkLength21 = null;
            HTuple hv_MarkModelID = null;
            HTuple hv_MarkModelRow = null;
            HTuple hv_MarkModelCol = null;
            HTuple hv_MarkModelAngle = null;
            HTuple hv_MarkScore = null;
            HTuple hv_MarkModelRegionArea = null;
            HTuple hv_MarkRefRow = null;
            HTuple hv_MarkRefCol = null;
            HTuple hv_MarkHomMat2D = null;
            HOperatorSet.GenEmptyObj(out var ho_MarkModelRegion);
            HOperatorSet.GenEmptyObj(out var ho_MarkTemplateImage);
            HOperatorSet.GenEmptyObj(out var ho_MarkModelContours);
            HOperatorSet.GenEmptyObj(out var ho_MarkTransContours);
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            HTuple hvMatchValue = Convert.ToDouble(CRecipeCamera.instance.config.iniMatchValue);
            try
            {
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.GetImageSize(ho_ModelImage, out hv_Width, out hv_Height);
                HOperatorSet.DrawRectangle2Mod(hv_WindowID, hv_Height / 2, hv_Width / 2, new HTuple(90).TupleRad(), 180, 60, out hv_MarkRow, out hv_MarkCol, out hv_MarkPhi, out hv_MarkLength11, out hv_MarkLength21);
                ho_MarkModelRegion.Dispose();
                HOperatorSet.GenRectangle2(out ho_MarkModelRegion, hv_MarkRow, hv_MarkCol, hv_MarkPhi, hv_MarkLength11, hv_MarkLength21);
                ho_MarkTemplateImage.Dispose();
                HOperatorSet.ReduceDomain(ho_ModelImage, ho_MarkModelRegion, out ho_MarkTemplateImage);
                HOperatorSet.CreateShapeModel(ho_MarkTemplateImage, 5, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), new HTuple(0.7).TupleRad(), new HTuple("point_reduction_high").TupleConcat("no_pregeneration"), "use_polarity", new HTuple(10).TupleConcat(16).TupleConcat(23), 3, out hv_MarkModelID);
                HOperatorSet.FindShapeModel(ho_MarkTemplateImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_MarkModelRow, out hv_MarkModelCol, out hv_MarkModelAngle, out hv_MarkScore);//đổi từ 48 sang 60 
                ho_MarkModelContours.Dispose();
                HOperatorSet.GetShapeModelContours(out ho_MarkModelContours, hv_MarkModelID, 1);
                HOperatorSet.AreaCenter(ho_MarkModelRegion, out hv_MarkModelRegionArea, out hv_MarkRefRow, out hv_MarkRefCol);
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_MarkRefRow, hv_MarkRefCol, 0, out hv_MarkHomMat2D);
                ho_MarkTransContours.Dispose();
                HOperatorSet.AffineTransContourXld(ho_MarkModelContours, out ho_MarkTransContours, hv_MarkHomMat2D);
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(ho_MarkTransContours, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispObj(ho_MarkModelRegion, hv_WindowID);
                if (hWindow != null)
                {
                    if (!FindAllMark(ho_ModelImage, hWindow, hv_MarkModelID, ho_MarkModelRegion))
                    {
                        MessageBox.Show("Create Model fail！");
                        return false;
                    }
                    bModelIsOK = true;
                }
                string szPath = Application.StartupPath + "\\Project\\UpCameraModel\\" + txtProjectNo.Text;
                string ModelPath = szPath + "\\Model.shm";
                string ModelRegionPath = szPath + "\\ModelRegion.reg";
                string modelImagePath = szPath + "\\ModelImage.bmp";
                if (!Directory.Exists(szPath))
                {
                    Directory.CreateDirectory(szPath);
                }
                HOperatorSet.WriteShapeModel(hv_MarkModelID, ModelPath);
                HOperatorSet.ClearShapeModel(hv_MarkModelID);
                HOperatorSet.WriteRegion(ho_MarkModelRegion, ModelRegionPath);
                HOperatorSet.WriteImage(ho_ModelImage, "bmp", 0, modelImagePath);
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
            HObject[] OTemp = new HObject[20];
            HObject ho_ALLMarkRegionAffineTrans = null;
            HTuple hv_MarkRow = null;
            HTuple hv_MarkCol = null;
            HTuple hv_MarkModelRow = null;
            HTuple hv_MarkModelCol = null;
            HTuple hv_MarkModelAngle = null;
            HTuple hv_MarkScore = null;
            HTuple hv_MarkAngle = null;
            HTuple hv_I = null;
            HTuple hv_MarkHomMat2D2 = new HTuple();
            HTuple hv_imageWidth = null;
            HTuple hv_imageHeight = null;
            HOperatorSet.GenEmptyObj(out var ho_MarkTemplateImage);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out ho_ALLMarkRegionAffineTrans);
            HTuple hv_FindA_RowLine1 = null;
            HTuple hv_FindA_ColLine1 = null;
            HTuple hv_DownRow = null;
            HTuple hv_DownCol = null;
            HTuple hv_DownPhi = null;
            HTuple hv_DownLength11 = null;
            HTuple hv_DownLength21 = null;
            HTuple hv_i = null;
            HTuple hv_Col = new HTuple();
            HTuple hv_MeasureHandleA = new HTuple();
            HTuple hv_RowEdgeA1 = new HTuple();
            HTuple hv_ColumnEdgeA1 = new HTuple();
            HTuple hv_AmplitudeA1 = new HTuple();
            HTuple hv_DistanceA1 = new HTuple();
            HTuple hv_RowBeginA = null;
            HTuple hv_ColBeginA = null;
            HTuple hv_RowEndA = null;
            HTuple hv_ColEndA = null;
            HTuple hv_Nr1 = null;
            HTuple hv_Nc1 = null;
            HTuple hv_Dist1 = null;
            HTuple hv_FindB_RowLine = null;
            HTuple hv_FindB_ColLine = null;
            HTuple hv_LeftRow = null;
            HTuple hv_LeftCol = null;
            HTuple hv_LeftPhi = null;
            HTuple hv_LeftLength11 = null;
            HTuple hv_LeftLength21 = null;
            HTuple hv_RowB = new HTuple();
            HTuple hv_MeasureHandleB = new HTuple();
            HTuple hv_RowEdgeB = new HTuple();
            HTuple hv_ColumnEdgeB = new HTuple();
            HTuple hv_AmplitudeB = new HTuple();
            HTuple hv_DistanceB = new HTuple();
            HTuple hv_RowBeginB = null;
            HTuple hv_ColBeginB = null;
            HTuple hv_RowEndB = null;
            HTuple hv_ColEndB = null;
            HTuple hv_AngleB = null;
            HTuple hv_IsParallel = null;
            HTuple hv_TimeJustProcess = new HTuple();
            HTuple hv_Start = new HTuple();
            HTuple hv_PageAngle = new HTuple();
            HTuple hv_PageRow = new HTuple();
            HTuple hv_PageCol = new HTuple();
            HTuple hv_HomMat2D1 = new HTuple();
            HTuple hv_Number = new HTuple();
            HTuple hv_n = new HTuple();
            HTuple hv_Row = new HTuple();
            HTuple hv_Column = new HTuple();
            HTuple hv_Angle = new HTuple();
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var ho_Rectangle);
            HOperatorSet.GenEmptyObj(out var ho_ContourA);
            HOperatorSet.GenEmptyObj(out var ho_LeftRectangle);
            HOperatorSet.GenEmptyObj(out var ho_ContourB);
            HOperatorSet.GenEmptyObj(out var ho_ReduceImage);
            HOperatorSet.GenEmptyObj(out var ho_Threshold);
            HTuple hvMatchValue = CRecipeCamera.instance.config.iniMatchValue;
            HTuple hvThreshold = CRecipeCamera.instance.config.iniThresholdValue;
            try
            {
                HOperatorSet.GetImageSize(ho_ModelImage, out hv_imageWidth, out hv_imageHeight);
                HOperatorSet.SetPart(hv_WindowID, 0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                HOperatorSet.ReduceDomain(ho_ModelImage, ho_MarkModelRegion, out ho_MarkTemplateImage);
                HOperatorSet.DispObj(ho_MarkTemplateImage, hv_WindowID);
                HOperatorSet.FindShapeModel(ho_MarkTemplateImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_MarkModelRow, out hv_MarkModelCol, out hv_MarkModelAngle, out hv_MarkScore);//đổi từ 48 sang 60 
                HOperatorSet.DispObj(ho_ModelImage, hv_WindowID);
                HOperatorSet.FindShapeModel(ho_ModelImage, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 60, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_MarkRow, out hv_MarkCol, out hv_MarkAngle, out hv_MarkScore);//đổi từ 48 sang 60 
                HOperatorSet.GenEmptyObj(out ho_Chambers);
                hv_AllMarkArea = new HTuple();
                hv_AllMarkRow = new HTuple();
                hv_AllMarkCol = new HTuple();
                hv_I = 0;
                while ((int)hv_I <= (int)(new HTuple(hv_MarkScore.TupleLength()) - 1))
                {
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispCross(hv_WindowID, hv_MarkRow.TupleSelect(hv_I), hv_MarkCol.TupleSelect(hv_I), 10, hv_MarkAngle.TupleSelect(hv_I));
                    HOperatorSet.VectorAngleToRigid(hv_MarkModelRow, hv_MarkModelCol, 0, hv_MarkRow.TupleSelect(hv_I), hv_MarkCol.TupleSelect(hv_I), 0, out hv_MarkHomMat2D2);
                    ho_ALLMarkRegionAffineTrans.Dispose();
                    HOperatorSet.AffineTransRegion(ho_MarkModelRegion, out ho_ALLMarkRegionAffineTrans, hv_MarkHomMat2D2, "false");
                    HOperatorSet.ConcatObj(ho_Chambers, ho_ALLMarkRegionAffineTrans, out OTemp[0]);
                    HOperatorSet.ReduceDomain(ho_ModelImage, ho_ALLMarkRegionAffineTrans, out ho_ReduceImage);
                    HOperatorSet.Threshold(ho_ReduceImage, out ho_Threshold, 0, hvThreshold);
                    HOperatorSet.AreaCenter(ho_Threshold, out var hv_ModelArea, out var hv_ModelRow, out var hv_ModelCol);
                    hv_AllMarkArea = hv_AllMarkArea.TupleConcat(hv_ModelArea);
                    hv_AllMarkRow = hv_AllMarkRow.TupleConcat(hv_MarkRow[hv_I]);
                    hv_AllMarkCol = hv_AllMarkCol.TupleConcat(hv_MarkCol[hv_I]);
                    set_display_font(hv_WindowID, 10, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, hv_ModelRow, hv_ModelCol);
                    HOperatorSet.WriteString(hv_WindowID, hv_ModelArea);
                    HOperatorSet.SetTposition(hv_WindowID, hv_ModelRow - 50, hv_ModelCol);
                    HOperatorSet.WriteString(hv_WindowID, hv_MarkScore[hv_I]);
                    ho_Chambers.Dispose();
                    ho_Chambers = OTemp[0];
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(ho_ALLMarkRegionAffineTrans, hv_WindowID);
                    HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispObj(ho_Threshold, hv_WindowID);
                    hv_I = (int)hv_I + 1;
                }
                hv_DownRow = CRecipeCamera.instance.config.iniDownRow;
                hv_DownCol = CRecipeCamera.instance.config.iniDownCol;
                hv_DownPhi = CRecipeCamera.instance.config.iniDownPhi;
                hv_DownLength11 = CRecipeCamera.instance.config.iniDownLength11;
                hv_DownLength21 = CRecipeCamera.instance.config.iniDownLength21;
                hv_LeftRow = CRecipeCamera.instance.config.iniLeftRow;
                hv_LeftCol = CRecipeCamera.instance.config.iniLeftCol;
                hv_LeftPhi = CRecipeCamera.instance.config.iniLeftPhi;
                hv_LeftLength11 = CRecipeCamera.instance.config.iniLeftLength11;
                hv_LeftLength21 = CRecipeCamera.instance.config.iniLeftLength21;
                hv_FindA_RowLine1 = new HTuple();
                hv_FindA_ColLine1 = new HTuple();
                HOperatorSet.GenRectangle2(out ho_Rectangle, hv_DownRow, hv_DownCol, hv_DownPhi, hv_DownLength11, hv_DownLength21);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(ho_Rectangle, hv_WindowID);
                hv_i = 0;
                while ((int)hv_i <= 20)
                {
                    hv_Col = hv_DownCol + hv_i * 50;
                    ho_Rectangle.Dispose();
                    HOperatorSet.GenRectangle2(out ho_Rectangle, hv_DownRow, hv_Col, hv_DownPhi, hv_DownLength11, hv_DownLength21);
                    HOperatorSet.GenMeasureRectangle2(hv_DownRow, hv_Col, hv_DownPhi, hv_DownLength11, hv_DownLength21, hv_imageWidth, hv_imageHeight, "nearest_neighbor", out hv_MeasureHandleA);
                    HOperatorSet.MeasurePos(ho_ModelImage, hv_MeasureHandleA, 1, 40, "positive", "first", out hv_RowEdgeA1, out hv_ColumnEdgeA1, out hv_AmplitudeA1, out hv_DistanceA1);
                    hv_FindA_RowLine1 = hv_FindA_RowLine1.TupleConcat(hv_RowEdgeA1);
                    hv_FindA_ColLine1 = hv_FindA_ColLine1.TupleConcat(hv_ColumnEdgeA1);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, hv_RowEdgeA1, hv_ColumnEdgeA1, 20, 45);
                    HOperatorSet.CloseMeasure(hv_MeasureHandleA);
                    hv_i = (int)hv_i + 1;
                }
                ho_ContourA.Dispose();
                HOperatorSet.GenContourPolygonXld(out ho_ContourA, hv_FindA_RowLine1, hv_FindA_ColLine1);
                HOperatorSet.FitLineContourXld(ho_ContourA, "tukey", -1, 0, 5, 1.345, out hv_RowBeginA, out hv_ColBeginA, out hv_RowEndA, out hv_ColEndA, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA);
                hv_FindB_RowLine = new HTuple();
                hv_FindB_ColLine = new HTuple();
                ho_LeftRectangle.Dispose();
                HOperatorSet.GenRectangle2(out ho_LeftRectangle, hv_LeftRow, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(ho_LeftRectangle, hv_WindowID);
                hv_i = 0;
                while ((int)hv_i <= 20)
                {
                    hv_RowB = hv_LeftRow + hv_i * 30;
                    ho_LeftRectangle.Dispose();
                    HOperatorSet.GenRectangle2(out ho_LeftRectangle, hv_RowB, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21);
                    HOperatorSet.GenMeasureRectangle2(hv_RowB, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21, hv_imageWidth, hv_imageHeight, "nearest_neighbor", out hv_MeasureHandleB);
                    HOperatorSet.MeasurePos(ho_ModelImage, hv_MeasureHandleB, 1, 40, "positive", "first", out hv_RowEdgeB, out hv_ColumnEdgeB, out hv_AmplitudeB, out hv_DistanceB);
                    hv_FindB_RowLine = hv_FindB_RowLine.TupleConcat(hv_RowEdgeB);
                    hv_FindB_ColLine = hv_FindB_ColLine.TupleConcat(hv_ColumnEdgeB);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, hv_RowEdgeB, hv_ColumnEdgeB, 20, 45);
                    hv_i = (int)hv_i + 1;
                }
                HOperatorSet.CloseMeasure(hv_MeasureHandleB);
                ho_ContourB.Dispose();
                HOperatorSet.GenContourPolygonXld(out ho_ContourB, hv_FindB_RowLine, hv_FindB_ColLine);
                HOperatorSet.FitLineContourXld(ho_ContourB, "tukey", -1, 0, 5, 1.345, out hv_RowBeginB, out hv_ColBeginB, out hv_RowEndB, out hv_ColEndB, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispLine(hv_WindowID, hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB);
                HOperatorSet.AngleLx(hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB, out hv_AngleB);
                HOperatorSet.AngleLx(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, out hv_ModelPageAngle);
                HOperatorSet.IntersectionLl(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB, out hv_ModelPageRow, out hv_ModelPageCol, out hv_IsParallel);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 30, 0);
                set_display_font(hv_WindowID, 20, "mono", "true", "false");
                HTuple hvMarkNum = "Mark Number：" + hv_MarkScore.Length;
                HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                HOperatorSet.WriteString(hv_WindowID, hvMarkNum);
                return true;
            }
            catch (Exception)
            {
                CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
                MessageBox.Show("Mark Number Error！");
                return false;
            }
        }

        private void btnSetModelPagePOS_Click_1(object sender, EventArgs e)
        {
            if (UpDown)
            {
                
                if (image != null && image.IsInitialized())
                {
                    SetModelPagePOS(image, hWindow);
                }
                else
                {
                    MessageBox.Show("ERROR:Please load image！");
                }
            }
            else
            {
                
                if (imageDown == null || !imageDown.IsInitialized())
                {
                    MessageBox.Show("Error set ROI. Please load/grab image first.");
                    return;
                }
                try
                {
                    HOperatorSet.SetColor(hWindow02, "red");
                    HOperatorSet.DrawRectangle1(hWindow02, out hv_Row01, out hv_Col01, out hv_Row02, out hv_Col02);
                    HOperatorSet.GenRectangle1(out ho_Rect, hv_Row01, hv_Col01, hv_Row02, hv_Col02);
                    HOperatorSet.DispObj(ho_Rect, hWindow02);
                    CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                    CRecipeCamera.instance.config.hvDownNewROI_ROW1 = hv_Row01;
                    CRecipeCamera.instance.config.hvDownNewROI_COL1 = hv_Col01;
                    CRecipeCamera.instance.config.hvDownNewROI_ROW2 = hv_Row02;
                    CRecipeCamera.instance.config.hvDownNewROI_COL2 = hv_Col02;
                    CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnLoadProjectModel_Click_1(object sender, EventArgs e)
        {
            if (hWindow != null)
            {
                if (CreateMarkRegion(hWindow))
                {
                    bModelIsOK = true;
                }
                else
                {
                    MessageBox.Show("ERROR:load model fail！");
                }
            }
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            if (UpDown)
            {
                if (!bUpCameraLive && bUpCameraOK)
                {
                    DASK.DO_WritePort((ushort)m_dev, 0, 128u);
                    bUpCameraLive = true;
                    btnLive.BackColor = Color.Gold;
                }
                else//note
                {
                    bUpCameraLive = false;
                    DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                    btnLive.BackColor = Color.Transparent;
                }
            }
            else
            {
                if (!bDWCameraLive)
                {
                    History_message(txtboxHistory, "Up Camera Live");
                    bDWCameraLive = true;
                    btnLive.BackColor = Color.Gold;
                }
                else
                {
                    bDWCameraLive = false;//note
                    btnLive.BackColor = Color.Transparent;
                }
            }
        }

        private void btnSaveImage_Click_1(object sender, EventArgs e)
        {
            if (UpDown)
            {
                if (image == null || !image.IsInitialized())
                {
                    MessageBox.Show("Error save image. Please load/grab image first.");
                    return;
                }
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "BMP Image|*.bmp";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    image.WriteImage("bmp", 0, dlg.FileName);
                }
                catch
                {
                }
            }
            else
            {
                if (imageDown == null || !imageDown.IsInitialized())
                {
                    MessageBox.Show("Error save image. Please load/grab image first.");
                    return;
                }
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "BMP Image|*.bmp";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    imageDown.WriteImage("bmp", 0, dlg.FileName);
                }
                catch
                {
                }
            }
        }
        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (UpDown)
            {
                OpenFileDialog odlg = new OpenFileDialog();
                odlg.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
                if (odlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    image.ReadImage(odlg.FileName);

                    if (image.IsInitialized())
                    {
                        hwindowctl.HalconWindow.ClearWindow();
                        image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                        hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                        hwindowctl.HalconWindow.DispObj(image);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Please load a valid image!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: Failed to load image. Details: {ex.Message}");
                    return;
                }

                if (image != null && image.IsInitialized())
                {
                    if (bModelIsOK)
                    {
                        try
                        {
                            FindMark(image, hwindowctl.HalconWindow);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ERROR: Model processing failed. Details: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Please load model!");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Please load image!");
                }
            }
            else
            {
                OpenFileDialog odlg = new OpenFileDialog();
                odlg.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
                if (odlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    imageDown.ReadImage(odlg.FileName);
                    if (imageDown.IsInitialized())
                    {
                        hwindowctl02.HalconWindow.ClearWindow();
                        imageDown.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                        hwindowctl02.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                        hwindowctl02.HalconWindow.DispObj(imageDown);
                    }
                }
                catch
                {
                }
                if (imageDown == null || !imageDown.IsInitialized() || hWindow02 == null)
                {
                    MessageBox.Show("Please load image！");
                }
                else if (CheckDownMark(imageDown, hWindow02))
                {
                }
            }
            //OpenFileDialog odlg = new OpenFileDialog();
            //odlg.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            //if (odlg.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}
            //try
            //{
            //    image.ReadImage(odlg.FileName);
            //    if (image.IsInitialized())
            //    {
            //        hwindowctl.HalconWindow.ClearWindow();
            //        image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
            //        hwindowctl.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
            //        hwindowctl.HalconWindow.DispObj(image);
            //    }
            //}
            //catch
            //{
            //}


            //if (image != null && image.IsInitialized())
            //{
            //    if (bModelIsOK)
            //    {
            //        FindMark(image, hWindow);
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR:Please load model！");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ERROR:Please load image！");
            //}


            //OpenFileDialog odlg = new OpenFileDialog();
            //odlg.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            //if (odlg.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}
            //try
            //{
            //    imageDown.ReadImage(odlg.FileName);
            //    if (imageDown.IsInitialized())
            //    {
            //        hwindowctl02.HalconWindow.ClearWindow();
            //        imageDown.GetImageSize(out hv_imageWidth, out hv_imageHeight);
            //        hwindowctl02.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
            //        hwindowctl02.HalconWindow.DispObj(imageDown);
            //    }
            //}
            //catch
            //{
            //}
            //if (imageDown == null || !imageDown.IsInitialized() || hWindow02 == null)
            //{
            //    MessageBox.Show("Please load image！");
            //}
            //else if (CheckDownMark(imageDown, hWindow02))
            //{
            //}
        }

        public bool FindMark(HImage checkImage, HTuple hv_WindowID)
        {
            HObject[] OTemp = new HObject[20];
            HObject ho_ALLMarkRegionAffineTrans = null;
            HObject ho_ImageAffinTrans = null;
            HObject ho_WrongPill = null;
            HObject ho_MissingPill = null;
            HObject ho_ImageReduced = null;
            HObject ho_TransContours = null;
            HTuple hv_Width = null;
            HTuple hv_Height = null;
            HTuple hv_FindA_RowLine1 = null;
            HTuple hv_FindA_ColLine1 = null;
            HTuple hv_DownRow = null;
            HTuple hv_DownCol = null;
            HTuple hv_DownPhi = null;
            HTuple hv_DownLength11 = null;
            HTuple hv_DownLength21 = null;
            HTuple hv_i = null;
            HTuple hv_Col = new HTuple();
            HTuple hv_MeasureHandleA = new HTuple();
            HTuple hv_RowEdgeA1 = new HTuple();
            HTuple hv_ColumnEdgeA1 = new HTuple();
            HTuple hv_AmplitudeA1 = new HTuple();
            HTuple hv_DistanceA1 = new HTuple();
            HTuple hv_RowBeginA = null;
            HTuple hv_ColBeginA = null;
            HTuple hv_RowEndA = null;
            HTuple hv_ColEndA = null;
            HTuple hv_Nr1 = null;
            HTuple hv_Nc1 = null;
            HTuple hv_Dist1 = null;
            HTuple hv_FindB_RowLine = null;
            HTuple hv_FindB_ColLine = null;
            HTuple hv_LeftRow = null;
            HTuple hv_LeftCol = null;
            HTuple hv_LeftPhi = null;
            HTuple hv_LeftLength11 = null;
            HTuple hv_LeftLength21 = null;
            HTuple hv_RowB = new HTuple();
            HTuple hv_MeasureHandleB = new HTuple();
            HTuple hv_RowEdgeB = new HTuple();
            HTuple hv_ColumnEdgeB = new HTuple();
            HTuple hv_AmplitudeB = new HTuple();
            HTuple hv_DistanceB = new HTuple();
            HTuple hv_RowBeginB = null;
            HTuple hv_ColBeginB = null;
            HTuple hv_RowEndB = null;
            HTuple hv_ColEndB = null;
            HTuple hv_IsParallel = null;
            HTuple hv_MarkHomMat2D2 = new HTuple();
            HTuple hv_aveScore = new HTuple();
            HTuple hv_TimeJustProcess = new HTuple();
            HTuple hv_Start = new HTuple();
            HTuple hv_PageAngle = new HTuple();
            HTuple hv_PageRow = new HTuple();
            HTuple hv_PageCol = new HTuple();
            HTuple hv_HomMat2D1 = new HTuple();
            HTuple hv_Number = new HTuple();
            HTuple hv_n = new HTuple();
            HTuple hv_Row = new HTuple();
            HTuple hv_Column = new HTuple();
            HTuple hv_Angle = new HTuple();
            HTuple hv_Score = new HTuple();
            HTuple hv_HomMat2D = new HTuple();
            HTuple hv_End = new HTuple();
            HTuple hvOffsetRow = null;
            HTuple hvOffsetCol = null;
            HTuple hvOffsetAngle = null;
            HTuple hvCheckAreaOffset = null;
            HTuple hvCheckArea = null;
            HTuple hvCheckRow = null;
            HTuple hvCheckCol = null;
            HObject hvThreRegion = null;
            HObject ho_Chamber142 = null;
            HTuple hvDealTime = null;
            HOperatorSet.GenEmptyObj(out hvThreRegion);
            HOperatorSet.GenEmptyObj(out var ho_Rectangle);
            HOperatorSet.GenEmptyObj(out var ho_ContourA);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var ho_ContourB);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out var _);
            HOperatorSet.GenEmptyObj(out ho_ALLMarkRegionAffineTrans);
            HOperatorSet.GenEmptyObj(out ho_ImageAffinTrans);
            HOperatorSet.GenEmptyObj(out ho_WrongPill);
            HOperatorSet.GenEmptyObj(out ho_MissingPill);
            HOperatorSet.GenEmptyObj(out ho_ImageReduced);
            HOperatorSet.GenEmptyObj(out ho_TransContours);
            CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
            hv_DownRow = CRecipeCamera.instance.config.iniDownRow;
            hv_DownCol = CRecipeCamera.instance.config.iniDownCol;
            hv_DownPhi = CRecipeCamera.instance.config.iniDownPhi;
            hv_DownLength11 = CRecipeCamera.instance.config.iniDownLength11;
            hv_DownLength21 = CRecipeCamera.instance.config.iniDownLength21;
            hv_LeftRow = CRecipeCamera.instance.config.iniLeftRow;
            hv_LeftCol = CRecipeCamera.instance.config.iniLeftCol;
            hv_LeftPhi = CRecipeCamera.instance.config.iniLeftPhi;
            hv_LeftLength11 = CRecipeCamera.instance.config.iniLeftLength11;
            hv_LeftLength21 = CRecipeCamera.instance.config.iniLeftLength21;
            double dScale = CRecipeCamera.instance.config.iniScale;
            string strUpOffset = "-" + Convert.ToString(CRecipeCamera.instance.config.iniUpOffset);
            HTuple hvUpOffset = Convert.ToDouble(strUpOffset) * dScale;
            HTuple hvDownOffset = Convert.ToDouble(CRecipeCamera.instance.config.iniDownOffset) * dScale;
            string strLeftOffset = "-" + Convert.ToString(CRecipeCamera.instance.config.iniLeftOffset);
            HTuple hvLeftOffset = Convert.ToDouble(strLeftOffset) * dScale;
            HTuple hvRightOffset = Convert.ToDouble(CRecipeCamera.instance.config.iniRightOffset) * dScale;
            HTuple hvAngleOffset1 = Convert.ToDouble(CRecipeCamera.instance.config.iniAngleOffset);
            string strAngleOffset2 = "-" + Convert.ToDouble(CRecipeCamera.instance.config.iniAngleOffset);
            HTuple hvAngleOffset2 = Convert.ToDouble(strAngleOffset2);
            HTuple hvAreaOffset = CRecipeCamera.instance.config.iniAreaOffset;
            HTuple hvMatchValue = Convert.ToDouble(CRecipeCamera.instance.config.iniMatchValue);
            HTuple hvThreshold = CRecipeCamera.instance.config.iniThresholdValue;
            try
            {
                iAllNum++;
                HOperatorSet.CountSeconds(out hv_Start);
                HOperatorSet.GetImageSize(checkImage, out hv_Width, out hv_Height);
                hv_FindA_RowLine1 = new HTuple();
                hv_FindA_ColLine1 = new HTuple();
                hv_i = 0;
                while ((int)hv_i <= 20)
                {
                    hv_Col = hv_DownCol + hv_i * 50;
                    ho_Rectangle.Dispose();
                    HOperatorSet.GenMeasureRectangle2(hv_DownRow, hv_Col, hv_DownPhi, hv_DownLength11, hv_DownLength21, hv_Width, hv_Height, "nearest_neighbor", out hv_MeasureHandleA);
                    HOperatorSet.MeasurePos(checkImage, hv_MeasureHandleA, 1, 40, "positive", "first", out hv_RowEdgeA1, out hv_ColumnEdgeA1, out hv_AmplitudeA1, out hv_DistanceA1);
                    hv_FindA_RowLine1 = hv_FindA_RowLine1.TupleConcat(hv_RowEdgeA1);
                    hv_FindA_ColLine1 = hv_FindA_ColLine1.TupleConcat(hv_ColumnEdgeA1);
                    HOperatorSet.CloseMeasure(hv_MeasureHandleA);
                    hv_i = (int)hv_i + 1;
                }
                ho_ContourA.Dispose();
                HOperatorSet.GenContourPolygonXld(out ho_ContourA, hv_FindA_RowLine1, hv_FindA_ColLine1);
                HOperatorSet.FitLineContourXld(ho_ContourA, "tukey", -1, 0, 5, 1.345, out hv_RowBeginA, out hv_ColBeginA, out hv_RowEndA, out hv_ColEndA, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                hv_FindB_RowLine = new HTuple();
                hv_FindB_ColLine = new HTuple();
                hv_i = 0;
                while ((int)hv_i <= 20)
                {
                    hv_RowB = hv_LeftRow + hv_i * 30;
                    HOperatorSet.GenMeasureRectangle2(hv_RowB, hv_LeftCol, hv_LeftPhi, hv_LeftLength11, hv_LeftLength21, hv_Width, hv_Height, "nearest_neighbor", out hv_MeasureHandleB);
                    HOperatorSet.MeasurePos(checkImage, hv_MeasureHandleB, 1, 40, "positive", "first", out hv_RowEdgeB, out hv_ColumnEdgeB, out hv_AmplitudeB, out hv_DistanceB);
                    hv_FindB_RowLine = hv_FindB_RowLine.TupleConcat(hv_RowEdgeB);
                    hv_FindB_ColLine = hv_FindB_ColLine.TupleConcat(hv_ColumnEdgeB);
                    HOperatorSet.CloseMeasure(hv_MeasureHandleB);
                    hv_i = (int)hv_i + 1;
                }
                ho_ContourB.Dispose();
                HOperatorSet.GenContourPolygonXld(out ho_ContourB, hv_FindB_RowLine, hv_FindB_ColLine);
                HOperatorSet.FitLineContourXld(ho_ContourB, "tukey", -1, 0, 5, 1.345, out hv_RowBeginB, out hv_ColBeginB, out hv_RowEndB, out hv_ColEndB, out hv_Nr1, out hv_Nc1, out hv_Dist1);
                HOperatorSet.AngleLx(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, out hv_PageAngle);
                HOperatorSet.IntersectionLl(hv_RowBeginA, hv_ColBeginA, hv_RowEndA, hv_ColEndA, hv_RowBeginB, hv_ColBeginB, hv_RowEndB, hv_ColEndB, out hv_PageRow, out hv_PageCol, out hv_IsParallel);
                HOperatorSet.VectorAngleToRigid(hv_PageRow, hv_PageCol, hv_PageAngle, hv_ModelPageRow, hv_ModelPageCol, hv_ModelPageAngle, out hv_HomMat2D1);
                ho_ImageAffinTrans.Dispose();
                HOperatorSet.AffineTransImage(checkImage, out ho_ImageAffinTrans, hv_HomMat2D1, "constant", "false");
                HOperatorSet.ClearWindow(hv_WindowID);
                HOperatorSet.DispObj(ho_ImageAffinTrans, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispCross(hv_WindowID, hv_PageRow, hv_PageCol, 100, 0);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.DispCross(hv_WindowID, hv_ModelPageRow, hv_ModelPageCol, 200, hv_ModelPageAngle);
                HOperatorSet.CountObj(ho_Chambers, out hv_Number);
                ho_WrongPill.Dispose();
                HOperatorSet.GenEmptyObj(out ho_WrongPill);
                ho_MissingPill.Dispose();
                HOperatorSet.GenEmptyObj(out ho_MissingPill);
                HTuple end_val198 = hv_Number;
                HTuple step_val198 = 1;
                HTuple ChamberArea = null;
                HTuple ChamberRow = null;
                HTuple ChamberCol = null;
                HOperatorSet.FindShapeModel(ho_ImageAffinTrans, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 62, 0.5, "least_squares", new HTuple(4).TupleConcat(1), 0.75, out hv_Row, out hv_Column, out hv_Angle, out hv_Score);//đổi từ 50 sang 62

                int foundMarks = hv_Score.Length;//note đếm mark 
                for (int i = 0; i < foundMarks; i++)
                {
                    HOperatorSet.SetColor(hv_WindowID, "#FFD700");
                    set_display_font(hv_WindowID, 15, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, hv_Row[i] + 10, hv_Column[i] + 10);
                    HOperatorSet.WriteString(hv_WindowID, (i + 1).ToString());
                } //note đếm mark 
                GetMarkValue(foundMarks.ToString(), hv_Number.ToString());
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.DispObj(ho_Chambers, hv_WindowID);
                HOperatorSet.SetColor(hv_WindowID, "red");
                if (hv_Number > hv_Score.Length)
                {
                    
                    set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.WriteString(hv_WindowID, "less");//note less
                    CImage.instance.SaveBMPImage(image, "less");//note less
                    iMissNum++;
                    HOperatorSet.CountSeconds(out hv_End);
                    hvDealTime = hv_End - hv_Start;
                    strDealTime = hvDealTime[0].D.ToString("0.000");
                    UpdateUI("Less", Color.Red);//note
                    return false;
                }
                if (hv_Number < hv_Score.Length)
                {
                    
                    set_display_font(hv_WindowID, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.WriteString(hv_WindowID, "more");
                    CImage.instance.SaveBMPImage(image, "more");
                    iDoubleNum++;
                    HOperatorSet.CountSeconds(out hv_End);
                    hvDealTime = hv_End - hv_Start;
                    strDealTime = hvDealTime[0].D.ToString("0.000");
                    UpdateUI("More", Color.Orange);//note
                    return false;
                }
                hv_n = 1;
                while (hv_n.Continue(end_val198, step_val198))
                {
                    HOperatorSet.SelectObj(ho_Chambers, out ho_Chamber142, hv_n);
                    HOperatorSet.AreaCenter(ho_Chamber142, out ChamberArea, out ChamberRow, out ChamberCol);
                    ho_ImageReduced.Dispose();
                    HOperatorSet.ReduceDomain(ho_ImageAffinTrans, ho_Chamber142, out ho_ImageReduced);
                    HOperatorSet.FindShapeModel(ho_ImageReduced, hv_MarkModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), hvMatchValue, 1, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out hv_Row, out hv_Column, out hv_Angle, out hv_Score);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispObj(ho_Chamber142, hv_WindowID);
                    HOperatorSet.SetColor(hv_WindowID, "red");
                    HOperatorSet.DispCross(hv_WindowID, hv_Row, hv_Column, 20, hv_Angle);
                    HOperatorSet.SetColor(hv_WindowID, "green");
                    HOperatorSet.DispCross(hv_WindowID, hv_AllMarkRow[hv_n - 1], hv_AllMarkCol[hv_n - 1], 20, hv_Angle);
                    hvOffsetRow = hv_Row - hv_AllMarkRow[hv_n - 1];
                    hvOffsetCol = hv_Column - hv_AllMarkCol[hv_n - 1];
                    hvOffsetAngle = new HTuple(hv_Angle).TupleDeg();
                    string strOffsetRow = hvOffsetRow[0].D.ToString("0.0");
                    string strOffsetCol = hvOffsetCol[0].D.ToString("0.0");
                    string strOffsetAngle = hvOffsetAngle[0].D.ToString("0.0");
                    if (bEnbleShow)
                    {
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        set_display_font(hv_WindowID, 12, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow - 90, ChamberCol);
                        HOperatorSet.WriteString(hv_WindowID, strOffsetRow);
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow - 60, ChamberCol);
                        HOperatorSet.WriteString(hv_WindowID, strOffsetCol);
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow - 30, ChamberCol);
                        HOperatorSet.WriteString(hv_WindowID, strOffsetAngle);
                    }
                    if (hvDownOffset < hvOffsetRow || hvOffsetRow < hvUpOffset)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow, ChamberCol);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(Dislocation)");
                        CImage.instance.SaveBMPImage(image, "dislocation");
                        UpdateUI("Location", Color.Red);
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out hv_End);
                        hvDealTime = hv_End - hv_Start;
                        strDealTime = hvDealTime[0].D.ToString("0.000");
                        return false;
                    }
                    if (hvRightOffset < hvOffsetCol || hvOffsetCol < hvLeftOffset)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow, ChamberCol);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(Dislocation)");
                        CImage.instance.SaveBMPImage(image, "dislocation");
                        UpdateUI("NG", Color.Red);
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out hv_End);
                        hvDealTime = hv_End - hv_Start;
                        strDealTime = hvDealTime[0].D.ToString("0.000");
                        return false;
                    }
                    if (hvAngleOffset1 < hvOffsetAngle || hvOffsetAngle < hvAngleOffset2)
                    {
                        set_display_font(hv_WindowID, 20, "mono", "true", "false");
                        HOperatorSet.SetTposition(hv_WindowID, ChamberRow, ChamberCol);
                        HOperatorSet.SetColor(hv_WindowID, "red");
                        HOperatorSet.WriteString(hv_WindowID, "NG(AngleDislocation)");
                        CImage.instance.SaveBMPImage(image, "dislocation");
                        UpdateUI("Location", Color.Red);
                        iOffsetPosNum++;
                        HOperatorSet.CountSeconds(out hv_End);
                        hvDealTime = hv_End - hv_Start;
                        strDealTime = hvDealTime[0].D.ToString("0.000");
                        return false;
                    }
                    hv_n = hv_n.TupleAdd(step_val198);
                }
                set_display_font(hv_WindowID, 30, "mono", "true", "false");
                HOperatorSet.SetTposition(hv_WindowID, 100, 100);
                HOperatorSet.SetColor(hv_WindowID, "green");
                HOperatorSet.WriteString(hv_WindowID, "OK");
                HOperatorSet.CountSeconds(out hv_End);
                hvDealTime = hv_End - hv_Start;
                strDealTime = hvDealTime[0].D.ToString("0.000");
                 UpdateUI("OK", Color.Green);//note
                return true;
            }
            catch (Exception)
            {
                set_display_font(hv_WindowID, 20, "mono", "true", "false");
                HOperatorSet.SetTposition(hv_WindowID, 50, 50);
                HOperatorSet.SetColor(hv_WindowID, "red");
                HOperatorSet.WriteString(hv_WindowID, "miss");
                CImage.instance.SaveBMPImage(image, "miss");
                iMissNum++;
                UpdateUI("Error", Color.Red);//note
                return false;
            }
        }
        public void show_ModelContour(object sender, EventArgs e)
        {
            HTuple hv_ModelRow1 = CRecipeCamera.instance.config.hv_OrgModelRow1;
            HTuple hv_ModelColumn1 = CRecipeCamera.instance.config.hv_OrgModelColumn1;
            HTuple hv_ModelAngle1 = CRecipeCamera.instance.config.hv_OrgModelAngle1;
            string szPath = Application.StartupPath + "\\MODEL";
            string ModelPath = szPath + "\\Model.shm";
            string ModelPath1 = szPath + "\\Modelcod.dxf";
            if (image == null || !image.IsInitialized())
            {
                MessageBox.Show(" Please load/grab image first!");
                return;
            }
            if (!Directory.Exists(szPath))
            {
                MessageBox.Show(" Please Create Model first!");
                return;
            }
            try
            {
                HOperatorSet.ReadShapeModel(ModelPath, out var hv_NowModel);
                HOperatorSet.ReadContourXldDxf(out var ho_NowModelContour, ModelPath1, new HTuple(), new HTuple(), out var _);
                HOperatorSet.FindShapeModel(image, hv_NowModel, new HTuple(0).TupleRad(), new HTuple(20).TupleRad(), 0.5, 1, 0.5, "least_squares", new HTuple(5).TupleConcat(1), 0.75, out var hv_NowModelRow1, out var hv_NowModelColumn1, out var hv_NowModelAngle1, out var hv_NowModelScore1);
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_NowModelRow1, hv_NowModelColumn1, hv_NowModelAngle1, out var hv_homMat2D2);
                HOperatorSet.AffineTransContourXld(ho_NowModelContour, out var ho_TransModelContour, hv_homMat2D2);
                HOperatorSet.SetColor(hWindow, "red");
                HOperatorSet.DispObj(ho_TransModelContour, hWindow);
                HOperatorSet.SetColor(hWindow, "green");
                HOperatorSet.SetTposition(hWindow, 50, 50);
                HOperatorSet.WriteString(hWindow, "score=" + hv_NowModelScore1);
            }
            catch (Exception)
            {
                MessageBox.Show(" Read Model Fail，Please check Model file!");
                CLogAssistant.instance.log_message("Read Model Fail!", ELogLevel.Error);
            }
        }

        private void ThreadDownCameraRun()
        {
            bool bCheckResult = false;
            bool bGrabStart = false;
            int iSensorOn = 0;
            bDownCameraCheckNG = false;
            while (!bExit)
            {
                if (bIOCarkOK && !bUnEnbleDownCamera)
                {
                    uint int_value;
                    short ret = DASK.DI_ReadPort((ushort)m_dev, 0, out int_value);
                    if (ret < 0)
                    {
                        break;
                    }
                    if (int_value == 1)
                    {
                        iSensorOn = 1;
                        bGrabStart = false;
                    }
                    if (iSensorOn == 1 && int_value == 0)
                    {
                        bGrabStart = true;
                        iSensorOn = 0;
                    }
                    if (bGrabStart)
                    {
                        bGrabStart = false;
                        if (!bUnEnbleDownCamera)
                        {
                            if (ret < 0)
                            {
                                break;
                            }
                            GrapeImageDownDelay();
                            if (!CheckDownMark(imageDown, hWindow02))
                            {
                                bDownCameraCheckNG = true;
                            }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }
        public void GrapeImageDownDelay()
        {
            int downCameraTime = CRecipeCamera.instance.config.iniDownCameraTime;
            try
            {
                Thread.Sleep(downCameraTime);
                imageDown.GrabImage(AcqHandleDown);
                imageDown.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl02.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                hwindowctl02.HalconWindow.DispObj(imageDown);
                CImage.instance.imageDW = imageDown;
            }
            catch (Exception)
            {
                History_message(txtboxHistory, "DownCamera Grab False!!");
            }
        }

        private bool TestCheckMegnet()
        {
            try
            {
                HOperatorSet.CountSeconds(out hv_StartTime);
                if (image == null || !image.IsInitialized())
                {
                    MessageBox.Show(" Please load/grab image first.");
                    History_message(txtboxHistory, "Test False,Please load/grab image first.");
                    return false;
                }
                HTuple hv_Area01;
                bool bCheckReturn01 = MegnetCheck(hWindow, image, CRecipeCamera.instance.config.hvLROI_ROW1, CRecipeCamera.instance.config.hvLROI_COL1, CRecipeCamera.instance.config.hvLROI_ROW2, CRecipeCamera.instance.config.hvLROI_COL2, CRecipeCamera.instance.config.hvLAreaMin, CRecipeCamera.instance.config.hvLAreaMax, out hv_Area01);
                HTuple hv_Area02;
                bool bCheckReturn02 = MegnetCheck(hWindow, image, CRecipeCamera.instance.config.hvRROI_ROW1, CRecipeCamera.instance.config.hvRROI_COL1, CRecipeCamera.instance.config.hvRROI_ROW2, CRecipeCamera.instance.config.hvRROI_COL2, CRecipeCamera.instance.config.hvRAreaMin, CRecipeCamera.instance.config.hvRAreaMax, out hv_Area02);
                HTuple hv_Area03;
                bool bCheckReturn03 = MegnetCheck(hWindow, image, CRecipeCamera.instance.config.hvUpROI_ROW1, CRecipeCamera.instance.config.hvUpROI_COL1, CRecipeCamera.instance.config.hvUpROI_ROW2, CRecipeCamera.instance.config.hvUpROI_COL2, CRecipeCamera.instance.config.hvUpAreaMin, CRecipeCamera.instance.config.hvUpAreaMax, out hv_Area03);
                HTuple hv_Area04;
                bool bCheckReturn04 = MegnetCheck(hWindow, image, CRecipeCamera.instance.config.hvDwROI_ROW1, CRecipeCamera.instance.config.hvDwROI_COL1, CRecipeCamera.instance.config.hvDwROI_ROW2, CRecipeCamera.instance.config.hvDwROI_COL2, CRecipeCamera.instance.config.hvDwAreaMin, CRecipeCamera.instance.config.hvDwAreaMax, out hv_Area04);
                set_display_font(hWindow, 30, "mono", "true", "false");
                HTuple hv_Row01_L = CRecipeCamera.instance.config.hvLROI_ROW1;
                HTuple hv_Col01_L = CRecipeCamera.instance.config.hvLROI_COL1;
                HTuple hv_Row02_L = CRecipeCamera.instance.config.hvLROI_ROW2;
                HTuple hv_Col02_L = CRecipeCamera.instance.config.hvLROI_COL2;
                HOperatorSet.GenRectangle1(out var ho_Rect, hv_Row01_L, hv_Col01_L, hv_Row02_L, hv_Col02_L);
                HOperatorSet.DispObj(ho_Rect, hWindow);
                HOperatorSet.SetTposition(hWindow, 450, 300);
                HOperatorSet.WriteString(hWindow, hv_Area01);
                HTuple hv_Row01_R = CRecipeCamera.instance.config.hvRROI_ROW1;
                HTuple hv_Col01_R = CRecipeCamera.instance.config.hvRROI_COL1;
                HTuple hv_Row02_R = CRecipeCamera.instance.config.hvRROI_ROW2;
                HTuple hv_Col02_R = CRecipeCamera.instance.config.hvRROI_COL2;
                HOperatorSet.GenRectangle1(out var ho_Rect01, hv_Row01_R, hv_Col01_R, hv_Row02_R, hv_Col02_R);
                HOperatorSet.DispObj(ho_Rect01, hWindow);
                HOperatorSet.SetTposition(hWindow, 450, 950);
                HOperatorSet.WriteString(hWindow, hv_Area02);
                HTuple hv_Row01_U = CRecipeCamera.instance.config.hvUpROI_ROW1;
                HTuple hv_Col01_U = CRecipeCamera.instance.config.hvUpROI_COL1;
                HTuple hv_Row02_U = CRecipeCamera.instance.config.hvUpROI_ROW2;
                HTuple hv_Col02_U = CRecipeCamera.instance.config.hvUpROI_COL2;
                HOperatorSet.GenRectangle1(out var ho_Rect02, hv_Row01_U, hv_Col01_U, hv_Row02_U, hv_Col02_U);
                HOperatorSet.DispObj(ho_Rect02, hWindow);
                HOperatorSet.SetTposition(hWindow, 200, 650);
                HOperatorSet.WriteString(hWindow, hv_Area03);
                HTuple hv_Row01_D = CRecipeCamera.instance.config.hvDwROI_ROW1;
                HTuple hv_Col01_D = CRecipeCamera.instance.config.hvDwROI_COL1;
                HTuple hv_Row02_D = CRecipeCamera.instance.config.hvDwROI_ROW2;
                HTuple hv_Col02_D = CRecipeCamera.instance.config.hvDwROI_COL2;
                HOperatorSet.GenRectangle1(out var ho_Rect03, hv_Row01_D, hv_Col01_D, hv_Row02_D, hv_Col02_D);
                HOperatorSet.DispObj(ho_Rect03, hWindow);
                HOperatorSet.SetTposition(hWindow, 750, 650);
                HOperatorSet.WriteString(hWindow, hv_Area04);
                if (chReMagnetNum[4] == '1')
                {
                    set_display_font(hWindow01, 16, "mono", "true", "false");
                    hwindowctl01.HalconWindow.ClearWindow();
                    hwindowctl02.HalconWindow.ClearWindow();
                    hwindowctl03.HalconWindow.ClearWindow();
                    hwindowctl04.HalconWindow.ClearWindow();
                    image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl01.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl01.HalconWindow.DispObj(image);
                    HOperatorSet.DispObj(ho_Rect, hWindow01);
                    HOperatorSet.DispObj(ho_Rect01, hWindow01);
                    HOperatorSet.DispObj(ho_Rect02, hWindow01);
                    HOperatorSet.DispObj(ho_Rect03, hWindow01);
                    HOperatorSet.SetColor(hWindow01, "red");
                    HOperatorSet.SetTposition(hWindow01, 0, 0);
                    HOperatorSet.WriteString(hWindow01, "磁铁1窗口");
                    HOperatorSet.SetTposition(hWindow01, 450, 300);
                    HOperatorSet.WriteString(hWindow01, hv_Area01);
                    HOperatorSet.SetTposition(hWindow01, 450, 950);
                    HOperatorSet.WriteString(hWindow01, hv_Area02);
                    HOperatorSet.SetTposition(hWindow01, 200, 650);
                    HOperatorSet.WriteString(hWindow01, hv_Area03);
                    HOperatorSet.SetTposition(hWindow01, 750, 650);
                    HOperatorSet.WriteString(hWindow01, hv_Area04);
                }
                if (chReMagnetNum[4] == '2')
                {
                    set_display_font(hWindow02, 16, "mono", "true", "false");
                    image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl02.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl02.HalconWindow.DispObj(image);
                    HOperatorSet.DispObj(ho_Rect, hWindow02);
                    HOperatorSet.DispObj(ho_Rect01, hWindow02);
                    HOperatorSet.DispObj(ho_Rect02, hWindow02);
                    HOperatorSet.DispObj(ho_Rect03, hWindow02);
                    HOperatorSet.SetColor(hWindow02, "red");
                    HOperatorSet.SetTposition(hWindow02, 0, 0);
                    HOperatorSet.WriteString(hWindow02, "磁铁2窗口");
                    HOperatorSet.SetTposition(hWindow02, 450, 300);
                    HOperatorSet.WriteString(hWindow02, hv_Area01);
                    HOperatorSet.SetTposition(hWindow02, 450, 950);
                    HOperatorSet.WriteString(hWindow02, hv_Area02);
                    HOperatorSet.SetTposition(hWindow02, 200, 650);
                    HOperatorSet.WriteString(hWindow02, hv_Area03);
                    HOperatorSet.SetTposition(hWindow02, 750, 650);
                    HOperatorSet.WriteString(hWindow02, hv_Area04);
                }
                if (chReMagnetNum[4] == '3')
                {
                    set_display_font(hWindow03, 16, "mono", "true", "false");
                    image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl03.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl03.HalconWindow.DispObj(image);
                    HOperatorSet.DispObj(ho_Rect, hWindow03);
                    HOperatorSet.DispObj(ho_Rect01, hWindow03);
                    HOperatorSet.DispObj(ho_Rect02, hWindow03);
                    HOperatorSet.DispObj(ho_Rect03, hWindow03);
                    HOperatorSet.SetColor(hWindow03, "red");
                    HOperatorSet.SetTposition(hWindow03, 0, 0);
                    HOperatorSet.WriteString(hWindow03, "磁铁3窗口");
                    HOperatorSet.SetTposition(hWindow03, 450, 300);
                    HOperatorSet.WriteString(hWindow03, hv_Area01);
                    HOperatorSet.SetTposition(hWindow03, 450, 950);
                    HOperatorSet.WriteString(hWindow03, hv_Area02);
                    HOperatorSet.SetTposition(hWindow03, 200, 650);
                    HOperatorSet.WriteString(hWindow03, hv_Area03);
                    HOperatorSet.SetTposition(hWindow03, 750, 650);
                    HOperatorSet.WriteString(hWindow03, hv_Area04);
                }
                if (chReMagnetNum[4] == '4')
                {
                    set_display_font(hWindow04, 16, "mono", "true", "false");
                    image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    hwindowctl04.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                    hwindowctl04.HalconWindow.DispObj(image);
                    HOperatorSet.DispObj(ho_Rect, hWindow04);
                    HOperatorSet.DispObj(ho_Rect01, hWindow04);
                    HOperatorSet.DispObj(ho_Rect02, hWindow04);
                    HOperatorSet.DispObj(ho_Rect03, hWindow04);
                    HOperatorSet.SetColor(hWindow04, "red");
                    HOperatorSet.SetTposition(hWindow04, 0, 0);
                    HOperatorSet.WriteString(hWindow04, "磁铁4窗口");
                    HOperatorSet.SetTposition(hWindow04, 450, 300);
                    HOperatorSet.WriteString(hWindow04, hv_Area01);
                    HOperatorSet.SetTposition(hWindow04, 450, 950);
                    HOperatorSet.WriteString(hWindow04, hv_Area02);
                    HOperatorSet.SetTposition(hWindow04, 200, 650);
                    HOperatorSet.WriteString(hWindow04, hv_Area03);
                    HOperatorSet.SetTposition(hWindow04, 750, 650);
                    HOperatorSet.WriteString(hWindow04, hv_Area04);
                }
                double dActiveTime;
                if (bCheckReturn01 && bCheckReturn02 && bCheckReturn03 && bCheckReturn04)
                {
                    set_display_font(hWindow, 32, "mono", "true", "false");
                    HOperatorSet.SetColor(hWindow, "green");
                    HOperatorSet.SetTposition(hWindow, 0, 500);
                    HOperatorSet.WriteString(hWindow, " 磁铁安装OK");
                    if (chReMagnetNum[4] == '1')
                    {
                        set_display_font(hWindow01, 20, "mono", "true", "false");
                        HOperatorSet.SetColor(hWindow01, "green");
                        HOperatorSet.SetTposition(hWindow01, 0, 650);
                        HOperatorSet.WriteString(hWindow01, " 磁铁1安装OK");
                        History_message(txtboxHistory, "磁铁1安装OK!");
                    }
                    if (chReMagnetNum[4] == '2')
                    {
                        set_display_font(hWindow02, 20, "mono", "true", "false");
                        HOperatorSet.SetColor(hWindow02, "green");
                        HOperatorSet.SetTposition(hWindow02, 0, 650);
                        HOperatorSet.WriteString(hWindow02, " 磁铁2安装OK");
                        History_message(txtboxHistory, "磁铁2安装OK!");
                    }
                    if (chReMagnetNum[4] == '3')
                    {
                        set_display_font(hWindow03, 20, "mono", "true", "false");
                        HOperatorSet.SetColor(hWindow03, "green");
                        HOperatorSet.SetTposition(hWindow03, 0, 650);
                        HOperatorSet.WriteString(hWindow03, " 磁铁3安装OK");
                        History_message(txtboxHistory, "磁铁3安装OK!");
                    }
                    if (chReMagnetNum[4] == '4')
                    {
                        set_display_font(hWindow04, 20, "mono", "true", "false");
                        HOperatorSet.SetColor(hWindow04, "green");
                        HOperatorSet.SetTposition(hWindow04, 0, 650);
                        HOperatorSet.WriteString(hWindow04, " 磁铁4安装OK");
                        History_message(txtboxHistory, "磁铁4安装OK!");
                    }
                    HOperatorSet.CountSeconds(out hv_EndTime);
                    dActiveTime = hv_EndTime - hv_StartTime;
                    return true;
                }
                set_display_font(hWindow, 32, "mono", "true", "false");
                HOperatorSet.SetColor(hWindow, "red");
                HOperatorSet.SetTposition(hWindow, 0, 500);
                HOperatorSet.WriteString(hWindow, " 磁铁安装NG");
                if (chReMagnetNum[4] == '1')
                {
                    set_display_font(hWindow01, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hWindow01, 0, 650);
                    HOperatorSet.WriteString(hWindow01, " 磁铁1安装NG");
                    History_message(txtboxHistory, "磁铁1安装NG!");
                }
                if (chReMagnetNum[4] == '2')
                {
                    set_display_font(hWindow02, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hWindow02, 0, 650);
                    HOperatorSet.WriteString(hWindow02, " 磁铁2安装NG");
                    History_message(txtboxHistory, "磁铁2安装NG!");
                }
                if (chReMagnetNum[4] == '3')
                {
                    set_display_font(hWindow03, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hWindow03, 0, 650);
                    HOperatorSet.WriteString(hWindow03, " 磁铁3安装NG");
                    History_message(txtboxHistory, "磁铁3安装NG!");
                }
                if (chReMagnetNum[4] == '4')
                {
                    set_display_font(hWindow04, 20, "mono", "true", "false");
                    HOperatorSet.SetTposition(hWindow04, 0, 650);
                    HOperatorSet.WriteString(hWindow04, " 磁铁4安装NG");
                    History_message(txtboxHistory, "磁铁4安装NG!");
                }
                CImage.instance.SaveBMPImage(image, "Megnet_NGImage");
                History_message(txtboxHistory, "Save Megnet_NGImage OK!!");
                HOperatorSet.CountSeconds(out hv_EndTime);
                dActiveTime = hv_EndTime - hv_StartTime;
                return false;
            }
            catch (Exception)
            {
                History_message(txtboxHistory, "Test False!!");
                return false;
            }
        }
        public bool MegnetCheck(HTuple hvWindow, HObject ho_Image, double dROIRow01, double dROICol01, double dROIRow02, double dROICol02, double dAreaMin, double dAeraMax, out HTuple hv_Area1)
        {
            HOperatorSet.SetColor(hvWindow, "green");
            HOperatorSet.DispObj(ho_Image, hvWindow);
            HOperatorSet.GenRectangle1(out var ho_Rectangle, dROIRow01, dROICol01, dROIRow02, dROICol02);
            HOperatorSet.DispObj(ho_Rectangle, hvWindow);
            HOperatorSet.ReduceDomain(ho_Image, ho_Rectangle, out var ho_ReduceRegion);
            HOperatorSet.Threshold(ho_ReduceRegion, out var ho_Threshold, CRecipeCamera.instance.config.Threshold, 255);
            HOperatorSet.AreaCenter(ho_Threshold, out var hv_Area, out var _, out var _);
            hv_Area1 = hv_Area;
            if (hv_Area[0].D > dAreaMin && hv_Area[0].D < dAeraMax)
            {
                return true;
            }
            return false;
        }
        public bool CheckDownMark(HImage hoDownCheckImage, HTuple hvDownWindowID)
        {
            HTuple hv_ModelRow1 = CRecipeCamera.instance.config.hv_OrgModelRow1;
            HTuple hv_ModelColumn1 = CRecipeCamera.instance.config.hv_OrgModelColumn1;
            HTuple hv_ModelAngle1 = CRecipeCamera.instance.config.hv_OrgModelAngle1;
            string strDownPath = Application.StartupPath + "\\Project\\DownCameraModel\\" + txtProjectNo.Text;
            string DownModelPath = strDownPath + "\\Model.shm";
            try
            {
                HOperatorSet.ReadShapeModel(DownModelPath, out hvDownModelID);
                hv_Row01 = CRecipeCamera.instance.config.hvDownNewROI_ROW1;
                hv_Col01 = CRecipeCamera.instance.config.hvDownNewROI_COL1;
                hv_Row02 = CRecipeCamera.instance.config.hvDownNewROI_ROW2;
                hv_Col02 = CRecipeCamera.instance.config.hvDownNewROI_COL2;
                HTuple hv_Row1_1 = CRecipeCamera.instance.config.hvDownNewROI_ROW1_1;
                HTuple hv_Col1_1 = CRecipeCamera.instance.config.hvDownNewROI_COL1_1;
                HTuple hv_Row1_2 = CRecipeCamera.instance.config.hvDownNewROI_ROW2_2;
                HTuple hv_Col1_2 = CRecipeCamera.instance.config.hvDownNewROI_COL2_2;
                HOperatorSet.DispObj(hoDownCheckImage, hvDownWindowID);
                HOperatorSet.SetColor(hvDownWindowID, "green");
                HOperatorSet.GenRectangle1(out var ho_Rect, hv_Row01, hv_Col01, hv_Row02, hv_Col02);
                HOperatorSet.DispObj(ho_Rect, hvDownWindowID);
                HOperatorSet.ReduceDomain(hoDownCheckImage, ho_Rect, out var ho_ReduceRegion);
                HOperatorSet.FindShapeModel(ho_ReduceRegion, hvDownModelID, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), 0.3, 1, 0.5, "least_squares", new HTuple(3).TupleConcat(1), 0.75, out var _, out var _, out var _, out var hv_NowModelScore1);
                set_display_font(hvDownWindowID, 25, "mono", "true", "false");
                HTuple str = null;
                if (hv_NowModelScore1.Length == 0)
                {
                    str = "NG！";
                    HOperatorSet.SetColor(hvDownWindowID, "red");
                    HOperatorSet.SetTposition(hvDownWindowID, 50, 50);
                    HOperatorSet.WriteString(hvDownWindowID, str);
                    CImage.instance.SaveBMPImage(hoDownCheckImage, "DownMarkNG");
                    iDownCameraNgNum++;
                    return false;
                }
                str = "OK_Score=" + hv_NowModelScore1;
                HOperatorSet.SetTposition(hvDownWindowID, 50, 50);
                HOperatorSet.WriteString(hvDownWindowID, str);
                return true;
            }
            catch (Exception)
            {
                set_display_font(hvDownWindowID, 25, "mono", "true", "false");
                HOperatorSet.SetTposition(hvDownWindowID, 100, 100);
                HOperatorSet.SetColor(hvDownWindowID, "red");
                HOperatorSet.WriteString(hvDownWindowID, "NG");
                CImage.instance.SaveBMPImage(hoDownCheckImage, "DownMarkNG");
                CLogAssistant.instance.log_message("NG!", ELogLevel.Error);
                iDownCameraNgNum++;
                return false;
            }
        }

        private void ThreadUpCameraRun()
        {
            bool bCheckResult = false;
            bool bGrabStart = false;
            int iSensorOn = 0;
            bMarkCheckStart = false;
            bUpCameraCheckNG = false;
            while (!bExit)
            {
                if (bIOCarkOK)
                {
                    short ret = DASK.DI_ReadPort((ushort)m_dev, 0, out var int_value);
                    if (ret < 0)
                    {
                        break;
                    }
                    if (int_value == 1)
                    {
                        iSensorOn = 1;
                        bGrabStart = false;
                    }
                    if (iSensorOn == 1 && int_value == 0)
                    {
                        bGrabStart = true;
                        iSensorOn = 0;
                    }
                    if (bGrabStart)
                    {
                        bMarkCheckStart = true;
                        bGrabStart = false;
                        ret = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                        if (!bUnEnbleUpCamera)
                        {
                            ret = DASK.DO_WritePort((ushort)m_dev, 0, 128u);
                            if (ret < 0)
                            {
                                break;
                            }
                            GrapeImageDelay();
                            ret = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                            if (!FindMark(image, hWindow))
                            {
                                bUpCameraCheckNG = true;
                                ret = DASK.DO_WritePort((ushort)m_dev, 0, 256u);
                            }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }
        private void BtnRun_Click(object sender, EventArgs e)
        {

            //if (!bUpCameraOK)
            //{
            //    MessageBox.Show("EEROR:Camera is closed !");
            //}
            //else if (hv_MarkModelID == null)
            //{
            //    MessageBox.Show("EEROR:Please load model !");
            //}
            //else if (!m_bRunFlg)
            //{
            //    m_bRunFlg = true;
            //    set_to_stop_status();
            //    upCameraAutoThread = new Thread(ThreadUpCameraRun);
            //    upCameraAutoThread.Start();
            //    BtnRun.Text = "Stop";
            //    BtnRun.BackColor = Color.Red;
            //    BtnRun.ForeColor = Color.White;
            //}
            //if (m_bRunFlg)
            //{
            //    bMarkCheckStart = false;
            //    m_bRunFlg = false;
            //    set_to_run_status();
            //    if (upCameraAutoThread != null)
            //    {
            //        upCameraAutoThread.Abort();
            //    }
            //    if (downCameraAutoThread != null)
            //    {
            //        downCameraAutoThread.Abort();
            //    }
            //    if (scanIOCardThread != null)
            //    {
            //        scanIOCardThread.Abort();
            //    }
            //    BtnRun.Text = "Run";
            //    BtnRun.BackColor = Color.Green;
            //    BtnRun.ForeColor = Color.White;
            //}
            if (!bUpCameraOK)
            {
                MessageBox.Show("ERROR: Camera is closed!");
            }
            else if (hv_MarkModelID == null)
            {
                MessageBox.Show("ERROR: Please load model!");
            }
            else
            {
                m_bRunFlg = !m_bRunFlg;

                if (m_bRunFlg)
                {
                    set_to_stop_status();
                    upCameraAutoThread = new Thread(ThreadUpCameraRun);
                    upCameraAutoThread.Start();
                    pControl.Enabled = false;
                    pButton1.Enabled = false;
                    pButton2.Enabled = false;
                    pButton3.Enabled = false;
                    BtnRun.Text = "Stop";
                    BtnRun.BackColor = Color.Red;
                    BtnRun.ForeColor = Color.White;
                    lbNT.Text = "Run Mode";
                }
                else
                {
                    bMarkCheckStart = false;
                    set_to_run_status();
                    if (upCameraAutoThread != null)
                    {
                        upCameraAutoThread.Abort();
                    }
                    if (downCameraAutoThread != null)
                    {
                        downCameraAutoThread.Abort();
                    }
                    if (scanIOCardThread != null)
                    {
                        scanIOCardThread.Abort();
                    }
                    pControl.Enabled = true;
                    BtnRun.Text = "Run";
                    BtnRun.BackColor = Color.Green;
                    BtnRun.ForeColor = Color.White;
                    pButton1.Enabled = true;
                    pButton2.Enabled = true;
                    pButton3.Enabled = true;
                    lbNT.Text = "Manual Mode";
                }
            }

        }
        private void set_to_run_status()//note
        {
            CLogAssistant.instance.log_message("Set to RUN mode", ELogLevel.Event);
            History_message(txtboxHistory, "RUNNINTG");
            //btnFolder.Enabled = true;
            //btnTrig.Enabled = true;
            //btnLive.Enabled = true;
            //btnSaveImage.Enabled = true;
            //btnCloseImage.Enabled = true;
            ////btnOpenImageDown.Enabled = true;
            ////btnSaveImageDown.Enabled = true;
            ////btnLiveDown.Enabled = true;
            ////btnCloseLiveDown.Enabled = true;
            ////btnGrabDown.Enabled = true;
            ////btnTestDown.Enabled = true;
            //btnSetModelPagePOS.Enabled = true;
            //btnCreateMarkModel.Enabled = true;
            //btnCreatModelDN.Enabled = true;
            //btnDrawRecDN.Enabled = true;
        }
        private void set_to_stop_status()
        {
            CLogAssistant.instance.log_message("Set to STOP mode", ELogLevel.Event);
            History_message(txtboxHistory, "STOP");
            //btnFolder.Enabled = false;
            //btnTrig.Enabled = false;
            //btnLive.Enabled = false;
            //btnSaveImage.Enabled = false;
            //btnCloseImage.Enabled = false;
            ////btnOpenImageDown.Enabled = false;
            ////btnSaveImageDown.Enabled = false;
            ////btnLiveDown.Enabled = false;
            ////btnCloseLiveDown.Enabled = false;
            ////btnGrabDown.Enabled = false;
            ////btnTestDown.Enabled = false;
            //btnSetModelPagePOS.Enabled = false;
            //btnCreateMarkModel.Enabled = false;
            //btnCreatModelDN.Enabled = false;
            //btnDrawRecDN.Enabled = false;
        }
        public bool CreateModelDN(HTuple hv_Window1, HObject ho_Image1)
        {
            string szPath = Application.StartupPath + "\\Project\\DownCameraModel\\" + txtProjectNo.Text;
            string ModelPath = szPath + "\\Model.shm";
            string ModelPath1 = szPath + "\\Modelcod.dxf";
            if (!Directory.Exists(szPath))
            {
                Directory.CreateDirectory(szPath);
            }
            try
            {
                MessageBox.Show("Pleas draw model region");
                HOperatorSet.DrawRectangle1(hv_Window1, out var hv_Row1_1, out var hv_Col1_1, out var hv_Row1_2, out var hv_Col1_2);
                HOperatorSet.GenRectangle1(out var ho_Rect1, hv_Row1_1, hv_Col1_1, hv_Row1_2, hv_Col1_2);
                HOperatorSet.DispObj(ho_Rect1, hv_Window1);
                HOperatorSet.ReduceDomain(ho_Image1, ho_Rect1, out var ho_ImageReduce1);
                HOperatorSet.CreateShapeModel(ho_ImageReduce1, 6, new HTuple(-45).TupleRad(), new HTuple(90).TupleRad(), new HTuple(0.4).TupleRad(), "auto", "use_polarity", "auto", "auto", out var hv_ModelId1);
                HOperatorSet.GetShapeModelContours(out var ho_ModelContours1, hv_ModelId1, 1);
                HOperatorSet.DispObj(ho_ModelContours1, hv_Window1);
                HOperatorSet.FindShapeModel(ho_Image1, hv_ModelId1, new HTuple(-30).TupleRad(), new HTuple(60).TupleRad(), 0.5, 1, 0.5, "least_squares", new HTuple(3).TupleConcat(1), 0.75, out var hv_ModelRow1, out var hv_ModelColumn1, out var hv_ModelAngle1, out var _);
                CRecipeCamera.instance.config.hv_OrgModelRow1 = hv_ModelRow1;
                CRecipeCamera.instance.config.hv_OrgModelColumn1 = hv_ModelColumn1;
                CRecipeCamera.instance.config.hv_OrgModelAngle1 = hv_ModelAngle1;
                HOperatorSet.WriteContourXldDxf(ho_ModelContours1, ModelPath1);
                HOperatorSet.WriteShapeModel(hv_ModelId1, ModelPath);
                HOperatorSet.ClearShapeModel(hv_ModelId1);
                CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                CRecipeCamera.instance.config.hvDownNewROI_ROW1_1 = hv_Row1_1;
                CRecipeCamera.instance.config.hvDownNewROI_COL1_1 = hv_Col1_1;
                CRecipeCamera.instance.config.hvDownNewROI_ROW2_2 = hv_Row1_2;
                CRecipeCamera.instance.config.hvDownNewROI_COL2_2 = hv_Col1_2;
                CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                MessageBox.Show("Create Model Finish！");
            }
            catch (Exception)
            {
                MessageBox.Show("Create Model Fail！");
                CLogAssistant.instance.log_message("Create Model Fail!", ELogLevel.Error);
            }
            return true;
        }
        private void ThreadScanIOCard()
        {
            while (!bExit && m_bRunFlg)
            {
                int nDelaySendTime = CRecipeCamera.instance.config.iniDelaySendTime;
                if (bMarkCheckStart)
                {
                    Thread.Sleep(nDelaySendTime);
                    if (bUpCameraCheckNG || bDownCameraCheckNG)
                    {
                        short ret = DASK.DO_WritePort((ushort)m_dev, 0, 256u);
                        bUpCameraCheckNG = false;
                        bDownCameraCheckNG = false;
                    }
                    bMarkCheckStart = false;
                }
                Thread.Sleep(10);
            }
        }
        private void btnDrawRecDN_Click(object sender, EventArgs e)
        {
            if (imageDown == null || !imageDown.IsInitialized())
            {
                MessageBox.Show("Error set ROI. Please load/grab image first.");
                return;
            }
            try
            {
                HOperatorSet.SetColor(hWindow02, "red");
                HOperatorSet.DrawRectangle1(hWindow02, out hv_Row01, out hv_Col01, out hv_Row02, out hv_Col02);
                HOperatorSet.GenRectangle1(out ho_Rect, hv_Row01, hv_Col01, hv_Row02, hv_Col02);
                HOperatorSet.DispObj(ho_Rect, hWindow02);
                CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                CRecipeCamera.instance.config.hvDownNewROI_ROW1 = hv_Row01;
                CRecipeCamera.instance.config.hvDownNewROI_COL1 = hv_Col01;
                CRecipeCamera.instance.config.hvDownNewROI_ROW2 = hv_Row02;
                CRecipeCamera.instance.config.hvDownNewROI_COL2 = hv_Col02;
                CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
            }
            catch (Exception)
            {
            }
        }
        private void btnCreatModelDN_Click(object sender, EventArgs e)
        {
            if (imageDown == null || !imageDown.IsInitialized())
            {
                MessageBox.Show(" Please load/grab image first.");
            }
            else
            {
                CreateModelDN(hWindow02, imageDown);
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)//note
        {
            try
            {
                //_instance = this;
                ////CheckSofewareSecurity();
                //view.Controls.Add(hwindowctl);//note add
                //G.Setting.chkboxUnEnbleDownCamera.Checked = true;
                //hwindowctl.Dock = DockStyle.Fill;
                //hwindowctl.HalconWindow.SetDraw("margin");
                //hwindowctl.HalconWindow.SetLineWidth(1);
                //hwindowctl.HalconWindow.SetColor("green");
                //hWindow = hwindowctl.HalconWindow;

                //view.Controls.Add(hwindowctl02);//note add down
                //hwindowctl02.Dock = DockStyle.Fill;
                //hwindowctl02.HalconWindow.SetDraw("margin");
                //hwindowctl02.HalconWindow.SetColor("green");
                //hWindow02 = hwindowctl02.HalconWindow;
                // Thêm cả hai HWindowControl vào panel view trong quá trình khởi tạo
                _instance = this;

                view.Controls.Add(hwindowctl); 
                hwindowctl.Dock = DockStyle.Fill;
                hwindowctl.HalconWindow.SetDraw("margin");
                hwindowctl.HalconWindow.SetLineWidth(1);
                hwindowctl.HalconWindow.SetColor("green");
                hWindow = hwindowctl.HalconWindow;

                view.Controls.Add(hwindowctl02); 
                hwindowctl02.Dock = DockStyle.Fill;
                hwindowctl02.HalconWindow.SetDraw("margin");
                hwindowctl02.HalconWindow.SetColor("green");
                hWindow02 = hwindowctl02.HalconWindow;
                hwindowctl02.Visible = false;

            }
            catch
            {
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            G.Setting.ShowDialog();
        }
        private string strCurrentProjectNo = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                strCurrentProjectNo = txtProjectNo.Text;
                txtMissNum.Text = Convert.ToString(iMissNum);
                txtOKNum.Text = Convert.ToString(iAllNum);
                txtOffsetPosNum.Text = Convert.ToString(iOffsetPosNum);
                txtDoubleNum.Text = Convert.ToString(iDoubleNum);
                txtDealWithTime.Text = strDealTime;
                iUpCameraDelayGrabTime = Convert.ToInt32(G.Setting.txtUpCameraTime.Text.Trim());
                double dyield0 = 0.0;
                double dyield1 = 0.0;
                double dReject = 0.0;
                if (iAllNum > 0)
                {
                    dyield0 = Convert.ToDouble(iAllNum - iDoubleNum - iMissNum - iOffsetPosNum);
                    dyield1 = Convert.ToDouble(iAllNum);
                    dReject = Convert.ToDouble(iDoubleNum + iMissNum + iOffsetPosNum);
                    double str1 = dyield0 / dyield1 * 100.0;
                    double str2 = dReject / dyield1 * 100.0;
                    txtyield.Text = Convert.ToString(Math.Round(str1, 2));
                    txtReject.Text = Convert.ToString(Math.Round(str2, 2));
                }
                DeleteNGImage();
            }
            catch
            {
            }
        }
        private void DeleteNGImage()
        {
            int nNowMonth = DateTime.Now.Month;
            int nNowDay = DateTime.Now.Day;
            int nCurrentSaveDay = 0;
            if (nNowMonth >= nStartSaveMonth && nNowDay >= nStartSaveDay)
            {
                nCurrentSaveDay = (nNowMonth - nStartSaveMonth) * 30 + (nNowDay - nStartSaveDay);
            }
            if (nNowMonth >= nStartSaveMonth && nNowDay < nStartSaveDay)
            {
                nCurrentSaveDay = (nNowMonth - nStartSaveMonth) * 30 - (nStartSaveDay - nNowDay);
            }
            G.Setting.txtCurrentSaveDay.Text = nCurrentSaveDay.ToString();
            try
            {
                if (nCurrentSaveDay >= nSaveNGimageDay && !m_bRunFlg)
                {
                    CImage.instance.DeleteDir("miss");
                    CImage.instance.DeleteDir("more");
                    CImage.instance.DeleteDir("double");
                    CImage.instance.DeleteDir("dislocation");
                    nStartSaveMonth = DateTime.Now.Month;
                    nStartSaveDay = DateTime.Now.Day;
                    CRecipeCamera.instance.LoadConfig("SystemConfig.xml");
                    CRecipeCamera.instance.config.iniStartSaveMonth = DateTime.Now.Month;
                    CRecipeCamera.instance.config.iniStartSaveDay = DateTime.Now.Day;
                    CRecipeCamera.instance.SaveConfig("SystemConfig.xml");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("mainform:timer_tick:" + ex.Message);
            }
        }

        private void btnTrig_Click(object sender, EventArgs e)
        {
            if (UpDown)
            {
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
                    GrapeImage1();
                    HOperatorSet.CountSeconds(out hv_EndTime);
                    ret = DASK.DO_WritePort((ushort)m_dev, 0, 0u);
                    HTuple hv_ActTime = hv_EndTime - hv_StartTime;
                    double fActiveTime = hv_ActTime;
                    txtGrapImageTime.Text = Convert.ToString(fActiveTime);
                }
                SetCtrlWhenStartGrab();
            }
            else
            {

                if (bDWCameraLive)
                {
                    bDWCameraLive = false;
                    return;
                }
                HOperatorSet.CountSeconds(out hv_StartTime);
                GrapeImageDown();
                HOperatorSet.CountSeconds(out hv_EndTime);
                HTuple hv_ActTime = hv_EndTime - hv_StartTime;
                double fActiveTime = hv_ActTime;
                txtGrapImageTime.Text = Convert.ToString(fActiveTime);
            }
        }
        
        private void SetCtrlWhenStartGrab()
        {
        }
        

        private void btnUp_Click(object sender, EventArgs e)
        {
            UpDown = !UpDown;
            if (UpDown)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = true;
                btnSetModelPagePOS.Text = "SetPosition";
                btnCreateMarkModel.Text = "SetMark";
                btnSelectZoomRegion.Visible = true;
                btnResetImage.Visible = true;
                btnUp.BackColor = Color.Transparent;
                btnDown.BackColor = Color.FromArgb(224, 224, 224);
                hwindowctl.Visible = true;  
                hwindowctl02.Visible = false;  
            }
            
        }
        public void GrapeImageDown()
        {
            try
            {
                HOperatorSet.CountSeconds(out hv_StartTime);
                imageDown.GrabImage(AcqHandleDown);
                imageDown.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                hwindowctl02.HalconWindow.SetPart(0, 0, hv_imageHeight - 1, hv_imageWidth - 1);
                hwindowctl02.HalconWindow.DispObj(imageDown);
                HOperatorSet.SetTposition(hWindow02, 10, 10);
                HOperatorSet.WriteString(hWindow02, "DownCamera");
                CImage.instance.imageDW = imageDown;
                History_message(txtboxHistory, "DownCamera triggered, got image.");
                HOperatorSet.CountSeconds(out hv_EndTime);
                HTuple hv_ActTime = hv_EndTime - hv_StartTime;
                double fActiveTime = hv_ActTime;
                HOperatorSet.SetTposition(hWindow02, 30, 30);
                HOperatorSet.WriteString(hWindow02, fActiveTime);
            }
            catch (Exception)
            {
                History_message(txtboxHistory, "DownCamera Grab False!!");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            UpDown = !UpDown;
            if (!UpDown)
            {
                btnUp.Enabled = true;
                btnDown.Enabled = false;
                btnSetModelPagePOS.Text = "DrawRegion";
                btnCreateMarkModel.Text = "ModelCreate";
                btnSelectZoomRegion.Visible = false;
                btnResetImage.Visible = false;
                btnUp.BackColor = Color.FromArgb(224, 224, 224);
                btnDown.BackColor = Color.Transparent;
                hwindowctl.Visible = false;
                hwindowctl02.Visible = true;
            }
            
        }
        private delegate void UpdateUIHandler(string message, Color color);

        private void UpdateUI(string message, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateUIHandler(UpdateUI), message, color);
            }
            else
            {
                lbNoti.Text = message;
                lbNoti.ForeColor = Color.White;
                lbNoti.BackColor = color;
            }
        }
        private delegate void GetMarkValueHanler(string valueF, string valueH );

        private void GetMarkValue(string valueF,string valueH)
        {
            if (InvokeRequired)
            {
                Invoke(new GetMarkValueHanler(GetMarkValue), valueF, valueH);
            }
            else
            {
                lbOK.Text = valueF;
                lbNG.Text = (Convert.ToInt16(valueH)  - Convert.ToInt16(valueF)).ToString(); 

            }
        }
        public bool Lang = true;
        private void btnLang_Click(object sender, EventArgs e)
        {
            Lang = !Lang;
            if (Lang)
            {
                lbPN.Text = "Project";
                btnFolder.Text = "Test";
                btnSaveImage.Text = "SaveImage";
                btnLive.Text = "Live";
                btnTrig.Text = "Trigger";
                btnLang.Text = "ENG";
                btnADM.Text = "Admin";
                btnHelp.Text = "Help";
                btnSet.Text = "Setting";
                label3.Text = "TrainModel";
                btnUp.Text = "UpCamera";
                btnDown.Text = "DownCamera";
                if (UpDown)
                {
                    btnSetModelPagePOS.Text = "SetPosition";
                    btnCreateMarkModel.Text = "SetMark";
                }
                else
                {
                    btnSetModelPagePOS.Text = "DrawRegion";
                    btnCreateMarkModel.Text = "ModelCreate";
                }
                btnSelectZoomRegion.Text = "SelectZoomRegion";
                btnResetImage.Text = "ResetImage";
                label32.Text = "OK_Rate:";
                label31.Text = "NG_Rate:";
                label15.Text = "Miss/pcs:";
                label13.Text = "Total/pcs:";
                label36.Text = "Disslocation/pcs:";
                label35.Text = "Double/pcs:";
                lbCycleTime.Text = "GrabTimeDelay/s";
                toolStripStatusLabel1.Text = "Delaytime/s";
                G.Setting.tabPage1.Text = "UpCameraParameter";
                G.Setting.label12.Text = "GrabDelay:";
                G.Setting.label14.Text = "Exposure:";
                G.Setting.label7.Text = "Gain:";
                G.Setting.label21.Text = "Send Delay:";
                G.Setting.label20.Text = "Upper:";
                G.Setting.label6.Text = "Up Camera Parameter";
                G.Setting.label9.Text = "Left:";
                G.Setting.label14.Text = "Down:";
                G.Setting.label16.Text = "Right:";
                G.Setting.label11.Text = "Angle:";
                G.Setting.label18.Text = "Score:";
                G.Setting.label23.Text = "Binary:";
                G.Setting.label22.Text = "Scale:";
                G.Setting.label28.Text = "DownCameraParameter";
                G.Setting.tabPage2.Text = "DownCameraParameter";
                G.Setting.label27.Text = "CameraDelay/ms:";
                G.Setting.label26.Text = "ExposureTime/us:";
                G.Setting.tabPage3.Text = "Production";
                G.Setting.label30.Text = "NGSaveDay:";
                G.Setting.label29.Text = "CurrentSaveDay:";
                G.Setting.chkboxUnEnbleDownCamera.Text = "DisableDownCamera";
                G.Setting.chkboxUnEnbleUpCamera.Text = "DisableUpCamera";
            }
            else
            {
                lbPN.Text = "Dự án";
                btnFolder.Text = "Kiểm tra";
                btnSaveImage.Text = "Lưu Ảnh";
                btnLive.Text = "Trực tiếp";
                btnTrig.Text = "Kích hoạt";
                btnLang.Text = "VI";
                btnADM.Text = "Quản trị";
                btnHelp.Text = "Trợ giúp";
                btnSet.Text = "Cài đặt";
                label3.Text = "Huấn luyện";
                btnUp.Text = "Camera Trên";
                btnDown.Text = "Camera Dưới";

                if (UpDown)
                {
                    btnSetModelPagePOS.Text = "Thiết Lập Vị Trí";
                    btnCreateMarkModel.Text = "Đánh Dấu";
                }
                else
                {
                    btnSetModelPagePOS.Text = "Vẽ Khu Vực";
                    btnCreateMarkModel.Text = "Tạo Mô Hình";
                }

                btnSelectZoomRegion.Text = "Chọn Vùng Phóng To";
                btnResetImage.Text = "Đặt Lại Ảnh";
                label32.Text = "Tỷ lệ OK:";
                label31.Text = "Tỷ lệ NG:";
                label15.Text = "Lỗi/pcs:";
                label13.Text = "Tổng/pcs:";
                label36.Text = "Lệch/pcs:";
                label35.Text = "Trùng/pcs:";
                lbCycleTime.Text = "Độ trễ Bắt ảnh/s";
                toolStripStatusLabel1.Text = "Thời gian trễ/s";

                G.Setting.tabPage1.Text = "Tham số Camera Trên";
                G.Setting.label12.Text = "Trễ Bắt:";
                G.Setting.label14.Text = "Phơi sáng:";
                G.Setting.label7.Text = "Độ lợi:";
                G.Setting.label21.Text = "Trễ Gửi:";
                G.Setting.label20.Text = "Trên:";
                G.Setting.label6.Text = "Tham số Camera Trên";
                G.Setting.label9.Text = "Trái:";
                G.Setting.label14.Text = "Dưới:";
                G.Setting.label16.Text = "Phải:";
                G.Setting.label11.Text = "Góc:";
                G.Setting.label18.Text = "Điểm số:";
                G.Setting.label23.Text = "Nhị phân:";
                G.Setting.label22.Text = "Tỷ lệ:";
                G.Setting.label28.Text = "Tham số Camera Dưới";
                G.Setting.tabPage2.Text = "Tham số Camera Dưới";
                G.Setting.label27.Text = "Trễ Camera/ms:";
                G.Setting.label26.Text = "Thời gian phơi/us:";
                G.Setting.tabPage3.Text = "Sản xuất";
                G.Setting.label30.Text = "Ngày Lưu NG:";
                G.Setting.label29.Text = "Ngày Lưu Hiện tại:";
                G.Setting.chkboxUnEnbleDownCamera.Text = "Vô hiệu Camera Dưới";
                G.Setting.chkboxUnEnbleUpCamera.Text = "Vô hiệu Camera Trên";
            }
        }
        public void BlockNGCon()
        {
            if (bUpCameraOK && bIOCarkOK)
            {
            }
            else
            {
                pControl.Visible=false;
                panel12.Enabled= false;
                pButton1.Visible=false;
                pButton2.Visible=false;
                pButton3.Visible=false;
                panel20.Visible= false;
                if (!bUpCameraOK)
                {
                    MessageBox.Show("Please Check Connect Camera");
                }
                if (!bIOCarkOK)
                {
                    MessageBox.Show("Please Check Connect Card PCI");
                }
            }
        }
    }
}
