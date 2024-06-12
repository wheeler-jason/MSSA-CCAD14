namespace Assignment6._3
{
    // Implement a queue using LinkedList to
    // model a call center call queue
    public class Program
    {
        static void Main(string[] args)
        {
            CallCenterQueue callCenterQueue = new CallCenterQueue();
            callCenterQueue.Enqueue("Call 1");
            callCenterQueue.Enqueue("Call 2");
            callCenterQueue.Enqueue("Call 3");
            callCenterQueue.Enqueue("Call 4");
            callCenterQueue.Enqueue("Call 5");
            callCenterQueue.Enqueue("Call 6");
            callCenterQueue.Enqueue("Call 7");
            callCenterQueue.Enqueue("Call 8");
            callCenterQueue.Enqueue("Call 9");
            callCenterQueue.Enqueue("Call 10");
            callCenterQueue.PrintQueue();
            callCenterQueue.Dequeue();
            callCenterQueue.Dequeue();
            callCenterQueue.Dequeue();
            callCenterQueue.PrintQueue();
            callCenterQueue.Clear();
            callCenterQueue.PrintQueue();
        }
    }
}
