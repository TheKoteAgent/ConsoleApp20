using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class MyStack<T>
    {
        private List<T> items;

        public MyStack()
        {
            items = new List<T>();
        }
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("null");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }
        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("null");
            }

            return items[items.Count - 1];
        }
        public int Count
        {
            get { return items.Count; }
        }
    }
}
