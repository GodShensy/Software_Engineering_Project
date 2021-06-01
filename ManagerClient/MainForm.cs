using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerClient
{
    public partial class MainForm : Form
    {
        Form father = null;
        PasswordForm passwordForm = null;
        String managerId = null;
        String managerPassword = null;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Form form)
        {
            InitializeComponent();
            father = form;
        }

        public void setIdAndPassword(String id,String password)
        {
            managerId = id;
            managerPassword = password;
        }

        private void menu_btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_btn_reset_password_Click(object sender, EventArgs e)
        {
            passwordForm = new PasswordForm(this);
            passwordForm.setIdAndPassword(managerId, managerPassword);
            passwordForm.TopLevel = false;
            passwordForm.WindowState = FormWindowState.Maximized;
            passwordForm.FormBorderStyle = FormBorderStyle.None;
            passwordForm.Parent = this.panelForm;
            passwordForm.Show();
        }
    }
}
