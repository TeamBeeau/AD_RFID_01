
namespace AD_RFID
{
    partial class ucReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProcess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.ProgressBar();
            this.btnReport = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckRaw = new System.Windows.Forms.CheckBox();
            this.ckDetail = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckOK = new System.Windows.Forms.CheckBox();
            this.ckNG = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnIsModel = new System.Windows.Forms.Button();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.wExport = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbProcess);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.process);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 91);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.ForeColor = System.Drawing.Color.White;
            this.lbProcess.Location = new System.Drawing.Point(1133, 114);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(38, 25);
            this.lbProcess.TabIndex = 15;
            this.lbProcess.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1169, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(7, 68);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(973, 20);
            this.process.TabIndex = 16;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Image = global::AD_RFID.Properties.Resources.Export;
            this.btnReport.Location = new System.Drawing.Point(825, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(153, 56);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Xuất dữ liệu";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(7, 27);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(316, 34);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "00000";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTotal.Visible = false;
            this.lbTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(329, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "pcs";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng sản lượng";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckRaw);
            this.groupBox1.Controls.Add(this.ckDetail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(376, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Cần xuất";
            // 
            // ckRaw
            // 
            this.ckRaw.CausesValidation = false;
            this.ckRaw.Checked = true;
            this.ckRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRaw.ForeColor = System.Drawing.Color.Blue;
            this.ckRaw.Location = new System.Drawing.Point(139, 21);
            this.ckRaw.Name = "ckRaw";
            this.ckRaw.Size = new System.Drawing.Size(120, 24);
            this.ckRaw.TabIndex = 12;
            this.ckRaw.Text = "File Hình Gốc";
            this.ckRaw.UseVisualStyleBackColor = true;
            // 
            // ckDetail
            // 
            this.ckDetail.Checked = true;
            this.ckDetail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDetail.Location = new System.Drawing.Point(15, 21);
            this.ckDetail.Name = "ckDetail";
            this.ckDetail.Size = new System.Drawing.Size(109, 24);
            this.ckDetail.TabIndex = 10;
            this.ckDetail.Text = "File Chi tiết";
            this.ckDetail.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.ckOK);
            this.panel3.Controls.Add(this.ckNG);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.dateTime);
            this.panel3.Controls.Add(this.btnDate);
            this.panel3.Controls.Add(this.btnIsModel);
            this.panel3.Controls.Add(this.cbModel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 58);
            this.panel3.TabIndex = 2;
            // 
            // ckOK
            // 
            this.ckOK.AutoSize = true;
            this.ckOK.Checked = true;
            this.ckOK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOK.ForeColor = System.Drawing.Color.SpringGreen;
            this.ckOK.Location = new System.Drawing.Point(792, 3);
            this.ckOK.Name = "ckOK";
            this.ckOK.Size = new System.Drawing.Size(58, 28);
            this.ckOK.TabIndex = 3;
            this.ckOK.Text = "OK";
            this.ckOK.UseVisualStyleBackColor = true;
            this.ckOK.CheckedChanged += new System.EventHandler(this.ckOK_CheckedChanged);
            // 
            // ckNG
            // 
            this.ckNG.AutoSize = true;
            this.ckNG.Checked = true;
            this.ckNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckNG.ForeColor = System.Drawing.Color.OrangeRed;
            this.ckNG.Location = new System.Drawing.Point(791, 27);
            this.ckNG.Name = "ckNG";
            this.ckNG.Size = new System.Drawing.Size(59, 28);
            this.ckNG.TabIndex = 3;
            this.ckNG.Text = "NG";
            this.ckNG.UseVisualStyleBackColor = true;
            this.ckNG.CheckedChanged += new System.EventHandler(this.ckNG_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::AD_RFID.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(895, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 47);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.BackgroundImage = global::AD_RFID.Properties.Resources.Down_Button;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Enabled = false;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(714, 6);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(52, 49);
            this.btnDown.TabIndex = 7;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Enabled = false;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(66, 5);
            this.dateTime.MinDate = new System.DateTime(2019, 10, 10, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(234, 49);
            this.dateTime.TabIndex = 5;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.Green;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Location = new System.Drawing.Point(3, 5);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(60, 50);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnIsModel
            // 
            this.btnIsModel.BackColor = System.Drawing.Color.Silver;
            this.btnIsModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIsModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsModel.ForeColor = System.Drawing.Color.Crimson;
            this.btnIsModel.Location = new System.Drawing.Point(306, 5);
            this.btnIsModel.Name = "btnIsModel";
            this.btnIsModel.Size = new System.Drawing.Size(70, 49);
            this.btnIsModel.TabIndex = 4;
            this.btnIsModel.Text = "PO";
            this.btnIsModel.UseVisualStyleBackColor = false;
            this.btnIsModel.Click += new System.EventHandler(this.btnIsModel_Click);
            // 
            // cbModel
            // 
            this.cbModel.Enabled = false;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(376, 5);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(390, 50);
            this.cbModel.TabIndex = 1;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            this.cbModel.MouseLeave += new System.EventHandler(this.cbModel_MouseLeave);
            // 
            // wExport
            // 
            this.wExport.WorkerReportsProgress = true;
            this.wExport.WorkerSupportsCancellation = true;
            this.wExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wExport_DoWork);
            this.wExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.wExport_ProgressChanged);
            this.wExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wExport_RunWorkerCompleted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 468);
            this.panel2.TabIndex = 3;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.BackgroundColor = System.Drawing.Color.Beige;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowHeadersWidth = 35;
            this.dataView.Size = new System.Drawing.Size(983, 468);
            this.dataView.TabIndex = 0;
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(983, 617);
            this.Load += new System.EventHandler(this.Report_Load);
            this.VisibleChanged += new System.EventHandler(this.Report_VisibleChanged);
            this.Click += new System.EventHandler(this.Report_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckNG;
        private System.Windows.Forms.CheckBox ckOK;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnIsModel;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckRaw;
        private System.Windows.Forms.CheckBox ckDetail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar process;
        private System.ComponentModel.BackgroundWorker wExport;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataView;
    }
}
