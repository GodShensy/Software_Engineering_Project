using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workerRegister;

namespace ManagerClient
{
    public partial class ApplyForm : UIForm
    {
        Form father = null;
        List<WorkerRegInf> datalist;
        public ApplyForm()
        {
            InitializeComponent();
        }

        public ApplyForm(Form form)
        {
            InitializeComponent();
            father = form;
        }

        private void ApplyForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            WorkerRegService conn = new WorkerRegService();
            String sql = "select * from workerregistered;";
            String[] parm = { };
            datalist = conn.selelectWorkerRegInf(sql, parm);
            if (datalist.Count <= 0)
            {
                MessageBox.Show("没有数据");
                this.uiDataGridView_RegInf.DataSource = datalist;
                this.uiDataGridView_RegInf.Refresh();
            }
            else
            {
                this.uiDataGridView_RegInf.DataSource = datalist;
                this.uiDataGridView_RegInf.Refresh();
            }
        }

        private void uiDataGridView_RegInf_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex; // 选中的列
            int cell = e.RowIndex; // 选中的行
            string userId = uiDataGridView_RegInf.Rows[cell].Cells[0].Value.ToString();// 读取账号回头用来修改
            string userName = uiDataGridView_RegInf.Rows[cell].Cells[1].Value.ToString();// 读取账号回头用来修改
            string userPassword = uiDataGridView_RegInf.Rows[cell].Cells[2].Value.ToString();// 读取账号回头用来修改
            string userSex = uiDataGridView_RegInf.Rows[cell].Cells[3].Value.ToString();// 读取账号回头用来修改
            string userBith = uiDataGridView_RegInf.Rows[cell].Cells[4].Value.ToString();// 读取账号回头用来修改
            string userHomeAddr = uiDataGridView_RegInf.Rows[cell].Cells[5].Value.ToString();// 读取账号回头用来修改
            string userEdu = uiDataGridView_RegInf.Rows[cell].Cells[6].Value.ToString();// 读取账号回头用来修改
            string userAddr = uiDataGridView_RegInf.Rows[cell].Cells[7].Value.ToString();// 读取账号回头用来修改
            string userTel = uiDataGridView_RegInf.Rows[cell].Cells[8].Value.ToString();// 读取账号回头用来修改
            WorkerRegInf inf = new WorkerRegInf();
            
            inf.Id = int.Parse(userId);
            inf.WorkerRegName = userName;
            inf.WorkerRegPassword = inf.WorkerRegPassword;
            inf.WorkerRegSex = int.Parse(userSex);
            inf.WorkerRegBirth = userBith;
            inf.WorkerRegHomeAddr = userHomeAddr;
            inf.WorkerRegEdu = int.Parse(userEdu);
            inf.WorkerRegAddr = userAddr;
            inf.WorkerRegTel = userTel;

            WorkerAddForm workerAddForm = new WorkerAddForm(this);
            workerAddForm.InfoSet(inf);
            workerAddForm.SetWorkerNumberTab();
            workerAddForm.ShowDialog();
            if(workerAddForm.getWorkerType())
            {
                WorkerRegService service = new WorkerRegService();
                service.removeById(inf.Id);
            }
            loadData();
        }
    }
}
