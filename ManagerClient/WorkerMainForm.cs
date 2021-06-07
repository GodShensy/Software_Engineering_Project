using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workers;
using WorkerClient.src.workerSign;

namespace ManagerClient
{
    public partial class WorkerMainForm : UIForm
    {
        Form father = null;
        String workerId = null;
        String workerPassword = null;
        String oldPassword = null;
        String newPassword = null;
        String checkPassword = null;
        WorkerInf inf = null;
        public WorkerMainForm()
        {
            InitializeComponent();
        }
        public WorkerMainForm(Form f)
        {
            InitializeComponent();
            father = f;
        }

        internal void setIdAndPassword(string managerId, string password)
        {
            workerId = managerId;
            workerPassword = password;
            this.uiCheckBoxGroup1.Text = "用户ID:" + workerId;
        }

        private void WorkerMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (newPassword == null || checkPassword == null || workerPassword == null)
            {
                MessageBox.Show("请先输入信息");
                return;
            }
            if (!oldPassword.Equals(workerPassword))
            {
                MessageBox.Show("原密码输入错误");
                return;
            }
            if (newPassword.Equals(checkPassword))
            {
                WorkerService mg = new WorkerService();
                if (mg.doPasswordChange(newPassword, workerId))
                    MessageBox.Show("密码修改成功");
                else
                    MessageBox.Show("密码修改失败");
            }
            else
            {
                MessageBox.Show("两次密码输入不一致");
                return;
            }
        }

        private void uiTextBox_oldPassword_TextChanged(object sender, EventArgs e)
        {
            oldPassword = this.uiTextBox_oldPassword.Text;
            if (oldPassword != workerPassword)
            {
                this.uiLabel_oldPassword.Text = "×";
                this.uiLabel_oldPassword.ForeColor = Color.Red;
            }
            else
            {
                this.uiLabel_oldPassword.Text = "√";
                this.uiLabel_oldPassword.ForeColor = Color.Green;
            }
        }

        private void uiTextBox_newPassword_TextChanged(object sender, EventArgs e)
        {
            newPassword = this.uiTextBox_newPassword.Text;
            if (checkPassword != null)
            {
                if (checkPassword.Equals(newPassword))
                {
                    this.uiLabel_newPassowrd.Text = "√";
                    this.uiLabel_newPassowrd.ForeColor = Color.Green;
                    this.uiLabel_checkPassowrd.Text = "√";
                    this.uiLabel_checkPassowrd.ForeColor = Color.Green;
                }
                else
                {
                    this.uiLabel_newPassowrd.Text = "×";
                    this.uiLabel_newPassowrd.ForeColor = Color.Red;
                    this.uiLabel_checkPassowrd.Text = "×";
                    this.uiLabel_checkPassowrd.ForeColor = Color.Red;
                    //MessageBox.Show("请确两次新密码输入一致");
                }
            }
            else
            {
                this.uiLabel_newPassowrd.Text = "√";
                this.uiLabel_newPassowrd.ForeColor = Color.Green;
            }
        }

        private void uiTextBox_checkPassword_TextChanged(object sender, EventArgs e)
        {
            checkPassword = this.uiTextBox_checkPassword.Text;
            if (newPassword != null)
            {
                if (checkPassword.Equals(newPassword))
                {
                    this.uiLabel_newPassowrd.Text = "√";
                    this.uiLabel_newPassowrd.ForeColor = Color.Green;
                    this.uiLabel_checkPassowrd.Text = "√";
                    this.uiLabel_checkPassowrd.ForeColor = Color.Green;
                }
                else
                {
                    this.uiLabel_newPassowrd.Text = "×";
                    this.uiLabel_newPassowrd.ForeColor = Color.Red;
                    this.uiLabel_checkPassowrd.Text = "×";
                    this.uiLabel_checkPassowrd.ForeColor = Color.Red;
                    //MessageBox.Show("请确两次新密码输入一致");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            uiLabel_longData.Text = DateTime.Now.ToLongDateString();
            uiLabel_shortData.Text = DateTime.Now.ToLongTimeString();
        }

        private void uiButton_sign_Click(object sender, EventArgs e)
        {
            WorkerSignService service = new WorkerSignService();

            if (service.doUserSignUpLoad(workerId, 1, DateTime.Now, "正常签到"))
            {
                MessageBox.Show("成功申请");
            }
            else
            {
                MessageBox.Show("申请失败");
            }

            this.uiButton_sign.Enabled = false;
            this.uiButton_unsign.Enabled = false;
        }

        private void uiButton_unsign_Click(object sender, EventArgs e)
        {
            InstructionsForm ins = new InstructionsForm(this);
            ins.ShowDialog();
            String setStr = ins.Instr;
            WorkerSignService service = new WorkerSignService();

            if (service.doUserSignUpLoad(workerId, 0, DateTime.Now, setStr))
            {
                MessageBox.Show("成功申请");
            }
            else
            {
                MessageBox.Show("申请失败");
            }

            this.uiButton_sign.Enabled = false;
            this.uiButton_unsign.Enabled = false;
        }

        private void uiButton_check_Click(object sender, EventArgs e)
        {
            List<WorkerInf> ls = null;
            WorkerService service = new WorkerService();
            String sql = "select * from workertab where workerNumber = @pair0;";
            String[] parms =
            {
                workerId
            };
            ls = service.selelectWorkerInf(sql, parms);
            if(ls.Count < 0)
            {
                MessageBox.Show("无数据");
            }
            else
            {
                inf = new WorkerInf();
                inf.Id = ls[0].Id;
                inf.WorkerNumber = ls[0].WorkerNumber;
                inf.WorkerPassword = ls[0].WorkerPassword;
                inf.WorkerName = ls[0].WorkerName;
                inf.WorkerSex = ls[0].WorkerSex;
                inf.WorkerBirth = ls[0].WorkerBirth;
                inf.WorkerHomeAddr = ls[0].WorkerHomeAddr;
                inf.WorkerEdu = ls[0].WorkerEdu;
                inf.WorkerLv = ls[0].WorkerLv;
                inf.WorkerTime = ls[0].WorkerTime;
                inf. = ls[0].WorkerNumber;
                inf.WorkerNumber = ls[0].WorkerNumber;
                inf.WorkerNumber = ls[0].WorkerNumber;
            }
        }
    }
}
