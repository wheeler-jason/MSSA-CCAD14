using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2._1
{
    /* 
     * Implement a stack using an array 
     * Include push and pop methods as a minimum
     */
    internal class StackArray<T>
    {
        private T[] stack;
        private int top;
        private int size;

        public StackArray(int size)
        {
            this.size = size;
            stack = new T[size];
            top = -1;
        }

        public void Push(T item)
        {
            // Check if stack is full first
            if (top == size - 1)
            {
                Console.WriteLine("Stack is full");
                throw new InvalidOperationException("Stack is full");
            }
            // if the stack is not full, increment top
            // and add the item to the stack
            else
            {
                stack[++top] = item;
            }
        }

        public T Pop()
        {
            // Check if stack is empty first
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            // if the stack is not empty, decrement top
            // and return the item at the top of the stack
            else
            {
                return stack[top--];
            }
        }

        public T Peek()
        {
            // Check if stack is empty first
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            // if the stack is not empty, return the item at
            // the top of the stack without removing it
            else
            {
                return stack[top];
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
