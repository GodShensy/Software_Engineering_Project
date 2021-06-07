
namespace WorkerClient
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
            this.label_userid = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_uid = new System.Windows.Forms.TextBox();
            this.textBox_upassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Location = new System.Drawing.Point(49, 47);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(43, 17);
            this.label_userid.TabIndex = 0;
            this.label_userid.Text = "员工id";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(49, 98);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(44, 17);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "密码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_uid
            // 
            this.textBox_uid.Location = new System.Drawing.Point(110, 44);
            this.textBox_uid.Name = "textBox_uid";
            this.textBox_uid.Size = new System.Drawing.Size(200, 23);
            this.textBox_uid.TabIndex = 4;
            // 
            // textBox_upassword
            // 
            this.textBox_upassword.Location = new System.Drawing.Point(110, 95);
            this.textBox_upassword.Name = "textBox_upassword";
            this.textBox_upassword.Size = new System.Drawing.Size(200, 23);
            this.textBox_upassword.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 258);
            this.Controls.Add(this.textBox_upassword);
            this.Controls.Add(this.textBox_uid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userid);
            this.Name = "Form1";
            this.Text = "员工登陆客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_uid;
        private System.Windows.Forms.TextBox textBox_upassword;
        private System.Windows.Forms.Label label_userId;
        private System.Windows.Forms.Button button2;
    }
}

