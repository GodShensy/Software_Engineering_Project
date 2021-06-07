
namespace ManagerClient
{
    partial class WorkerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerMainForm));
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiButton_unsign = new Sunny.UI.UIButton();
            this.uiButton_sign = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel_longData = new Sunny.UI.UILabel();
            this.uiLabel_shortData = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel_checkPassowrd = new Sunny.UI.UILabel();
            this.uiLabel_newPassowrd = new Sunny.UI.UILabel();
            this.uiLabel_oldPassword = new Sunny.UI.UILabel();
            this.uiTextBox_checkPassword = new Sunny.UI.UITextBox();
            this.uiTextBox_newPassword = new Sunny.UI.UITextBox();
            this.uiTextBox_oldPassword = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiTextBox_userName = new Sunny.UI.UITextBox();
            this.uiTextBox_userAddr = new Sunny.UI.UITextBox();
            this.uiTextBox_userTel = new Sunny.UI.UITextBox();
            this.uiDatePicker_userBirth = new Sunny.UI.UIDatePicker();
            this.uiButton_check = new Sunny.UI.UIButton();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(30, 120);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(800, 432);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiButton_unsign);
            this.tabPage1.Controls.Add(this.uiButton_sign);
            this.tabPage1.Controls.Add(this.uiGroupBox2);
            this.tabPage1.Location = new System.Drawing.Point(121, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(679, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "签到&请假";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiButton_unsign
            // 
            this.uiButton_unsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_unsign.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_unsign.Location = new System.Drawing.Point(216, 314);
            this.uiButton_unsign.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_unsign.Name = "uiButton_unsign";
            this.uiButton_unsign.Size = new System.Drawing.Size(100, 35);
            this.uiButton_unsign.TabIndex = 2;
            this.uiButton_unsign.Text = "请假";
            this.uiButton_unsign.Click += new System.EventHandler(this.uiButton_unsign_Click);
            // 
            // uiButton_sign
            // 
            this.uiButton_sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_sign.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_sign.Location = new System.Drawing.Point(67, 314);
            this.uiButton_sign.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_sign.Name = "uiButton_sign";
            this.uiButton_sign.Size = new System.Drawing.Size(100, 35);
            this.uiButton_sign.TabIndex = 1;
            this.uiButton_sign.Text = "签到";
            this.uiButton_sign.Click += new System.EventHandler(this.uiButton_sign_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiLabel_longData);
            this.uiGroupBox2.Controls.Add(this.uiLabel_shortData);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(31, 36);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(378, 143);
            this.uiGroupBox2.TabIndex = 0;
            this.uiGroupBox2.Text = "系统时间";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel_longData
            // 
            this.uiLabel_longData.AutoSize = true;
            this.uiLabel_longData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_longData.Location = new System.Drawing.Point(8, 112);
            this.uiLabel_longData.Name = "uiLabel_longData";
            this.uiLabel_longData.Size = new System.Drawing.Size(96, 21);
            this.uiLabel_longData.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_longData.TabIndex = 1;
            this.uiLabel_longData.Text = "2021/03/03";
            this.uiLabel_longData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_shortData
            // 
            this.uiLabel_shortData.AutoSize = true;
            this.uiLabel_shortData.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_shortData.Location = new System.Drawing.Point(64, 32);
            this.uiLabel_shortData.Name = "uiLabel_shortData";
            this.uiLabel_shortData.Size = new System.Drawing.Size(256, 75);
            this.uiLabel_shortData.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_shortData.TabIndex = 0;
            this.uiLabel_shortData.Text = "00:00:00";
            this.uiLabel_shortData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiButton2);
            this.tabPage2.Controls.Add(this.uiButton1);
            this.tabPage2.Controls.Add(this.uiGroupBox1);
            this.tabPage2.Location = new System.Drawing.Point(121, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(679, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改密码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton2.Location = new System.Drawing.Point(396, 336);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(128, 35);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "清空";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(122, 336);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(119, 35);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "修改";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel_checkPassowrd);
            this.uiGroupBox1.Controls.Add(this.uiLabel_newPassowrd);
            this.uiGroupBox1.Controls.Add(this.uiLabel_oldPassword);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_checkPassword);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_newPassword);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_oldPassword);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(95, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(480, 259);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel_checkPassowrd
            // 
            this.uiLabel_checkPassowrd.AutoSize = true;
            this.uiLabel_checkPassowrd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_checkPassowrd.Location = new System.Drawing.Point(370, 161);
            this.uiLabel_checkPassowrd.Name = "uiLabel_checkPassowrd";
            this.uiLabel_checkPassowrd.Size = new System.Drawing.Size(17, 21);
            this.uiLabel_checkPassowrd.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_checkPassowrd.TabIndex = 4;
            this.uiLabel_checkPassowrd.Text = "*";
            this.uiLabel_checkPassowrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_newPassowrd
            // 
            this.uiLabel_newPassowrd.AutoSize = true;
            this.uiLabel_newPassowrd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_newPassowrd.Location = new System.Drawing.Point(371, 113);
            this.uiLabel_newPassowrd.Name = "uiLabel_newPassowrd";
            this.uiLabel_newPassowrd.Size = new System.Drawing.Size(17, 21);
            this.uiLabel_newPassowrd.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_newPassowrd.TabIndex = 4;
            this.uiLabel_newPassowrd.Text = "*";
            this.uiLabel_newPassowrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_oldPassword
            // 
            this.uiLabel_oldPassword.AutoSize = true;
            this.uiLabel_oldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_oldPassword.Location = new System.Drawing.Point(371, 63);
            this.uiLabel_oldPassword.Name = "uiLabel_oldPassword";
            this.uiLabel_oldPassword.Size = new System.Drawing.Size(17, 21);
            this.uiLabel_oldPassword.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_oldPassword.TabIndex = 4;
            this.uiLabel_oldPassword.Text = "*";
            this.uiLabel_oldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_checkPassword
            // 
            this.uiTextBox_checkPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_checkPassword.FillColor = System.Drawing.Color.White;
            this.uiTextBox_checkPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_checkPassword.Location = new System.Drawing.Point(138, 157);
            this.uiTextBox_checkPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_checkPassword.Maximum = 2147483647D;
            this.uiTextBox_checkPassword.Minimum = -2147483648D;
            this.uiTextBox_checkPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_checkPassword.Name = "uiTextBox_checkPassword";
            this.uiTextBox_checkPassword.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_checkPassword.Size = new System.Drawing.Size(225, 29);
            this.uiTextBox_checkPassword.TabIndex = 3;
            this.uiTextBox_checkPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_checkPassword.TextChanged += new System.EventHandler(this.uiTextBox_checkPassword_TextChanged);
            // 
            // uiTextBox_newPassword
            // 
            this.uiTextBox_newPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_newPassword.FillColor = System.Drawing.Color.White;
            this.uiTextBox_newPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_newPassword.Location = new System.Drawing.Point(138, 108);
            this.uiTextBox_newPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_newPassword.Maximum = 2147483647D;
            this.uiTextBox_newPassword.Minimum = -2147483648D;
            this.uiTextBox_newPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_newPassword.Name = "uiTextBox_newPassword";
            this.uiTextBox_newPassword.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_newPassword.Size = new System.Drawing.Size(225, 29);
            this.uiTextBox_newPassword.TabIndex = 2;
            this.uiTextBox_newPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_newPassword.TextChanged += new System.EventHandler(this.uiTextBox_newPassword_TextChanged);
            // 
            // uiTextBox_oldPassword
            // 
            this.uiTextBox_oldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_oldPassword.FillColor = System.Drawing.Color.White;
            this.uiTextBox_oldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_oldPassword.Location = new System.Drawing.Point(138, 58);
            this.uiTextBox_oldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_oldPassword.Maximum = 2147483647D;
            this.uiTextBox_oldPassword.Minimum = -2147483648D;
            this.uiTextBox_oldPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_oldPassword.Name = "uiTextBox_oldPassword";
            this.uiTextBox_oldPassword.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_oldPassword.Size = new System.Drawing.Size(225, 29);
            this.uiTextBox_oldPassword.TabIndex = 1;
            this.uiTextBox_oldPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_oldPassword.TextChanged += new System.EventHandler(this.uiTextBox_oldPassword_TextChanged);
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(27, 157);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(107, 25);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "确认密码：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(43, 113);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(88, 25);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "新密码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(43, 63);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(88, 25);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "原密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiCheckBoxGroup1);
            this.tabPage3.Location = new System.Drawing.Point(121, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(679, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改个人信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton_check);
            this.uiCheckBoxGroup1.Controls.Add(this.uiDatePicker_userBirth);
            this.uiCheckBoxGroup1.Controls.Add(this.uiTextBox_userTel);
            this.uiCheckBoxGroup1.Controls.Add(this.uiTextBox_userAddr);
            this.uiCheckBoxGroup1.Controls.Add(this.uiTextBox_userName);
            this.uiCheckBoxGroup1.Controls.Add(this.label7);
            this.uiCheckBoxGroup1.Controls.Add(this.label6);
            this.uiCheckBoxGroup1.Controls.Add(this.label5);
            this.uiCheckBoxGroup1.Controls.Add(this.label2);
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(18, 16);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(623, 387);
            this.uiCheckBoxGroup1.TabIndex = 0;
            this.uiCheckBoxGroup1.Text = "用户信息";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(148, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "电话:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "先居住地:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(148, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "生日:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiTextBox_userName
            // 
            this.uiTextBox_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_userName.FillColor = System.Drawing.Color.White;
            this.uiTextBox_userName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_userName.Location = new System.Drawing.Point(221, 75);
            this.uiTextBox_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_userName.Maximum = 2147483647D;
            this.uiTextBox_userName.Minimum = -2147483648D;
            this.uiTextBox_userName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_userName.Name = "uiTextBox_userName";
            this.uiTextBox_userName.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_userName.Size = new System.Drawing.Size(223, 29);
            this.uiTextBox_userName.TabIndex = 1;
            this.uiTextBox_userName.Text = "uiTextBox1";
            this.uiTextBox_userName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_userAddr
            // 
            this.uiTextBox_userAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_userAddr.FillColor = System.Drawing.Color.White;
            this.uiTextBox_userAddr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_userAddr.Location = new System.Drawing.Point(221, 113);
            this.uiTextBox_userAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_userAddr.Maximum = 2147483647D;
            this.uiTextBox_userAddr.Minimum = -2147483648D;
            this.uiTextBox_userAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_userAddr.Name = "uiTextBox_userAddr";
            this.uiTextBox_userAddr.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_userAddr.Size = new System.Drawing.Size(223, 29);
            this.uiTextBox_userAddr.TabIndex = 2;
            this.uiTextBox_userAddr.Text = "uiTextBox2";
            this.uiTextBox_userAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_userTel
            // 
            this.uiTextBox_userTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_userTel.FillColor = System.Drawing.Color.White;
            this.uiTextBox_userTel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_userTel.Location = new System.Drawing.Point(221, 210);
            this.uiTextBox_userTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_userTel.Maximum = 2147483647D;
            this.uiTextBox_userTel.Minimum = -2147483648D;
            this.uiTextBox_userTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_userTel.Name = "uiTextBox_userTel";
            this.uiTextBox_userTel.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_userTel.Size = new System.Drawing.Size(223, 29);
            this.uiTextBox_userTel.TabIndex = 3;
            this.uiTextBox_userTel.Text = "uiTextBox3";
            this.uiTextBox_userTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiDatePicker_userBirth
            // 
            this.uiDatePicker_userBirth.FillColor = System.Drawing.Color.White;
            this.uiDatePicker_userBirth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiDatePicker_userBirth.Location = new System.Drawing.Point(221, 165);
            this.uiDatePicker_userBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker_userBirth.MaxLength = 10;
            this.uiDatePicker_userBirth.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker_userBirth.Name = "uiDatePicker_userBirth";
            this.uiDatePicker_userBirth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker_userBirth.Size = new System.Drawing.Size(223, 29);
            this.uiDatePicker_userBirth.SymbolDropDown = 61555;
            this.uiDatePicker_userBirth.SymbolNormal = 61555;
            this.uiDatePicker_userBirth.TabIndex = 4;
            this.uiDatePicker_userBirth.Text = "uiDatePicker1";
            this.uiDatePicker_userBirth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker_userBirth.Value = new System.DateTime(2021, 6, 7, 21, 34, 44, 823);
            // 
            // uiButton_check
            // 
            this.uiButton_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_check.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_check.Location = new System.Drawing.Point(248, 300);
            this.uiButton_check.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_check.Name = "uiButton_check";
            this.uiButton_check.Size = new System.Drawing.Size(100, 35);
            this.uiButton_check.TabIndex = 5;
            this.uiButton_check.Text = "确定";
            this.uiButton_check.Click += new System.EventHandler(this.uiButton_check_Click);
            // 
            // WorkerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "WorkerMainForm";
            this.Text = "WorkerMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkerMainForm_FormClosed);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox_checkPassword;
        private Sunny.UI.UITextBox uiTextBox_newPassword;
        private Sunny.UI.UITextBox uiTextBox_oldPassword;
        private Sunny.UI.UILabel uiLabel_checkPassowrd;
        private Sunny.UI.UILabel uiLabel_newPassowrd;
        private Sunny.UI.UILabel uiLabel_oldPassword;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel_shortData;
        private Sunny.UI.UILabel uiLabel_longData;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIButton uiButton_unsign;
        private Sunny.UI.UIButton uiButton_sign;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox uiTextBox_userTel;
        private Sunny.UI.UITextBox uiTextBox_userAddr;
        private Sunny.UI.UITextBox uiTextBox_userName;
        private Sunny.UI.UIDatePicker uiDatePicker_userBirth;
        private Sunny.UI.UIButton uiButton_check;
    }
}