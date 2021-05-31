using DataBaseTest.DateBaseAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerRegister
{
    class workerRegService
    {
        public int insertWorkerInf(workerRegInf inf)
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
    }
}
