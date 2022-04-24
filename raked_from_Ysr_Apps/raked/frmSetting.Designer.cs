
namespace raked
{
    partial class frmSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrlApp = new System.Windows.Forms.LinkLabel();
            this.lblUrlProject = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSendGmail = new System.Windows.Forms.LinkLabel();
            this.lblFacebook = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUrlProject);
            this.groupBox1.Controls.Add(this.lblUrlApp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.groupBox1.Size = new System.Drawing.Size(239, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات التطبيق";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "تطبيق راكـــد \r\nالإصدار : 1.0.1\r\nالنوع : مفتوح المصدر\r\nرابط التطبيق  :\r\nرابط المش" +
    "روع : \r\n";
            // 
            // lblUrlApp
            // 
            this.lblUrlApp.AutoSize = true;
            this.lblUrlApp.BackColor = System.Drawing.Color.Transparent;
            this.lblUrlApp.Location = new System.Drawing.Point(75, 79);
            this.lblUrlApp.Name = "lblUrlApp";
            this.lblUrlApp.Size = new System.Drawing.Size(54, 18);
            this.lblUrlApp.TabIndex = 1;
            this.lblUrlApp.TabStop = true;
            this.lblUrlApp.Text = "انقر هنا";
            this.lblUrlApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUrlApp_LinkClicked);
            // 
            // lblUrlProject
            // 
            this.lblUrlProject.AutoSize = true;
            this.lblUrlProject.BackColor = System.Drawing.Color.Transparent;
            this.lblUrlProject.Location = new System.Drawing.Point(75, 100);
            this.lblUrlProject.Name = "lblUrlProject";
            this.lblUrlProject.Size = new System.Drawing.Size(54, 18);
            this.lblUrlProject.TabIndex = 2;
            this.lblUrlProject.TabStop = true;
            this.lblUrlProject.Text = "انقر هنا";
            this.lblUrlProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUrlProject_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSendGmail);
            this.groupBox2.Controls.Add(this.lblFacebook);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(266, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.groupBox2.Size = new System.Drawing.Size(219, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المطور";
            // 
            // lblSendGmail
            // 
            this.lblSendGmail.AutoSize = true;
            this.lblSendGmail.Location = new System.Drawing.Point(11, 70);
            this.lblSendGmail.Name = "lblSendGmail";
            this.lblSendGmail.Size = new System.Drawing.Size(54, 18);
            this.lblSendGmail.TabIndex = 2;
            this.lblSendGmail.TabStop = true;
            this.lblSendGmail.Text = "انقر هنا";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(11, 49);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(54, 18);
            this.lblFacebook.TabIndex = 1;
            this.lblFacebook.TabStop = true;
            this.lblFacebook.Text = "انقر هنا";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم : ياسر عبدالحكيم \r\nصفحة الفيس بوك : \r\nالبريد الإكتروني : ";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 163);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عند التطبيق";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblUrlProject;
        private System.Windows.Forms.LinkLabel lblUrlApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lblSendGmail;
        private System.Windows.Forms.LinkLabel lblFacebook;
        private System.Windows.Forms.Label label2;
    }
}