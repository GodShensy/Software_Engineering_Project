using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkerClient
{
    public partial class MainFrom : Form
    {
        Form fatherForm = null;
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
    }
}
