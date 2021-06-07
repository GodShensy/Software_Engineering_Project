using DataBaseTest.DateBaseAccess;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workers;

namespace ManagerClient
{
    public partial class SelectFrom : UIForm
    {
        public List<WorkerInf> list = null;
        private Boolean status;
        Form father = null;
        public SelectFrom()
        {
            InitializeComponent();
            status = false;
        }

        public SelectFrom(Form form)
        {
            InitializeComponent();
            father = form;
            status = false;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
          
        }

        public List<WorkerInf> getInfoList()
        {
            return list;
        }

        public Boolean selectStatus()
        {
            return status; 
        }

        private void uiButton_select_Click(object sender, EventArgs e)
        {
            String workerName = this.textBox_worker_name.Text;
            String workerNumber = this.textBox_worker_number.Text;
            String workerTime = this.numericUpDown_worker_time.Value.ToString();
            String workerJoinTime = this.dateTimePicker_join_time.Value.ToShortDateString();
            String sql = "select * from workertab";
            Boolean isfirst = true;
            status = true;
            if (!workerName.Equals(""))
            {
                if (isfirst)
                {
                    sql += (" where workerName = '" + workerName + "' ");
                    isfirst = false;
                }
                else
                {
                    sql += ("and workerName = '" + workerName + "' ");
                }
            }

            if (!workerNumber.Equals(""))
            {
                if (isfirst)
                {
                    sql += (" where workerNumber = '" + workerNumber + "' ");
                    isfirst = false;
                }
                else
                {
                    sql += ("and workerNumber = '" + workerNumber + "' ");
                }
            }

            if (!workerTime.Equals("") && this.checkBox_use_time.Checked)
            {
                if (isfirst)
                {
                    sql += (" where workerTime = " + workerTime + " ");
                    isfirst = false;
                }
                else
                {
                    sql += ("and workerTime = " + workerTime + " ");
                }
            }

            if (!workerJoinTime.Equals("") && this.checkBox_jointime.Checked)
            {
                if (isfirst)
                {
                    sql += (" where workerJoinTime = " + workerJoinTime + "' ");
                    isfirst = false;
                }
                else
                {
                    sql += ("and workerJoinTime = '" + workerJoinTime + "' ");
                }
            }
            String[] strs = { };
            sql += ";";

            WorkerService wc = new WorkerService();
            list = wc.selelectWorkerInf(sql, strs);
            this.Close();
        }
    }
}
