
namespace ManagerClient
{
    partial class RecForm
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
            this.textBox_workerNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Number = new System.Windows.Forms.DataGridView();
            this.textBox_benefits = new System.Windows.Forms.TextBox();
            this.textBox_insurance = new System.Windows.Forms.TextBox();
            this.textBox_workerDay = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入员工编号：";
            // 
            // textBox_workerNumber
            // 
            this.textBox_workerNumber.Location = new System.Drawing.Point(191, 42);
            this.textBox_workerNumber.Name = "textBox_workerNumber";
            this.textBox_workerNumber.Size = new System.Drawing.Size(149, 23);
            this.textBox_workerNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "月效益：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "月保险金：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "有效工作天数：";
            // 
            // dataGridView_Number
            // 
            this.dataGridView_Number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Number.Location = new System.Drawing.Point(554, 27);
            this.dataGridView_Number.Name = "dataGridView_Number";
            this.dataGridView_Number.ReadOnly = true;
            this.dataGridView_Number.RowTemplate.Height = 25;
            this.dataGridView_Number.Size = new System.Drawing.Size(144, 364);
            this.dataGridView_Number.TabIndex = 5;
            // 
            // textBox_benefits
            // 
            this.textBox_benefits.Location = new System.Drawing.Point(191, 90);
            this.textBox_benefits.Name = "textBox_benefits";
            this.textBox_benefits.Size = new System.Drawing.Size(149, 23);
            this.textBox_benefits.TabIndex = 6;
            // 
            // textBox_insurance
            // 
            this.textBox_insurance.Location = new System.Drawing.Point(191, 132);
            this.textBox_insurance.Name = "textBox_insurance";
            this.textBox_insurance.Size = new System.Drawing.Size(149, 23);
            this.textBox_insurance.TabIndex = 7;
            // 
            // textBox_workerDay
            // 
            this.textBox_workerDay.Location = new System.Drawing.Point(191, 176);
            this.textBox_workerDay.Name = "textBox_workerDay";
            this.textBox_workerDay.Size = new System.Drawing.Size(149, 23);
            this.textBox_workerDay.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 230);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 55);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(93, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "月工资：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_workerDay);
            this.Controls.Add(this.textBox_insurance);
            this.Controls.Add(this.textBox_benefits);
            this.Controls.Add(this.dataGridView_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_workerNumber);
            this.Controls.Add(this.label1);
            this.Name = "RecForm";
            this.Text = "RecForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_workerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_Number;
        private System.Windows.Forms.TextBox textBox_benefits;
        private System.Windows.Forms.TextBox textBox_insurance;
        private System.Windows.Forms.TextBox textBox_workerDay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}