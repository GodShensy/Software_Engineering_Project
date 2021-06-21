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
    public partial class InstructionsForm : UIForm
    {
        Form father = null;
        private String instr = null;

        public string Instr { get => instr; set => instr = value; }

        public InstructionsForm()
        {
            InitializeComponent();
        }

        public InstructionsForm(Form form)
        {
            InitializeComponent();
            father = form;
        }

        private void uiButton_check_Click(object sender, EventArgs e)
        {
            Instr = this.uiTextBox1.Text;
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.uiTextBox1.Text = "";
        }
    }
}
