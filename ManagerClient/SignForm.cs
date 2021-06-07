using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workers;
using WorkerClient.src.workerSign;

namespace ManagerClient
{
    public partial class SignForm : UIForm
    {
        Form fatherform = null;
        List<WorkerSignInf> datalist = null;
        public SignForm()
        {
            InitializeComponent();
            loadData();
        }

        public SignForm(Form form)
        {
            InitializeComponent();
            fatherform = form;
            loadData();
        }

        private void loadData()
        {
            WorkerSignService conn = new WorkerSignService();
            String sql = "select * from signtab;";
            String[] parm = { };
            datalist = conn.selelectWorkerInf(sql, parm);
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                //MessageBox.Show(datalist.Count+"");
                this.uiDataGridView_sign_data.DataSource = datalist;
            }
        }

        private void uiDataGridView_sign_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex; // 选中的列
            int cell = e.RowIndex; // 选中的行
            int userId = (int)uiDataGridView_sign_data.Rows[cell].Cells[0].Value;// 读取账号回头用来修改
            string changedStringName = "";
            Boolean changedValue = false;
            changedValue = (bool)uiDataGridView_sign_data.Rows[cell].Cells[col].Value;
            changedStringName = this.uiDataGridView_sign_data.Columns[e.ColumnIndex].Name;
            WorkerSignService service = new WorkerSignService();
            if (service.doUpLoadCheckStatus(userId, changedValue) <= 0)
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
