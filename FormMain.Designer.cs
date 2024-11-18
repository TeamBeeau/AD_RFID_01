using System.Drawing;
using System.Windows.Forms;

namespace AD_RFID
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pPro = new System.Windows.Forms.Panel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoadProjectModel = new System.Windows.Forms.Button();
            this.lbPN = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lbNT = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.pModel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pView = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Panel();
            this.pControl = new System.Windows.Forms.Panel();
            this.btnWebCam = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.chkShowEable = new AD_RFID.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKich = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnLive = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnTrig = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel57 = new System.Windows.Forms.Panel();
            this.txtDoubleNum = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtOffsetPosNum = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtMissNum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtOKNum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel55 = new System.Windows.Forms.Panel();
            this.txtReject = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtyield = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pButton2 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pButton1 = new System.Windows.Forms.Panel();
            this.btnCreateMarkModel = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSetModelPagePOS = new System.Windows.Forms.Button();
            this.pButton3 = new System.Windows.Forms.Panel();
            this.btnResetImage = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnSelectZoomRegion = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPO = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNoti = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lbOK = new System.Windows.Forms.Label();
            this.lbNG = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxHistory = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbCam = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPCI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCycleTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtGrapImageTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDealWithTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmTrain = new System.Windows.Forms.Timer(this.components);
            this.tmMouseRightDown = new System.Windows.Forms.Timer(this.components);
            this.workWebCam = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pPro.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel24.SuspendLayout();
            this.pModel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pView.SuspendLayout();
            this.pControl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel20.SuspendLayout();
            this.pButton2.SuspendLayout();
            this.pButton1.SuspendLayout();
            this.pButton3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel12);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Name = "panel1";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SlateGray;
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel24);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.pPro);
            this.panel15.Controls.Add(this.panel37);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // pPro
            // 
            this.pPro.Controls.Add(this.btnSaveAs);
            this.pPro.Controls.Add(this.btnLoadProjectModel);
            this.pPro.Controls.Add(this.lbPN);
            this.pPro.Controls.Add(this.txtProjectNo);
            resources.ApplyResources(this.pPro, "pPro");
            this.pPro.Name = "pPro";
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveAs.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAs.Image = global::AD_RFID.Properties.Resources.icons8_save_as_30;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoadProjectModel
            // 
            resources.ApplyResources(this.btnLoadProjectModel, "btnLoadProjectModel");
            this.btnLoadProjectModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadProjectModel.ForeColor = System.Drawing.Color.Black;
            this.btnLoadProjectModel.Image = global::AD_RFID.Properties.Resources.Down_Button;
            this.btnLoadProjectModel.Name = "btnLoadProjectModel";
            this.btnLoadProjectModel.UseVisualStyleBackColor = false;
            this.btnLoadProjectModel.Click += new System.EventHandler(this.btnLoadProjectModel_Click_1);
            // 
            // lbPN
            // 
            resources.ApplyResources(this.lbPN, "lbPN");
            this.lbPN.ForeColor = System.Drawing.Color.White;
            this.lbPN.Name = "lbPN";
            // 
            // txtProjectNo
            // 
            resources.ApplyResources(this.txtProjectNo, "txtProjectNo");
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.TextChanged += new System.EventHandler(this.txtProjectNo_TextChanged);
            this.txtProjectNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectNo_KeyDown);
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.btnTrain);
            this.panel37.Controls.Add(this.lbNT);
            this.panel37.Controls.Add(this.panel38);
            resources.ApplyResources(this.panel37, "panel37");
            this.panel37.Name = "panel37";
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnTrain, "btnTrain");
            this.btnTrain.ForeColor = System.Drawing.Color.Black;
            this.btnTrain.Image = global::AD_RFID.Properties.Resources.icons8_click_40;
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // lbNT
            // 
            this.lbNT.BackColor = System.Drawing.Color.Silver;
            this.lbNT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lbNT, "lbNT");
            this.lbNT.ForeColor = System.Drawing.Color.White;
            this.lbNT.Name = "lbNT";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.BtnRun);
            resources.ApplyResources(this.panel38, "panel38");
            this.panel38.Name = "panel38";
            // 
            // BtnRun
            // 
            this.BtnRun.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.BtnRun, "BtnRun");
            this.BtnRun.ForeColor = System.Drawing.Color.Green;
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.UseVisualStyleBackColor = false;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnLang);
            this.panel24.Controls.Add(this.btnReport);
            this.panel24.Controls.Add(this.btnHelp);
            this.panel24.Controls.Add(this.btnSet);
            resources.ApplyResources(this.panel24, "panel24");
            this.panel24.Name = "panel24";
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnLang, "btnLang");
            this.btnLang.ForeColor = System.Drawing.Color.Black;
            this.btnLang.Image = global::AD_RFID.Properties.Resources.Language_Skill_1;
            this.btnLang.Name = "btnLang";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::AD_RFID.Properties.Resources.icons8_admin_48;
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Image = global::AD_RFID.Properties.Resources.icons8_help_40;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSet, "btnSet");
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Image = global::AD_RFID.Properties.Resources.icons8_settings_40;
            this.btnSet.Name = "btnSet";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pModel
            // 
            this.pModel.BackColor = System.Drawing.Color.White;
            this.pModel.Controls.Add(this.panel6);
            this.pModel.Controls.Add(this.panel5);
            this.pModel.Controls.Add(this.statusStrip1);
            resources.ApplyResources(this.pModel, "pModel");
            this.pModel.Name = "pModel";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pView);
            this.panel6.Controls.Add(this.pControl);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // pView
            // 
            this.pView.Controls.Add(this.view);
            resources.ApplyResources(this.pView, "pView");
            this.pView.Name = "pView";
            // 
            // view
            // 
            resources.ApplyResources(this.view, "view");
            this.view.Name = "view";
            this.view.Paint += new System.Windows.Forms.PaintEventHandler(this.view_Paint);
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.LightSlateGray;
            this.pControl.Controls.Add(this.btnWebCam);
            this.pControl.Controls.Add(this.panel21);
            this.pControl.Controls.Add(this.chkShowEable);
            this.pControl.Controls.Add(this.panel3);
            this.pControl.Controls.Add(this.btnKich);
            this.pControl.Controls.Add(this.btnFolder);
            this.pControl.Controls.Add(this.btnSimulation);
            this.pControl.Controls.Add(this.panel18);
            this.pControl.Controls.Add(this.btnSaveImage);
            this.pControl.Controls.Add(this.panel16);
            this.pControl.Controls.Add(this.btnLive);
            this.pControl.Controls.Add(this.panel11);
            this.pControl.Controls.Add(this.btnTrig);
            this.pControl.Controls.Add(this.panel10);
            resources.ApplyResources(this.pControl, "pControl");
            this.pControl.Name = "pControl";
            // 
            // btnWebCam
            // 
            this.btnWebCam.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnWebCam, "btnWebCam");
            this.btnWebCam.ForeColor = System.Drawing.Color.Black;
            this.btnWebCam.Image = global::AD_RFID.Properties.Resources.icons8_camera_50__1_;
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.UseVisualStyleBackColor = false;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebCam_Click);
            // 
            // panel21
            // 
            resources.ApplyResources(this.panel21, "panel21");
            this.panel21.Name = "panel21";
            // 
            // chkShowEable
            // 
            this.chkShowEable.BackColor = System.Drawing.Color.Transparent;
            this.chkShowEable.BackgroundColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chkShowEable, "chkShowEable");
            this.chkShowEable.BorderColor = System.Drawing.Color.Silver;
            this.chkShowEable.BorderRadius = 0;
            this.chkShowEable.BorderSize = 0;
            this.chkShowEable.FlatAppearance.BorderSize = 0;
            this.chkShowEable.ForeColor = System.Drawing.Color.Black;
            this.chkShowEable.IsCLick = false;
            this.chkShowEable.IsNotChange = false;
            this.chkShowEable.IsRect = false;
            this.chkShowEable.IsUnGroup = true;
            this.chkShowEable.Name = "chkShowEable";
            this.chkShowEable.TextColor = System.Drawing.Color.Black;
            this.chkShowEable.UseVisualStyleBackColor = false;
            this.chkShowEable.Click += new System.EventHandler(this.chkShowEable_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnKich
            // 
            resources.ApplyResources(this.btnKich, "btnKich");
            this.btnKich.Name = "btnKich";
            this.btnKich.UseVisualStyleBackColor = true;
            this.btnKich.Click += new System.EventHandler(this.btnKich_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnFolder, "btnFolder");
            this.btnFolder.ForeColor = System.Drawing.Color.Black;
            this.btnFolder.Image = global::AD_RFID.Properties.Resources.icons8_folder_40;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSimulation
            // 
            resources.ApplyResources(this.btnSimulation, "btnSimulation");
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel18
            // 
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImage.Image = global::AD_RFID.Properties.Resources.icons8_save_30;
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click_1);
            // 
            // panel16
            // 
            resources.ApplyResources(this.panel16, "panel16");
            this.panel16.Name = "panel16";
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnLive, "btnLive");
            this.btnLive.ForeColor = System.Drawing.Color.Black;
            this.btnLive.Image = global::AD_RFID.Properties.Resources.icons8_live_30;
            this.btnLive.Name = "btnLive";
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // btnTrig
            // 
            this.btnTrig.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnTrig, "btnTrig");
            this.btnTrig.ForeColor = System.Drawing.Color.Black;
            this.btnTrig.Image = global::AD_RFID.Properties.Resources.icons8_click_40;
            this.btnTrig.Name = "btnTrig";
            this.btnTrig.UseVisualStyleBackColor = false;
            this.btnTrig.Click += new System.EventHandler(this.btnTrig_Click);
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.panel57);
            this.panel2.Controls.Add(this.panel23);
            this.panel2.Controls.Add(this.panel19);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel55);
            this.panel2.Controls.Add(this.panel20);
            this.panel2.Controls.Add(this.pButton2);
            this.panel2.Controls.Add(this.pButton1);
            this.panel2.Controls.Add(this.pButton3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtboxHistory);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.txtDoubleNum);
            this.panel57.Controls.Add(this.label35);
            resources.ApplyResources(this.panel57, "panel57");
            this.panel57.Name = "panel57";
            // 
            // txtDoubleNum
            // 
            this.txtDoubleNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoubleNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtDoubleNum, "txtDoubleNum");
            this.txtDoubleNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDoubleNum.Name = "txtDoubleNum";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label35.Name = "label35";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtOffsetPosNum);
            this.panel23.Controls.Add(this.label36);
            resources.ApplyResources(this.panel23, "panel23");
            this.panel23.Name = "panel23";
            // 
            // txtOffsetPosNum
            // 
            this.txtOffsetPosNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOffsetPosNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtOffsetPosNum, "txtOffsetPosNum");
            this.txtOffsetPosNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOffsetPosNum.Name = "txtOffsetPosNum";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label36.Name = "label36";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtMissNum);
            this.panel19.Controls.Add(this.label15);
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Name = "panel19";
            // 
            // txtMissNum
            // 
            this.txtMissNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMissNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtMissNum, "txtMissNum");
            this.txtMissNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMissNum.Name = "txtMissNum";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Name = "label15";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtOKNum);
            this.panel14.Controls.Add(this.label13);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // txtOKNum
            // 
            this.txtOKNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOKNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtOKNum, "txtOKNum");
            this.txtOKNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOKNum.Name = "txtOKNum";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Name = "label13";
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.txtReject);
            this.panel55.Controls.Add(this.label31);
            this.panel55.Controls.Add(this.txtyield);
            this.panel55.Controls.Add(this.label32);
            resources.ApplyResources(this.panel55, "panel55");
            this.panel55.Name = "panel55";
            // 
            // txtReject
            // 
            this.txtReject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtReject, "txtReject");
            this.txtReject.ForeColor = System.Drawing.Color.Red;
            this.txtReject.Name = "txtReject";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Name = "label31";
            // 
            // txtyield
            // 
            this.txtyield.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtyield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtyield, "txtyield");
            this.txtyield.ForeColor = System.Drawing.Color.Green;
            this.txtyield.Name = "txtyield";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Name = "label32";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label3);
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Name = "panel20";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // pButton2
            // 
            this.pButton2.Controls.Add(this.btnDown);
            this.pButton2.Controls.Add(this.btnUp);
            resources.ApplyResources(this.pButton2, "pButton2");
            this.pButton2.Name = "pButton2";
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.ForeColor = System.Drawing.Color.Black;
            this.btnDown.Image = global::AD_RFID.Properties.Resources.icons8_camera_30__2_;
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.ForeColor = System.Drawing.Color.Black;
            this.btnUp.Image = global::AD_RFID.Properties.Resources.icons8_camera_30__1_;
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pButton1
            // 
            this.pButton1.Controls.Add(this.btnCreateMarkModel);
            this.pButton1.Controls.Add(this.panel9);
            this.pButton1.Controls.Add(this.btnSetModelPagePOS);
            resources.ApplyResources(this.pButton1, "pButton1");
            this.pButton1.Name = "pButton1";
            // 
            // btnCreateMarkModel
            // 
            this.btnCreateMarkModel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCreateMarkModel, "btnCreateMarkModel");
            this.btnCreateMarkModel.ForeColor = System.Drawing.Color.Black;
            this.btnCreateMarkModel.Image = global::AD_RFID.Properties.Resources.icons8_edge_constraint_50;
            this.btnCreateMarkModel.Name = "btnCreateMarkModel";
            this.btnCreateMarkModel.UseVisualStyleBackColor = false;
            this.btnCreateMarkModel.Click += new System.EventHandler(this.btnCreateMarkModel_Click);
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // btnSetModelPagePOS
            // 
            this.btnSetModelPagePOS.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSetModelPagePOS, "btnSetModelPagePOS");
            this.btnSetModelPagePOS.ForeColor = System.Drawing.Color.Black;
            this.btnSetModelPagePOS.Image = global::AD_RFID.Properties.Resources.icons8_square_50;
            this.btnSetModelPagePOS.Name = "btnSetModelPagePOS";
            this.btnSetModelPagePOS.UseVisualStyleBackColor = false;
            this.btnSetModelPagePOS.Click += new System.EventHandler(this.btnSetModelPagePOS_Click_1);
            // 
            // pButton3
            // 
            this.pButton3.Controls.Add(this.btnResetImage);
            this.pButton3.Controls.Add(this.panel17);
            this.pButton3.Controls.Add(this.btnSelectZoomRegion);
            resources.ApplyResources(this.pButton3, "pButton3");
            this.pButton3.Name = "pButton3";
            // 
            // btnResetImage
            // 
            this.btnResetImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnResetImage, "btnResetImage");
            this.btnResetImage.ForeColor = System.Drawing.Color.Black;
            this.btnResetImage.Image = global::AD_RFID.Properties.Resources.icons8_reset_50;
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.UseVisualStyleBackColor = false;
            this.btnResetImage.Click += new System.EventHandler(this.btnResetImage_Click);
            // 
            // panel17
            // 
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // btnSelectZoomRegion
            // 
            this.btnSelectZoomRegion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSelectZoomRegion, "btnSelectZoomRegion");
            this.btnSelectZoomRegion.ForeColor = System.Drawing.Color.Black;
            this.btnSelectZoomRegion.Image = global::AD_RFID.Properties.Resources.icons8_click_on_zoom_in_or_out_isolated_on_white_background_50;
            this.btnSelectZoomRegion.Name = "btnSelectZoomRegion";
            this.btnSelectZoomRegion.UseVisualStyleBackColor = false;
            this.btnSelectZoomRegion.Click += new System.EventHandler(this.btnSelectZoomRegion_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPO);
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.lbNoti);
            this.panel8.Controls.Add(this.panel13);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // txtPO
            // 
            resources.ApplyResources(this.txtPO, "txtPO");
            this.txtPO.FormattingEnabled = true;
            this.txtPO.Name = "txtPO";
            this.txtPO.SelectedIndexChanged += new System.EventHandler(this.txtPO_SelectedIndexChanged);
            this.txtPO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPO_KeyDown);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // lbNoti
            // 
            this.lbNoti.BackColor = System.Drawing.Color.Green;
            this.lbNoti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lbNoti, "lbNoti");
            this.lbNoti.ForeColor = System.Drawing.Color.White;
            this.lbNoti.Name = "lbNoti";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.lbOK);
            this.panel13.Controls.Add(this.lbNG);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // lbOK
            // 
            resources.ApplyResources(this.lbOK, "lbOK");
            this.lbOK.ForeColor = System.Drawing.Color.Green;
            this.lbOK.Name = "lbOK";
            // 
            // lbNG
            // 
            resources.ApplyResources(this.lbNG, "lbNG");
            this.lbNG.ForeColor = System.Drawing.Color.Red;
            this.lbNG.Name = "lbNG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AD_RFID.Properties.Resources._1_removebg_preview1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtboxHistory
            // 
            resources.ApplyResources(this.txtboxHistory, "txtboxHistory");
            this.txtboxHistory.Name = "txtboxHistory";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCam,
            this.lbPCI,
            this.lbCycleTime,
            this.txtGrapImageTime,
            this.toolStripStatusLabel1,
            this.txtDealWithTime});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lbCam
            // 
            this.lbCam.Name = "lbCam";
            resources.ApplyResources(this.lbCam, "lbCam");
            // 
            // lbPCI
            // 
            this.lbPCI.Name = "lbPCI";
            resources.ApplyResources(this.lbPCI, "lbPCI");
            // 
            // lbCycleTime
            // 
            this.lbCycleTime.Name = "lbCycleTime";
            resources.ApplyResources(this.lbCycleTime, "lbCycleTime");
            // 
            // txtGrapImageTime
            // 
            this.txtGrapImageTime.Name = "txtGrapImageTime";
            resources.ApplyResources(this.txtGrapImageTime, "txtGrapImageTime");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // txtDealWithTime
            // 
            this.txtDealWithTime.Name = "txtDealWithTime";
            resources.ApplyResources(this.txtDealWithTime, "txtDealWithTime");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmTrain
            // 
            this.tmTrain.Tick += new System.EventHandler(this.tmTrain_Tick);
            // 
            // tmMouseRightDown
            // 
            this.tmMouseRightDown.Tick += new System.EventHandler(this.tmMouseRightDown_Tick);
            // 
            // workWebCam
            // 
            this.workWebCam.WorkerReportsProgress = true;
            this.workWebCam.WorkerSupportsCancellation = true;
            this.workWebCam.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workWebCam_DoWork);
            this.workWebCam.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workWebCam_RunWorkerCompleted);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pModel);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.pPro.ResumeLayout(false);
            this.pPro.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.pModel.ResumeLayout(false);
            this.pModel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pView.ResumeLayout(false);
            this.pControl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel57.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel55.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.pButton2.ResumeLayout(false);
            this.pButton1.ResumeLayout(false);
            this.pButton3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel12;
        private Panel pModel;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button Reset;
        private Panel pControl;
        private Button btnTrig;
        private Button btnLive;
        private System.Windows.Forms.Timer timer1;
        private Panel pView;
        private Panel panel24;
        private Button btnReport;
        private Button btnHelp;
        private Button btnSet;
        private Panel panel15;
        private Panel panel37;
        private Panel pPro;
        private Label lbPN;
        private Button btnLoadProjectModel;
        private Panel panel38;
        private Button BtnRun;
        private Button btnLang;
        private Panel panel16;
        private Panel panel11;
        private Panel panel10;
        private TextBox txtboxHistory;
        public TextBox txtProjectNo;
        private Panel view;
        private Panel panel2;
        private Button btnSaveImage;
        private Panel panel18;
        private Button btnFolder;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Label lbNoti;
        private Panel panel20;
        private Label label3;
        private Panel pButton2;
        private Button btnDown;
        private Button btnUp;
        private Panel pButton1;
        private Button btnCreateMarkModel;
        private Panel panel9;
        private Button btnSetModelPagePOS;
        private Panel pButton3;
        private Button btnResetImage;
        private Panel panel17;
        private Button btnSelectZoomRegion;
        private Panel panel57;
        private Label txtDoubleNum;
        private Label label35;
        private Label lbNT;
        private Panel panel23;
        private Label txtOffsetPosNum;
        private Label label36;
        private Panel panel19;
        private Label txtMissNum;
        private Label label15;
        private Panel panel14;
        private Label txtOKNum;
        private Label label13;
        private Panel panel55;
        private Label txtReject;
        private Label label31;
        private Label txtyield;
        private Label label32;
        private Panel panel13;
        private Label lbOK;
        private Label lbNG;
        private Label label1;
        private Button btnSaveAs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSimulation;
        private Button btnKich;
        private Button btnTrain;
        private Panel panel3;
        private Timer tmTrain;
        private Timer tmMouseRightDown;
        private Button btnReset;
        private RJButton chkShowEable;
        private Label label2;
        private Panel panel21;
        private Button btnWebCam;
        public System.ComponentModel.BackgroundWorker workWebCam;
        private Button btnDelete;
        private ComboBox txtPO;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel lbCam;
        public ToolStripStatusLabel lbPCI;
        private ToolStripStatusLabel lbCycleTime;
        private ToolStripStatusLabel txtGrapImageTime;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtDealWithTime;
    }
}
