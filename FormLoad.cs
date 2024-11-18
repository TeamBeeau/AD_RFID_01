

using AD_RFID;
using BeeUi.Commons;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Net;

using System.Windows.Forms;

namespace BeeUi
{
    public partial class FormLoad : Form
    {
       
     
      
       
        public FormLoad()
        {
            InitializeComponent();
            G.FormLoad = this;
                //  Disable();
                //  Enable();

            // listStringCCD;

            // RsDirPermissions rsDirPermissions = new RsDirPermissions();
            // rsDirPermissions.SetEveryoneAccess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+"\\Bee Eyes Automation\\EasyVision");
            //G.Load = this;

            try
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
              
                lbVersion.Text = version.ToString();
              
            }
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
                //react appropriately
            }


        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            this.Hide();
            tmLoad.Enabled = true;
        }

        private void tmLoad_Tick(object sender, EventArgs e)
        {
            tmLoad.Enabled = false;
            G.FormActive = new FormActive();
            if (G.FormActive.CheckActive(Decompile.GetMacAddress()))
            {
                this.Hide();

                G.FormMain = new FormMain();
                G.FormMain.Show();
            }
            else
            {
                this.Hide();
                G.FormActive = new FormActive();
                G.FormActive.Show();
            }
        }
    }
}
