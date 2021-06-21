
namespace ManagerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_log = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.uiCheckBox_isMannager = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(123, 63);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(157, 29);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(123, 106);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(157, 29);
            this.textBox_password.TabIndex = 3;
            // 
            // button_log
            // 
            this.button_log.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_log.Location = new System.Drawing.Point(58, 206);
            this.button_log.Margin = new System.Windows.Forms.Padding(2);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(77, 26);
            this.button_log.TabIndex = 4;
            this.button_log.Text = "登陆";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_quit
            // 
            this.button_quit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_quit.Location = new System.Drawing.Point(218, 206);
            this.button_quit.Margin = new System.Windows.Forms.Padding(2);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(77, 27);
            this.button_quit.TabIndex = 5;
            this.button_quit.Text = "员工注册";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // uiCheckBox_isMannager
            // 
            this.uiCheckBox_isMannager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_isMannager.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiCheckBox_isMannager.Location = new System.Drawing.Point(58, 153);
            this.uiCheckBox_isMannager.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_isMannager.Name = "uiCheckBox_isMannager";
            this.uiCheckBox_isMannager.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_isMannager.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox_isMannager.TabIndex = 6;
            this.uiCheckBox_isMannager.Text = "管理员登陆";
            this.uiCheckBox_isMannager.CheckedChanged += new System.EventHandler(this.uiCheckBox_isMannager_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 271);
            this.Controls.Add(this.uiCheckBox_isMannager);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "管理员客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_quit;
        private Sunny.UI.UICheckBox uiCheckBox_isMannager;
    }
}

