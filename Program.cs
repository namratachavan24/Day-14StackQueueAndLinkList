namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            foreach (int ele in list)
            {
                Console.WriteLine(ele);
            }
        }
    }
}