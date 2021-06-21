using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sunny;
using Sunny.UI;

namespace ManagerClient
{
    public partial class MainForm : UIForm
    {
        Form father = null;
        PasswordForm passwordForm = null;
        InfoForm infoForm = null;
        RecForm recForm = null;
        ApplyForm applyForm = null;
        SignForm signForm = null;
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

        private void closeSonForm()
        {
            if (passwordForm != null)
            {
                passwordForm.Dispose();
                passwordForm = null;
            }
            if(infoForm != null)
            {
                infoForm.Dispose();
                infoForm = null;
            }
            if(recForm != null)
            {
                recForm.Dispose();
                recForm = null;
            }
            if(signForm != null)
            {
                signForm.Dispose();
                signForm = null;
            }
            if(applyForm != null)
            {
                applyForm.Dispose();
                applyForm = null;
            }
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
            closeSonForm();
            if (passwordForm == null)
                passwordForm = new PasswordForm(this);
            passwordForm.setIdAndPassword(managerId, managerPassword);
            passwordForm.TopLevel = false;
            passwordForm.WindowState = FormWindowState.Maximized;
            passwordForm.FormBorderStyle = FormBorderStyle.None;
            passwordForm.Parent = this.panelForm;
            passwordForm.Show();
        }

        private void menu_info_btn_Click(object sender, EventArgs e)
        {
            closeSonForm();
            if (infoForm == null)
                infoForm = new InfoForm(this);

            //infoForm.setIdAndPassword(managerId, managerPassword);
            infoForm.TopLevel = false;
            infoForm.WindowState = FormWindowState.Maximized;
            infoForm.FormBorderStyle = FormBorderStyle.None;
            infoForm.Parent = this.panelForm;
            infoForm.Show();
        }

        private void ToolStripMenuItem_rec_Click(object sender, EventArgs e)
        {
            closeSonForm();
            if (recForm == null)
                recForm = new RecForm(this);
            recForm.TopLevel = false;
            recForm.WindowState = FormWindowState.Maximized;
            recForm.FormBorderStyle = FormBorderStyle.None;
            recForm.Parent = this.panelForm;
            recForm.Show();
        }

        private void toolStripMenuItem_signManage_Click(object sender, EventArgs e)
        {
            closeSonForm();
            if(signForm == null)
                signForm = new SignForm(this);
            signForm.TopLevel = false;
            signForm.WindowState = FormWindowState.Maximized;
            signForm.FormBorderStyle = FormBorderStyle.None;
            signForm.Parent = this.panelForm;
            signForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem_regin_Click(object sender, EventArgs e)
        {
            closeSonForm();
            if (applyForm == null)
                applyForm = new ApplyForm(this);
            applyForm.TopLevel = false;
            applyForm.WindowState = FormWindowState.Maximized;
            applyForm.FormBorderStyle = FormBorderStyle.None;
            applyForm.Parent = this.panelForm;
            applyForm.Show();
        }
    }
}
