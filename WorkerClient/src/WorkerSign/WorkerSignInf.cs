using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerClient.src.workerSign
{
    class WorkerSignInf
    {
        private String workerId;
        private int signType;
        private String signData;
        private bool isChecked;

        public WorkerSignInf()
        {

        }
        public string WorkerId { get => workerId; set => workerId = value; }
        public int SignType { get => signType; set => signType = value; }
        public string SignData { get => signData; set => signData = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }

        public override bool Equals(object obj)
        {
            return obj is WorkerSignInf inf &&
                   WorkerId == inf.WorkerId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(WorkerId);
        }
    }
}
