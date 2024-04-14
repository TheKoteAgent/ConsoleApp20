using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class taks2
    {
        public static T minn<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) <= 0 && a.CompareTo(c) <= 0)
                return a;
            if (b.CompareTo(a) <= 0 && b.CompareTo(c) <= 0)
                return b;
            return c;
        }
    }
}
