using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkerClient.src.workers;

namespace WorkerClient
{
    public partial class Form1 : Form
    {
        MainFrom mainForm = null;
        String uid = "";
        String upassword = "";
        public Form1()
        {
            InitializeComponent();
            mainForm = new MainFrom(this);
            mainForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 登陆按钮
            uid = this.textBox_uid.Text;
            upassword = this.textBox_upassword.Text;
            if(uid.Equals(""))
            {
                MessageBox.Show("请输入用户id");
                return;
            }
            if(upassword.Equals(""))
            {
                MessageBox.Show("请输入密码");
            }

            WorkerService service = new WorkerService();

            if(!service.doWorkerSelect(uid,upassword))
            {
                MessageBox.Show("用户不存在");
                return;
            }
            // 跳转到主窗口
            MessageBox.Show("登陆成功");
            this.Hide();
            mainForm.resetButton();
            mainForm.setIdAndPassword(uid, upassword);
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
