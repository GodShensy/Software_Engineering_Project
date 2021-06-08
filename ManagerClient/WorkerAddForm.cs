using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workerRegister;
using WorkerClient.src.workers;

namespace ManagerClient
{
    public partial class WorkerAddForm : UIForm
    {
        Form father = null;
        List<WorkerInf> workerInfs = null;
        String workerNumberNew = "";
        int[] flag_nums = null;
        Boolean workerType = false;
        public WorkerAddForm()
        {
            InitializeComponent();
            this.comboBox_worker_lv.SelectedIndex = 0;
            this.comboBox_worker_edu.SelectedIndex = 0;
        }
        public WorkerAddForm(Form form)
        {
            InitializeComponent();
            father = form;
            this.comboBox_worker_lv.SelectedIndex = 0;
            this.comboBox_worker_edu.SelectedIndex = 0;
            flag_nums = new int[8];
            for (int i = 0; i < 8; i++)
                flag_nums[i] = 0;
        }

        public void InfoSet(WorkerRegInf inf)
        {
            textBox_worker_name.Text = inf.WorkerRegName;
            textBox_worker_tel.Text = inf.WorkerRegTel;
            textBox_worker_password.Text = inf.WorkerRegPassword;
            textBox_worker_homeAddr.Text = inf.WorkerRegHomeAddr;
            textBox_addr.Text = inf.WorkerRegAddr;
            radioButton_man.Checked = (inf.WorkerRegSex == 1 ? true : false);
            radioButton_female.Checked = (inf.WorkerRegSex == 0 ? true : false);
            dateTimePicker_worker_birth.Value = DateTime.Parse(inf.WorkerRegBirth);
            comboBox_worker_edu.SelectedIndex = inf.WorkerRegEdu;
            workerType = true;
        }

        public void SetWorkerNumberTab()
        {
            WorkerService service = new WorkerService();
            String sql = "select * from workertab;";
            String[] parms = { };
            workerInfs = service.selelectWorkerInf(sql , parms);
        }

        public Boolean getWorkerType()
        {
            return workerType;
        }

        //todo: 获取数据库已有工号，这里将父类的数据表传过来
        private void textBox_worker_number_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("点击获取了工号" + workerInfs.Count);
            //List<int> idlist = new List<int>();
            Hashtable hashtable = new Hashtable();
            int getCnt = -1;
            
            foreach(WorkerInf inf in workerInfs)
            {
                //idlist.Add(int.Parse(inf.WorkerNumber));
                hashtable.Add(int.Parse(inf.WorkerNumber) ,1);
            }
            
            // todo: 获取深度数据
            for (int i = 0; i <= 99999; i++)
            { 
                // 如果目标值已经在哈希表中
                if(!hashtable.ContainsKey(i))
                {
                    getCnt = i;
                    break;
                }
            }
            workerNumberNew = String.Format("{0:D4}", getCnt);
            this.textBox_worker_number.Text = workerNumberNew;
            this.label_worker_number.Text = "√";
            this.label_worker_number.ForeColor = Color.Green;
            flag_nums[0] = 1;
        }

        public void setInforList(List<WorkerInf> list)
        {
            workerInfs = new List<WorkerInf>();
            workerInfs = list.GetRange(0, list.Count);
            //MessageBox.Show("Deep copy");
        }

        private void textBox_worker_password_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_worker_password.Text;
            if (str.Length >= 6)
            {
                this.label_worker_password.Text = "√";
                this.label_worker_password.ForeColor = Color.Green;
                flag_nums[1] = 1;
            }
            else
            {
                this.label_worker_password.Text = "密码过短";
                this.label_worker_password.ForeColor = Color.Red;
                flag_nums[1] = 0;
            }
        }

        private void textBox_worker_name_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_worker_name.Text;
            if (str.Length > 0 && str.Length < 20)
            {
                this.label_worker_name.Text = "√";
                this.label_worker_name.ForeColor = Color.Green;
                flag_nums[2] = 1;
            }
            else
            {
                this.label_worker_name.Text = "输入过长";
                this.label_worker_name.ForeColor = Color.Red;
                flag_nums[2] = 0;
            }
        }

        private void textBox_worker_tel_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_worker_tel.Text;
            if (str.Length > 0 && str.Length < 15)
            {
                this.label_worker_tel.Text = "√";
                this.label_worker_tel.ForeColor = Color.Green;
                flag_nums[3] = 1;
            }
            else
            {
                this.label_worker_tel.Text = "输入过长";
                this.label_worker_tel.ForeColor = Color.Red;
                flag_nums[3] = 0;
            }
        }

        private void textBox_worker_homeAddr_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_worker_homeAddr.Text;
            if (str.Length > 0 && str.Length < 11)
            {
                this.label_worker_home_addr.Text = "√";
                this.label_worker_home_addr.ForeColor = Color.Green;
                flag_nums[4] = 1;
            }
            else
            {
                this.label_worker_home_addr.Text = "输入过长";
                this.label_worker_home_addr.ForeColor = Color.Red;
                flag_nums[4] = 0;
            }
        }

        private void textBox_worker_rec_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_worker_rec.Text;
            float rec = 0;
            if(float.TryParse(str , out rec))
            {
                if(rec < 0)
                {
                    this.label_worker_rec.Text = "出现负值";
                    this.label_worker_rec.ForeColor = Color.Red;
                    flag_nums[5] = 0;
                }
                else
                {
                    this.label_worker_rec.Text = "√";
                    this.label_worker_rec.ForeColor = Color.Green;
                    flag_nums[5] = 1;
                }
            }
            else
            {
                this.label_worker_rec.Text = "输入过长";
                this.label_worker_rec.ForeColor = Color.Red;
                flag_nums[5] = 0;
            }
        }

        private void textBox_addr_TextChanged(object sender, EventArgs e)
        {
            String str = this.textBox_addr.Text;
            if (str.Length > 0 && str.Length < 21)
            {
                this.label_worker_addr.Text = "√";
                this.label_worker_addr.ForeColor = Color.Green;
                flag_nums[6] = 1;
            }
            else
            {
                this.label_worker_addr.Text = "输入过长";
                this.label_worker_addr.ForeColor = Color.Red;
                flag_nums[6] = 0;
            }
        }

        private void uiButton_push_change_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                if (flag_nums[i] == 0)
                {
                    MessageBox.Show("请正确输入");
                    return;
                }
            }
            String worker_number = textBox_worker_number.Text;
            String worker_password = textBox_worker_password.Text;
            String worker_name = textBox_worker_name.Text;
            String worker_tel = textBox_worker_tel.Text;
            DateTime worker_birth = dateTimePicker_worker_birth.Value;
            String worker_birth_str = worker_birth.ToShortDateString();
            String worker_home_addr = textBox_worker_homeAddr.Text;
            int worker_edu = comboBox_worker_edu.SelectedIndex;
            String worker_rec = textBox_worker_rec.Text;
            int worker_sex = radioButton_man.Checked ? 1 : 0;
            int worker_lv = comboBox_worker_lv.SelectedIndex;
            String worker_addr = textBox_addr.Text;
            DateTime worker_join_time = dateTimePicker_joinTime.Value;
            String worker_join_time_str = worker_join_time.ToShortDateString();
            int worker_time = ((int)numericUpDown_workerTime.Value);
            WorkerInf inf = new WorkerInf();
            inf.WorkerNumber = worker_number;
            inf.WorkerPassword = worker_password;
            inf.WorkerName = worker_name;
            inf.WorkerTel = worker_tel;
            inf.WorkerBirth = worker_birth_str;
            inf.WorkerHomeAddr = worker_home_addr;
            inf.WorkerEdu = worker_edu;
            inf.WorkerLv = worker_lv;
            inf.WorkerTime = worker_time;
            inf.WorkerJoinTime = worker_join_time_str;
            inf.WorkerBaseRec = float.Parse(worker_rec);
            inf.WorkerAdd = worker_addr;
            inf.WorkerSex = worker_sex;
            WorkerService service = new WorkerService();
            int cnt = service.insertWorkerInf(inf);
            if (cnt <= 0)
            {
                MessageBox.Show("插入失败");
                workerType = false;
            }
            else
            {
                MessageBox.Show("插入完成");
                this.Close();
            }
        }
    }
}
