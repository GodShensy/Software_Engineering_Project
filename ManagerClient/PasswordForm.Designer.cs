
namespace ManagerClient
{
    partial class PasswordForm
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_check_password = new System.Windows.Forms.TextBox();
            this.label_reset_password_tip3 = new System.Windows.Forms.Label();
            this.label_reset_password_tip2 = new System.Windows.Forms.Label();
            this.label_reset_password_tip1 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton_reset_password = new Sunny.UI.UIButton();
            this.uiButton_clear = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(195, 64);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(192, 29);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Location = new System.Drawing.Point(195, 109);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(192, 29);
            this.textBox_new_password.TabIndex = 4;
            this.textBox_new_password.TextChanged += new System.EventHandler(this.textBox_new_password_TextChanged);
            // 
            // textBox_check_password
            // 
            this.textBox_check_password.Location = new System.Drawing.Point(195, 152);
            this.textBox_check_password.Name = "textBox_check_password";
            this.textBox_check_password.Size = new System.Drawing.Size(192, 29);
            this.textBox_check_password.TabIndex = 5;
            this.textBox_check_password.TextChanged += new System.EventHandler(this.textBox_check_password_TextChanged);
            // 
            // label_reset_password_tip3
            // 
            this.label_reset_password_tip3.AutoSize = true;
            this.label_reset_password_tip3.Location = new System.Drawing.Point(393, 160);
            this.label_reset_password_tip3.Name = "label_reset_password_tip3";
            this.label_reset_password_tip3.Size = new System.Drawing.Size(17, 21);
            this.label_reset_password_tip3.TabIndex = 8;
            this.label_reset_password_tip3.Text = "*";
            // 
            // label_reset_password_tip2
            // 
            this.label_reset_password_tip2.AutoSize = true;
            this.label_reset_password_tip2.Location = new System.Drawing.Point(393, 113);
            this.label_reset_password_tip2.Name = "label_reset_password_tip2";
            this.label_reset_password_tip2.Size = new System.Drawing.Size(17, 21);
            this.label_reset_password_tip2.TabIndex = 7;
            this.label_reset_password_tip2.Text = "*";
            // 
            // label_reset_password_tip1
            // 
            this.label_reset_password_tip1.AutoSize = true;
            this.label_reset_password_tip1.Location = new System.Drawing.Point(393, 67);
            this.label_reset_password_tip1.Name = "label_reset_password_tip1";
            this.label_reset_password_tip1.Size = new System.Drawing.Size(17, 21);
            this.label_reset_password_tip1.TabIndex = 6;
            this.label_reset_password_tip1.Text = "*";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.label_reset_password_tip3);
            this.uiGroupBox1.Controls.Add(this.textBox_check_password);
            this.uiGroupBox1.Controls.Add(this.label_reset_password_tip2);
            this.uiGroupBox1.Controls.Add(this.textBox_password);
            this.uiGroupBox1.Controls.Add(this.label_reset_password_tip1);
            this.uiGroupBox1.Controls.Add(this.textBox_new_password);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(60, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(467, 235);
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.Text = "输入信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(39, 154);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(135, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "CheckPassword:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(49, 111);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(125, 23);
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "NewPassword:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(54, 67);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(120, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "OldPassword:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_reset_password
            // 
            this.uiButton_reset_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_reset_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_reset_password.Location = new System.Drawing.Point(109, 307);
            this.uiButton_reset_password.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_reset_password.Name = "uiButton_reset_password";
            this.uiButton_reset_password.Size = new System.Drawing.Size(100, 35);
            this.uiButton_reset_password.TabIndex = 9;
            this.uiButton_reset_password.Text = "提交";
            this.uiButton_reset_password.Click += new System.EventHandler(this.uiButton_reset_password_Click);
            // 
            // uiButton_clear
            // 
            this.uiButton_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_clear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_clear.Location = new System.Drawing.Point(338, 307);
            this.uiButton_clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_clear.Name = "uiButton_clear";
            this.uiButton_clear.Size = new System.Drawing.Size(100, 35);
            this.uiButton_clear.TabIndex = 10;
            this.uiButton_clear.Text = "清空";
            this.uiButton_clear.Click += new System.EventHandler(this.uiButton_clear_Click);
            // 
            // PasswordForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 465);
            this.Controls.Add(this.uiButton_clear);
            this.Controls.Add(this.uiButton_reset_password);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "PasswordForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "PasswordForm";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.TextBox textBox_check_password;
        private System.Windows.Forms.Label label_reset_password_tip1;
        private System.Windows.Forms.Label label_reset_password_tip2;
        private System.Windows.Forms.Label label_reset_password_tip3;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton_reset_password;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton_clear;
    }
}