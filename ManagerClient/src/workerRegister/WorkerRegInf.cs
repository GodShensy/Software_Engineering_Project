using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerRegister
{
    class WorkerRegInf
    {
        private int id;
        private String workerRegName;
        private String workerRegPassword;
        private int workerRegSex;
        private String workerRegBirth;
        private String workerRegHomeAddr;
        private int workerRegEdu;
        private String workerRegAddr;
        private String workerRegTel;

        public WorkerRegInf()
        {

        }

        public WorkerRegInf(int id, string workerRegName, string workerRegPassword, int workerRegSex, string workerRegBirth, string workerRegHomeAddr, int workerRegEdu, string workerRegAddr, string workerRegTel)
        {
            this.id = id;
            this.workerRegName = workerRegName;
            this.workerRegPassword = workerRegPassword;
            this.workerRegSex = workerRegSex;
            this.workerRegBirth = workerRegBirth;
            this.workerRegHomeAddr = workerRegHomeAddr;
            this.workerRegEdu = workerRegEdu;
            this.workerRegAddr = workerRegAddr;
            this.workerRegTel = workerRegTel;
        }

        public string WorkerRegTel { get => workerRegTel; set => workerRegTel = value; }
        public string WorkerRegAddr { get => workerRegAddr; set => workerRegAddr = value; }
        public int WorkerRegEdu { get => workerRegEdu; set => workerRegEdu = value; }
        public string WorkerRegHomeAddr { get => workerRegHomeAddr; set => workerRegHomeAddr = value; }
        public string WorkerRegBirth { get => workerRegBirth; set => workerRegBirth = value; }
        public int WorkerRegSex { get => workerRegSex; set => workerRegSex = value; }
        public string WorkerRegPassword { get => workerRegPassword; set => workerRegPassword = value; }
        public string WorkerRegName { get => workerRegName; set => workerRegName = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is WorkerRegInf inf &&
                   WorkerRegTel == inf.WorkerRegTel &&
                   WorkerRegAddr == inf.WorkerRegAddr &&
                   WorkerRegEdu == inf.WorkerRegEdu &&
                   WorkerRegHomeAddr == inf.WorkerRegHomeAddr &&
                   WorkerRegBirth == inf.WorkerRegBirth &&
                   WorkerRegSex == inf.WorkerRegSex &&
                   WorkerRegPassword == inf.WorkerRegPassword &&
                   WorkerRegName == inf.WorkerRegName &&
                   Id == inf.Id;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(WorkerRegTel);
            hash.Add(WorkerRegAddr);
            hash.Add(WorkerRegEdu);
            hash.Add(WorkerRegHomeAddr);
            hash.Add(WorkerRegBirth);
            hash.Add(WorkerRegSex);
            hash.Add(WorkerRegPassword);
            hash.Add(WorkerRegName);
            hash.Add(Id);
            return hash.ToHashCode();
        }
    }
}
