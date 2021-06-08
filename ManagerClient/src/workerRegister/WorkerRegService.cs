using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerRegister
{
    class WorkerRegService
    {
        public int insertWorkerInf(WorkerRegInf inf)
        {
            // 插入一个
            String[] parm =
            {
                inf.WorkerRegName,
                inf.WorkerRegPassword,
                inf.WorkerRegSex.ToString(),
                inf.WorkerRegBirth,
                inf.WorkerRegHomeAddr,
                inf.WorkerRegEdu.ToString(),
                inf.WorkerRegAddr,
                inf.WorkerRegTel
            };
            String sql = "insert into workerregistered(" +
                         "id," +
                         "workerName," +/** 0 */
                         "workerPassword," +/** 1 */
                         "workerSex," +/** 2 */
                         "workerBirth," +/** 3 */
                         "workerHomeAddr," +/** 4 */
                         "workerEdu," +/** 5 */
                         "workerAddr," +/** 6 */
                         "workerTel)" +/** 7 */
                         " values(null, @pair0,@pair1,@pair2,@pair3,@pair4,@pair5,@pair6,@pair7 );";
            return MysqlConnectorHelper.exectUID(sql, parm);
        }

        public int removeById(int id)
        {
            String[] parms =
            {
                id.ToString()
            };
            String sql = "delete from workerregistered where id = @pair0";
            return MysqlConnectorHelper.exectUID(sql, parms);
        }

        internal List<WorkerRegInf> selelectWorkerRegInf(string sql, string[] parms)
        {
            MySqlConnection mycon = MysqlConnectorHelper.getConn();
            List<WorkerRegInf> rs = new List<WorkerRegInf>();
            try
            {
                mycon.Open();
                Console.WriteLine("已经建立链接");
                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                for (int i = 0; i < parms.Length; i++)
                {
                    cmd.Parameters.AddWithValue("pair" + i.ToString(), parms[i]);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    WorkerRegInf e = new WorkerRegInf();
                    e.Id = reader.GetInt32("id");
                    e.WorkerRegName = reader.GetString("workerName");
                    e.WorkerRegPassword = reader.GetString("workerPassword");
                    e.WorkerRegSex = reader.GetInt32("workerSex");
                    e.WorkerRegBirth = reader.GetDateTime("workerBirth").ToString();
                    e.WorkerRegHomeAddr = reader.GetString("workerHomeAddr");
                    e.WorkerRegEdu = reader.GetInt32("workerEdu");
                    e.WorkerRegAddr = reader.GetString("workerAddr");
                    e.WorkerRegTel = reader.GetString("workerTel");
                    rs.Add(e);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                mycon.Close();
            }
            return rs;
        }
    }
}
