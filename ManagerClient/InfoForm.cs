using DataBaseTest.DateBaseAccess;
using ManagerClient.src.workers.Compares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkerClient.src.workers;
using MaterialSkin;
using MaterialSkin.Controls;
using Sunny;
using Sunny.UI;

namespace ManagerClient
{
    public partial class InfoForm : UIForm
    {
        Form father = null;
        WorkerAddForm workerAddForm = null;
        SelectFrom selectFrom = null;
        List<WorkerInf> datalist = null; // 非保存性数据对这力操作 当前一直操作的
        List<WorkerInf> dataListSave = null; // 源数据保存 ， 这个为了快速回退
        String strOrderBy = null;
        // 标记点击时排序的逻辑
        int[] rankFlag = { 1 , 1 , 1 ,1 ,
                           1 , 1 , 1 ,1 ,
                           1 , 1 , 1 ,1 ,
                           1 , 1 , 1 ,1 ,
                           1 , 1 , 1 , 1};
        public InfoForm()
        {
            InitializeComponent();
        }
        public InfoForm(Form form)
        {
            InitializeComponent();
            father = form;
        }

        private void button_show_workerTab_Click(object sender, EventArgs e)
        {
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                // 重新加载一边
                WorkerService conn = new WorkerService();
                String sql = "select * from workertab;";
                String[] parm = { };
                datalist = conn.selelectWorkerInf(sql, parm);

                this.uiDataGridView_worker.DataSource = datalist;
                this.uiDataGridView_worker.Refresh();
                dataListSave = datalist.GetRange(0, datalist.Count); // 深度拷贝
            }
        }

        public void reRoad()
        {
            WorkerService conn = new WorkerService();
            String sql = "select * from workertab;";
            String[] parm = { };
            datalist = conn.selelectWorkerInf(sql, parm);
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                this.uiDataGridView_worker.DataSource = datalist;
                dataListSave = datalist.GetRange(0, datalist.Count); // 深度拷贝
                this.uiDataGridView_worker.Refresh();
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            WorkerService conn = new WorkerService();
            String sql = "select * from workertab;";
            String[] parm = { };
            datalist = conn.selelectWorkerInf(sql, parm);
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                this.uiDataGridView_worker.DataSource = datalist;
                dataListSave = datalist.GetRange(0,datalist.Count); // 深度拷贝
            }
        }


        private void dataGridView_worker_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button_AddInfo_Click(object sender, EventArgs e)
        {
            workerAddForm = new WorkerAddForm(this);
            workerAddForm.setInforList(datalist);
            workerAddForm.ShowDialog();
            reRoad();
        }

        private void button_clear_infos_Click(object sender, EventArgs e)
        {
            String[] str = { };
            int lines = MysqlConnectorHelper.exectUID("delete from workertab;", str);
            MessageBox.Show("删除了: " + lines + " 条记录");

                // 重新加载一边
                WorkerService conn = new WorkerService();
                String sql = "select * from workertab;";
                String[] parm = { };
                datalist = conn.selelectWorkerInf(sql, parm);


                this.uiDataGridView_worker.DataSource = datalist;

                this.uiDataGridView_worker.Refresh();
                dataListSave = datalist.GetRange(0, datalist.Count); // 深度拷贝

        }


        private void button_save_data_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            if (path.SelectedPath.Equals(""))
                return;
            String flodeRoad = path.SelectedPath;
            WriteData(flodeRoad);
            MessageBox.Show("完成导出");
        }

        public void WriteData(String DataFileRootPath)
        {
            try
            {
                if (System.IO.Directory.Exists(DataFileRootPath) == false)
                {
                    System.IO.Directory.CreateDirectory(DataFileRootPath);
                }
                StringBuilder DataColumn = new StringBuilder();
                StringBuilder DataLine = new StringBuilder();

                string strT = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + DateTime.Now.Millisecond.ToString();

                //列标题
                DataColumn.Append("id,工号,密码,姓名,性别,生日,籍贯,学历,等级,工龄,加入时间,基础收入,先居住地,电话");
                //行数据
                DataLine.Append(strT + ",");

                string FileName = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                string FilePath = DataFileRootPath + "\\" + FileName + "-report.txt";
                System.IO.StreamWriter stream = new System.IO.StreamWriter(FilePath, false, Encoding.UTF8);

                stream.WriteLine(DataLine);
                stream.WriteLine(DataColumn);
                foreach (WorkerInf workerInf in datalist)
                {
                    stream.WriteLine(workerInf.toStringForFile());
                }
                stream.Flush();
                stream.Close();
                stream.Dispose();
            }
            catch (Exception ex)
            {

            }
        }

        private void button_load_flie_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView_worker_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex; // 选中的列
            int cell = e.RowIndex; // 选中的行
            string userId = uiDataGridView_worker.Rows[0].Cells[cell].Value.ToString();// 读取账号回头用来修改
            string changedStringName = "";
            string changedValue = "";
            //MessageBox.Show("选中 列 " + col + "  选中 行 " + cell);
            //MessageBox.Show(dataGridView_worker.Rows[cell].Cells[col].Value.ToString());
            changedValue = uiDataGridView_worker.Rows[cell].Cells[col].Value.ToString();
            changedStringName = this.uiDataGridView_worker.Columns[e.ColumnIndex].Name;
            MessageBox.Show(changedStringName + " " + changedValue + " " + userId);
            WorkerService service = new WorkerService();

            int cnt = service.doWorkerInfoChangeByItem(changedStringName, changedValue, userId);
            if (cnt <= 0)
            {
                MessageBox.Show("修改失败");
            }
        }

        private void uiDataGridView_worker_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.uiDataGridView_worker.Columns[e.ColumnIndex].Name;
            int columnNum = e.ColumnIndex;
            //MessageBox.Show(columnNum+"");
            switch (columnNum)
            {
                case 0: /** 账号 */
                    break;
                case 1: /** 密码 */
                    break;
                case 2: /** 姓名 + */
                    break;
                case 3:
                    if (rankFlag[3] == 1)
                    {
                        datalist.Sort(new WorkerSexCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerSexCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[3] ^= 1;
                    break;
                case 4: /** 出生日期 +  */
                    if (rankFlag[4] == 1)
                    {
                        datalist.Sort(new WorkerBirthCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerBirthCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[4] ^= 1;
                    break;
                case 5: /** 籍贯 */
                    break;
                case 6: /** 学历 +  */
                    if (rankFlag[6] == 1)
                    {
                        datalist.Sort(new WorkerEduCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerEduCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[6] ^= 1;
                    break;
                case 7: /** 等级 +  */
                    if (rankFlag[7] == 1)
                    {
                        datalist.Sort(new WorkerLvCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerLvCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[7] ^= 1;
                    break;
                case 8: /** 工作时间 +  */
                    if (rankFlag[8] == 1)
                    {
                        datalist.Sort(new WorkerTimeCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerTimeCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[8] ^= 1;
                    break;
                case 9: /** 加入时间 +  */

                    if (rankFlag[9] == 1)
                    {
                        datalist.Sort(new WorkerJoinTimeCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerJoinTimeCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[9] ^= 1;

                    break;
                case 10: /** 工资 +  */
                    if (rankFlag[10] == 1)
                    {
                        datalist.Sort(new WorkerRecCmpAsc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    else
                    {
                        datalist.Sort(new WorkerRecCmpDesc());
                        uiDataGridView_worker.DataSource = datalist;
                        uiDataGridView_worker.Refresh();
                    }
                    rankFlag[10] ^= 1;
                    break;
                case 11: /** 住址 */
                    break;
                case 12: /** 电话 */
                    break;
                default:
                    break;
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            selectFrom = new SelectFrom(this);
            //selectFrom.setInforList(datalist);
            selectFrom.ShowDialog();
            if(selectFrom.selectStatus())
            {
                List<WorkerInf> ls = selectFrom.getInfoList();
                datalist = ls.GetRange(0, ls.Count);
                uiDataGridView_worker.DataSource = datalist;
                uiDataGridView_worker.Refresh();
            }
            //reRoad();
        }

        private void uiButton_Add_Click(object sender, EventArgs e)
        {
            workerAddForm = new WorkerAddForm(this);
            workerAddForm.setInforList(datalist);
            workerAddForm.ShowDialog();
            reRoad();
        }

        private void uiButton_readInfo_Click(object sender, EventArgs e)
        {

        }

        private void uiButton_infoSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            if (path.SelectedPath.Equals(""))
                return;
            String flodeRoad = path.SelectedPath;
            WriteData(flodeRoad);
            MessageBox.Show("完成导出");
        }

        private void uiButton_SelectInfo_Click(object sender, EventArgs e)
        {
            selectFrom = new SelectFrom(this);
            //selectFrom.setInforList(datalist);
            selectFrom.ShowDialog();
            if (selectFrom.selectStatus())
            {
                List<WorkerInf> ls = selectFrom.getInfoList();
                datalist = ls.GetRange(0, ls.Count);
                uiDataGridView_worker.DataSource = datalist;
                uiDataGridView_worker.Refresh();
            }
            //reRoad();
        }

        private void uiButton_clearInfo_Click(object sender, EventArgs e)
        {
            String[] str = { };
            int lines = MysqlConnectorHelper.exectUID("delete from workertab;", str);
            MessageBox.Show("删除了: " + lines + " 条记录");

            // 重新加载一边
            WorkerService conn = new WorkerService();
            String sql = "select * from workertab;";
            String[] parm = { };
            datalist = conn.selelectWorkerInf(sql, parm);


            this.uiDataGridView_worker.DataSource = datalist;

            this.uiDataGridView_worker.Refresh();
            dataListSave = datalist.GetRange(0, datalist.Count); // 深度拷贝
        }

        private void uiButton_showData_Click(object sender, EventArgs e)
        {
            if (datalist.Count <= 0)
                MessageBox.Show("没有数据");
            else
            {
                // 重新加载一边
                WorkerService conn = new WorkerService();
                String sql = "select * from workertab;";
                String[] parm = { };
                datalist = conn.selelectWorkerInf(sql, parm);

                this.uiDataGridView_worker.DataSource = datalist;
                this.uiDataGridView_worker.Refresh();
                dataListSave = datalist.GetRange(0, datalist.Count); // 深度拷贝
            }
        }
    }
}
