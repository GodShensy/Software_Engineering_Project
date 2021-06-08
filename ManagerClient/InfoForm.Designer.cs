
namespace ManagerClient
{
    partial class InfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView_worker = new Sunny.UI.UIDataGridView();
            this.uiButton_showData = new Sunny.UI.UIButton();
            this.uiButton_clearInfo = new Sunny.UI.UIButton();
            this.uiButton_SelectInfo = new Sunny.UI.UIButton();
            this.uiButton_infoSave = new Sunny.UI.UIButton();
            this.uiButton_readInfo = new Sunny.UI.UIButton();
            this.uiButton_Add = new Sunny.UI.UIButton();
            this.workerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerHomeAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerLv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerJoinTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBaseRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView_worker
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_worker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView_worker.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_worker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_worker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView_worker.ColumnHeadersHeight = 32;
            this.uiDataGridView_worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_worker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerNumber,
            this.workerPassword,
            this.workerName,
            this.workerSex,
            this.workerBirth,
            this.workerHomeAddr,
            this.workerEdu,
            this.workerLv,
            this.workerTime,
            this.workerJoinTime,
            this.workerBaseRec,
            this.workerAddr,
            this.workerTel,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView_worker.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView_worker.EnableHeadersVisualStyles = false;
            this.uiDataGridView_worker.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiDataGridView_worker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_worker.Location = new System.Drawing.Point(12, 53);
            this.uiDataGridView_worker.Name = "uiDataGridView_worker";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_worker.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_worker.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView_worker.RowTemplate.Height = 29;
            this.uiDataGridView_worker.SelectedIndex = -1;
            this.uiDataGridView_worker.ShowGridLine = true;
            this.uiDataGridView_worker.Size = new System.Drawing.Size(792, 400);
            this.uiDataGridView_worker.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView_worker.TabIndex = 7;
            this.uiDataGridView_worker.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_worker_CellContentDoubleClick);
            this.uiDataGridView_worker.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_worker_CellEndEdit);
            this.uiDataGridView_worker.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiDataGridView_worker_ColumnHeaderMouseClick);
            // 
            // uiButton_showData
            // 
            this.uiButton_showData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_showData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_showData.Location = new System.Drawing.Point(11, 12);
            this.uiButton_showData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_showData.Name = "uiButton_showData";
            this.uiButton_showData.Size = new System.Drawing.Size(100, 35);
            this.uiButton_showData.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_showData.TabIndex = 8;
            this.uiButton_showData.Text = "ShowData";
            this.uiButton_showData.Click += new System.EventHandler(this.uiButton_showData_Click);
            // 
            // uiButton_clearInfo
            // 
            this.uiButton_clearInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_clearInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_clearInfo.Location = new System.Drawing.Point(117, 12);
            this.uiButton_clearInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_clearInfo.Name = "uiButton_clearInfo";
            this.uiButton_clearInfo.Size = new System.Drawing.Size(100, 35);
            this.uiButton_clearInfo.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_clearInfo.TabIndex = 9;
            this.uiButton_clearInfo.Text = "ClearInfo";
            this.uiButton_clearInfo.Click += new System.EventHandler(this.uiButton_clearInfo_Click);
            // 
            // uiButton_SelectInfo
            // 
            this.uiButton_SelectInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_SelectInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_SelectInfo.Location = new System.Drawing.Point(223, 12);
            this.uiButton_SelectInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_SelectInfo.Name = "uiButton_SelectInfo";
            this.uiButton_SelectInfo.Size = new System.Drawing.Size(100, 35);
            this.uiButton_SelectInfo.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_SelectInfo.TabIndex = 10;
            this.uiButton_SelectInfo.Text = "Select";
            this.uiButton_SelectInfo.Click += new System.EventHandler(this.uiButton_SelectInfo_Click);
            // 
            // uiButton_infoSave
            // 
            this.uiButton_infoSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_infoSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_infoSave.Location = new System.Drawing.Point(329, 12);
            this.uiButton_infoSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_infoSave.Name = "uiButton_infoSave";
            this.uiButton_infoSave.Size = new System.Drawing.Size(100, 35);
            this.uiButton_infoSave.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_infoSave.TabIndex = 11;
            this.uiButton_infoSave.Text = "Save";
            this.uiButton_infoSave.Click += new System.EventHandler(this.uiButton_infoSave_Click);
            // 
            // uiButton_readInfo
            // 
            this.uiButton_readInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_readInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_readInfo.Location = new System.Drawing.Point(435, 12);
            this.uiButton_readInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_readInfo.Name = "uiButton_readInfo";
            this.uiButton_readInfo.Size = new System.Drawing.Size(100, 35);
            this.uiButton_readInfo.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_readInfo.TabIndex = 12;
            this.uiButton_readInfo.Text = "ReadFile";
            this.uiButton_readInfo.Click += new System.EventHandler(this.uiButton_readInfo_Click);
            // 
            // uiButton_Add
            // 
            this.uiButton_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_Add.Location = new System.Drawing.Point(541, 12);
            this.uiButton_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Add.Name = "uiButton_Add";
            this.uiButton_Add.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Add.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_Add.TabIndex = 13;
            this.uiButton_Add.Text = "Add";
            this.uiButton_Add.Click += new System.EventHandler(this.uiButton_Add_Click);
            // 
            // workerNumber
            // 
            this.workerNumber.DataPropertyName = "workerNumber";
            this.workerNumber.HeaderText = "工号";
            this.workerNumber.Name = "workerNumber";
            this.workerNumber.ReadOnly = true;
            // 
            // workerPassword
            // 
            this.workerPassword.DataPropertyName = "workerPassword";
            this.workerPassword.HeaderText = "密码";
            this.workerPassword.Name = "workerPassword";
            // 
            // workerName
            // 
            this.workerName.DataPropertyName = "workerName";
            this.workerName.HeaderText = "姓名";
            this.workerName.Name = "workerName";
            // 
            // workerSex
            // 
            this.workerSex.DataPropertyName = "workerSex";
            this.workerSex.HeaderText = "性别 *";
            this.workerSex.Name = "workerSex";
            // 
            // workerBirth
            // 
            this.workerBirth.DataPropertyName = "workerBirth";
            this.workerBirth.HeaderText = "生日 *";
            this.workerBirth.Name = "workerBirth";
            // 
            // workerHomeAddr
            // 
            this.workerHomeAddr.DataPropertyName = "workerHomeAddr";
            this.workerHomeAddr.HeaderText = "籍贯";
            this.workerHomeAddr.Name = "workerHomeAddr";
            // 
            // workerEdu
            // 
            this.workerEdu.DataPropertyName = "workerEdu";
            this.workerEdu.HeaderText = "学历 *";
            this.workerEdu.Name = "workerEdu";
            // 
            // workerLv
            // 
            this.workerLv.DataPropertyName = "workerLv";
            this.workerLv.HeaderText = "等级 *";
            this.workerLv.Name = "workerLv";
            // 
            // workerTime
            // 
            this.workerTime.DataPropertyName = "workerTime";
            this.workerTime.HeaderText = "工龄 *";
            this.workerTime.Name = "workerTime";
            // 
            // workerJoinTime
            // 
            this.workerJoinTime.DataPropertyName = "workerJoinTime";
            this.workerJoinTime.HeaderText = "加入时间 *";
            this.workerJoinTime.Name = "workerJoinTime";
            // 
            // workerBaseRec
            // 
            this.workerBaseRec.DataPropertyName = "workerBaseRec";
            this.workerBaseRec.HeaderText = "基本收入 *";
            this.workerBaseRec.Name = "workerBaseRec";
            // 
            // workerAddr
            // 
            this.workerAddr.DataPropertyName = "workerAdd";
            this.workerAddr.HeaderText = "现居住地";
            this.workerAddr.Name = "workerAddr";
            // 
            // workerTel
            // 
            this.workerTel.DataPropertyName = "workerTel";
            this.workerTel.HeaderText = "电话";
            this.workerTel.Name = "workerTel";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // InfoForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(816, 465);
            this.ControlBox = false;
            this.Controls.Add(this.uiButton_Add);
            this.Controls.Add(this.uiButton_readInfo);
            this.Controls.Add(this.uiButton_infoSave);
            this.Controls.Add(this.uiButton_SelectInfo);
            this.Controls.Add(this.uiButton_clearInfo);
            this.Controls.Add(this.uiButton_showData);
            this.Controls.Add(this.uiDataGridView_worker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowInTaskbar = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "InfoForm";
            this.TextAlignment = System.Drawing.StringAlignment.Far;
            this.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_worker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView uiDataGridView_worker;
        private Sunny.UI.UIButton uiButton_showData;
        private Sunny.UI.UIButton uiButton_clearInfo;
        private Sunny.UI.UIButton uiButton_SelectInfo;
        private Sunny.UI.UIButton uiButton_infoSave;
        private Sunny.UI.UIButton uiButton_readInfo;
        private Sunny.UI.UIButton uiButton_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerHomeAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerLv;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerJoinTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBaseRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}