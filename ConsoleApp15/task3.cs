using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class task3
    {

            public static T Sum<T>(T[] array)
            {
                if (array == null || array.Length == 0)
                {

                    throw new ArgumentException("null");
                }

                T sum = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    sum = Add(sum, array[i]);
                }
                return sum;
            }

            private static T Add<T>(T x, T y)
            {
                dynamic dx = x;
                dynamic dy = y;
                return dx + dy;
            }
        
    }
}
