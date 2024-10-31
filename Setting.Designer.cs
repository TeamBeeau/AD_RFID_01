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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtUpExposureTime = new System.Windows.Forms.NumericUpDown();
            this.txtUpCameraTime = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSaveCameraPra = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelaySendTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpCameraGain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.chkShowEable = new System.Windows.Forms.CheckBox();
            this.btnResetDay = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCurrentSaveDay = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.cmbSaveNgDay = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lbOI = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpExposureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraTime)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel61.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 1177);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 1130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UpCameraParameter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 1124);
            this.panel1.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 410);
            this.panel2.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Location = new System.Drawing.Point(394, 209);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 48);
            this.label23.TabIndex = 4;
            this.label23.Text = "Binary:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Visible = false;
            // 
            // chkboxUnEnbleUpCamera
            // 
            this.chkboxUnEnbleUpCamera.AutoSize = true;
            this.chkboxUnEnbleUpCamera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkboxUnEnbleUpCamera.Location = new System.Drawing.Point(459, 337);
            this.chkboxUnEnbleUpCamera.Name = "chkboxUnEnbleUpCamera";
            this.chkboxUnEnbleUpCamera.Size = new System.Drawing.Size(223, 30);
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
            this.label17.Location = new System.Drawing.Point(722, 90);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 37);
            this.label17.TabIndex = 3;
            this.label17.Text = "(0.1~1.0)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Location = new System.Drawing.Point(722, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 48);
            this.label15.TabIndex = 3;
            this.label15.Text = "mm";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveCheckPra
            // 
            this.btnSaveCheckPra.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCheckPra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveCheckPra.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCheckPra.Location = new System.Drawing.Point(81, 283);
            this.btnSaveCheckPra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveCheckPra.Name = "btnSaveCheckPra";
            this.btnSaveCheckPra.Size = new System.Drawing.Size(357, 107);
            this.btnSaveCheckPra.TabIndex = 2;
            this.btnSaveCheckPra.Text = "Set";
            this.btnSaveCheckPra.UseVisualStyleBackColor = false;
            this.btnSaveCheckPra.Click += new System.EventHandler(this.btnSaveCheckPra_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(317, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 48);
            this.label13.TabIndex = 3;
            this.label13.Text = "mm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThresholdValue
            // 
            this.txtThresholdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThresholdValue.Location = new System.Drawing.Point(540, 211);
            this.txtThresholdValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(172, 44);
            this.txtThresholdValue.TabIndex = 0;
            this.txtThresholdValue.Visible = false;
            // 
            // txtMatchValue
            // 
            this.txtMatchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatchValue.Location = new System.Drawing.Point(540, 85);
            this.txtMatchValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMatchValue.Name = "txtMatchValue";
            this.txtMatchValue.Size = new System.Drawing.Size(172, 44);
            this.txtMatchValue.TabIndex = 1;
            // 
            // txtScale
            // 
            this.txtScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtScale.Location = new System.Drawing.Point(171, 211);
            this.txtScale.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(136, 44);
            this.txtScale.TabIndex = 1;
            // 
            // txtRightOffset
            // 
            this.txtRightOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRightOffset.Location = new System.Drawing.Point(540, 144);
            this.txtRightOffset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRightOffset.Name = "txtRightOffset";
            this.txtRightOffset.Size = new System.Drawing.Size(172, 44);
            this.txtRightOffset.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label22.Location = new System.Drawing.Point(49, 207);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 48);
            this.label22.TabIndex = 2;
            this.label22.Text = "Scale:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDownOffset
            // 
            this.txtDownOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDownOffset.Location = new System.Drawing.Point(171, 138);
            this.txtDownOffset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDownOffset.Name = "txtDownOffset";
            this.txtDownOffset.Size = new System.Drawing.Size(136, 44);
            this.txtDownOffset.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(416, 85);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 48);
            this.label18.TabIndex = 2;
            this.label18.Text = "Score:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Location = new System.Drawing.Point(385, 144);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 48);
            this.label16.TabIndex = 2;
            this.label16.Text = "Right:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(17, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 48);
            this.label14.TabIndex = 2;
            this.label14.Text = "Down:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(739, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 48);
            this.label10.TabIndex = 3;
            this.label10.Text = "o";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(317, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 48);
            this.label8.TabIndex = 3;
            this.label8.Text = "mm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label19.Location = new System.Drawing.Point(317, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 48);
            this.label19.TabIndex = 3;
            this.label19.Text = "mm";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAngleOffset
            // 
            this.txtAngleOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAngleOffset.Location = new System.Drawing.Point(540, 15);
            this.txtAngleOffset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAngleOffset.Name = "txtAngleOffset";
            this.txtAngleOffset.Size = new System.Drawing.Size(172, 44);
            this.txtAngleOffset.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(409, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 48);
            this.label11.TabIndex = 2;
            this.label11.Text = "Angle:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLeftOffset
            // 
            this.txtLeftOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLeftOffset.Location = new System.Drawing.Point(171, 77);
            this.txtLeftOffset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLeftOffset.Name = "txtLeftOffset";
            this.txtLeftOffset.Size = new System.Drawing.Size(136, 44);
            this.txtLeftOffset.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(10, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 48);
            this.label9.TabIndex = 2;
            this.label9.Text = "Left:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpOffset
            // 
            this.txtUpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUpOffset.Location = new System.Drawing.Point(171, 15);
            this.txtUpOffset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpOffset.Name = "txtUpOffset";
            this.txtUpOffset.Size = new System.Drawing.Size(136, 44);
            this.txtUpOffset.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label20.Location = new System.Drawing.Point(10, 8);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 48);
            this.label20.TabIndex = 2;
            this.label20.Text = "Upper:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(0, 482);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limit Set";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.txtUpExposureTime);
            this.panel11.Controls.Add(this.txtUpCameraTime);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.btnSaveCameraPra);
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.txtDelaySendTime);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.txtUpCameraGain);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel11.Location = new System.Drawing.Point(0, 69);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(898, 413);
            this.panel11.TabIndex = 1;
            // 
            // txtUpExposureTime
            // 
            this.txtUpExposureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUpExposureTime.Location = new System.Drawing.Point(236, 142);
            this.txtUpExposureTime.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpExposureTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtUpExposureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUpExposureTime.Name = "txtUpExposureTime";
            this.txtUpExposureTime.Size = new System.Drawing.Size(200, 69);
            this.txtUpExposureTime.TabIndex = 10;
            this.txtUpExposureTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtUpCameraTime
            // 
            this.txtUpCameraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUpCameraTime.Location = new System.Drawing.Point(236, 54);
            this.txtUpCameraTime.Margin = new System.Windows.Forms.Padding(6);
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
            this.txtUpCameraTime.Size = new System.Drawing.Size(200, 69);
            this.txtUpCameraTime.TabIndex = 9;
            this.txtUpCameraTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Location = new System.Drawing.Point(452, 297);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 48);
            this.label24.TabIndex = 8;
            this.label24.Text = "ms";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.Visible = false;
            // 
            // btnSaveCameraPra
            // 
            this.btnSaveCameraPra.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCameraPra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveCameraPra.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCameraPra.Location = new System.Drawing.Point(601, 56);
            this.btnSaveCameraPra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveCameraPra.Name = "btnSaveCameraPra";
            this.btnSaveCameraPra.Size = new System.Drawing.Size(276, 293);
            this.btnSaveCameraPra.TabIndex = 1;
            this.btnSaveCameraPra.Text = "Set";
            this.btnSaveCameraPra.UseVisualStyleBackColor = false;
            this.btnSaveCameraPra.Click += new System.EventHandler(this.btnSaveCameraPra_Click_1);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label21.Location = new System.Drawing.Point(4, 294);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 48);
            this.label21.TabIndex = 4;
            this.label21.Text = "Send Delay:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Visible = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 48);
            this.label12.TabIndex = 2;
            this.label12.Text = "GrabDelay:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDelaySendTime
            // 
            this.txtDelaySendTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDelaySendTime.Location = new System.Drawing.Point(236, 297);
            this.txtDelaySendTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDelaySendTime.Name = "txtDelaySendTime";
            this.txtDelaySendTime.Size = new System.Drawing.Size(202, 51);
            this.txtDelaySendTime.TabIndex = 1;
            this.txtDelaySendTime.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(444, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "(1~20)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exposure:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(444, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "us";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(94, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 48);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gain:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(446, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUpCameraGain
            // 
            this.txtUpCameraGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUpCameraGain.Location = new System.Drawing.Point(236, 226);
            this.txtUpCameraGain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpCameraGain.Name = "txtUpCameraGain";
            this.txtUpCameraGain.Size = new System.Drawing.Size(202, 51);
            this.txtUpCameraGain.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(898, 69);
            this.label6.TabIndex = 2;
            this.label6.Text = "Up Camera Parameter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel48);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 1130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DownCameraParameter";
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
            this.panel48.Location = new System.Drawing.Point(3, 3);
            this.panel48.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(898, 378);
            this.panel48.TabIndex = 20;
            // 
            // chkboxUnEnbleDownCamera
            // 
            this.chkboxUnEnbleDownCamera.AutoSize = true;
            this.chkboxUnEnbleDownCamera.Checked = true;
            this.chkboxUnEnbleDownCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxUnEnbleDownCamera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkboxUnEnbleDownCamera.Location = new System.Drawing.Point(362, 289);
            this.chkboxUnEnbleDownCamera.Name = "chkboxUnEnbleDownCamera";
            this.chkboxUnEnbleDownCamera.Size = new System.Drawing.Size(245, 29);
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
            this.btnSaveDownCameraPra.Location = new System.Drawing.Point(12, 254);
            this.btnSaveDownCameraPra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveDownCameraPra.Name = "btnSaveDownCameraPra";
            this.btnSaveDownCameraPra.Size = new System.Drawing.Size(298, 108);
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
            this.panel52.Location = new System.Drawing.Point(0, 154);
            this.panel52.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel52.Name = "panel52";
            this.panel52.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel52.Size = new System.Drawing.Size(898, 75);
            this.panel52.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Font = new System.Drawing.Font("Arial", 12F);
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(6, 4);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.label26.Size = new System.Drawing.Size(271, 67);
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
            this.txtDownExposureTime.Location = new System.Drawing.Point(302, 13);
            this.txtDownExposureTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDownExposureTime.Name = "txtDownExposureTime";
            this.txtDownExposureTime.Size = new System.Drawing.Size(584, 56);
            this.txtDownExposureTime.TabIndex = 1;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.label27);
            this.panel49.Controls.Add(this.txtDownCameraTime);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel49.Location = new System.Drawing.Point(0, 79);
            this.panel49.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel49.Name = "panel49";
            this.panel49.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel49.Size = new System.Drawing.Size(898, 75);
            this.panel49.TabIndex = 11;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Font = new System.Drawing.Font("Arial", 12F);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(6, 4);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.label27.Size = new System.Drawing.Size(288, 67);
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
            this.txtDownCameraTime.Location = new System.Drawing.Point(302, 13);
            this.txtDownCameraTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDownCameraTime.Name = "txtDownCameraTime";
            this.txtDownCameraTime.Size = new System.Drawing.Size(584, 56);
            this.txtDownCameraTime.TabIndex = 1;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.label28);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel61.Name = "panel61";
            this.panel61.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel61.Size = new System.Drawing.Size(898, 79);
            this.panel61.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(6, 4);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(886, 71);
            this.label28.TabIndex = 1;
            this.label28.Text = "DownCameraParameter";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkShowEable);
            this.tabPage3.Controls.Add(this.btnResetDay);
            this.tabPage3.Controls.Add(this.panel23);
            this.tabPage3.Controls.Add(this.panel22);
            this.tabPage3.Controls.Add(this.lbOI);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 1130);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Production";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkShowEable
            // 
            this.chkShowEable.AutoSize = true;
            this.chkShowEable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkShowEable.Location = new System.Drawing.Point(331, 260);
            this.chkShowEable.Name = "chkShowEable";
            this.chkShowEable.Size = new System.Drawing.Size(185, 29);
            this.chkShowEable.TabIndex = 34;
            this.chkShowEable.Text = "ShowMessage";
            this.chkShowEable.UseVisualStyleBackColor = true;
            this.chkShowEable.Visible = false;
            this.chkShowEable.CheckedChanged += new System.EventHandler(this.chkShowEable_CheckedChanged);
            // 
            // btnResetDay
            // 
            this.btnResetDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetDay.Location = new System.Drawing.Point(2, 239);
            this.btnResetDay.Name = "btnResetDay";
            this.btnResetDay.Size = new System.Drawing.Size(308, 69);
            this.btnResetDay.TabIndex = 32;
            this.btnResetDay.Text = "Reset";
            this.btnResetDay.UseVisualStyleBackColor = true;
            this.btnResetDay.Click += new System.EventHandler(this.btnResetDay_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label29);
            this.panel23.Controls.Add(this.txtCurrentSaveDay);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(3, 153);
            this.panel23.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel23.Size = new System.Drawing.Size(898, 75);
            this.panel23.TabIndex = 31;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Left;
            this.label29.Font = new System.Drawing.Font("Arial", 12F);
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(6, 4);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.label29.Size = new System.Drawing.Size(271, 67);
            this.label29.TabIndex = 0;
            this.label29.Text = "CurrentSaveDay:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentSaveDay
            // 
            this.txtCurrentSaveDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentSaveDay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCurrentSaveDay.Location = new System.Drawing.Point(302, 13);
            this.txtCurrentSaveDay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCurrentSaveDay.Name = "txtCurrentSaveDay";
            this.txtCurrentSaveDay.Size = new System.Drawing.Size(584, 56);
            this.txtCurrentSaveDay.TabIndex = 1;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.cmbSaveNgDay);
            this.panel22.Controls.Add(this.label30);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(3, 68);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel22.Size = new System.Drawing.Size(898, 85);
            this.panel22.TabIndex = 30;
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
            this.cmbSaveNgDay.Location = new System.Drawing.Point(302, 14);
            this.cmbSaveNgDay.Name = "cmbSaveNgDay";
            this.cmbSaveNgDay.Size = new System.Drawing.Size(324, 57);
            this.cmbSaveNgDay.TabIndex = 1;
            this.cmbSaveNgDay.SelectedIndexChanged += new System.EventHandler(this.cmbSaveNgDay_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Left;
            this.label30.Font = new System.Drawing.Font("Arial", 13.875F);
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(6, 4);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.label30.Size = new System.Drawing.Size(289, 77);
            this.label30.TabIndex = 0;
            this.label30.Text = "NGSaveDay:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOI
            // 
            this.lbOI.BackColor = System.Drawing.Color.Transparent;
            this.lbOI.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbOI.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbOI.ForeColor = System.Drawing.Color.Black;
            this.lbOI.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbOI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbOI.Location = new System.Drawing.Point(3, 3);
            this.lbOI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOI.Name = "lbOI";
            this.lbOI.Size = new System.Drawing.Size(898, 65);
            this.lbOI.TabIndex = 23;
            this.lbOI.Text = "Production";
            this.lbOI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 1177);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Setting";
            this.Text = "Set";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpExposureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCameraTime)).EndInit();
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
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
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
        private Label label24;
        public TextBox txtDelaySendTime;
        private Label label5;
        private Label label3;
        private Label label2;
        public TextBox txtUpCameraGain;
        private Panel panel48;
        private Panel panel52;
        private Panel panel49;
        private Panel panel61;
        private Panel panel23;
        private Panel panel22;
        public TextBox txtDownExposureTime;
        public TextBox txtDownCameraTime;
        public TextBox txtCurrentSaveDay;
        public ComboBox cmbSaveNgDay;
        public CheckBox chkboxUnEnbleDownCamera;
        public CheckBox chkShowEable;
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
        public Button btnSaveCameraPra;
        public Label label21;
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
        public Label lbOI;
    }
}