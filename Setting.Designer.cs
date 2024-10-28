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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
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
            this.numUpExposureTime = new System.Windows.Forms.NumericUpDown();
            this.numeUpGrabDelay = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpExposureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeUpGrabDelay)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label23);
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
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 221);
            this.panel2.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Location = new System.Drawing.Point(211, 76);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 25);
            this.label23.TabIndex = 4;
            this.label23.Text = "Binary:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label17.Location = new System.Drawing.Point(361, 47);
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
            this.label15.Location = new System.Drawing.Point(132, 109);
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
            this.btnSaveCheckPra.Location = new System.Drawing.Point(59, 152);
            this.btnSaveCheckPra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveCheckPra.Name = "btnSaveCheckPra";
            this.btnSaveCheckPra.Size = new System.Drawing.Size(298, 36);
            this.btnSaveCheckPra.TabIndex = 2;
            this.btnSaveCheckPra.Text = "Set";
            this.btnSaveCheckPra.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(132, 75);
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
            this.txtThresholdValue.Location = new System.Drawing.Point(270, 77);
            this.txtThresholdValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(88, 26);
            this.txtThresholdValue.TabIndex = 0;
            this.txtThresholdValue.Visible = false;
            // 
            // txtMatchValue
            // 
            this.txtMatchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatchValue.Location = new System.Drawing.Point(270, 44);
            this.txtMatchValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMatchValue.Name = "txtMatchValue";
            this.txtMatchValue.Size = new System.Drawing.Size(88, 26);
            this.txtMatchValue.TabIndex = 1;
            // 
            // txtScale
            // 
            this.txtScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtScale.Location = new System.Drawing.Point(270, 110);
            this.txtScale.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(88, 26);
            this.txtScale.TabIndex = 1;
            // 
            // txtRightOffset
            // 
            this.txtRightOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRightOffset.Location = new System.Drawing.Point(59, 108);
            this.txtRightOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRightOffset.Name = "txtRightOffset";
            this.txtRightOffset.Size = new System.Drawing.Size(70, 26);
            this.txtRightOffset.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label22.Location = new System.Drawing.Point(203, 111);
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
            this.txtDownOffset.Location = new System.Drawing.Point(59, 72);
            this.txtDownOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDownOffset.Name = "txtDownOffset";
            this.txtDownOffset.Size = new System.Drawing.Size(70, 26);
            this.txtDownOffset.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(211, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "Score:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Location = new System.Drawing.Point(8, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Right:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(-17, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Down:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(380, 8);
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
            this.label8.Location = new System.Drawing.Point(132, 37);
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
            this.label19.Location = new System.Drawing.Point(132, 5);
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
            this.txtAngleOffset.Location = new System.Drawing.Point(270, 8);
            this.txtAngleOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAngleOffset.Name = "txtAngleOffset";
            this.txtAngleOffset.Size = new System.Drawing.Size(88, 26);
            this.txtAngleOffset.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(211, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Angle:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLeftOffset
            // 
            this.txtLeftOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLeftOffset.Location = new System.Drawing.Point(59, 40);
            this.txtLeftOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLeftOffset.Name = "txtLeftOffset";
            this.txtLeftOffset.Size = new System.Drawing.Size(70, 26);
            this.txtLeftOffset.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(5, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Left:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpOffset
            // 
            this.txtUpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUpOffset.Location = new System.Drawing.Point(59, 8);
            this.txtUpOffset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUpOffset.Name = "txtUpOffset";
            this.txtUpOffset.Size = new System.Drawing.Size(70, 26);
            this.txtUpOffset.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label20.Location = new System.Drawing.Point(5, 4);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Upper:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(0, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limit Set";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.numUpExposureTime);
            this.panel11.Controls.Add(this.numeUpGrabDelay);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.btnConnect);
            this.panel11.Controls.Add(this.btnSearch);
            this.panel11.Controls.Add(this.cbDeviceList);
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
            this.panel11.Location = new System.Drawing.Point(0, 36);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(435, 215);
            this.panel11.TabIndex = 1;
            // 
            // numUpExposureTime
            // 
            this.numUpExposureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.numUpExposureTime.Location = new System.Drawing.Point(99, 78);
            this.numUpExposureTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpExposureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpExposureTime.Name = "numUpExposureTime";
            this.numUpExposureTime.Size = new System.Drawing.Size(100, 38);
            this.numUpExposureTime.TabIndex = 10;
            this.numUpExposureTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeUpGrabDelay
            // 
            this.numeUpGrabDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.numeUpGrabDelay.Location = new System.Drawing.Point(99, 42);
            this.numeUpGrabDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeUpGrabDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeUpGrabDelay.Name = "numeUpGrabDelay";
            this.numeUpGrabDelay.Size = new System.Drawing.Size(100, 38);
            this.numeUpGrabDelay.TabIndex = 9;
            this.numeUpGrabDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Location = new System.Drawing.Point(207, 155);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 25);
            this.label24.TabIndex = 8;
            this.label24.Text = "ms";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.Location = new System.Drawing.Point(270, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 36);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.Image = global::AD_RFID.Properties.Resources.Search;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(207, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(5, 5);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(198, 41);
            this.cbDeviceList.TabIndex = 6;
            // 
            // btnSaveCameraPra
            // 
            this.btnSaveCameraPra.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCameraPra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveCameraPra.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCameraPra.Location = new System.Drawing.Point(273, 48);
            this.btnSaveCameraPra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveCameraPra.Name = "btnSaveCameraPra";
            this.btnSaveCameraPra.Size = new System.Drawing.Size(138, 133);
            this.btnSaveCameraPra.TabIndex = 1;
            this.btnSaveCameraPra.Text = "Set";
            this.btnSaveCameraPra.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label21.Location = new System.Drawing.Point(5, 156);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 25);
            this.label21.TabIndex = 4;
            this.label21.Text = "Send Delay";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(5, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "GrabDelay:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDelaySendTime
            // 
            this.txtDelaySendTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDelaySendTime.Location = new System.Drawing.Point(99, 155);
            this.txtDelaySendTime.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDelaySendTime.Name = "txtDelaySendTime";
            this.txtDelaySendTime.Size = new System.Drawing.Size(103, 29);
            this.txtDelaySendTime.TabIndex = 1;
            this.txtDelaySendTime.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(203, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "(1~20)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exposure:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(203, 82);
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
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(28, 122);
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
            this.label2.Location = new System.Drawing.Point(204, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUpCameraGain
            // 
            this.txtUpCameraGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUpCameraGain.Location = new System.Drawing.Point(99, 118);
            this.txtUpCameraGain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUpCameraGain.Name = "txtUpCameraGain";
            this.txtUpCameraGain.Size = new System.Drawing.Size(103, 29);
            this.txtUpCameraGain.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Camera Parameter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 519);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Setting";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpExposureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeUpGrabDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSaveCameraPra;
        private Label label12;
        private Label label2;
        private TextBox txtUpCameraGain;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label4;
        private TextBox txtMatchValue;
        private Label label17;
        private Label label18;
        private TextBox txtRightOffset;
        private Label label15;
        private Label label16;
        private TextBox txtDownOffset;
        private Label label13;
        private Label label14;
        private TextBox txtAngleOffset;
        private Label label10;
        private Label label11;
        private TextBox txtLeftOffset;
        private Label label8;
        private Label label9;
        private TextBox txtUpOffset;
        private Label label19;
        private Label label20;
        private Button btnSaveCheckPra;
        private TextBox txtDelaySendTime;
        private TextBox txtThresholdValue;
        private TextBox txtScale;
        private Label label22;
        private Panel panel11;
        private Label label21;
        private Label label6;
        private Panel panel2;
        private Label label23;
        private Button btnConnect;
        private Button btnSearch;
        public ComboBox cbDeviceList;
        private Label label24;
        public NumericUpDown numeUpGrabDelay;
        public NumericUpDown numUpExposureTime;
    }
}