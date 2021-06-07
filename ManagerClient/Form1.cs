using ManagerClient.src.managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sunny;
using Sunny.UI;
using WorkerClient.src.workers;

namespace ManagerClient
{
    public partial class Form1 : UIForm
    {
        MainForm mainForm = null;
        WorkerMainForm workerMainForm = null;

        public Boolean isManager = false;
        public Form1()
        {
            InitializeComponent();
         }

        private void button_log_Click(object sender, EventArgs e)
        {
            if(isManager == true)
            {
                mainForm = new MainForm(this);
                mainForm.Hide();
                String managerId = this.textBox_id.Text;
                if (managerId.Equals(""))
                {
                    MessageBox.Show("请输入账号");
                    return;
                }
                String password = this.textBox_password.Text;
                if (password.Equals(""))
                {
                    MessageBox.Show("请输入密码");
                    return;
                }
                ManagerService mag = new ManagerService();
                Boolean flag = mag.doManagerSelectByIdAndPassword(managerId, password);
                if (flag)
                {
                    this.Hide();
                    mainForm.Show();
                    mainForm.setIdAndPassword(managerId, password);
                    return;
                }
                MessageBox.Show("用户不存在");
            }else
            {
                workerMainForm = new WorkerMainForm(this);
                workerMainForm.Hide();
                String managerId = this.textBox_id.Text;
                if (managerId.Equals(""))
                {
                    MessageBox.Show("请输入账号");
                    return;
                }
                String password = this.textBox_password.Text;
                if (password.Equals(""))
                {
                    MessageBox.Show("请输入密码");
                    return;
                }
                WorkerService mag = new WorkerService();
                Boolean flag = mag.doWorkerSelect(managerId, password);
                if (flag)
                {
                    this.Hide();
                    workerMainForm.Show();
                    workerMainForm.setIdAndPassword(managerId, password);
                    return;
                }
                MessageBox.Show("用户不存在");
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiCheckBox_isMannager_CheckedChanged(object sender, EventArgs e)
        {
            if (this.uiCheckBox_isMannager.Checked == true)
            {
                isManager = true;
            }
            else
            {
                isManager = false;
            }
        }
    }
}
