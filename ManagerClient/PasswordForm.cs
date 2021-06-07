using ManagerClient.src.managers;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerClient
{
    public partial class PasswordForm : UIForm
    {
        Form father = null;
        String userId = null;
        String userPassword = null;
        String newPassword = null;
        String checkPassword = null;
        String oldPassword = null;
        public PasswordForm()
        {
            InitializeComponent();
        }
        public PasswordForm(Form form)
        {
            InitializeComponent();
            father = form;
        }

        public void setIdAndPassword(String id , String password)
        {
            userId = id;
            userPassword = password;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            oldPassword = this.textBox_password.Text;
            if(oldPassword != userPassword)
            {
                this.label_reset_password_tip1.Text = "×";
                this.label_reset_password_tip1.ForeColor = Color.Red;
            }
            else
            {
                this.label_reset_password_tip1.Text = "√";
                this.label_reset_password_tip1.ForeColor = Color.Green;
            }
        }

        private void textBox_new_password_TextChanged(object sender, EventArgs e)
        {
            newPassword = this.textBox_new_password.Text;
            if(checkPassword != null)
            {
                if (checkPassword.Equals(newPassword))
                {
                    this.label_reset_password_tip2.Text = "√";
                    this.label_reset_password_tip2.ForeColor = Color.Green;
                    this.label_reset_password_tip3.Text = "√";
                    this.label_reset_password_tip3.ForeColor = Color.Green;
                }
                else
                {
                    this.label_reset_password_tip2.Text = "×";
                    this.label_reset_password_tip2.ForeColor = Color.Red;
                    this.label_reset_password_tip3.Text = "×";
                    this.label_reset_password_tip3.ForeColor = Color.Red;
                    //MessageBox.Show("请确两次新密码输入一致");
                }
            }
            else
            {
                this.label_reset_password_tip2.Text = "√";
                this.label_reset_password_tip2.ForeColor = Color.Green;
            }

        }

        private void textBox_check_password_TextChanged(object sender, EventArgs e)
        {
            checkPassword = this.textBox_check_password.Text;
            if(newPassword != null)
            {
                if(checkPassword.Equals(newPassword))
                {
                    this.label_reset_password_tip2.Text = "√";
                    this.label_reset_password_tip2.ForeColor = Color.Green;
                    this.label_reset_password_tip3.Text = "√";
                    this.label_reset_password_tip3.ForeColor = Color.Green;
                }
                else
                {
                    this.label_reset_password_tip2.Text = "×";
                    this.label_reset_password_tip2.ForeColor = Color.Red;
                    this.label_reset_password_tip3.Text = "×";
                    this.label_reset_password_tip3.ForeColor = Color.Red;
                    //MessageBox.Show("请确两次新密码输入一致");
                }
            }
        }



        private void uiButton_reset_password_Click(object sender, EventArgs e)
        {
            //doPasswordChange();
            if (newPassword == null || checkPassword == null || userPassword == null)
            {
                MessageBox.Show("请先输入信息");
                return;
            }
            if (!oldPassword.Equals(userPassword))
            {
                MessageBox.Show("原密码输入错误");
                return;
            }
            if (newPassword.Equals(checkPassword))
            {
                ManagerService mg = new ManagerService();
                if (mg.doPasswordChange(newPassword, userId))
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

        private void uiButton_clear_Click(object sender, EventArgs e)
        {
            textBox_check_password.Text = "";
            textBox_new_password.Text = "";
            textBox_password.Text = "";
            label_reset_password_tip1.Text = "*";
            label_reset_password_tip2.Text = "*";
            label_reset_password_tip3.Text = "*";
        }
    }
}
