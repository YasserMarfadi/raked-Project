using Microsoft.Win32;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace raked
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Alt && e.KeyCode == Keys.F4)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "برنامج راكد", "يمكنك تشغيل راكد عبر الضغط على زر الأيقونة.", ToolTipIcon.Info);

            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "برنامج راكد", "يمكنك تشغيل راكد عبر الضغط على زر الأيقونة.", ToolTipIcon.Info);
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                // open form Setting and this hide
                this.Hide();
                frmSetting frm = new frmSetting();
                frm.ShowDialog();
            }
            /*else if (e.Alt && e.KeyData == Keys.Tab)// e.windows
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }*/

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // show form when click icon app in Task Bar icons
            this.Show();
        }

        private void frmHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //--- not important
            // cancel keys press on the keyboard
            e.Handled = true;
        }
        string strInfoApp = @"
        انتقل إلى قائمة الايقونات المخفية في شريط المهام لتشغيل وضع الركود

          Ctrl+Q لإيقاف وضع الركود انقر على 

         التطبيق ستجده في قائمة الايقونات المخفية في شريط المهام عند تشغيل جهاز الكمبيوتر, فليس من الضروري تشغيل التطبيق مرة أخرى 

         Ctrl+W لإظهار معلومات عن التطبيق انقر على

         alt+F4 لإغلاق  التطبيق انتقل إلى شاشة عن التطبيق وانقر
        ";
        private void frmHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show(strInfoApp, "تعليمات",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            // hide form
            this.Hide();
            // message notify 
            notifyIcon1.ShowBalloonTip(1000, "راكد", "يمكنك تشغيل وضع الركود عبر الضغط على زر الأيقونة.", ToolTipIcon.Info);
            //  run app when you run device
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Raked", Application.ExecutablePath);
        }
    }
}
