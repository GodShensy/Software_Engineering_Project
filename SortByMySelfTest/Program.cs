using System;
using System.Collections.Generic;

namespace SortByMySelfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataType> ls = new List<DataType>();
            List<DataType> ls2 = null;
            DataTypeCompare cp = new DataTypeCompare();
            ls.Add(new DataType("方片", 1, 1.1f));
            ls.Add(new DataType("桃花", 0, 2.1f));
            ls.Add(new DataType("方片", 1, 3.1f));
            ls.Add(new DataType("桃花", 4, 4.1f));
            ls.Add(new DataType("黑桃", 3, 5.1f));
            ls.Add(new DataType("红桃", 2, 6.1f));
            ls.Add(new DataType("方片", 11, 7.1f));
            ls.Add(new DataType("黑桃", 7, 8.1f));
            ls.Sort(cp);
            ls2 = ls.GetRange(0,ls.Count);
            ls[0] = new DataType("12222", 1, 1);
            foreach (DataType data in ls)
            {
                Console.WriteLine(data.StrDt + " " + data.IntDt + " " + data.FloatDt);
            }
            Console.WriteLine("-------------------");

            foreach (DataType data in ls2)
            {
                Console.WriteLine(data.StrDt + " " + data.IntDt + " " + data.FloatDt);
            }
        }
    }
}
