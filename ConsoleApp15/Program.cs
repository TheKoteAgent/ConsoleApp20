using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Program
    {
        public static void Main()
        {           
            //taks1
            int a = 1, b = 2, c = 3;
            Console.WriteLine($"max: {task1.maxx(a, b, c)}");
            //task2
            Console.WriteLine($"max: {taks2.minn(a, b, c)}");
            //task3
            int[] Arr= { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum: {task3.Sum(Arr)}");
            //task4
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("numbers:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}