using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortByMySelfTest
{
    class DataType
    {
        private String strDt;
        private int intDt;
        private float floatDt;

        public string StrDt { get => strDt; set => strDt = value; }
        public int IntDt { get => intDt; set => intDt = value; }
        public float FloatDt { get => floatDt; set => floatDt = value; }

        public override bool Equals(object obj)
        {
            return obj is DataType type &&
                   StrDt == type.StrDt &&
                   IntDt == type.IntDt &&
                   FloatDt == type.FloatDt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StrDt, IntDt, FloatDt);
        }

        public DataType(string strDt, int intDt, float floatDt)
        {
            this.StrDt = strDt;
            this.IntDt = intDt;
            this.FloatDt = floatDt;
        }
    }

    class DataTypeCompare : IComparer<DataType>
    {
        public int Compare([AllowNull] DataType x, [AllowNull] DataType y)
        {
            if (x.IntDt > y.IntDt)
                return 1;
            else if (x.IntDt < y.IntDt)
                return -1;
            else
            {
                return 0;
            }
        }
    }
}
