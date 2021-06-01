
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
            this.资料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.待遇管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_btn_reset_password = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_btn_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.资料管理ToolStripMenuItem,
            this.待遇管理ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.menu_btn_reset_password,
            this.menu_btn_quit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 资料管理ToolStripMenuItem
            // 
            this.资料管理ToolStripMenuItem.Name = "资料管理ToolStripMenuItem";
            this.资料管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.资料管理ToolStripMenuItem.Text = "资料管理";
            // 
            // 待遇管理ToolStripMenuItem
            // 
            this.待遇管理ToolStripMenuItem.Name = "待遇管理ToolStripMenuItem";
            this.待遇管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.待遇管理ToolStripMenuItem.Text = "待遇管理";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // menu_btn_reset_password
            // 
            this.menu_btn_reset_password.Name = "menu_btn_reset_password";
            this.menu_btn_reset_password.Size = new System.Drawing.Size(104, 21);
            this.menu_btn_reset_password.Text = "修改管理员密码";
            this.menu_btn_reset_password.Click += new System.EventHandler(this.menu_btn_reset_password_Click);
            // 
            // menu_btn_quit
            // 
            this.menu_btn_quit.Name = "menu_btn_quit";
            this.menu_btn_quit.Size = new System.Drawing.Size(44, 21);
            this.menu_btn_quit.Text = "退出";
            this.menu_btn_quit.Click += new System.EventHandler(this.menu_btn_quit_Click);
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 25);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 425);
            this.panelForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 资料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待遇管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_reset_password;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_quit;
        private System.Windows.Forms.Panel panelForm;
    }
}