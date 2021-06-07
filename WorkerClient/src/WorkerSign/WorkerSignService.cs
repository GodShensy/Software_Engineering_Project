using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerSign
{
    class WorkerSignService
    {
        public Boolean doUserSignUpLoad(String uid , DateTime dt , int checkType)
        {
            String sql = "insert into signtab" +
                         "(workerId,signType,signData,isChecked)" +
                         " VALUES" +
                         " (@pair0,@pair1,@pair2,@pair3);";
            String[] parm =
            {
                uid,
                checkType.ToString(),
                dt.ToShortDateString(),
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
                    e.WorkerId = reader.GetString("workerId");
                    e.SignType = reader.GetInt32("signType");
                    e.SignData = reader.GetDateTime("signData").ToShortDateString();
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
