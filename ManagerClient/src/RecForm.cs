using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkerClient.src.workers;

namespace ManagerClient
{
    class MinData
    {
        public string workerNumber;
    }
    public partial class RecForm : Form
    {
        Form father = null;
        private List<WorkerInf> datalist;
        private List<MinData> numbers;

        public RecForm()
        {
            InitializeComponent();
        }
        public RecForm(Form form)
        {
            InitializeComponent();
            father = form;
            SelectNumber();
        }

        public void SelectNumber()
        {
            WorkerService conn = new WorkerService();
            String sql = "select * from workertab;";
            String[] parm = { };
            datalist = conn.selelectWorkerInf(sql, parm);
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                numbers = new List<MinData>();
                numbers.Clear();
                foreach (WorkerInf w in datalist)
                {
                    MinData m = new MinData();
                    m.workerNumber = w.WorkerNumber;
                    numbers.Add(m);
                }
                this.dataGridView_Number.DataSource = numbers;
            }
        }
    }
}
