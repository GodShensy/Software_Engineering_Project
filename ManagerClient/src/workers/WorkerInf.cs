using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WorkerClient.src.workers
{
    public class WorkerInf
    {
        private int id; /** 自动分配id ，数据库操作时忽略 */
        private string workerNumber; /** 员工工号 */
        private string workerPassword; /** 登陆密码 */
        private string workerName; /** 姓名 */
        private int workerSex; /** 性别 */
        private string workerBirth; /** 生日 */
        private string workerHomeAddr; /** 籍贯 */
        private int workerEdu; /** 学历 */
        private int workerLv; /** 等级 */
        private int workerTime; /** 工龄 */
        private string workerJoinTime; /** 员工入职时间 */
        private float workerBaseRec; /** 员工基本工资 */
        private string workerAdd; /** 员工住址 */
        private string workerTel; /** 员工电话 */

        public WorkerInf()
        {

        }

        public WorkerInf(int id, string workerNumber, string workerPassword, string worderName, int workerSex, string workerBirth, string workerHOmeAddr, int workerEdu, int workerLv, int workerTime, string workerJoinTime, float workerBaseRec, string workerAdd, string workerTel)
        {
            this.Id = id;
            this.WorkerNumber = workerNumber;
            this.WorkerPassword = workerPassword;
            this.WorkerName = worderName;
            this.WorkerSex = workerSex;
            this.WorkerBirth = workerBirth;
            this.WorkerHomeAddr = workerHOmeAddr;
            this.WorkerEdu = workerEdu;
            this.WorkerLv = workerLv;
            this.WorkerTime = workerTime;
            this.WorkerJoinTime = workerJoinTime;
            this.WorkerBaseRec = workerBaseRec;
            this.WorkerAdd = workerAdd;
            this.WorkerTel = workerTel;
        }
         /** 员工工号 */
        public string WorkerNumber { get => workerNumber; set => workerNumber = value = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 登陆密码 */
        public string WorkerPassword { get => workerPassword; set => workerPassword = value = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 姓名 */
        public string WorkerName { get => workerName; set => workerName = value = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 性别 */
        public int WorkerSex { get => workerSex; set => workerSex = value = value == null ? 0 : value; }
        /** 生日 */
        public string WorkerBirth { get => workerBirth; set => workerBirth = value = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 籍贯 */
        public string WorkerHomeAddr { get => workerHomeAddr; set => workerHomeAddr = value = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 学历 */
        public int WorkerEdu { get => workerEdu; set => workerEdu = value = value == null ? 0 : value; }
        /** 等级 */
        public int WorkerLv { get => workerLv; set => workerLv = value = value == null ? 0 : value; }
        /** 工龄 */
        public int WorkerTime { get => workerTime; set => workerTime = value = value == null ? 0 : value; }
        /** 员工入职时间 */
        public string WorkerJoinTime { get => workerJoinTime; set => workerJoinTime = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 员工基本工资 */
        public float WorkerBaseRec { get => workerBaseRec; set => workerBaseRec = value == null ? -1 : value; }
        /** 员工住址 */
        public string WorkerAdd { get => workerAdd; set => workerAdd = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 员工电话 */
        public string WorkerTel { get => workerTel; set => workerTel = String.IsNullOrEmpty(value) ? "null" : value; }
        /** 自动分配id ，数据库操作时忽略 */
        public int Id { get => id; set => id = value = value == null ? 0 : value; }

        public override bool Equals(object obj)
        {
            return obj is WorkerInf inf &&
                   WorkerTel == inf.WorkerTel &&
                   WorkerAdd == inf.WorkerAdd &&
                   WorkerBaseRec == inf.WorkerBaseRec &&
                   WorkerJoinTime == inf.WorkerJoinTime &&
                   WorkerTime == inf.WorkerTime &&
                   WorkerLv == inf.WorkerLv &&
                   WorkerEdu == inf.WorkerEdu &&
                   WorkerHomeAddr == inf.WorkerHomeAddr &&
                   WorkerBirth == inf.WorkerBirth &&
                   WorkerSex == inf.WorkerSex &&
                   WorkerName == inf.WorkerName &&
                   WorkerPassword == inf.WorkerPassword &&
                   WorkerNumber == inf.WorkerNumber &&
                   Id == inf.Id;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(WorkerTel);
            hash.Add(WorkerAdd);
            hash.Add(WorkerBaseRec);
            hash.Add(WorkerJoinTime);
            hash.Add(WorkerTime);
            hash.Add(WorkerLv);
            hash.Add(WorkerEdu);
            hash.Add(WorkerHomeAddr);
            hash.Add(WorkerBirth);
            hash.Add(WorkerSex);
            hash.Add(WorkerName);
            hash.Add(WorkerPassword);
            hash.Add(WorkerNumber);
            hash.Add(Id);
            return hash.ToHashCode();
        }

        public String toStringForFile()
        {
            StringBuilder inf = new StringBuilder();

            inf.Append(id);
            inf.Append(","+workerNumber);
            inf.Append("," + workerPassword);
            inf.Append("," + workerName);
            inf.Append("," + workerSex);
            inf.Append("," + workerBirth);
            inf.Append("," + workerHomeAddr);
            inf.Append("," + workerEdu);
            inf.Append("," + workerLv);
            inf.Append("," + workerTime);
            inf.Append("," + workerJoinTime);
            inf.Append("," + workerBaseRec);
            inf.Append("," + workerAdd);
            inf.Append("," + workerTel);
            return inf.ToString();
        }
    }
}
