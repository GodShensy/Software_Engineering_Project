using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerSign
{
    class WorkerSignService
    {
        public int doUpLoadCheckStatus(int itemId  , bool checkStatus)
        {
            String sql = "update signtab set isChecked = @pair0 where id = @pair1;";
            String[] parms =
            {
                (checkStatus ? 0 : 1).ToString(),
                itemId.ToString()
            };

            return MysqlConnectorHelper.exectUID(sql, parms);
        }
        public Boolean doUserSignUpLoad(String uid, int checkType , DateTime dt ,String instructions)
        {
            String sql = "insert into signtab" +
                         "(workerId,signType,signData,instructions,isChecked)" +
                         " VALUES" +
                         " (@pair0,@pair1,@pair2,@pair3,@pair4);";
            String[] parm =
            {
                uid,
                checkType.ToString(),
                dt.ToShortDateString(),
                instructions,
                "0"
            };
            if(MysqlConnectorHelper.exectUID(sql, parm) > 0)
            {
                return true;
            }
            return false;
        }
        public List<WorkerSignInf> selelectWorkerInf(String sql, String[] parms)
        {
            MySqlConnection mycon = MysqlConnectorHelper.getConn();
            List<WorkerSignInf> rs = new List<WorkerSignInf>();
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
                    WorkerSignInf e = new WorkerSignInf();
                    e.Id = reader.GetInt32("id");
                    e.WorkerId = reader.GetString("workerId");
                    e.SignType = reader.GetInt32("signType");
                    e.SignData = reader.GetDateTime("signData").ToShortDateString();
                    e.Instructions = reader.GetString("instructions");
                    e.IsChecked = reader.GetBoolean("isChecked");
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
