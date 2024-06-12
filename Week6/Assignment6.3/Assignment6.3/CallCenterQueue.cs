using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._3
{
    internal class CallCenterQueue
    {
        private LinkedList<string> callQueue = new LinkedList<string>();

        public void Enqueue(string call)
        {
            callQueue.AddLast(call);
            Console.WriteLine($"{call} has been added to the queue");
        }
        
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            string call = callQueue.First.Value;
            callQueue.RemoveFirst();
            Console.WriteLine($"{call} has been removed from the queue");
        }

        public void Clear() {
            callQueue.Clear();
            Console.WriteLine("The queue has been cleared");
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Console.WriteLine("The calls in the queue are:");
            foreach (string call in callQueue)
            {
                Console.WriteLine(call);
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Console.WriteLine($"The next call in the queue is {callQueue.First.Value}");
        }

        public bool IsEmpty()
        {
            return callQueue.Count == 0;
        }
    }
}
