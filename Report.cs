using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_RFID
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            ucReport ucReport = new ucReport();
            ucReport.Parent = this;
            ucReport.Dock = DockStyle.Fill;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
