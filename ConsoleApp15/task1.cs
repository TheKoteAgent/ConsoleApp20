using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class task1
    {
        public static T maxx<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                return a;
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                return b;
            return c;
        }
    }
}
