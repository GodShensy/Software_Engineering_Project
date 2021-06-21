
namespace ManagerClient
{
    partial class WorkerAddForm
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
            this.textBox_worker_number = new System.Windows.Forms.TextBox();
            this.textBox_worker_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.textBox_worker_name = new System.Windows.Forms.TextBox();
            this.textBox_worker_tel = new System.Windows.Forms.TextBox();
            this.dateTimePicker_worker_birth = new System.Windows.Forms.DateTimePicker();
            this.textBox_worker_homeAddr = new System.Windows.Forms.TextBox();
            this.comboBox_worker_edu = new System.Windows.Forms.ComboBox();
            this.comboBox_worker_lv = new System.Windows.Forms.ComboBox();
            this.numericUpDown_workerTime = new System.Windows.Forms.NumericUpDown();
            this.textBox_worker_rec = new System.Windows.Forms.TextBox();
            this.dateTimePicker_joinTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.label_worker_number = new System.Windows.Forms.Label();
            this.label_worker_password = new System.Windows.Forms.Label();
            this.label_worker_name = new System.Windows.Forms.Label();
            this.label_worker_tel = new System.Windows.Forms.Label();
            this.label_worker_home_addr = new System.Windows.Forms.Label();
            this.label_worker_rec = new System.Windows.Forms.Label();
            this.label_worker_addr = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton_push_change = new Sunny.UI.UIButton();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_workerTime)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_worker_number
            // 
            this.textBox_worker_number.Location = new System.Drawing.Point(85, 45);
            this.textBox_worker_number.Name = "textBox_worker_number";
            this.textBox_worker_number.ReadOnly = true;
            this.textBox_worker_number.Size = new System.Drawing.Size(134, 29);
            this.textBox_worker_number.TabIndex = 13;
            this.textBox_worker_number.Text = "点击分配工号";
            this.textBox_worker_number.Click += new System.EventHandler(this.textBox_worker_number_Click);
            // 
            // textBox_worker_password
            // 
            this.textBox_worker_password.Location = new System.Drawing.Point(328, 88);
            this.textBox_worker_password.Name = "textBox_worker_password";
            this.textBox_worker_password.Size = new System.Drawing.Size(134, 29);
            this.textBox_worker_password.TabIndex = 14;
            this.textBox_worker_password.TextChanged += new System.EventHandler(this.textBox_worker_password_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_female);
            this.panel1.Controls.Add(this.radioButton_man);
            this.panel1.Location = new System.Drawing.Point(331, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 29);
            this.panel1.TabIndex = 15;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(65, 2);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(44, 25);
            this.radioButton_female.TabIndex = 1;
            this.radioButton_female.Text = "女";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Checked = true;
            this.radioButton_man.Location = new System.Drawing.Point(4, 2);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(44, 25);
            this.radioButton_man.TabIndex = 0;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "男";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // textBox_worker_name
            // 
            this.textBox_worker_name.Location = new System.Drawing.Point(84, 88);
            this.textBox_worker_name.Name = "textBox_worker_name";
            this.textBox_worker_name.Size = new System.Drawing.Size(133, 29);
            this.textBox_worker_name.TabIndex = 16;
            this.textBox_worker_name.TextChanged += new System.EventHandler(this.textBox_worker_name_TextChanged);
            // 
            // textBox_worker_tel
            // 
            this.textBox_worker_tel.Location = new System.Drawing.Point(83, 129);
            this.textBox_worker_tel.Name = "textBox_worker_tel";
            this.textBox_worker_tel.Size = new System.Drawing.Size(133, 29);
            this.textBox_worker_tel.TabIndex = 17;
            this.textBox_worker_tel.TextChanged += new System.EventHandler(this.textBox_worker_tel_TextChanged);
            // 
            // dateTimePicker_worker_birth
            // 
            this.dateTimePicker_worker_birth.Location = new System.Drawing.Point(118, 171);
            this.dateTimePicker_worker_birth.Name = "dateTimePicker_worker_birth";
            this.dateTimePicker_worker_birth.Size = new System.Drawing.Size(149, 29);
            this.dateTimePicker_worker_birth.TabIndex = 18;
            // 
            // textBox_worker_homeAddr
            // 
            this.textBox_worker_homeAddr.Location = new System.Drawing.Point(328, 132);
            this.textBox_worker_homeAddr.Name = "textBox_worker_homeAddr";
            this.textBox_worker_homeAddr.Size = new System.Drawing.Size(133, 29);
            this.textBox_worker_homeAddr.TabIndex = 19;
            this.textBox_worker_homeAddr.TextChanged += new System.EventHandler(this.textBox_worker_homeAddr_TextChanged);
            // 
            // comboBox_worker_edu
            // 
            this.comboBox_worker_edu.FormattingEnabled = true;
            this.comboBox_worker_edu.Items.AddRange(new object[] {
            "高中",
            "学士",
            "硕士",
            "博士",
            "其他"});
            this.comboBox_worker_edu.Location = new System.Drawing.Point(362, 176);
            this.comboBox_worker_edu.Name = "comboBox_worker_edu";
            this.comboBox_worker_edu.Size = new System.Drawing.Size(99, 29);
            this.comboBox_worker_edu.TabIndex = 20;
            // 
            // comboBox_worker_lv
            // 
            this.comboBox_worker_lv.FormattingEnabled = true;
            this.comboBox_worker_lv.Items.AddRange(new object[] {
            "初级测试工程师",
            "中级测试工程师",
            "高级测试工程师"});
            this.comboBox_worker_lv.Location = new System.Drawing.Point(362, 219);
            this.comboBox_worker_lv.Name = "comboBox_worker_lv";
            this.comboBox_worker_lv.Size = new System.Drawing.Size(100, 29);
            this.comboBox_worker_lv.TabIndex = 21;
            this.comboBox_worker_lv.Tag = "";
            // 
            // numericUpDown_workerTime
            // 
            this.numericUpDown_workerTime.Location = new System.Drawing.Point(118, 316);
            this.numericUpDown_workerTime.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_workerTime.Name = "numericUpDown_workerTime";
            this.numericUpDown_workerTime.Size = new System.Drawing.Size(88, 29);
            this.numericUpDown_workerTime.TabIndex = 22;
            this.numericUpDown_workerTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_worker_rec
            // 
            this.textBox_worker_rec.Location = new System.Drawing.Point(118, 360);
            this.textBox_worker_rec.Name = "textBox_worker_rec";
            this.textBox_worker_rec.Size = new System.Drawing.Size(88, 29);
            this.textBox_worker_rec.TabIndex = 23;
            this.textBox_worker_rec.TextChanged += new System.EventHandler(this.textBox_worker_rec_TextChanged);
            // 
            // dateTimePicker_joinTime
            // 
            this.dateTimePicker_joinTime.Location = new System.Drawing.Point(118, 216);
            this.dateTimePicker_joinTime.Name = "dateTimePicker_joinTime";
            this.dateTimePicker_joinTime.Size = new System.Drawing.Size(149, 29);
            this.dateTimePicker_joinTime.TabIndex = 24;
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(118, 273);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(343, 29);
            this.textBox_addr.TabIndex = 25;
            this.textBox_addr.TextChanged += new System.EventHandler(this.textBox_addr_TextChanged);
            // 
            // label_worker_number
            // 
            this.label_worker_number.AutoSize = true;
            this.label_worker_number.Location = new System.Drawing.Point(225, 53);
            this.label_worker_number.Name = "label_worker_number";
            this.label_worker_number.Size = new System.Drawing.Size(17, 21);
            this.label_worker_number.TabIndex = 26;
            this.label_worker_number.Text = "*";
            // 
            // label_worker_password
            // 
            this.label_worker_password.AutoSize = true;
            this.label_worker_password.Location = new System.Drawing.Point(468, 94);
            this.label_worker_password.Name = "label_worker_password";
            this.label_worker_password.Size = new System.Drawing.Size(17, 21);
            this.label_worker_password.TabIndex = 27;
            this.label_worker_password.Text = "*";
            // 
            // label_worker_name
            // 
            this.label_worker_name.AutoSize = true;
            this.label_worker_name.Location = new System.Drawing.Point(225, 96);
            this.label_worker_name.Name = "label_worker_name";
            this.label_worker_name.Size = new System.Drawing.Size(17, 21);
            this.label_worker_name.TabIndex = 29;
            this.label_worker_name.Text = "*";
            // 
            // label_worker_tel
            // 
            this.label_worker_tel.AutoSize = true;
            this.label_worker_tel.Location = new System.Drawing.Point(225, 132);
            this.label_worker_tel.Name = "label_worker_tel";
            this.label_worker_tel.Size = new System.Drawing.Size(17, 21);
            this.label_worker_tel.TabIndex = 30;
            this.label_worker_tel.Text = "*";
            // 
            // label_worker_home_addr
            // 
            this.label_worker_home_addr.AutoSize = true;
            this.label_worker_home_addr.Location = new System.Drawing.Point(467, 135);
            this.label_worker_home_addr.Name = "label_worker_home_addr";
            this.label_worker_home_addr.Size = new System.Drawing.Size(17, 21);
            this.label_worker_home_addr.TabIndex = 32;
            this.label_worker_home_addr.Text = "*";
            // 
            // label_worker_rec
            // 
            this.label_worker_rec.AutoSize = true;
            this.label_worker_rec.Location = new System.Drawing.Point(212, 368);
            this.label_worker_rec.Name = "label_worker_rec";
            this.label_worker_rec.Size = new System.Drawing.Size(17, 21);
            this.label_worker_rec.TabIndex = 35;
            this.label_worker_rec.Text = "*";
            // 
            // label_worker_addr
            // 
            this.label_worker_addr.AutoSize = true;
            this.label_worker_addr.Location = new System.Drawing.Point(467, 281);
            this.label_worker_addr.Name = "label_worker_addr";
            this.label_worker_addr.Size = new System.Drawing.Size(17, 21);
            this.label_worker_addr.TabIndex = 36;
            this.label_worker_addr.Text = "*";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiButton_push_change);
            this.uiGroupBox1.Controls.Add(this.uiLabel13);
            this.uiGroupBox1.Controls.Add(this.uiLabel12);
            this.uiGroupBox1.Controls.Add(this.uiLabel11);
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.uiLabel8);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.dateTimePicker_joinTime);
            this.uiGroupBox1.Controls.Add(this.label_worker_rec);
            this.uiGroupBox1.Controls.Add(this.label_worker_addr);
            this.uiGroupBox1.Controls.Add(this.label_worker_home_addr);
            this.uiGroupBox1.Controls.Add(this.label_worker_tel);
            this.uiGroupBox1.Controls.Add(this.label_worker_name);
            this.uiGroupBox1.Controls.Add(this.label_worker_password);
            this.uiGroupBox1.Controls.Add(this.label_worker_number);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_rec);
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Controls.Add(this.numericUpDown_workerTime);
            this.uiGroupBox1.Controls.Add(this.comboBox_worker_lv);
            this.uiGroupBox1.Controls.Add(this.comboBox_worker_edu);
            this.uiGroupBox1.Controls.Add(this.textBox_addr);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_homeAddr);
            this.uiGroupBox1.Controls.Add(this.dateTimePicker_worker_birth);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_tel);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_name);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_password);
            this.uiGroupBox1.Controls.Add(this.textBox_worker_number);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(22, 54);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(536, 526);
            this.uiGroupBox1.TabIndex = 37;
            this.uiGroupBox1.Text = "用户信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton_push_change
            // 
            this.uiButton_push_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_push_change.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_push_change.Location = new System.Drawing.Point(374, 430);
            this.uiButton_push_change.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_push_change.Name = "uiButton_push_change";
            this.uiButton_push_change.Size = new System.Drawing.Size(100, 35);
            this.uiButton_push_change.TabIndex = 50;
            this.uiButton_push_change.Text = "提交";
            this.uiButton_push_change.Click += new System.EventHandler(this.uiButton_push_change_Click);
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel13.Location = new System.Drawing.Point(34, 222);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(78, 21);
            this.uiLabel13.TabIndex = 49;
            this.uiLabel13.Text = "加入时间:";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel12.Location = new System.Drawing.Point(34, 273);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(78, 21);
            this.uiLabel12.TabIndex = 48;
            this.uiLabel12.Text = "现居住地:";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel11.Location = new System.Drawing.Point(310, 222);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(46, 21);
            this.uiLabel11.TabIndex = 47;
            this.uiLabel11.Text = "等级:";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel10.Location = new System.Drawing.Point(278, 45);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(46, 21);
            this.uiLabel10.TabIndex = 46;
            this.uiLabel10.Text = "性别:";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel9.Location = new System.Drawing.Point(34, 363);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(78, 21);
            this.uiLabel9.TabIndex = 45;
            this.uiLabel9.Text = "基本工资:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel8.Location = new System.Drawing.Point(34, 318);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(46, 21);
            this.uiLabel8.TabIndex = 44;
            this.uiLabel8.Text = "工龄:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel7.Location = new System.Drawing.Point(310, 179);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(46, 21);
            this.uiLabel7.TabIndex = 43;
            this.uiLabel7.Text = "学历:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(276, 135);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(46, 21);
            this.uiLabel6.TabIndex = 42;
            this.uiLabel6.Text = "籍贯:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(31, 177);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(46, 21);
            this.uiLabel5.TabIndex = 41;
            this.uiLabel5.Text = "生日:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(34, 132);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(46, 21);
            this.uiLabel4.TabIndex = 40;
            this.uiLabel4.Text = "电话:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(31, 91);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(46, 21);
            this.uiLabel3.TabIndex = 39;
            this.uiLabel3.Text = "姓名:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(276, 92);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(46, 21);
            this.uiLabel2.TabIndex = 38;
            this.uiLabel2.Text = "密码:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(33, 48);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(46, 21);
            this.uiLabel1.TabIndex = 37;
            this.uiLabel1.Text = "工号:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WorkerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 611);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "WorkerAddForm";
            this.Text = "WorkerAddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_workerTime)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_worker_number;
        private System.Windows.Forms.TextBox textBox_worker_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_worker_name;
        private System.Windows.Forms.TextBox textBox_worker_tel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_worker_birth;
        private System.Windows.Forms.TextBox textBox_worker_homeAddr;
        private System.Windows.Forms.ComboBox comboBox_worker_edu;
        private System.Windows.Forms.ComboBox comboBox_worker_lv;
        private System.Windows.Forms.NumericUpDown numericUpDown_workerTime;
        private System.Windows.Forms.TextBox textBox_worker_rec;
        private System.Windows.Forms.DateTimePicker dateTimePicker_joinTime;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.Label label_worker_number;
        private System.Windows.Forms.Label label_worker_password;
        private System.Windows.Forms.Label label_worker_name;
        private System.Windows.Forms.Label label_worker_tel;
        private System.Windows.Forms.Label label_worker_home_addr;
        private System.Windows.Forms.Label label_worker_rec;
        private System.Windows.Forms.Label label_worker_addr;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UIButton uiButton_push_change;
    }
}