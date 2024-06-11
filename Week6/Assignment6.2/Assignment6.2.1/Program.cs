namespace Assignment6._2._1
{
    /* Implement a stack using an array 
       Include push and pop methods as a minimum
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> stack = new StackArray<int>(100);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Peek()); // Output: 30

            Console.WriteLine(stack.Pop());  // Output: 30
            Console.WriteLine(stack.Pop());  // Output: 20

            Console.WriteLine(stack.IsEmpty()); // Output: False

            Console.WriteLine(stack.Pop());  // Output: 10

            Console.WriteLine(stack.IsEmpty()); // Output: True

            Console.WriteLine(stack.Pop());  // Stack is empty, throws InvalidOperationException
        }
    }
}
