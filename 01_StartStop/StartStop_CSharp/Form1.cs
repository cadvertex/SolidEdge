using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using SolidEdgeFramework;

namespace Cust01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SolidEdgeFramework.Application oApp;
        Type typ;

        private void cmdStart_Click(object sender, EventArgs e)
        {
            try
            {
                //typ = Type.GetTypeFromProgID("SolidEdge.Application");
                //oApp =  (SolidEdgeFramework.Application)Activator.CreateInstance(typ);
                oApp = (SolidEdgeFramework.Application)Marshal.GetActiveObject("SolidEdge.Application");
            }
		    catch (Exception ex)
            {
			    MessageBox.Show(ex.Message);
            }
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            oApp.Visible = true;
        }

        private void cmdHide_Click(object sender, EventArgs e)
        {
            oApp.Visible = false;
        }

        private void cmdVersion_Click(object sender, EventArgs e)
        {
            label1.Text = oApp.Name + " - " + oApp.Version;
        }

        private void cmdAppend_Click(object sender, EventArgs e)
        {
            oApp.StatusBar += txtStatus.Text;
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            oApp.StatusBarVisible = chkStatus.Checked;
        }

        private void chkEdge_CheckedChanged(object sender, EventArgs e)
        {
            oApp.EdgeBarVisible = chkEdge.Checked;
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            oApp.Quit();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
