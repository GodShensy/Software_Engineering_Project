using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerSign
{
    class WorkerSignInf
    {
        private int id;
        private String workerId;
        private int signType;
        private String signData;
        private String instructions;
        private bool isChecked;

        public WorkerSignInf()
        {

        }
        public int Id { get => id; set => id = value; }
        public string WorkerId { get => workerId; set => workerId = value; }
        public int SignType { get => signType; set => signType = value; }
        public string SignData { get => signData; set => signData = value; }
        public string Instructions { get => instructions; set => instructions = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }

        public override bool Equals(object obj)
        {
            return obj is WorkerSignInf inf &&
                   id == inf.id &&
                   workerId == inf.workerId &&
                   signType == inf.signType &&
                   signData == inf.signData &&
                   instructions == inf.instructions &&
                   isChecked == inf.isChecked &&
                   Id == inf.Id &&
                   WorkerId == inf.WorkerId &&
                   SignType == inf.SignType &&
                   SignData == inf.SignData &&
                   Instructions == inf.Instructions &&
                   IsChecked == inf.IsChecked;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(isChecked);
        }
    }
}
