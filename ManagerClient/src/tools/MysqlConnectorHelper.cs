using MySqlConnector;
using System;
using System.Data;

namespace DataBaseTest.DateBaseAccess
{
    public class MysqlConnectorHelper
    {
        public static String server = "123.56.238.206";
        public static String port = "3306";
        public static String user = "root";
        public static String password = "123456";
        public static String datebase = "myplusc";
        public static String charset = "utf-8";

        public static MySqlConnection getConn()
        {
            string constring = string.Format("server={0};user id={1};password={2};database={3};port={4};", server, user, password, datebase, port);
            MySqlConnection mycon = null;
            try
            {
                mycon = new MySqlConnection(constring);
                Console.WriteLine("链接建立成功");
            }
            catch (MySqlException e)
            {
                throw e; // 抛出异常
            }
            return mycon;
        }

        // 一个查询操作的模板，可以按照这个结构进行修改
        public static void SelectPrj()
        {
            String sql = "";
            MySqlConnection mycon = getConn();

            try
            {
                mycon.Open();
                Console.WriteLine("已经建立链接");
                sql = "select * from signtab;";
                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32("id"));
                    Console.WriteLine(reader.GetString("workerId"));
                    Console.WriteLine(reader.GetDateTime("signData"));
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
        }

        // 增删改的通用借口
        /*例子：*
            String[] par =
            {
                "1234",
                "3232"
            };
            exectUID("insert into dataTypeTest(id, name) values(@0, @1 );", par);
         */
        public static int exectUID(String sql, String[] thParams)
        {
            int result = 0;
            MySqlConnection mycon = null;
            try
            {
                mycon = getConn();
                mycon.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                for (int i = 0; i < thParams.Length; i++)
                {
                    cmd.Parameters.AddWithValue("pair" + i.ToString(), thParams[i]);
                }
                result = cmd.ExecuteNonQuery();
                Console.WriteLine(result);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                mycon.Close();
            }
            return result;
        }

    }
}
