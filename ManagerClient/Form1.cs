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

namespace ManagerClient
{
    public partial class Form1 : Form
    {
        MainForm mainForm = null;
        public Form1()
        {
            InitializeComponent();
            mainForm = new MainForm(this);
            mainForm.Hide();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            String managerId = this.textBox_id.Text;
            if(managerId.Equals(""))
            {
                MessageBox.Show("请输入账号");
                return;
            }    
            String password = this.textBox_password.Text;
            if(password.Equals(""))
            {
                MessageBox.Show("请输入密码");
                return;
            }
            ManagerService mag = new ManagerService();
            Boolean flag = mag.doManagerSelectByIdAndPassword(managerId, password);
            if(flag)
            {
                this.Hide();
                mainForm.Show();
                mainForm.setIdAndPassword(managerId,password);
                return;
            }
            MessageBox.Show("用户不存在");
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
