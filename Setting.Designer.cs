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
            panel1 = new Panel();
            panel2 = new Panel();
            label23 = new Label();
            label17 = new Label();
            label15 = new Label();
            btnSaveCheckPra = new Button();
            label13 = new Label();
            txtThresholdValue = new TextBox();
            txtMatchValue = new TextBox();
            txtScale = new TextBox();
            txtRightOffset = new TextBox();
            label22 = new Label();
            txtDownOffset = new TextBox();
            label18 = new Label();
            label16 = new Label();
            label14 = new Label();
            label10 = new Label();
            label8 = new Label();
            label19 = new Label();
            txtAngleOffset = new TextBox();
            label11 = new Label();
            txtLeftOffset = new TextBox();
            label9 = new Label();
            txtUpOffset = new TextBox();
            label20 = new Label();
            label1 = new Label();
            panel11 = new Panel();
            numeUpGrabDelay = new NumericUpDown();
            label24 = new Label();
            btnConnect = new Button();
            btnSearch = new Button();
            cbDeviceList = new ComboBox();
            btnSaveCameraPra = new Button();
            label21 = new Label();
            label12 = new Label();
            txtDelaySendTime = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtUpCameraGain = new TextBox();
            label6 = new Label();
            numUpExposureTime = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpGrabDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpExposureTime).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 599);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(btnSaveCheckPra);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtThresholdValue);
            panel2.Controls.Add(txtMatchValue);
            panel2.Controls.Add(txtScale);
            panel2.Controls.Add(txtRightOffset);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(txtDownOffset);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txtAngleOffset);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtLeftOffset);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtUpOffset);
            panel2.Controls.Add(label20);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 255);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label23
            // 
            label23.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ImageAlign = ContentAlignment.TopCenter;
            label23.Location = new Point(246, 88);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(57, 29);
            label23.TabIndex = 4;
            label23.Text = "Binary:";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ImageAlign = ContentAlignment.TopCenter;
            label17.Location = new Point(421, 54);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 3;
            label17.Text = "(0.1~1.0)";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ImageAlign = ContentAlignment.TopCenter;
            label15.Location = new Point(154, 126);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(50, 29);
            label15.TabIndex = 3;
            label15.Text = "mm";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveCheckPra
            // 
            btnSaveCheckPra.BackColor = Color.Transparent;
            btnSaveCheckPra.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCheckPra.ForeColor = Color.Black;
            btnSaveCheckPra.Location = new Point(69, 175);
            btnSaveCheckPra.Margin = new Padding(2, 1, 2, 1);
            btnSaveCheckPra.Name = "btnSaveCheckPra";
            btnSaveCheckPra.Size = new Size(348, 42);
            btnSaveCheckPra.TabIndex = 2;
            btnSaveCheckPra.Text = "Set";
            btnSaveCheckPra.UseVisualStyleBackColor = false;
            btnSaveCheckPra.Click += btnSaveCheckPra_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ImageAlign = ContentAlignment.TopCenter;
            label13.Location = new Point(154, 86);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(50, 29);
            label13.TabIndex = 3;
            label13.Text = "mm";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtThresholdValue
            // 
            txtThresholdValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtThresholdValue.Location = new Point(315, 89);
            txtThresholdValue.Margin = new Padding(2, 1, 2, 1);
            txtThresholdValue.Name = "txtThresholdValue";
            txtThresholdValue.Size = new Size(102, 26);
            txtThresholdValue.TabIndex = 0;
            txtThresholdValue.Visible = false;
            // 
            // txtMatchValue
            // 
            txtMatchValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatchValue.Location = new Point(315, 51);
            txtMatchValue.Margin = new Padding(2, 1, 2, 1);
            txtMatchValue.Name = "txtMatchValue";
            txtMatchValue.Size = new Size(102, 26);
            txtMatchValue.TabIndex = 1;
            // 
            // txtScale
            // 
            txtScale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtScale.Location = new Point(315, 127);
            txtScale.Margin = new Padding(2, 1, 2, 1);
            txtScale.Name = "txtScale";
            txtScale.Size = new Size(102, 26);
            txtScale.TabIndex = 1;
            // 
            // txtRightOffset
            // 
            txtRightOffset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRightOffset.Location = new Point(69, 125);
            txtRightOffset.Margin = new Padding(2, 1, 2, 1);
            txtRightOffset.Name = "txtRightOffset";
            txtRightOffset.Size = new Size(81, 26);
            txtRightOffset.TabIndex = 1;
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ImageAlign = ContentAlignment.TopCenter;
            label22.Location = new Point(237, 128);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(66, 29);
            label22.TabIndex = 2;
            label22.Text = "Scale:";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDownOffset
            // 
            txtDownOffset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDownOffset.Location = new Point(69, 83);
            txtDownOffset.Margin = new Padding(2, 1, 2, 1);
            txtDownOffset.Name = "txtDownOffset";
            txtDownOffset.Size = new Size(81, 26);
            txtDownOffset.TabIndex = 1;
            // 
            // label18
            // 
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ImageAlign = ContentAlignment.TopCenter;
            label18.Location = new Point(246, 54);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(57, 29);
            label18.TabIndex = 2;
            label18.Text = "Score:";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ImageAlign = ContentAlignment.TopCenter;
            label16.Location = new Point(9, 125);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 29);
            label16.TabIndex = 2;
            label16.Text = "Right:";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(-20, 85);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(77, 29);
            label14.TabIndex = 2;
            label14.Text = "Down:";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.TopLeft;
            label10.Location = new Point(443, 9);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 29);
            label10.TabIndex = 3;
            label10.Text = "o";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(154, 43);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 29);
            label8.TabIndex = 3;
            label8.Text = "mm";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ImageAlign = ContentAlignment.TopCenter;
            label19.Location = new Point(154, 6);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(50, 29);
            label19.TabIndex = 3;
            label19.Text = "mm";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAngleOffset
            // 
            txtAngleOffset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAngleOffset.Location = new Point(315, 9);
            txtAngleOffset.Margin = new Padding(2, 1, 2, 1);
            txtAngleOffset.Name = "txtAngleOffset";
            txtAngleOffset.Size = new Size(102, 26);
            txtAngleOffset.TabIndex = 1;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(246, 11);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(59, 29);
            label11.TabIndex = 2;
            label11.Text = "Angle:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLeftOffset
            // 
            txtLeftOffset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLeftOffset.Location = new Point(69, 46);
            txtLeftOffset.Margin = new Padding(2, 1, 2, 1);
            txtLeftOffset.Name = "txtLeftOffset";
            txtLeftOffset.Size = new Size(81, 26);
            txtLeftOffset.TabIndex = 1;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(6, 46);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 29);
            label9.TabIndex = 2;
            label9.Text = "Left:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUpOffset
            // 
            txtUpOffset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpOffset.Location = new Point(69, 9);
            txtUpOffset.Margin = new Padding(2, 1, 2, 1);
            txtUpOffset.Name = "txtUpOffset";
            txtUpOffset.Size = new Size(81, 26);
            txtUpOffset.TabIndex = 1;
            // 
            // label20
            // 
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ImageAlign = ContentAlignment.TopCenter;
            label20.Location = new Point(6, 5);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(59, 29);
            label20.TabIndex = 2;
            label20.Text = "Upper:";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 289);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(507, 46);
            label1.TabIndex = 2;
            label1.Text = "Limit Set";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(numUpExposureTime);
            panel11.Controls.Add(numeUpGrabDelay);
            panel11.Controls.Add(label24);
            panel11.Controls.Add(btnConnect);
            panel11.Controls.Add(btnSearch);
            panel11.Controls.Add(cbDeviceList);
            panel11.Controls.Add(btnSaveCameraPra);
            panel11.Controls.Add(label21);
            panel11.Controls.Add(label12);
            panel11.Controls.Add(txtDelaySendTime);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(label3);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label2);
            panel11.Controls.Add(txtUpCameraGain);
            panel11.Dock = DockStyle.Top;
            panel11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel11.Location = new Point(0, 41);
            panel11.Margin = new Padding(2, 1, 2, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(507, 248);
            panel11.TabIndex = 1;
            // 
            // numeUpGrabDelay
            // 
            numeUpGrabDelay.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeUpGrabDelay.Location = new Point(115, 49);
            numeUpGrabDelay.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numeUpGrabDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeUpGrabDelay.Name = "numeUpGrabDelay";
            numeUpGrabDelay.Size = new Size(117, 38);
            numeUpGrabDelay.TabIndex = 9;
            numeUpGrabDelay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label24
            // 
            label24.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ImageAlign = ContentAlignment.TopCenter;
            label24.Location = new Point(242, 179);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(60, 29);
            label24.TabIndex = 8;
            label24.Text = "ms";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnect.ImeMode = ImeMode.NoControl;
            btnConnect.Location = new Point(315, 6);
            btnConnect.Margin = new Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(164, 41);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Image = Properties.Resources.Search;
            btnSearch.ImeMode = ImeMode.NoControl;
            btnSearch.Location = new Point(242, 6);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 41);
            btnSearch.TabIndex = 5;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbDeviceList
            // 
            cbDeviceList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeviceList.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbDeviceList.FormattingEnabled = true;
            cbDeviceList.Location = new Point(6, 6);
            cbDeviceList.Margin = new Padding(4, 3, 4, 3);
            cbDeviceList.Name = "cbDeviceList";
            cbDeviceList.Size = new Size(230, 41);
            cbDeviceList.TabIndex = 6;
            // 
            // btnSaveCameraPra
            // 
            btnSaveCameraPra.BackColor = Color.Transparent;
            btnSaveCameraPra.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCameraPra.ForeColor = Color.Black;
            btnSaveCameraPra.Location = new Point(318, 55);
            btnSaveCameraPra.Margin = new Padding(2, 1, 2, 1);
            btnSaveCameraPra.Name = "btnSaveCameraPra";
            btnSaveCameraPra.Size = new Size(161, 154);
            btnSaveCameraPra.TabIndex = 1;
            btnSaveCameraPra.Text = "Set";
            btnSaveCameraPra.UseVisualStyleBackColor = false;
            btnSaveCameraPra.Click += btnSaveCameraPra_Click;
            // 
            // label21
            // 
            label21.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ImageAlign = ContentAlignment.TopCenter;
            label21.Location = new Point(6, 180);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(108, 29);
            label21.TabIndex = 4;
            label21.Text = "Send Delay";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(6, 58);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(108, 29);
            label12.TabIndex = 2;
            label12.Text = "GrabDelay:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDelaySendTime
            // 
            txtDelaySendTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDelaySendTime.Location = new Point(115, 179);
            txtDelaySendTime.Margin = new Padding(2, 1, 2, 1);
            txtDelaySendTime.Name = "txtDelaySendTime";
            txtDelaySendTime.Size = new Size(119, 29);
            txtDelaySendTime.TabIndex = 1;
            txtDelaySendTime.Visible = false;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(237, 138);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 29);
            label5.TabIndex = 3;
            label5.Text = "(1~20)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(6, 95);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 29);
            label4.TabIndex = 2;
            label4.Text = "Exposure:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(237, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 3;
            label3.Text = "us";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(33, 141);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 29);
            label7.TabIndex = 2;
            label7.Text = "Gain:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(238, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 29);
            label2.TabIndex = 3;
            label2.Text = "ms";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpCameraGain
            // 
            txtUpCameraGain.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpCameraGain.Location = new Point(115, 136);
            txtUpCameraGain.Margin = new Padding(2, 1, 2, 1);
            txtUpCameraGain.Name = "txtUpCameraGain";
            txtUpCameraGain.Size = new Size(119, 29);
            txtUpCameraGain.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(507, 41);
            label6.TabIndex = 2;
            label6.Text = "Camera Parameter";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numUpExposureTime
            // 
            numUpExposureTime.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numUpExposureTime.Location = new Point(115, 90);
            numUpExposureTime.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numUpExposureTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpExposureTime.Name = "numUpExposureTime";
            numUpExposureTime.Size = new Size(117, 38);
            numUpExposureTime.TabIndex = 10;
            numUpExposureTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 599);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Setting";
            Text = "Set";
            FormClosing += Set_FormClosing;
            Load += Set_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeUpGrabDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpExposureTime).EndInit();
            ResumeLayout(false);
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
        private NumericUpDown numeUpGrabDelay;
        private NumericUpDown numUpExposureTime;
    }
}