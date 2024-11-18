using System.Drawing;
using System.Windows.Forms;

namespace AD_RFID
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.chkboxUnEnbleUpCamera = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveCheckPra = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThresholdValue = new System.Windows.Forms.TextBox();
            this.txtMatchValue = new System.Windows.Forms.TextBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.txtRightOffset = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDownOffset = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAngleOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLeftOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpOffset = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.txtUpCameraGain = new System.Windows.Forms.NumericUpDown();
            this.txtUpExposureTime = new System.Windows.Forms.NumericUpDown();
            this.txtUpCameraTime = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackWidth = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.trackHeight = new System.Windows.Forms.TrackBar();
            this.trackOffSetY = new System.Windows.Forms.TrackBar();
            this.label36 = new System.Windows.Forms.Label();
            this.trackOffSetX = new System.Windows.Forms.TrackBar();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel48 = new System.Windows.Forms.Panel();
            this.chkboxUnEnbleDownCamera = new System.Windows.Forms.CheckBox();
            this.btnSaveDownCameraPra = new System.Windows.Forms.Button();
            this.panel52 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDownExposureTime = new System.Windows.Forms.TextBox();
            this.panel49 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDownCameraTime = new System.Windows.Forms.TextBox();
            this.panel61 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSet3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbSaveNgDay = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.Panel();
            this.lbDay = new System.Windows.Forms.Label();
            this.trackDay = new System.Windows.Forms.TrackBar();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pCany = new System.Windows.Forms.Panel();
            this.btnResetDay = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCurrentSaveDay = new System.Windows.Forms.TextBox();
            this.btnResult = new AD_RFID.RJButton();
            this.btnRaw = new AD_RFID.RJButton();
            this.btnNG = new AD_RFID.RJButton();
            this.btnOK = new AD_RFID.RJButton();
            this.btnMedium = new AD_RFID.RJButton();
            this.btnSmall = new AD_RFID.RJButton();
            this.btnBig = new AD_RFID.RJButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpExposureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOffSetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOffSetX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel61.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDay)).BeginInit();
            this.pCany.SuspendLayout();
            this.panel23.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(452, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UpCamera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbY);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbHeight);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.lbWidth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trackWidth);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.trackHeight);
            this.panel1.Controls.Add(this.trackOffSetY);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.trackOffSetX);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 461);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(0, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 40);
            this.label5.TabIndex = 54;
            this.label5.Text = "Resolution";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.BackColor = System.Drawing.Color.Transparent;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.Location = new System.Drawing.Point(384, 657);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(24, 25);
            this.lbY.TabIndex = 53;
            this.lbY.Text = "0";
            this.lbY.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.chkboxUnEnbleUpCamera);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnSaveCheckPra);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtThresholdValue);
            this.panel2.Controls.Add(this.txtMatchValue);
            this.panel2.Controls.Add(this.txtScale);
            this.panel2.Controls.Add(this.txtRightOffset);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtDownOffset);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtAngleOffset);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtLeftOffset);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtUpOffset);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 221);
            this.panel2.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Location = new System.Drawing.Point(198, 115);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 25);
            this.label23.TabIndex = 4;
            this.label23.Text = "Binary:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkboxUnEnbleUpCamera
            // 
            this.chkboxUnEnbleUpCamera.AutoSize = true;
            this.chkboxUnEnbleUpCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxUnEnbleUpCamera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkboxUnEnbleUpCamera.Location = new System.Drawing.Point(279, 171);
            this.chkboxUnEnbleUpCamera.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxUnEnbleUpCamera.Name = "chkboxUnEnbleUpCamera";
            this.chkboxUnEnbleUpCamera.Size = new System.Drawing.Size(158, 24);
            this.chkboxUnEnbleUpCamera.TabIndex = 33;
            this.chkboxUnEnbleUpCamera.Text = "DisableUpCamera";
            this.chkboxUnEnbleUpCamera.UseVisualStyleBackColor = true;
            this.chkboxUnEnbleUpCamera.CheckedChanged += new System.EventHandler(this.chkboxUnEnbleUpCamera_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label17.Location = new System.Drawing.Point(362, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "(0.1~1.0)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Location = new System.Drawing.Point(161, 115);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "mm";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveCheckPra
            // 
            this.btnSaveCheckPra.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCheckPra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveCheckPra.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCheckPra.Location = new System.Drawing.Point(10, 153);
            this.btnSaveCheckPra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveCheckPra.Name = "btnSaveCheckPra";
            this.btnSaveCheckPra.Size = new System.Drawing.Size(265, 56);
            this.btnSaveCheckPra.TabIndex = 2;
            this.btnSaveCheckPra.Text = "Set";
            this.btnSaveCheckPra.UseVisualStyleBackColor = false;
            this.btnSaveCheckPra.Click += new System.EventHandler(this.btnSaveCheckPra_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(159, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "mm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThresholdValue
            // 
            this.txtThresholdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThresholdValue.Location = new System.Drawing.Point(271, 116);
            this.txtThresholdValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(88, 26);
            this.txtThresholdValue.TabIndex = 0;
            this.txtThresholdValue.TextChanged += new System.EventHandler(this.txtThresholdValue_TextChanged);
            // 
            // txtMatchValue
            // 
            this.txtMatchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatchValue.Location = new System.Drawing.Point(271, 50);
            this.txtMatchValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMatchValue.Name = "txtMatchValue";
            this.txtMatchValue.Size = new System.Drawing.Size(88, 26);
            this.txtMatchValue.TabIndex = 1;
            // 
            // txtScale
            // 
            this.txtScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtScale.Location = new System.Drawing.Point(273, 81);
            this.txtScale.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(86, 26);
            this.txtScale.TabIndex = 1;
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            // 
            // txtRightOffset
            // 
            this.txtRightOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRightOffset.Location = new System.Drawing.Point(68, 115);
            this.txtRightOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRightOffset.Name = "txtRightOffset";
            this.txtRightOffset.Size = new System.Drawing.Size(89, 26);
            this.txtRightOffset.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label22.Location = new System.Drawing.Point(212, 81);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 25);
            this.label22.TabIndex = 2;
            this.label22.Text = "Scale:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDownOffset
            // 
            this.txtDownOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDownOffset.Location = new System.Drawing.Point(68, 78);
            this.txtDownOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDownOffset.Name = "txtDownOffset";
            this.txtDownOffset.Size = new System.Drawing.Size(89, 26);
            this.txtDownOffset.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(209, 50);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "Score:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Location = new System.Drawing.Point(-10, 115);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Right:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(-9, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Down:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(371, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "o";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(159, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "mm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label19.Location = new System.Drawing.Point(159, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "mm";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAngleOffset
            // 
            this.txtAngleOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAngleOffset.Location = new System.Drawing.Point(271, 14);
            this.txtAngleOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAngleOffset.Name = "txtAngleOffset";
            this.txtAngleOffset.Size = new System.Drawing.Size(88, 26);
            this.txtAngleOffset.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(205, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Angle:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLeftOffset
            // 
            this.txtLeftOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLeftOffset.Location = new System.Drawing.Point(68, 46);
            this.txtLeftOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLeftOffset.Name = "txtLeftOffset";
            this.txtLeftOffset.Size = new System.Drawing.Size(89, 26);
            this.txtLeftOffset.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(-12, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Left:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpOffset
            // 
            this.txtUpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUpOffset.Location = new System.Drawing.Point(68, 14);
            this.txtUpOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUpOffset.Name = "txtUpOffset";
            this.txtUpOffset.Size = new System.Drawing.Size(89, 26);
            this.txtUpOffset.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label20.Location = new System.Drawing.Point(-12, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Upper:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.Transparent;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(384, 606);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(24, 25);
            this.lbX.TabIndex = 53;
            this.lbX.Text = "0";
            this.lbX.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(0, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limit Set";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.BackColor = System.Drawing.Color.Transparent;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.Location = new System.Drawing.Point(384, 560);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(24, 25);
            this.lbHeight.TabIndex = 53;
            this.lbHeight.Text = "0";
            this.lbHeight.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.label37);
            this.panel11.Controls.Add(this.txtUpCameraGain);
            this.panel11.Controls.Add(this.txtUpExposureTime);
            this.panel11.Controls.Add(this.txtUpCameraTime);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel11.Location = new System.Drawing.Point(0, 36);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(448, 170);
            this.panel11.TabIndex = 1;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(278, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 134);
            this.button1.TabIndex = 45;
            this.button1.Text = "Save Para";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label37.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label37.Location = new System.Drawing.Point(222, 122);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 25);
            this.label37.TabIndex = 53;
            this.label37.Text = "1-15";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUpCameraGain
            // 
            this.txtUpCameraGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUpCameraGain.Location = new System.Drawing.Point(118, 113);
            this.txtUpCameraGain.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtUpCameraGain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpCameraGain.Name = "txtUpCameraGain";
            this.txtUpCameraGain.Size = new System.Drawing.Size(100, 38);
            this.txtUpCameraGain.TabIndex = 52;
            this.txtUpCameraGain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpCameraGain.ValueChanged += new System.EventHandler(this.txtUpCameraGain_ValueChanged);
            // 
            // txtUpExposureTime
            // 
            this.txtUpExposureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUpExposureTime.Location = new System.Drawing.Point(118, 63);
            this.txtUpExposureTime.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtUpExposureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpExposureTime.Name = "txtUpExposureTime";
            this.txtUpExposureTime.Size = new System.Drawing.Size(100, 38);
            this.txtUpExposureTime.TabIndex = 10;
            this.txtUpExposureTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpExposureTime.ValueChanged += new System.EventHandler(this.txtUpExposureTime_ValueChanged);
            // 
            // txtUpCameraTime
            // 
            this.txtUpCameraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUpCameraTime.Location = new System.Drawing.Point(118, 17);
            this.txtUpCameraTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtUpCameraTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpCameraTime.Name = "txtUpCameraTime";
            this.txtUpCameraTime.Size = new System.Drawing.Size(100, 38);
            this.txtUpCameraTime.TabIndex = 9;
            this.txtUpCameraTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(5, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "GrabDelay:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exposure:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(222, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "us";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(25, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gain:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(223, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.BackColor = System.Drawing.Color.Transparent;
            this.lbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWidth.Location = new System.Drawing.Point(384, 512);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(24, 25);
            this.lbWidth.TabIndex = 53;
            this.lbWidth.Text = "0";
            this.lbWidth.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parameter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackWidth
            // 
            this.trackWidth.Location = new System.Drawing.Point(106, 512);
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(272, 45);
            this.trackWidth.TabIndex = 45;
            this.trackWidth.Visible = false;
            this.trackWidth.Scroll += new System.EventHandler(this.trackWidth_Scroll);
            this.trackWidth.ValueChanged += new System.EventHandler(this.trackWidth_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(25, 512);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 25);
            this.label25.TabIndex = 43;
            this.label25.Text = "Width";
            this.label25.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 657);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 25);
            this.label21.TabIndex = 51;
            this.label21.Text = "OffSetY";
            this.label21.Visible = false;
            // 
            // trackHeight
            // 
            this.trackHeight.Location = new System.Drawing.Point(106, 563);
            this.trackHeight.Name = "trackHeight";
            this.trackHeight.Size = new System.Drawing.Size(272, 45);
            this.trackHeight.TabIndex = 46;
            this.trackHeight.Visible = false;
            this.trackHeight.ValueChanged += new System.EventHandler(this.trackHeight_ValueChanged);
            // 
            // trackOffSetY
            // 
            this.trackOffSetY.Location = new System.Drawing.Point(106, 657);
            this.trackOffSetY.Name = "trackOffSetY";
            this.trackOffSetY.Size = new System.Drawing.Size(272, 45);
            this.trackOffSetY.TabIndex = 50;
            this.trackOffSetY.Visible = false;
            this.trackOffSetY.ValueChanged += new System.EventHandler(this.trackOffSetY_ValueChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(18, 560);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(74, 25);
            this.label36.TabIndex = 47;
            this.label36.Text = "Height";
            this.label36.Visible = false;
            // 
            // trackOffSetX
            // 
            this.trackOffSetX.Location = new System.Drawing.Point(106, 606);
            this.trackOffSetX.Name = "trackOffSetX";
            this.trackOffSetX.Size = new System.Drawing.Size(272, 45);
            this.trackOffSetX.TabIndex = 49;
            this.trackOffSetX.Visible = false;
            this.trackOffSetX.ValueChanged += new System.EventHandler(this.trackOffSetX_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 606);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 25);
            this.label24.TabIndex = 48;
            this.label24.Text = "OffSetX";
            this.label24.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel48);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(452, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DownCamera";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.chkboxUnEnbleDownCamera);
            this.panel48.Controls.Add(this.btnSaveDownCameraPra);
            this.panel48.Controls.Add(this.panel52);
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel61);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel48.Location = new System.Drawing.Point(2, 2);
            this.panel48.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(448, 197);
            this.panel48.TabIndex = 20;
            // 
            // chkboxUnEnbleDownCamera
            // 
            this.chkboxUnEnbleDownCamera.AutoSize = true;
            this.chkboxUnEnbleDownCamera.Checked = true;
            this.chkboxUnEnbleDownCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxUnEnbleDownCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxUnEnbleDownCamera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkboxUnEnbleDownCamera.Location = new System.Drawing.Point(195, 146);
            this.chkboxUnEnbleDownCamera.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxUnEnbleDownCamera.Name = "chkboxUnEnbleDownCamera";
            this.chkboxUnEnbleDownCamera.Size = new System.Drawing.Size(232, 29);
            this.chkboxUnEnbleDownCamera.TabIndex = 35;
            this.chkboxUnEnbleDownCamera.Text = "DisableDownCamera";
            this.chkboxUnEnbleDownCamera.UseVisualStyleBackColor = true;
            this.chkboxUnEnbleDownCamera.CheckedChanged += new System.EventHandler(this.chkboxUnEnbleDownCamera_CheckedChanged);
            // 
            // btnSaveDownCameraPra
            // 
            this.btnSaveDownCameraPra.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveDownCameraPra.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDownCameraPra.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDownCameraPra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveDownCameraPra.Location = new System.Drawing.Point(6, 132);
            this.btnSaveDownCameraPra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveDownCameraPra.Name = "btnSaveDownCameraPra";
            this.btnSaveDownCameraPra.Size = new System.Drawing.Size(149, 56);
            this.btnSaveDownCameraPra.TabIndex = 13;
            this.btnSaveDownCameraPra.Text = "Set";
            this.btnSaveDownCameraPra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDownCameraPra.UseVisualStyleBackColor = false;
            this.btnSaveDownCameraPra.Click += new System.EventHandler(this.btnSaveDownCameraPra_Click);
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.label26);
            this.panel52.Controls.Add(this.txtDownExposureTime);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel52.Location = new System.Drawing.Point(0, 80);
            this.panel52.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel52.Name = "panel52";
            this.panel52.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel52.Size = new System.Drawing.Size(448, 39);
            this.panel52.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Font = new System.Drawing.Font("Arial", 12F);
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(3, 2);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label26.Size = new System.Drawing.Size(136, 35);
            this.label26.TabIndex = 0;
            this.label26.Text = "ExposureTime/us:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDownExposureTime
            // 
            this.txtDownExposureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownExposureTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtDownExposureTime.Location = new System.Drawing.Point(151, 5);
            this.txtDownExposureTime.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDownExposureTime.Name = "txtDownExposureTime";
            this.txtDownExposureTime.Size = new System.Drawing.Size(293, 32);
            this.txtDownExposureTime.TabIndex = 1;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.label27);
            this.panel49.Controls.Add(this.txtDownCameraTime);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel49.Location = new System.Drawing.Point(0, 41);
            this.panel49.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel49.Name = "panel49";
            this.panel49.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel49.Size = new System.Drawing.Size(448, 39);
            this.panel49.TabIndex = 11;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Font = new System.Drawing.Font("Arial", 12F);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(3, 2);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label27.Size = new System.Drawing.Size(144, 35);
            this.label27.TabIndex = 0;
            this.label27.Text = "CameraDelay/ms:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDownCameraTime
            // 
            this.txtDownCameraTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownCameraTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtDownCameraTime.Location = new System.Drawing.Point(151, 5);
            this.txtDownCameraTime.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDownCameraTime.Name = "txtDownCameraTime";
            this.txtDownCameraTime.Size = new System.Drawing.Size(293, 32);
            this.txtDownCameraTime.TabIndex = 1;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.label28);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel61.Name = "panel61";
            this.panel61.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel61.Size = new System.Drawing.Size(448, 41);
            this.panel61.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(3, 2);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(442, 37);
            this.label28.TabIndex = 1;
            this.label28.Text = "DownCameraParameter";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSet3);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.cmbSaveNgDay);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.pArea);
            this.tabPage3.Controls.Add(this.pCany);
            this.tabPage3.Controls.Add(this.btnResetDay);
            this.tabPage3.Controls.Add(this.panel23);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(452, 711);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Production";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSet3
            // 
            this.btnSet3.BackColor = System.Drawing.Color.Transparent;
            this.btnSet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSet3.ForeColor = System.Drawing.Color.Black;
            this.btnSet3.Location = new System.Drawing.Point(26, 456);
            this.btnSet3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSet3.Name = "btnSet3";
            this.btnSet3.Size = new System.Drawing.Size(413, 68);
            this.btnSet3.TabIndex = 41;
            this.btnSet3.Text = "Set";
            this.btnSet3.UseVisualStyleBackColor = false;
            this.btnSet3.Click += new System.EventHandler(this.btnSet3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnResult);
            this.panel5.Controls.Add(this.btnRaw);
            this.panel5.Location = new System.Drawing.Point(24, 144);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(415, 73);
            this.panel5.TabIndex = 40;
            // 
            // cmbSaveNgDay
            // 
            this.cmbSaveNgDay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbSaveNgDay.FormattingEnabled = true;
            this.cmbSaveNgDay.Items.AddRange(new object[] {
            "5",
            "15",
            "30",
            "45",
            "60",
            "75",
            "90"});
            this.cmbSaveNgDay.Location = new System.Drawing.Point(402, 646);
            this.cmbSaveNgDay.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSaveNgDay.Name = "cmbSaveNgDay";
            this.cmbSaveNgDay.Size = new System.Drawing.Size(164, 33);
            this.cmbSaveNgDay.TabIndex = 1;
            this.cmbSaveNgDay.Visible = false;
            this.cmbSaveNgDay.SelectedIndexChanged += new System.EventHandler(this.cmbSaveNgDay_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Arial", 13.875F);
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(398, 604);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label30.Size = new System.Drawing.Size(144, 40);
            this.label30.TabIndex = 0;
            this.label30.Text = "NGSaveDay:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(20, 121);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 20);
            this.label31.TabIndex = 40;
            this.label31.Text = "Image";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNG);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Location = new System.Drawing.Point(24, 45);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(415, 73);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(20, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 20);
            this.label32.TabIndex = 35;
            this.label32.Text = "Conditions";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(25, 328);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(160, 20);
            this.label33.TabIndex = 36;
            this.label33.Text = "Compression method";
            // 
            // pArea
            // 
            this.pArea.Controls.Add(this.lbDay);
            this.pArea.Controls.Add(this.trackDay);
            this.pArea.Controls.Add(this.label34);
            this.pArea.Controls.Add(this.label35);
            this.pArea.Location = new System.Drawing.Point(24, 227);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(410, 79);
            this.pArea.TabIndex = 38;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(319, 10);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(18, 20);
            this.lbDay.TabIndex = 34;
            this.lbDay.Text = "0";
            // 
            // trackDay
            // 
            this.trackDay.LargeChange = 1;
            this.trackDay.Location = new System.Drawing.Point(5, 33);
            this.trackDay.Maximum = 100;
            this.trackDay.Name = "trackDay";
            this.trackDay.Size = new System.Drawing.Size(405, 45);
            this.trackDay.TabIndex = 33;
            this.trackDay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackDay.Scroll += new System.EventHandler(this.trackDay_Scroll);
            this.trackDay.ValueChanged += new System.EventHandler(this.trackDay_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(353, 10);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 20);
            this.label34.TabIndex = 32;
            this.label34.Text = "Day";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(4, 6);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 20);
            this.label35.TabIndex = 5;
            this.label35.Text = "Limit";
            // 
            // pCany
            // 
            this.pCany.Controls.Add(this.btnMedium);
            this.pCany.Controls.Add(this.btnSmall);
            this.pCany.Controls.Add(this.btnBig);
            this.pCany.Location = new System.Drawing.Point(24, 354);
            this.pCany.Name = "pCany";
            this.pCany.Padding = new System.Windows.Forms.Padding(5);
            this.pCany.Size = new System.Drawing.Size(418, 73);
            this.pCany.TabIndex = 37;
            // 
            // btnResetDay
            // 
            this.btnResetDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetDay.Location = new System.Drawing.Point(280, 646);
            this.btnResetDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetDay.Name = "btnResetDay";
            this.btnResetDay.Size = new System.Drawing.Size(154, 36);
            this.btnResetDay.TabIndex = 32;
            this.btnResetDay.Text = "Reset";
            this.btnResetDay.UseVisualStyleBackColor = true;
            this.btnResetDay.Visible = false;
            this.btnResetDay.Click += new System.EventHandler(this.btnResetDay_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label29);
            this.panel23.Controls.Add(this.txtCurrentSaveDay);
            this.panel23.Location = new System.Drawing.Point(332, 551);
            this.panel23.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Size = new System.Drawing.Size(448, 39);
            this.panel23.TabIndex = 31;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Left;
            this.label29.Font = new System.Drawing.Font("Arial", 12F);
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(3, 2);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label29.Size = new System.Drawing.Size(136, 35);
            this.label29.TabIndex = 0;
            this.label29.Text = "CurrentSaveDay:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label29.Visible = false;
            // 
            // txtCurrentSaveDay
            // 
            this.txtCurrentSaveDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentSaveDay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCurrentSaveDay.Location = new System.Drawing.Point(151, 7);
            this.txtCurrentSaveDay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCurrentSaveDay.Name = "txtCurrentSaveDay";
            this.txtCurrentSaveDay.Size = new System.Drawing.Size(293, 32);
            this.txtCurrentSaveDay.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResult.BackgroundImage")));
            this.btnResult.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResult.BorderRadius = 0;
            this.btnResult.BorderSize = 0;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResult.Enabled = false;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.IsCLick = false;
            this.btnResult.IsNotChange = false;
            this.btnResult.IsRect = false;
            this.btnResult.IsUnGroup = true;
            this.btnResult.Location = new System.Drawing.Point(194, 5);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(216, 63);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Result";
            this.btnResult.TextColor = System.Drawing.Color.Black;
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRaw
            // 
            this.btnRaw.BackColor = System.Drawing.Color.Transparent;
            this.btnRaw.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRaw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRaw.BackgroundImage")));
            this.btnRaw.BorderColor = System.Drawing.Color.Silver;
            this.btnRaw.BorderRadius = 0;
            this.btnRaw.BorderSize = 0;
            this.btnRaw.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRaw.FlatAppearance.BorderSize = 0;
            this.btnRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaw.ForeColor = System.Drawing.Color.Black;
            this.btnRaw.IsCLick = true;
            this.btnRaw.IsNotChange = false;
            this.btnRaw.IsRect = false;
            this.btnRaw.IsUnGroup = true;
            this.btnRaw.Location = new System.Drawing.Point(5, 5);
            this.btnRaw.Name = "btnRaw";
            this.btnRaw.Size = new System.Drawing.Size(189, 63);
            this.btnRaw.TabIndex = 0;
            this.btnRaw.Text = "Raw";
            this.btnRaw.TextColor = System.Drawing.Color.Black;
            this.btnRaw.UseVisualStyleBackColor = false;
            this.btnRaw.Click += new System.EventHandler(this.btnRaw_Click);
            // 
            // btnNG
            // 
            this.btnNG.BackColor = System.Drawing.Color.Transparent;
            this.btnNG.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNG.BackgroundImage")));
            this.btnNG.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNG.BorderRadius = 0;
            this.btnNG.BorderSize = 0;
            this.btnNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNG.FlatAppearance.BorderSize = 0;
            this.btnNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNG.ForeColor = System.Drawing.Color.Black;
            this.btnNG.IsCLick = false;
            this.btnNG.IsNotChange = false;
            this.btnNG.IsRect = false;
            this.btnNG.IsUnGroup = true;
            this.btnNG.Location = new System.Drawing.Point(194, 5);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(216, 63);
            this.btnNG.TabIndex = 1;
            this.btnNG.Text = "NG";
            this.btnNG.TextColor = System.Drawing.Color.Black;
            this.btnNG.UseVisualStyleBackColor = false;
            this.btnNG.Click += new System.EventHandler(this.btnNG_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.BorderRadius = 0;
            this.btnOK.BorderSize = 0;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.IsCLick = true;
            this.btnOK.IsNotChange = false;
            this.btnOK.IsRect = false;
            this.btnOK.IsUnGroup = true;
            this.btnOK.Location = new System.Drawing.Point(5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(189, 63);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.Black;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedium.BackgroundImage")));
            this.btnMedium.BorderColor = System.Drawing.Color.Silver;
            this.btnMedium.BorderRadius = 0;
            this.btnMedium.BorderSize = 0;
            this.btnMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.Color.Black;
            this.btnMedium.IsCLick = false;
            this.btnMedium.IsNotChange = false;
            this.btnMedium.IsRect = false;
            this.btnMedium.IsUnGroup = false;
            this.btnMedium.Location = new System.Drawing.Point(141, 5);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(138, 63);
            this.btnMedium.TabIndex = 5;
            this.btnMedium.Text = "Medium";
            this.btnMedium.TextColor = System.Drawing.Color.Black;
            this.btnMedium.UseVisualStyleBackColor = false;
            // 
            // btnSmall
            // 
            this.btnSmall.BackColor = System.Drawing.Color.Transparent;
            this.btnSmall.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmall.BackgroundImage")));
            this.btnSmall.BorderColor = System.Drawing.Color.Silver;
            this.btnSmall.BorderRadius = 0;
            this.btnSmall.BorderSize = 0;
            this.btnSmall.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSmall.FlatAppearance.BorderSize = 0;
            this.btnSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.ForeColor = System.Drawing.Color.Black;
            this.btnSmall.IsCLick = true;
            this.btnSmall.IsNotChange = false;
            this.btnSmall.IsRect = false;
            this.btnSmall.IsUnGroup = true;
            this.btnSmall.Location = new System.Drawing.Point(5, 5);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(136, 63);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "Small";
            this.btnSmall.TextColor = System.Drawing.Color.Black;
            this.btnSmall.UseVisualStyleBackColor = false;
            // 
            // btnBig
            // 
            this.btnBig.BackColor = System.Drawing.Color.Transparent;
            this.btnBig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBig.BackgroundImage")));
            this.btnBig.BorderColor = System.Drawing.Color.Silver;
            this.btnBig.BorderRadius = 0;
            this.btnBig.BorderSize = 0;
            this.btnBig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBig.FlatAppearance.BorderSize = 0;
            this.btnBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBig.ForeColor = System.Drawing.Color.Black;
            this.btnBig.IsCLick = false;
            this.btnBig.IsNotChange = false;
            this.btnBig.IsRect = false;
            this.btnBig.IsUnGroup = false;
            this.btnBig.Location = new System.Drawing.Point(279, 5);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(134, 63);
            this.btnBig.TabIndex = 4;
            this.btnBig.Text = "Big";
            this.btnBig.TextColor = System.Drawing.Color.Black;
            this.btnBig.UseVisualStyleBackColor = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 502);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Setting";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpExposureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOffSetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOffSetX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel48.PerformLayout();
            this.panel52.ResumeLayout(false);
            this.panel52.PerformLayout();
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel61.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pArea.ResumeLayout(false);
            this.pArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDay)).EndInit();
            this.pCany.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private Panel panel1;
        private Panel panel2;
        private Label label17;
        private Label label15;
        private Label label13;
        public TextBox txtThresholdValue;
        public TextBox txtMatchValue;
        public TextBox txtScale;
        public TextBox txtRightOffset;
        public TextBox txtDownOffset;
        private Label label10;
        private Label label8;
        private Label label19;
        public TextBox txtAngleOffset;
        public TextBox txtLeftOffset;
        public TextBox txtUpOffset;
        private Panel panel11;
        public NumericUpDown txtUpExposureTime;
        public NumericUpDown txtUpCameraTime;
        private Label label3;
        private Label label2;
        private Panel panel48;
        private Panel panel52;
        private Panel panel49;
        private Panel panel61;
        private Panel panel23;
        public TextBox txtDownExposureTime;
        public TextBox txtDownCameraTime;
        public TextBox txtCurrentSaveDay;
        public ComboBox cmbSaveNgDay;
        public CheckBox chkboxUnEnbleDownCamera;
        public CheckBox chkboxUnEnbleUpCamera;
        public TabPage tabPage1;
        public Label label23;
        public Button btnSaveCheckPra;
        public Label label22;
        public Label label18;
        public Label label16;
        public Label label14;
        public Label label11;
        public Label label9;
        public Label label20;
        public Label label1;
        public Label label12;
        public Label label4;
        public Label label7;
        public Label label6;
        public Button btnSaveDownCameraPra;
        public Label label26;
        public Label label27;
        public Label label28;
        public TabPage tabPage2;
        public TabPage tabPage3;
        public Button btnResetDay;
        public Label label29;
        public Label label30;
        private Label label25;
        private Label label31;
        private Panel panel3;
        private Label label32;
        private Label label33;
        private Panel pArea;
        private Label label34;
        private Label label35;
        private Panel pCany;
        private RJButton btnOK;
        private RJButton btnNG;
        private Panel panel5;
        private RJButton btnResult;
        private RJButton btnRaw;
        private TrackBar trackDay;
        private RJButton btnSmall;
        private RJButton btnBig;
        private RJButton btnMedium;
        public Button button1;
        public Button btnSet3;
        private Label label36;
        private Label label21;
        private Label label24;
        public NumericUpDown txtUpCameraGain;
        public TrackBar trackWidth;
        public TrackBar trackHeight;
        public TrackBar trackOffSetY;
        public TrackBar trackOffSetX;
        private Label lbY;
        private Label lbX;
        private Label lbHeight;
        private Label lbWidth;
        public Label label5;
        private Label label37;
        private Label lbDay;
    }
}