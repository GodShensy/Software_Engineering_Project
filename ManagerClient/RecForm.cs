using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WorkerClient.src.workers;

namespace ManagerClient
{
    public partial class RecForm : UIForm
    {
        Form father = null;
        private List<WorkerInf> datalist;
        private List<MinData> numbers;
        public int[] flagStatus = { 0 ,0 ,0 ,0 ,0 };
        private String worker_Number = "";
        private String worker_Benefits = "";
        private String worker_Insurance = "";
        private String worker_Day = "";

        public RecForm()
        {
            InitializeComponent();
        }
        public RecForm(Form form)
        {
            InitializeComponent();
            father = form;
            SelectNumber();
            for (int i = 0; i < flagStatus.Length; i++)
                flagStatus[0] = 0;
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
                    m.WorkerNumber = w.WorkerNumber;
                    numbers.Add(m);
                }
                this.uiDataGridView_Number.DataSource = numbers;
                this.uiDataGridView_Number.Refresh();
            }
        }

        private void button_getAns_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4;i++)
                if(flagStatus[i] == 0)
                {
                    MessageBox.Show("请填写完整信息");
                    return;
                }
            String sql = "select * from workertab where workerNumber = @pair0;";
            WorkerService service = new WorkerService();
            String[] parm =
            {
                worker_Number,
            };
            List<WorkerInf> inflist = service.selelectWorkerInf(sql, parm);
            float worker_rec = inflist[0].WorkerBaseRec;
            float mainRec = 0;
            float years = inflist[0].WorkerTime;
            float days = float.Parse(worker_Day);
            float benefits = float.Parse(worker_Benefits);
            float insurance = float.Parse(worker_Insurance);

            mainRec = (worker_rec + 10 * days + benefits * years /100) * 0.9f - insurance;

            this.textBox_ans.Text = mainRec + "";
        }

        private void textBox_workerNumber_TextChanged(object sender, EventArgs e)
        {
            worker_Number = this.textBox_workerNumber.Text;
            if(!worker_Number.Equals(""))
            {
                flagStatus[0] = 1;
                label_number.Text = "√";
                label_number.ForeColor = Color.Green;
            }
            else
            {
                flagStatus[0] = 0;
                label_number.Text = "×";
                label_number.ForeColor = Color.Red;
            }
        }

        private void textBox_benefits_TextChanged(object sender, EventArgs e)
        {
            worker_Benefits = this.textBox_benefits.Text;
            if (!worker_Benefits.Equals(""))
            {
                flagStatus[1] = 1;
                label_benefits.Text = "√";
                label_benefits.ForeColor = Color.Green;
            }
            else
            {
                flagStatus[1] = 0;
                label_benefits.Text = "×";
                label_benefits.ForeColor = Color.Red;
            }
        }

        private void textBox_insurance_TextChanged(object sender, EventArgs e)
        {
            worker_Insurance = this.textBox_insurance.Text;
            if (!worker_Insurance.Equals(""))
            {
                flagStatus[2] = 1;
                label_insurance.Text = "√";
                label_insurance.ForeColor = Color.Green;
            }
            else
            {
                flagStatus[2] = 0;
                label_insurance.Text = "×";
                label_insurance.ForeColor = Color.Red;
            }
        }

        private void textBox_workerDay_TextChanged(object sender, EventArgs e)
        {
            worker_Day = this.textBox_workerDay.Text;
            if (!worker_Day.Equals(""))
            {
                flagStatus[3] = 1;
                label_workerDay.Text = "√";
                label_workerDay.ForeColor = Color.Green;
            }
            else
            {
                flagStatus[3] = 0;
                label_workerDay.Text = "×";
                label_workerDay.ForeColor = Color.Red;
            }
        }
    }
}
