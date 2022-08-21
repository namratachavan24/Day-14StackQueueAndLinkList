namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC-1 
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            foreach (int ele in list)
            {
                Console.WriteLine(ele);
            }

            //UC-2
            AddElementsLinkList addele = new AddElementsLinkList();
            addele.Add(70);
            addele.Add(30);
            addele.Add(56);
            addele.Display();

            //UC-3
            AppendLinkList appendele = new AppendLinkList();
            appendele.Add(70);
            appendele.Add(30);
            appendele.Add(56);
            //appendele.Display();
            appendele.Append(56);
            appendele.Append(30);
            appendele.Append(70);
            appendele.Display();

            //UC-4

            InsertInLinklist insertIn = new InsertInLinklist();
            insertIn.Append(56);
            insertIn.Append(70);
            insertIn.Display();
            insertIn.Insert(30, 56);
            insertIn.Display();

            //UC-5

            DelFirstElementLinklist delFirst = new DelFirstElementLinklist();
            delFirst.Append(56);
            delFirst.Append(70);
            delFirst.Display();
            delFirst.Insert(30, 56);
            delFirst.Display();
            delFirst.DeleteFirst();
            delFirst.Display();

            //UC-6

            DeleteLastEleLinklist deleteLast = new DeleteLastEleLinklist();
            deleteLast.Append(56);
            deleteLast.Append(70);
            deleteLast.Display();
            deleteLast.Insert(30, 56);
            deleteLast.Display();
            deleteLast.Deletelast();
            deleteLast.Display();

            //UC-7
            SearchLinklist searchlist = new SearchLinklist();
            searchlist.Add(56);
            searchlist.Add(30);
            searchlist.Add(70);
            searchlist.Display();
            Console.WriteLine(" ");
            Console.WriteLine("----*----------*----");
            searchlist.Search(30);
            searchlist.Display();

            //UC-8

            InsertAfterLinklist insertAfter = new InsertAfterLinklist();
            insertAfter.Add(56);
            insertAfter.Add(30);
            insertAfter.Add(70);
            insertAfter.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            insertAfter.AddAfterAtPerticulatPosition(30);
            insertAfter.Display();
            Console.Read();


            //UC-9

            DeleteFourtyLinklist deleteFourty = new DeleteFourtyLinklist();
            deleteFourty.Add(56);
            deleteFourty.Add(30);
            deleteFourty.Add(70);
            deleteFourty.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            deleteFourty.AddAfterAtPerticulatPosition(30);
            int position = deleteFourty.deletePerticulatElement(30);
            Console.WriteLine("\nthe size of linkedlist is {0} ", position);
            deleteFourty.Display();
            Console.Read();

        }
    }
    
}