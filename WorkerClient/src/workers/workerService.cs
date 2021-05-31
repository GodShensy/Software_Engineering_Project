using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workers
{
    class workerService
    {
        public Boolean doWorkerSelect(String userID,String userPassword)
        {
            // 查找一个
            String sql = "";
            String[] thParams =
            {
                userID,
                userPassword
            };
            MySqlConnection mycon = MysqlConnectorHelper.getConn();
            int cnt = 0;
            try
            {
                mycon.Open();
                Console.WriteLine("已经建立链接");
                sql = "select * from workertab where workerNumber = @pair0 and workerPassword = @pair1;";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                for (int i = 0; i < thParams.Length; i++)
                {
                    cmd.Parameters.AddWithValue("pair" + i.ToString(), thParams[i]);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt++;
                    Console.WriteLine(reader.GetString("workerNumber"));
                    Console.WriteLine(reader.GetString("workerPassword"));
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
            if (cnt > 0)
                return true;
            return false;
        }

        public int insertWorkerInf(workerInf inf)
        {
            // 插入一个
            String[] parm =
            {
                inf.WorkerNumber,
                inf.WorkerPassword,
                inf.WorkerSex.ToString(),
                inf.WorkerBirth,
                inf.WorkerHomeAddr,
                inf.WorkerEdu,
                inf.WorkerLv.ToString(),
                inf.WorkerTime,
                inf.WorkerJoinTime,
                inf.WorkerBaseRec.ToString(),
                inf.WorkerAdd,
                inf.WorkerTel
            };
            String sql = "insert into workertab(" +
                         "id," +
                         "workerNumber," + /** 0 */
                         "workerPassword," +/** 1 */
                         "workerName," +/** 2 */
                         "workerSex," +/** 3 */
                         "workerBirth," +/** 4 */
                         "workerHomeAddr," +/** 5 */
                         "workerEdu," +/** 6 */
                         "workerLv," +/** 7 */
                         "workerTime," +/** 8 */
                         "workerJoinTime," +/** 9 */
                         "workerBaseRec," +/** 10 */
                         "workerAddr," +/** 11 */
                         "workerTel)" +/** 12 */
                         " values(null, @pair0,@pair1,@pair2,@pair3,@pair4,@pair5,@pair6,@pair7,@pair8,@pair9,@pair10,@pair11,@pair12 );";
            return MysqlConnectorHelper.exectUID(sql, parm);
        }

        public List<workerInf> selelectWorkerInf(String sql , String[] parms)
        {
            MySqlConnection mycon = MysqlConnectorHelper.getConn();
            List<workerInf> rs = new List<workerInf>();
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
                workerInf e = new workerInf();
                while (reader.Read())
                {
                    e.WorkerNumber = reader.GetString("workerNumber");
                    e.WorkerPassword = reader.GetString("workerPassword");
                    e.WorderName = reader.GetString("workerName");
                    e.WorkerSex = reader.GetInt32("workerSex");
                    e.WorkerBirth = reader.GetDateTime("workerBirth").ToString();
                    e.WorkerHomeAddr = reader.GetString("workerHomeAddr");
                    e.WorkerEdu = reader.GetString("workerEdu");
                    e.WorkerLv = reader.GetInt32("workerLv");
                    e.WorkerTime = reader.GetDateTime("workerTime").ToString();
                    e.WorkerJoinTime = reader.GetDateTime("workerJoinTime").ToString();
                    e.WorkerBaseRec = reader.GetFloat("workerBaseRec");
                    e.WorkerHomeAddr = reader.GetString("workerAddr");
                    e.WorkerTel = reader.GetString("workerTel");
                }
                rs.Add(e);
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
