using DataBaseTest.DateBaseAccess;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerClient.src.managers
{
    class ManagerService
    {
        public Boolean doPasswordChange(String password , String id)//改管理员密码
        {
            String sql = "update managertab set managerpassword = @pair0 where managerid = @pair1;";
            String[] parm ={
                password,
                id
            };
            if(MysqlConnectorHelper.exectUID(sql , parm) > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean doManagerSelectByIdAndPassword(String userID, String userPassword)//管理员登陆
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
                sql = "select * from managertab where managerid = @pair0 and managerpassword = @pair1;";

                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                for (int i = 0; i < thParams.Length; i++)
                {
                    cmd.Parameters.AddWithValue("pair" + i.ToString(), thParams[i]);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt++;
                    //Console.WriteLine(reader.GetString("managerid"));
                    //Console.WriteLine(reader.GetString("managerpassword"));
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
    }
}
