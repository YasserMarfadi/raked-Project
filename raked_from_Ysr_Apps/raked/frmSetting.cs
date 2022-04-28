using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raked
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void lblUrlApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yassermarfadi.github.io/raked/");
        }

        private void lblUrlProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yassermarfadi.github.io/raked/");
            // Process.Start("https://github.com/YasserMarfadi/raked-Project/tree/main/");
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void frmSetting_KeyDown(object sender, KeyEventArgs e)
        {
            // close app 
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
