using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workerRegister;

namespace WorkerClient
{
    public partial class RegFrom : Form
    {
        Form fatherForm = null;

        public RegFrom()
        {
            InitializeComponent();
        }

        public RegFrom(Form form)
        {
            InitializeComponent();
            this.fatherForm = form;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            fatherForm.Show();
        }

        private void button_push_data_Click(object sender, EventArgs e)
        {
            String inputName = this.textBox_name.Text;
            String inputPassword = this.textBox_password.Text;
            int sex = radioButton_man.Checked ? 1 : 0;
            DateTime dateTime = this.dateTimePicker_birth.Value;
            String homeAddr = this.textBox_home_addr.Text;
            String Addr = this.textBox_addr.Text;
            int edu = this.comboBox_edu.SelectedIndex;
            String tel = this.textBox_tel.Text;
            WorkerRegInf regInf = new WorkerRegInf();
            regInf.WorkerRegName = inputName;
            regInf.WorkerRegPassword = inputPassword;
            regInf.WorkerRegSex = sex;
            regInf.WorkerRegBirth = dateTime.ToString();
            regInf.WorkerRegHomeAddr = homeAddr;
            regInf.WorkerRegAddr = Addr;
            regInf.WorkerRegEdu = edu;
            regInf.WorkerRegTel = tel;
            WorkerRegService service = new WorkerRegService();
            service.insertWorkerInf(regInf);
            MessageBox.Show("提交完成!");
        }
    }
}
