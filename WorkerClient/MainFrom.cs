using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workerSign;

namespace WorkerClient
{
    public partial class MainFrom : Form
    {
        Form fatherForm = null;
        private String userNumber = "";
        private String userPassword = "";
        public MainFrom()
        {
            InitializeComponent();
        }

        public MainFrom(Form father)
        {
            InitializeComponent();
            this.fatherForm = father;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            fatherForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_s.Text = DateTime.Now.ToString();
        }

        private void buttom_sign_Click(object sender, EventArgs e)
        {
            WorkerSignService service = new WorkerSignService();

            if(service.doUserSignUpLoad(userNumber, DateTime.Now, 1))
            {
                MessageBox.Show("成功申请");
            }
            else
            {
                MessageBox.Show("申请失败");
            }

            this.buttom_sign.Enabled = false;
            this.button_leave.Enabled = false;
        }

        private void button_leave_Click(object sender, EventArgs e)
        {
            WorkerSignService service = new WorkerSignService();

            if (service.doUserSignUpLoad(userNumber, DateTime.Now, 0))
            {
                MessageBox.Show("成功申请");
            }
            else
            {
                MessageBox.Show("申请失败");
            }

            this.buttom_sign.Enabled = false;
            this.button_leave.Enabled = false;
        }

        public void setIdAndPassword(String id, String password)
        {
            userNumber = id;
            userPassword = password;
        }

        public void resetButton()
        {
            this.buttom_sign.Enabled = true;
            this.button_leave.Enabled = true;
        }
    }
}
