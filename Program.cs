namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC-1

            LinklistStack stack = new LinklistStack();

            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();

            //UC-2
            PeakAndPopStack peakAndPopStack = new PeakAndPopStack();
            peakAndPopStack.Push(56);
            peakAndPopStack.Push(30);
            peakAndPopStack.Push(70);
            peakAndPopStack.Display();
            while (!peakAndPopStack.IsEmpty())
            {
                peakAndPopStack.Peek();
                peakAndPopStack.Pop();
            }

            //UC-3

            QueueUsingLinklist queue = new QueueUsingLinklist();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            //UC-4

            DequeueElementsQueue dequeue = new DequeueElementsQueue();
            dequeue.Enqueue(56);
            dequeue.Enqueue(30);
            dequeue.Enqueue(70);
            dequeue.Display();
            while (!dequeue.IsEmpty())
            {
                dequeue.Dequeue();
            }
        }
    }
}