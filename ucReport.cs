using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_RFID
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewTextBoxColumn();
            var col4 = new DataGridViewTextBoxColumn();
            var col5 = new DataGridViewTextBoxColumn();
            var col6 = new DataGridViewTextBoxColumn();
            // var col7 = new DataGridViewImageColumn();
            // var col8 = new DataGridViewImageColumn();

            col1.HeaderText = "STT";
            col1.Name = "STT";
            col1.DataPropertyName = "STT";
            col1.Width = 60;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            col2.HeaderText = "Date";
            col2.Name = "Date";
            col2.DataPropertyName = "Date";
            col2.Width = 220;
            col2.DefaultCellStyle.Font = new Font("Arial", 18);
            col2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col3.HeaderText = "PO";
            col3.Name = "PO";
            col3.DataPropertyName = "PO";
            col3.Width = 250;
            col3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col3.DefaultCellStyle.Font = new Font("Arial", 18);
            col3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            col4.HeaderText = "OK";
            col4.Name = "OK";
            col4.DataPropertyName = "OK";
            col4.Width = 140;
            col4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col4.DefaultCellStyle.Font = new Font("Arial", 30, FontStyle.Bold);
            col4.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            col4.DefaultCellStyle.BackColor = Color.LightGray;
            col5.HeaderText = "NG";
            col5.Name = "NG";
            col5.DataPropertyName = "NG";
            col5.Width = 200;
            col5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col5.DefaultCellStyle.Font = new Font("Arial", 30);
            col5.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            col6.HeaderText = "Status";
            col6.Name = "Status";
            col6.DataPropertyName = "Status";
            col6.Width = 120;
            col6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col6.DefaultCellStyle.Font = new Font("Arial", 30);
            col6.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            col6.DefaultCellStyle.ForeColor = Color.White;


            /* col7.HeaderText = "Raw";
             col7.Name = "Raw";
             col7.DataPropertyName = "Raw";
             col7.ImageLayout = DataGridViewImageCellLayout.Stretch;
             col7.Width = 380;

             col8.HeaderText = "Result";
             col8.Name = "Result";
             col8.DataPropertyName = "Result";
             col8.ImageLayout = DataGridViewImageCellLayout.Stretch;
             col8.Width = 380;*/

            dataView.DataSource = null;
            dataView.RowTemplate.Height = 50;
            dataView.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5, col6 });
            //String path = Path.Combine(Environment.CurrentDirectory, "DataReport.mdf");
            // G._pathSqlMaster= @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+path+";Integrated Security=True";

            //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\chitu\Desktop\Nidec_fan_2019_10_19\Checking Number Of Fan version 1.2.261019\Nidec-Kiem Tra Linh Kiện\bin\Release\DataReport.mdf;Integrated Security=True";
        }
        public  void Empty( System.IO.DirectoryInfo directory)
        {
            foreach (System.IO.FileInfo file in directory.GetFiles()) file.Delete();
            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
            directory.Delete();
        }
        public void Connect_SQL()
        {
            

            string nameFileSQL = @"Report\" + DateTime.Now.ToString("yyyyMMdd") + ".mdf";
            if (!File.Exists(nameFileSQL))
            {
                File.Copy(@"Report\Default.mdf", nameFileSQL);
                File.Exists(@"Report\Default.mdf");
            }
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ChiTu\Codes\BeeIV2\bin\Release\Report\Default.mdf;Integrated Security=True;Connect Timeout=30
            String path = Path.Combine(Environment.CurrentDirectory, nameFileSQL);
            G._pathSqlMaster = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30"; ;
            G.cnn = new SqlConnection(G._pathSqlMaster);
           // G.cnn.Close();
            G.cnn.Open();
           

            string resourceDir = Path.Combine(Environment.CurrentDirectory, "Report");
            string[] files = Directory.GetFiles(resourceDir, "*.mdf");
            DateTime dtNow = DateTime.Now;
           foreach(string path2 in files)
            {
                if (path2 .Contains("Default.mdf")) 
                    continue;
                 String Date = Path.GetFileNameWithoutExtension(path2);
                DateTime date2 = DateTime.ParseExact(Date, "yyyyMMdd", null);
                TimeSpan sp = dtNow - date2;
                if(sp.TotalDays> G.Config.LimitDateSave)
                {
                    
                        File.Delete(path2);
                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("Report//" + Date);
                    if(Directory.Exists("Report//" + Date))
                    Empty(directory);
                   
                }
           
            }    
        


        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public void SQL_Delete(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = G._pathSqlMaster;
            SqlCommand command;


            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "DELETE * FROM Report";

            command = new SqlCommand(sql, G.cnn);

            adapter.DeleteCommand = new SqlCommand(sql, G.cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            G.cnn.Close();

        }

        public List<String> SQL_List(int num, DataTable dt)
        {
            List<String> value = new List<String>();
            try
            {
                string[] array = dt.Rows.OfType<DataRow>().Select(k => k[num].ToString()).ToArray();

                foreach (String arr in array)
                {
                    value.Add(arr);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return value;
        }
        public DataTable Table(string Get, string Table, string Where, SqlConnection con)
        {
            DataTable dt = new DataTable();



            String sql = "";
            String desc = "";


            if (Where != "")
                sql = "SELECT " + Get + " FROM " + Table + " WHERE " + Where + desc;
            else
                sql = "SELECT " + Get + " FROM " + Table + "" + desc;
            using (SqlDataAdapter mycommand = new SqlDataAdapter(sql, con))
            {

                DataSet DS = new DataSet();

                mycommand.Fill(DS);
                dt = DS.Tables[0];
            }



            return dt;
        }
        int Toatal = 0, Qty=0;
        DataTable dtPicture = new DataTable();
        DataTable dtPicturers = new DataTable();
       public  DataTable dtAll = new DataTable();
        public void ShowData()
        {
             Qty = 0;
            Toatal = 0;
            String sql = "";
            sql += _sModel;
            if (_sStatus != "" && _sModel != "")
            {
                sql += "AND " + _sStatus;
            }
            else if (_sStatus != "" && _sModel == "")
            {
                sql += _sStatus;
            }

            string resourceDir = Path.Combine(Environment.CurrentDirectory, "Report");
            string[] files = Directory.GetFiles(resourceDir, "*.mdf");
            dtAll = new DataTable();
            //    dtPicture = new DataTable();
            //  dtPicturers = new DataTable();
            G.cnn.Close();
           
            foreach (var file in files)
            {
                SqlConnection con = new SqlConnection();
                if (file.Contains("Default"))
                    continue;
                if (file.Contains("PO"))
                    continue;
                String path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + ";Integrated Security=True;Connect Timeout=30"; ;
                con = new SqlConnection(path);
                con.Open();
              
         
                DataTable dtOne = Table("STT,Date,PO,OK,NG,Status", "Report", sql, con);
                // DataTable dtTwo = Table("Raw", "Report", sql, con);
                // DataTable dtThree = Table("Result", "Report", sql, con);
                dtAll.Merge(dtOne);
                // dtPicture.Merge(dtTwo);
                // dtPicturers.Merge(dtThree);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                con.Close();

            }
            G.cnn.Open();
            dataView.DataSource = dtAll;

            for (int j = 0; j < dataView.Rows.Count; j++)
            {
                if (!dataView.Rows[j].Cells["Date"].Value.ToString().Contains(_sDate))
                {
                    dataView.Rows.RemoveAt(j);
                    j--;
                }
                else if (dataView.Rows[j].Cells["Status"].Value.ToString() == "OK")
                {
                    dataView.Rows[j].Cells["Status"].Style.BackColor = Color.Green;
                }
                else
                {
                    dataView.Rows[j].Cells["Status"].Style.BackColor = Color.DarkRed;

                }
                if (j != -1)
                {
                    // Qty += Convert.ToInt32(dataView.Rows[j].Cells["Qty"].Value.ToString());
                   // Toatal += Convert.ToInt32(dataView.Rows[j].Cells["Total"].Value.ToString());
                }
            }
            //lbQty.Text = Qty + "";
            //lbTotal.Text = Toatal + "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
        void StartOSK()
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            string osk = null;

            if (osk == null)
            {
                osk = Path.Combine(Path.Combine(windir, "sysnative"), "osk.exe");
                if (!File.Exists(osk))
                {
                    osk = null;
                }
            }

            if (osk == null)
            {
                osk = Path.Combine(Path.Combine(windir, "system32"), "osk.exe");
                if (!File.Exists(osk))
                {
                    osk = null;
                }
            }

            if (osk == null)
            {
                osk = "osk.exe";
            }

            Process.Start(osk);
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        String path = "";
        String pathSave = "";
        private void btnReport_Click(object sender, EventArgs e)
        {

            SaveFileDialog fDialog = new SaveFileDialog();
            fDialog.Filter = "excel file |*.xls;*.xlsx";
            fDialog.FilterIndex = 1;
            fDialog.RestoreDirectory = true;

            fDialog.Title = "Lưu dữ liệu Log";
            fDialog.FileName = DateTime.Now.ToString("yyyy_MM_dd");
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                pathSave = fDialog.FileName;
                process.Maximum = dtAll.Rows.Count;
                wExport.RunWorkerAsync();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Report_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (G.cnn.State == ConnectionState.Closed) {
                    Connect_SQL();
                }
                DataTable dt = Table("PO,STT", "Report", "", G.cnn);
                List<String> _listName = SQL_List(0, dt);
                _listName = _listName.Distinct().ToList();
                cbModel.DataSource = _listName;
            }
        }
        public int ExecuteNonQuery(string sql)
        {
            int rowsUpdated = 0;

            using (SqlCommand mycommand = new SqlCommand())
            {
                mycommand.Connection = G.cnn;
                mycommand.CommandText = sql;
                rowsUpdated = mycommand.ExecuteNonQuery();
            }


            return rowsUpdated;

        }
        public bool SQL_DeleteRow(String where)
        {
            Boolean returnCode = true;
            try
            {

                this.ExecuteNonQuery(String.Format("delete from {0} where {1};", "Report", where));
            }
            catch (Exception ex)
            {
                returnCode = false;
            }
            return returnCode;
        }
        int _numPCsReset = 10000;
        public void Loads()
        {
           

        }
        public void Report_Load(object sender, EventArgs e)
        {
            DataTable dt = Table("PO,STT", "Report", "", G.cnn);
            List<String> _listName = SQL_List(0, dt);
            _listName = _listName.Distinct().ToList();
            cbModel.DataSource = _listName;

            String[] sSpilt = dateTime.Value.ToString("MM/dd/yyyy").Split('/');
            int m = Convert.ToInt32(sSpilt[0]);
            int d = Convert.ToInt32(sSpilt[1]);
            int y = Convert.ToInt32(sSpilt[2]);
            _sDate = m + "/" + d + "/" + y;

        }
        bool _isModel = false;
        String _sModel = "";
        private void btnIsModel_Click(object sender, EventArgs e)
        {
            _isModel = !_isModel;
            if (_isModel == true)
            {
                btnIsModel.BackColor = Color.Green;
                btnIsModel.ForeColor = Color.White;
                _sModel = "PO='" + cbModel.Text + "'";
                cbModel.Enabled = true;
                btnDown.Enabled = true;
            }
            else
            {
                btnIsModel.BackColor = Color.Silver;
                btnIsModel.ForeColor = Color.Crimson;
                _sModel = "";
                cbModel.Enabled = false;
                btnDown.Enabled = false;
            }
            //  ShowData();
        }
        bool _isLoad = false;
        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoad)
            {
                _sModel = "PO='" + cbModel.Text + "'";
                // ShowData();
            }
            _isLoad = true;
        }
        String _sDate = "";
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {


            String[] sSpilt = dateTime.Value.ToString("MM/dd/yyyy").Split('/');
            int m = Convert.ToInt32(sSpilt[0]);
            int d = Convert.ToInt32(sSpilt[1]);
            int y = Convert.ToInt32(sSpilt[2]);
            _sDate = m + "/" + d + "/" + y;

            ShowData();
        }
        String _sStatus = "";
        private void ckOK_CheckedChanged(object sender, EventArgs e)
        {
            _sStatus = "";
            if (ckOK.Checked && ckNG.Checked)
            {
                _sStatus = "";
            }
            else if (ckOK.Checked)
            {
                _sStatus = "Status='OK'";
            }
            else if (ckNG.Checked)
            {
                _sStatus = "Status='NG'";
            }
            //  ShowData();
        }

        private void ckNG_CheckedChanged(object sender, EventArgs e)
        {
            _sStatus = "";
            if (ckOK.Checked && ckNG.Checked)
            {
                _sStatus = "";
            }
            else if (ckOK.Checked)
            {
                _sStatus = "Status='OK'";
            }
            else if (ckNG.Checked)
            {
                _sStatus = "Status='NG'";
            }
            //  ShowData();
        }
        bool _isDate = true;
        private void btnDate_Click(object sender, EventArgs e)
        {
            _isDate = !_isDate;
            if (_isDate == true)
            {
                btnDate.BackColor = Color.Green;
                btnDate.ForeColor = Color.White;

                String[] sSpilt = dateTime.Value.ToString("MM/dd/yyyy").Split('/');
                int m = Convert.ToInt32(sSpilt[0]);
                int d = Convert.ToInt32(sSpilt[1]);
                int y = Convert.ToInt32(sSpilt[2]);
                _sDate = m + "/" + d + "/" + y;

                dateTime.Enabled = true;
            }
            else
            {
                btnDate.BackColor = Color.Silver;
                btnDate.ForeColor = Color.Crimson;
                _sDate = "";
                dateTime.Enabled = false;
            }

        }

        private void ckMoth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //G.isTop = false;
            cbModel.DroppedDown = true;
        }
        public void SQL_Delete()
        {
            string sqlTrunc = "TRUNCATE TABLE " + "Report";
            SqlCommand cmd = new SqlCommand(sqlTrunc, G.cnn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = (" DBCC CHECKIDENT('Report', RESEED,0)");
            cmd.ExecuteNonQuery();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon xoa tất cả?", "Delete all",
         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQL_Delete();
                MessageBox.Show("Đã Xóa hết");
            }
        }

        private void cbModel_MouseLeave(object sender, EventArgs e)
        {
           // G.isTop = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void wExport_DoWork(object sender, DoWorkEventArgs e)
        {
            String _sExel = "";
            _sExel += "Report Data " + "\t" + "\t" + "Date : " + DateTime.Now.ToString("yyyy/MM/dd");
            _sExel += Environment.NewLine;
            _sExel += Environment.NewLine;
           
            _sExel += "STT" + "\t" + "DATE" + "\t" + "PO" + "\t" + "OK" + "\t" + "NG" + "\t" + "Status";
            _sExel += Environment.NewLine;
            System.IO.DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(pathSave));

            /*   foreach (FileInfo file in di.GetFiles())
               {
                   file.Delete();
               }
               foreach (DirectoryInfo dir in di.GetDirectories())
               {
                   dir.Delete(true);
               }*/
            String sPicRaw = Path.GetDirectoryName(pathSave) + "\\" + "Raw";
            if (ckRaw.Checked)
                System.IO.Directory.CreateDirectory(sPicRaw);
            String sPicResult = Path.GetDirectoryName(pathSave) + "\\" + "Result";

            G.cnn.Close();
            for (int i = 0; i < dtAll.Rows.Count; i++)
            {
                try
                {
                    for (int j = 0; j < dtAll.Columns.Count; j++)
                    {
                        if (ckDetail.Checked)
                            _sExel += dtAll.Rows[i][j].ToString() + "\t";
                    }
                    _sExel += Environment.NewLine;
                    String sDate = dtAll.Rows[i]["Date"].ToString();
                    DateTime myDate = DateTime.Parse(sDate);
                    string index = dtAll.Rows[i]["STT"].ToString();
                    String day = myDate.Day + "";
                    String morth = myDate.Month + "";
                    String year = myDate.Year + "";
                    if (day.Length < 2) day = "0" + day;
                    if (morth.Length < 2) morth = "0" + morth;
                    String foder = Path.Combine(Environment.CurrentDirectory, "Report\\" + year + morth + day + ".mdf");


                    SqlConnection con;
                    String path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + foder + ";Integrated Security=True;Connect Timeout=30"; ;
                    con = new SqlConnection(path);
                    con.Open();
                    // DataTable dtOne = Table("Raw", "Report", "STT='" + dtAll.Rows[i]["STT"].ToString() + "'", con);
                    if (ckRaw.Checked)
                    {
                        DataTable dtTwo = Table("Raw", "Report", "STT='" + index + "'", con);
                        Image imgRaw = Image.FromFile(dtTwo.Rows[0][0].ToString());// byteArrayToImage((byte[])dtTwo.Rows[0][0]);
                        Bitmap bmRaw = (Bitmap)imgRaw;
                        String save = "";
                   
                        String name = Path.GetFileNameWithoutExtension(dtTwo.Rows[0]["Raw"].ToString());
                        save = sPicRaw + "\\" + name + ".png";
                        using (MemoryStream memory = new MemoryStream())
                        {
                            using (FileStream fs = new FileStream(save, FileMode.Create))
                            {
                                bmRaw.Save(memory, ImageFormat.Png);
                                byte[] bytes = memory.ToArray();
                                fs.Write(bytes, 0, bytes.Length);
                            }
                        }
                    }
                   
                    con.Close();
                    // dtPicture.Merge(dtTwo);
                    // dtPicturers.Merge(dtThree);
                    File.Exists(foder);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    wExport.ReportProgress(i + 1);
                    // Simulate long task
                    System.Threading.Thread.Sleep(50);
                }
                catch (Exception)
                {

                }
            }
            G.cnn.Open();
            if (ckDetail.Checked)
                File.WriteAllText(pathSave, _sExel);


        }

        private void wExport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            process.Value = e.ProgressPercentage;
            double per = (e.ProgressPercentage * 1.0 / process.Maximum) * 100.0;
            if (per == 100)
            {
                process.Value = 0;
                per = 0;
            }
            lbProcess.Text = (int)per + "";

        }

        private void wExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            //G.EditImage._ucInfor.text.Text = "Đã xuất File thành công!";
            //G.EditImage._ucInfor.BringToFront();
            //G.EditImage._ucInfor.Visible = true;

        }

      
    }
}
