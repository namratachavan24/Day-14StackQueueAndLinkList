using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueUsingLinklist
    {
        Node last;
        Node first;
        public QueueUsingLinklist()
        {
            this.last = null;
            this.first = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            
            if (this.last == null || this.first == null)
            {
                this.last = node;
                this.first = node;
            }
            else
            {
                last.next = node;
                last = node;

            }
            Console.WriteLine("{0} data is inserted \n", node.data);
        }
        public void Display()
        {
            Node temp = this.first;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty\n");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " \n");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            if (first == null)
            {
                Console.WriteLine("LinkedList Queue is empty, so deletion can't possible");
                return;
            }
            else
            {
                Console.WriteLine("{0} is removed", first.data);
                first = first.next;
                //if queue become empty last must be null
                if (first == null)
                {
                    last = null;
                }

            }

        }
        public bool IsEmpty()
        {

            if (first == null || last == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
