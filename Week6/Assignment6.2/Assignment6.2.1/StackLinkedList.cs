using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2._1
{
    internal class StackLinkedList<T>
    {
        private LinkedList<T> list = new LinkedList<T>();
       

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T top = list.First.Value;
            list.RemoveFirst();
            return top;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return list.First.Value;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

    }
}
