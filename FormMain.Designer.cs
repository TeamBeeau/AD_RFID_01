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
            this.label1 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLoadProjectModel = new System.Windows.Forms.Button();
            this.lbPN = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.panel38 = new System.Windows.Forms.Panel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnLang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.panel53 = new System.Windows.Forms.Panel();
            this.btnCloseImage = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnLive = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnTrig = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnContinous = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.panel41 = new System.Windows.Forms.Panel();
            this.btnSetModelPagePOS = new System.Windows.Forms.Button();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.btnResetImage = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnFolder = new System.Windows.Forms.Button();
            this.panel40 = new System.Windows.Forms.Panel();
            this.btnSelectZoomRegion = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnCreateMarkModel = new System.Windows.Forms.Button();
            this.panel42 = new System.Windows.Forms.Panel();
            this.lbPC = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.txtOffsetPosNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel57 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMissNum = new System.Windows.Forms.TextBox();
            this.panel55 = new System.Windows.Forms.Panel();
            this.txtOKNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbOI = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCHECK = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbCam = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPCI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCycleTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.workLoading = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.panel53.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel15.Controls.Add(this.label1);
            this.panel15.Controls.Add(this.panel37);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.panel7);
            this.panel37.Controls.Add(this.panel38);
            resources.ApplyResources(this.panel37, "panel37");
            this.panel37.Name = "panel37";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLoadProjectModel);
            this.panel7.Controls.Add(this.lbPN);
            this.panel7.Controls.Add(this.txtProjectNo);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // btnLoadProjectModel
            // 
            this.btnLoadProjectModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnLoadProjectModel, "btnLoadProjectModel");
            this.btnLoadProjectModel.ForeColor = System.Drawing.Color.Black;
            this.btnLoadProjectModel.Image = global::AD_RFID.Properties.Resources.Down_Button;
            this.btnLoadProjectModel.Name = "btnLoadProjectModel";
            this.btnLoadProjectModel.UseVisualStyleBackColor = false;
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
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.BtnRun);
            resources.ApplyResources(this.panel38, "panel38");
            this.panel38.Name = "panel38";
            // 
            // BtnRun
            // 
            this.BtnRun.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BtnRun, "BtnRun");
            this.BtnRun.ForeColor = System.Drawing.Color.White;
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.UseVisualStyleBackColor = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnLang);
            this.panel24.Controls.Add(this.button3);
            this.panel24.Controls.Add(this.button2);
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
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::AD_RFID.Properties.Resources.icons8_admin_48;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::AD_RFID.Properties.Resources.icons8_help_40;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSet, "btnSet");
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Image = global::AD_RFID.Properties.Resources.icons8_settings_40;
            this.btnSet.Name = "btnSet";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.statusStrip1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel36);
            this.panel6.Controls.Add(this.panel53);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.imgView);
            resources.ApplyResources(this.panel36, "panel36");
            this.panel36.Name = "panel36";
            // 
            // imgView
            // 
            resources.ApplyResources(this.imgView, "imgView");
            this.imgView.Name = "imgView";
            this.imgView.TabStop = false;
            // 
            // panel53
            // 
            this.panel53.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel53.Controls.Add(this.btnCloseImage);
            this.panel53.Controls.Add(this.panel16);
            this.panel53.Controls.Add(this.btnLive);
            this.panel53.Controls.Add(this.panel11);
            this.panel53.Controls.Add(this.btnTrig);
            this.panel53.Controls.Add(this.panel10);
            this.panel53.Controls.Add(this.btnContinous);
            this.panel53.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel53, "panel53");
            this.panel53.Name = "panel53";
            // 
            // btnCloseImage
            // 
            this.btnCloseImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCloseImage, "btnCloseImage");
            this.btnCloseImage.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseImage.Image = global::AD_RFID.Properties.Resources.icons8_camera_off_40;
            this.btnCloseImage.Name = "btnCloseImage";
            this.btnCloseImage.UseVisualStyleBackColor = false;
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
            this.btnLive.Image = global::AD_RFID.Properties.Resources.Video_Record;
            this.btnLive.Name = "btnLive";
            this.btnLive.UseVisualStyleBackColor = false;
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
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // btnContinous
            // 
            this.btnContinous.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnContinous, "btnContinous");
            this.btnContinous.ForeColor = System.Drawing.Color.Green;
            this.btnContinous.Image = global::AD_RFID.Properties.Resources.icons8_start_40;
            this.btnContinous.Name = "btnContinous";
            this.btnContinous.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel9);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.panel18);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel8);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel18.Controls.Add(this.panel28);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.lbOI);
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.panel14);
            this.panel28.Controls.Add(this.panel13);
            this.panel28.Controls.Add(this.panel42);
            resources.ApplyResources(this.panel28, "panel28");
            this.panel28.Name = "panel28";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnSaveImage);
            this.panel14.Controls.Add(this.panel41);
            this.panel14.Controls.Add(this.panel33);
            this.panel14.Controls.Add(this.panel32);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImage.Image = global::AD_RFID.Properties.Resources.icons8_save_40;
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.btnSetModelPagePOS);
            resources.ApplyResources(this.panel41, "panel41");
            this.panel41.Name = "panel41";
            // 
            // btnSetModelPagePOS
            // 
            this.btnSetModelPagePOS.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSetModelPagePOS, "btnSetModelPagePOS");
            this.btnSetModelPagePOS.ForeColor = System.Drawing.Color.Black;
            this.btnSetModelPagePOS.Image = global::AD_RFID.Properties.Resources.icons8_square_50;
            this.btnSetModelPagePOS.Name = "btnSetModelPagePOS";
            this.btnSetModelPagePOS.UseVisualStyleBackColor = false;
            // 
            // panel33
            // 
            resources.ApplyResources(this.panel33, "panel33");
            this.panel33.Name = "panel33";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.btnResetImage);
            resources.ApplyResources(this.panel32, "panel32");
            this.panel32.Name = "panel32";
            // 
            // btnResetImage
            // 
            this.btnResetImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnResetImage, "btnResetImage");
            this.btnResetImage.ForeColor = System.Drawing.Color.Black;
            this.btnResetImage.Image = global::AD_RFID.Properties.Resources.icons8_reset_60;
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnFolder);
            this.panel13.Controls.Add(this.panel40);
            this.panel13.Controls.Add(this.panel27);
            this.panel13.Controls.Add(this.panel25);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnFolder, "btnFolder");
            this.btnFolder.ForeColor = System.Drawing.Color.Black;
            this.btnFolder.Image = global::AD_RFID.Properties.Resources.icons8_folder_40;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.UseVisualStyleBackColor = false;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.btnSelectZoomRegion);
            resources.ApplyResources(this.panel40, "panel40");
            this.panel40.Name = "panel40";
            // 
            // btnSelectZoomRegion
            // 
            this.btnSelectZoomRegion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSelectZoomRegion, "btnSelectZoomRegion");
            this.btnSelectZoomRegion.ForeColor = System.Drawing.Color.Black;
            this.btnSelectZoomRegion.Image = global::AD_RFID.Properties.Resources.icons8_expand_collapse_arrows_50;
            this.btnSelectZoomRegion.Name = "btnSelectZoomRegion";
            this.btnSelectZoomRegion.UseVisualStyleBackColor = false;
            // 
            // panel27
            // 
            resources.ApplyResources(this.panel27, "panel27");
            this.panel27.Name = "panel27";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btnCreateMarkModel);
            resources.ApplyResources(this.panel25, "panel25");
            this.panel25.Name = "panel25";
            // 
            // btnCreateMarkModel
            // 
            this.btnCreateMarkModel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCreateMarkModel, "btnCreateMarkModel");
            this.btnCreateMarkModel.ForeColor = System.Drawing.Color.Black;
            this.btnCreateMarkModel.Image = global::AD_RFID.Properties.Resources.icons8_edge_constraint_50;
            this.btnCreateMarkModel.Name = "btnCreateMarkModel";
            this.btnCreateMarkModel.UseVisualStyleBackColor = false;
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.lbPC);
            resources.ApplyResources(this.panel42, "panel42");
            this.panel42.Name = "panel42";
            // 
            // lbPC
            // 
            this.lbPC.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbPC, "lbPC");
            this.lbPC.ForeColor = System.Drawing.Color.Black;
            this.lbPC.Name = "lbPC";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel59);
            this.panel21.Controls.Add(this.panel57);
            this.panel21.Controls.Add(this.panel55);
            resources.ApplyResources(this.panel21, "panel21");
            this.panel21.Name = "panel21";
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.txtOffsetPosNum);
            this.panel59.Controls.Add(this.label14);
            resources.ApplyResources(this.panel59, "panel59");
            this.panel59.Name = "panel59";
            // 
            // txtOffsetPosNum
            // 
            resources.ApplyResources(this.txtOffsetPosNum, "txtOffsetPosNum");
            this.txtOffsetPosNum.Name = "txtOffsetPosNum";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Name = "label14";
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.label15);
            this.panel57.Controls.Add(this.txtMissNum);
            resources.ApplyResources(this.panel57, "panel57");
            this.panel57.Name = "panel57";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Name = "label15";
            // 
            // txtMissNum
            // 
            resources.ApplyResources(this.txtMissNum, "txtMissNum");
            this.txtMissNum.Name = "txtMissNum";
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.txtOKNum);
            this.panel55.Controls.Add(this.label13);
            resources.ApplyResources(this.panel55, "panel55");
            this.panel55.Name = "panel55";
            // 
            // txtOKNum
            // 
            resources.ApplyResources(this.txtOKNum, "txtOKNum");
            this.txtOKNum.Name = "txtOKNum";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Name = "label13";
            // 
            // lbOI
            // 
            this.lbOI.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbOI, "lbOI");
            this.lbOI.ForeColor = System.Drawing.Color.Black;
            this.lbOI.Name = "lbOI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnCHECK);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnCHECK
            // 
            this.btnCHECK.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCHECK, "btnCHECK");
            this.btnCHECK.ForeColor = System.Drawing.Color.Transparent;
            this.btnCHECK.Name = "btnCHECK";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.panel17);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.label4.Name = "label4";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::AD_RFID.Properties.Resources._1_removebg_preview1;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCam,
            this.lbPCI,
            this.lbCycleTime});
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
            // workLoading
            // 
            this.workLoading.WorkerReportsProgress = true;
            this.workLoading.WorkerSupportsCancellation = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.panel53.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel42.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel59.ResumeLayout(false);
            this.panel59.PerformLayout();
            this.panel57.ResumeLayout(false);
            this.panel57.PerformLayout();
            this.panel55.ResumeLayout(false);
            this.panel55.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel12;
        private Panel panel3;
        private Panel panel5;
        private Panel panel9;
        private Panel panel8;
        private StatusStrip statusStrip1;
        private Panel panel6;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button Reset;
        private Panel panel53;
        private Button btnTrig;
        private Button btnLive;
        private Button btnFolder;
        private Button btnContinous;
        private System.Windows.Forms.Timer timer1;
        private Panel panel36;
        private Button btnCloseImage;
        private Button btnSaveImage;
        private Panel panel17;
        private Panel panel18;
        private Panel panel28;
        private Panel panel14;
        private Panel panel41;
        private Button btnSetModelPagePOS;
        private Panel panel33;
        private Panel panel32;
        private Button btnResetImage;
        private Panel panel13;
        private Panel panel40;
        private Button btnSelectZoomRegion;
        private Panel panel27;
        private Panel panel25;
        private Button btnCreateMarkModel;
        private Panel panel42;
        private Label lbPC;
        private Label lbOI;
        private Panel panel2;
        private Label btnCHECK;
        private Panel panel24;
        private Button button3;
        private Button button2;
        private Button btnSet;
        private Panel panel15;
        private Panel panel37;
        private Panel panel7;
        private Label lbPN;
        private Button btnLoadProjectModel;
        private Panel panel38;
        private Button BtnRun;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnLang;
        public PictureBox imgView;
        public System.ComponentModel.BackgroundWorker workLoading;
        private ToolStripStatusLabel lbCycleTime;
        private TextBox txtProjectNo;
        private ToolStripStatusLabel lbPCI;
        private ToolStripStatusLabel lbCam;
        private Panel panel21;
        private Panel panel59;
        private TextBox txtOffsetPosNum;
        private Label label14;
        private Panel panel57;
        private Label label15;
        private TextBox txtMissNum;
        private Panel panel55;
        private TextBox txtOKNum;
        private Label label13;
        private Panel panel16;
        private Panel panel11;
        private Panel panel10;
        private Panel panel4;
    }
}
