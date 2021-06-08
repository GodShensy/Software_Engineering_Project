
namespace ManagerClient
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_info_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_rec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_btn_reset_password = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_signManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_btn_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem_regin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_info_btn,
            this.ToolStripMenuItem_rec,
            this.menu_btn_reset_password,
            this.toolStripMenuItem_signManage,
            this.toolStripMenuItem_regin,
            this.menu_btn_quit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_info_btn
            // 
            this.menu_info_btn.Name = "menu_info_btn";
            this.menu_info_btn.Size = new System.Drawing.Size(65, 24);
            this.menu_info_btn.Text = "资料管理";
            this.menu_info_btn.Click += new System.EventHandler(this.menu_info_btn_Click);
            // 
            // ToolStripMenuItem_rec
            // 
            this.ToolStripMenuItem_rec.Name = "ToolStripMenuItem_rec";
            this.ToolStripMenuItem_rec.Size = new System.Drawing.Size(65, 24);
            this.ToolStripMenuItem_rec.Text = "待遇管理";
            this.ToolStripMenuItem_rec.Click += new System.EventHandler(this.ToolStripMenuItem_rec_Click);
            // 
            // menu_btn_reset_password
            // 
            this.menu_btn_reset_password.Name = "menu_btn_reset_password";
            this.menu_btn_reset_password.Size = new System.Drawing.Size(101, 24);
            this.menu_btn_reset_password.Text = "修改管理员密码";
            this.menu_btn_reset_password.Click += new System.EventHandler(this.menu_btn_reset_password_Click);
            // 
            // toolStripMenuItem_signManage
            // 
            this.toolStripMenuItem_signManage.Name = "toolStripMenuItem_signManage";
            this.toolStripMenuItem_signManage.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem_signManage.Text = "签到管理";
            this.toolStripMenuItem_signManage.Click += new System.EventHandler(this.toolStripMenuItem_signManage_Click);
            // 
            // menu_btn_quit
            // 
            this.menu_btn_quit.Name = "menu_btn_quit";
            this.menu_btn_quit.Size = new System.Drawing.Size(41, 24);
            this.menu_btn_quit.Text = "退出";
            this.menu_btn_quit.Click += new System.EventHandler(this.menu_btn_quit_Click);
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForm.Location = new System.Drawing.Point(0, 30);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(816, 465);
            this.panelForm.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panelForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 495);
            this.panel1.TabIndex = 2;
            // 
            // toolStripMenuItem_regin
            // 
            this.toolStripMenuItem_regin.Name = "toolStripMenuItem_regin";
            this.toolStripMenuItem_regin.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem_regin.Text = "入职申请";
            this.toolStripMenuItem_regin.Click += new System.EventHandler(this.toolStripMenuItem_regin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 530);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 530);
            this.MinimumSize = new System.Drawing.Size(816, 530);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_info_btn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_rec;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_reset_password;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_quit;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_signManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_regin;
    }
}