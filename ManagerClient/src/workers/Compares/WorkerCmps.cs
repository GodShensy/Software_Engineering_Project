using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WorkerClient.src.workers;

namespace ManagerClient.src.workers.Compares
{
    class WorkerCmps
    {

    }

    class WorkerSexCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerSex > y.WorkerSex)
                return 1;
            else if (x.WorkerSex < y.WorkerSex)
                return -1;
            return 0;
        }
    }

    class WorkerSexCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerSex > y.WorkerSex)
                return -1;
            else if (x.WorkerSex < y.WorkerSex)
                return 1;
            return 0;
        }
    }

    class WorkerBirthCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            DateTime b1 = DateTime.Parse(x.WorkerBirth);
            DateTime b2 = DateTime.Parse(y.WorkerBirth);
            if (b1 > b2)
                return 1;
            else if (b1 < b2)
                return -1;
            return 0;
        }
    }

    class WorkerBirthCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            DateTime b1 = DateTime.Parse(x.WorkerBirth);
            DateTime b2 = DateTime.Parse(y.WorkerBirth);
            if (b1 > b2)
                return -1;
            else if (b1 < b2)
                return 1;
            return 0;
        }
    }

    class WorkerEduCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerEdu > y.WorkerEdu)
                return 1;
            else if (x.WorkerEdu < y.WorkerEdu)
                return -1;
            return 0;
        }
    }

    class WorkerEduCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerEdu > y.WorkerEdu)
                return -1;
            else if (x.WorkerEdu < y.WorkerEdu)
                return 1;
            return 0;
        }
    }

    class WorkerLvCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerLv > y.WorkerLv)
                return 1;
            else if (x.WorkerLv < y.WorkerLv)
                return -1;
            return 0;
        }
    }

    class WorkerLvCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerLv > y.WorkerLv)
                return -1;
            else if (x.WorkerLv < y.WorkerLv)
                return 1;
            return 0;
        }
    }

    class WorkerTimeCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerTime > y.WorkerTime)
                return 1;
            else if (x.WorkerTime < y.WorkerTime)
                return -1;
            return 0;
        }
    }

    class WorkerTimeCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerTime > y.WorkerTime)
                return -1;
            else if (x.WorkerTime < y.WorkerTime)
                return 1;
            return 0;
        }
    }

    class WorkerJoinTimeCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            DateTime b1 = DateTime.Parse(x.WorkerJoinTime);
            DateTime b2 = DateTime.Parse(y.WorkerJoinTime);
            if (b1 > b2)
                return 1;
            else if (b1 < b2)
                return -1;
            return 0;
        }
    }

    class WorkerJoinTimeCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            DateTime b1 = DateTime.Parse(x.WorkerJoinTime);
            DateTime b2 = DateTime.Parse(y.WorkerJoinTime);
            if (b1 > b2)
                return -1;
            else if (b1 < b2)
                return 1;
            return 0;
        }
    }

    class WorkerRecCmpAsc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerBaseRec > y.WorkerBaseRec)
                return 1;
            else if (x.WorkerBaseRec < y.WorkerBaseRec)
                return -1;
            return 0;
        }
    }

    class WorkerRecCmpDesc : IComparer<WorkerInf>
    {
        public int Compare([AllowNull] WorkerInf x, [AllowNull] WorkerInf y)
        {
            if (x.WorkerBaseRec > y.WorkerBaseRec)
                return -1;
            else if (x.WorkerBaseRec < y.WorkerBaseRec)
                return 1;
            return 0;
        }
    }
}
