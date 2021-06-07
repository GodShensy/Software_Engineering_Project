
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_workerNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_benefits = new System.Windows.Forms.TextBox();
            this.textBox_insurance = new System.Windows.Forms.TextBox();
            this.textBox_workerDay = new System.Windows.Forms.TextBox();
            this.textBox_ans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_benefits = new System.Windows.Forms.Label();
            this.label_insurance = new System.Windows.Forms.Label();
            this.uiDataGridView_Number = new Sunny.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Number)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入员工编号：";
            // 
            // textBox_workerNumber
            // 
            this.textBox_workerNumber.Location = new System.Drawing.Point(180, 45);
            this.textBox_workerNumber.Name = "textBox_workerNumber";
            this.textBox_workerNumber.Size = new System.Drawing.Size(149, 29);
            this.textBox_workerNumber.TabIndex = 1;
            this.textBox_workerNumber.TextChanged += new System.EventHandler(this.textBox_workerNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "月效益：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "月保险金：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "有效工作天数：";
            // 
            // textBox_benefits
            // 
            this.textBox_benefits.Location = new System.Drawing.Point(180, 150);
            this.textBox_benefits.Name = "textBox_benefits";
            this.textBox_benefits.Size = new System.Drawing.Size(149, 29);
            this.textBox_benefits.TabIndex = 6;
            this.textBox_benefits.TextChanged += new System.EventHandler(this.textBox_benefits_TextChanged);
            // 
            // textBox_insurance
            // 
            this.textBox_insurance.Location = new System.Drawing.Point(180, 96);
            this.textBox_insurance.Name = "textBox_insurance";
            this.textBox_insurance.Size = new System.Drawing.Size(149, 29);
            this.textBox_insurance.TabIndex = 7;
            this.textBox_insurance.TextChanged += new System.EventHandler(this.textBox_insurance_TextChanged);
            // 
            // textBox_workerDay
            // 
            this.textBox_workerDay.Location = new System.Drawing.Point(150, 297);
            this.textBox_workerDay.Name = "textBox_workerDay";
            this.textBox_workerDay.ReadOnly = true;
            this.textBox_workerDay.Size = new System.Drawing.Size(149, 29);
            this.textBox_workerDay.TabIndex = 8;
            this.textBox_workerDay.TextChanged += new System.EventHandler(this.textBox_workerDay_TextChanged);
            // 
            // textBox_ans
            // 
            this.textBox_ans.Location = new System.Drawing.Point(150, 345);
            this.textBox_ans.Multiline = true;
            this.textBox_ans.Name = "textBox_ans";
            this.textBox_ans.ReadOnly = true;
            this.textBox_ans.Size = new System.Drawing.Size(150, 55);
            this.textBox_ans.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 50);
            this.label5.TabIndex = 10;
            this.label5.Text = "月工资:";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(335, 45);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(17, 21);
            this.label_number.TabIndex = 12;
            this.label_number.Text = "*";
            // 
            // label_benefits
            // 
            this.label_benefits.AutoSize = true;
            this.label_benefits.Location = new System.Drawing.Point(335, 153);
            this.label_benefits.Name = "label_benefits";
            this.label_benefits.Size = new System.Drawing.Size(17, 21);
            this.label_benefits.TabIndex = 13;
            this.label_benefits.Text = "*";
            // 
            // label_insurance
            // 
            this.label_insurance.AutoSize = true;
            this.label_insurance.Location = new System.Drawing.Point(335, 104);
            this.label_insurance.Name = "label_insurance";
            this.label_insurance.Size = new System.Drawing.Size(17, 21);
            this.label_insurance.TabIndex = 14;
            this.label_insurance.Text = "*";
            // 
            // uiDataGridView_Number
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Number.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView_Number.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiDataGridView_Number.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Number.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView_Number.ColumnHeadersHeight = 32;
            this.uiDataGridView_Number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_Number.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView_Number.DefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView_Number.EnableHeadersVisualStyles = false;
            this.uiDataGridView_Number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiDataGridView_Number.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Number.Location = new System.Drawing.Point(548, 46);
            this.uiDataGridView_Number.Name = "uiDataGridView_Number";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Number.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_Number.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView_Number.RowTemplate.Height = 29;
            this.uiDataGridView_Number.ScrollMode = Sunny.UI.UIDataGridView.UIDataGridViewScrollMode.Page;
            this.uiDataGridView_Number.SelectedIndex = -1;
            this.uiDataGridView_Number.ShowGridLine = true;
            this.uiDataGridView_Number.ShowRect = false;
            this.uiDataGridView_Number.Size = new System.Drawing.Size(141, 364);
            this.uiDataGridView_Number.StyleCustomMode = true;
            this.uiDataGridView_Number.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "workerNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "工号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.textBox_workerNumber);
            this.uiGroupBox1.Controls.Add(this.label_insurance);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label_benefits);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label_number);
            this.uiGroupBox1.Controls.Add(this.textBox_benefits);
            this.uiGroupBox1.Controls.Add(this.textBox_insurance);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(34, 46);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(400, 227);
            this.uiGroupBox1.TabIndex = 17;
            this.uiGroupBox1.Text = "信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(334, 365);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 18;
            this.uiButton1.Text = "计算结果";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // RecForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 465);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_workerDay);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiDataGridView_Number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ans);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "RecForm";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Number)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_workerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_benefits;
        private System.Windows.Forms.TextBox textBox_insurance;
        private System.Windows.Forms.TextBox textBox_workerDay;
        private System.Windows.Forms.TextBox textBox_ans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_benefits;
        private System.Windows.Forms.Label label_insurance;
        private Sunny.UI.UIDataGridView uiDataGridView_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton1;
    }
}