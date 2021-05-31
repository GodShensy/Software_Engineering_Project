using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WorkerClient.src.workers
{
    class workerInf
    {
        private int id; /** 自动分配id ，数据库操作时忽略 */
        private string workerNumber; /** 员工工号 */
        private string workerPassword; /** 登陆密码 */
        private string worderName; /** 姓名 */
        private int workerSex; /** 性别 */
        private string workerBirth; /** 生日 */
        private string workerHomeAddr; /** 籍贯 */
        private string workerEdu; /** 学历 */
        private int workerLv; /** 等级 */
        private string workerTime; /** 工龄 */
        private string workerJoinTime; /** 员工入职时间 */
        private float workerBaseRec; /** 员工基本工资 */
        private string workerAdd; /** 员工住址 */
        private string workerTel; /** 员工电话 */

        public workerInf()
        {

        }

        public workerInf(int id, string workerNumber, string workerPassword, string worderName, int workerSex, string workerBirth, string workerHOmeAddr, string workerEdu, int workerLv, string workerTime, string workerJoinTime, float workerBaseRec, string workerAdd, string workerTel)
        {
            this.Id = id;
            this.WorkerNumber = workerNumber;
            this.WorkerPassword = workerPassword;
            this.WorderName = worderName;
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

        /** 员工电话 */
        public string WorkerTel { get => workerTel; set => workerTel = value; }
        /** 员工住址 */
        public string WorkerAdd { get => workerAdd; set => workerAdd = value; }
        /** 员工基本工资 */
        public float WorkerBaseRec { get => workerBaseRec; set => workerBaseRec = value; }
        /** 员工入职时间 */
        public string WorkerJoinTime { get => workerJoinTime; set => workerJoinTime = value; }
        /** 工龄 */
        public string WorkerTime { get => workerTime; set => workerTime = value; }
        /** 等级 */
        public int WorkerLv { get => workerLv; set => workerLv = value; }
        /** 学历 */
        public string WorkerEdu { get => workerEdu; set => workerEdu = value; }
        /** 籍贯 */
        public string WorkerHomeAddr { get => workerHomeAddr; set => workerHomeAddr = value; }
        /** 生日 */
        public string WorkerBirth { get => workerBirth; set => workerBirth = value; }
        /** 性别 */
        public int WorkerSex { get => workerSex; set => workerSex = value; }
        /** 姓名 */
        public string WorderName { get => worderName; set => worderName = value; }
        /** 登陆密码 */
        public string WorkerPassword { get => workerPassword; set => workerPassword = value; }
        /** 员工工号 */
        public string WorkerNumber { get => workerNumber; set => workerNumber = value; }
        /** 自动分配id ，数据库操作时忽略 */
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is workerInf inf &&
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
                   WorderName == inf.WorderName &&
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
            hash.Add(WorderName);
            hash.Add(WorkerPassword);
            hash.Add(WorkerNumber);
            hash.Add(Id);
            return hash.ToHashCode();
        }
    }
}
