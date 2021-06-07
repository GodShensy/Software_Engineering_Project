
namespace WorkerClient
{
    partial class MainFrom
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
            this.components = new System.ComponentModel.Container();
            this.button_back = new System.Windows.Forms.Button();
            this.buttom_sign = new System.Windows.Forms.Button();
            this.label_s = new System.Windows.Forms.Label();
            this.button_leave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(438, 226);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // buttom_sign
            // 
            this.buttom_sign.Location = new System.Drawing.Point(33, 226);
            this.buttom_sign.Name = "buttom_sign";
            this.buttom_sign.Size = new System.Drawing.Size(75, 23);
            this.buttom_sign.TabIndex = 1;
            this.buttom_sign.Text = "签到";
            this.buttom_sign.UseVisualStyleBackColor = true;
            this.buttom_sign.Click += new System.EventHandler(this.buttom_sign_Click);
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft YaHei UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_s.Location = new System.Drawing.Point(33, 86);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(519, 75);
            this.label_s.TabIndex = 4;
            this.label_s.Text = "2021-6-5 10:22:50";
            // 
            // button_leave
            // 
            this.button_leave.Location = new System.Drawing.Point(147, 226);
            this.button_leave.Name = "button_leave";
            this.button_leave.Size = new System.Drawing.Size(75, 23);
            this.button_leave.TabIndex = 5;
            this.button_leave.Text = "请假";
            this.button_leave.UseVisualStyleBackColor = true;
            this.button_leave.Click += new System.EventHandler(this.button_leave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 285);
            this.Controls.Add(this.button_leave);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.buttom_sign);
            this.Controls.Add(this.button_back);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button buttom_sign;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Button button_leave;
        private System.Windows.Forms.Timer timer1;
    }
}