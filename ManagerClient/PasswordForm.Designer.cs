
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_check_password = new System.Windows.Forms.TextBox();
            this.button_reset_password = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_reset_password_tip3 = new System.Windows.Forms.Label();
            this.label_reset_password_tip2 = new System.Windows.Forms.Label();
            this.label_reset_password_tip1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(111, 60);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(192, 23);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Location = new System.Drawing.Point(111, 110);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(192, 23);
            this.textBox_new_password.TabIndex = 4;
            this.textBox_new_password.TextChanged += new System.EventHandler(this.textBox_new_password_TextChanged);
            // 
            // textBox_check_password
            // 
            this.textBox_check_password.Location = new System.Drawing.Point(111, 154);
            this.textBox_check_password.Name = "textBox_check_password";
            this.textBox_check_password.Size = new System.Drawing.Size(192, 23);
            this.textBox_check_password.TabIndex = 5;
            this.textBox_check_password.TextChanged += new System.EventHandler(this.textBox_check_password_TextChanged);
            // 
            // button_reset_password
            // 
            this.button_reset_password.Location = new System.Drawing.Point(60, 313);
            this.button_reset_password.Name = "button_reset_password";
            this.button_reset_password.Size = new System.Drawing.Size(78, 23);
            this.button_reset_password.TabIndex = 6;
            this.button_reset_password.Text = "确定";
            this.button_reset_password.UseVisualStyleBackColor = true;
            this.button_reset_password.Click += new System.EventHandler(this.button_reset_password_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_reset_password_tip3);
            this.groupBox1.Controls.Add(this.label_reset_password_tip2);
            this.groupBox1.Controls.Add(this.label_reset_password_tip1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_check_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_new_password);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 229);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // label_reset_password_tip3
            // 
            this.label_reset_password_tip3.AutoSize = true;
            this.label_reset_password_tip3.Location = new System.Drawing.Point(309, 154);
            this.label_reset_password_tip3.Name = "label_reset_password_tip3";
            this.label_reset_password_tip3.Size = new System.Drawing.Size(13, 17);
            this.label_reset_password_tip3.TabIndex = 8;
            this.label_reset_password_tip3.Text = "*";
            // 
            // label_reset_password_tip2
            // 
            this.label_reset_password_tip2.AutoSize = true;
            this.label_reset_password_tip2.Location = new System.Drawing.Point(309, 112);
            this.label_reset_password_tip2.Name = "label_reset_password_tip2";
            this.label_reset_password_tip2.Size = new System.Drawing.Size(13, 17);
            this.label_reset_password_tip2.TabIndex = 7;
            this.label_reset_password_tip2.Text = "*";
            // 
            // label_reset_password_tip1
            // 
            this.label_reset_password_tip1.AutoSize = true;
            this.label_reset_password_tip1.Location = new System.Drawing.Point(309, 64);
            this.label_reset_password_tip1.Name = "label_reset_password_tip1";
            this.label_reset_password_tip1.Size = new System.Drawing.Size(13, 17);
            this.label_reset_password_tip1.TabIndex = 6;
            this.label_reset_password_tip1.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(480, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 229);
            this.textBox1.TabIndex = 8;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_reset_password);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.TextBox textBox_check_password;
        private System.Windows.Forms.Button button_reset_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_reset_password_tip1;
        private System.Windows.Forms.Label label_reset_password_tip2;
        private System.Windows.Forms.Label label_reset_password_tip3;
        private System.Windows.Forms.TextBox textBox1;
    }
}