using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class InsertInLinklist
    {
        Node head;
        Node current;
        public void Add(int data)
        {
            Node node = new Node(data);
            //no first node added to list
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //head is asigned to new node
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("{0} data is inserted ", node.data);
        }

        public void Append(int data)
        {
            Node node = new Node(data);
            //no first node added to list
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                //assigning node to temp->next
                temp.next = node;
            }
            Console.WriteLine("{0} data is inserted ", node.data);
        }

        public void Insert(int data, int posVal)
        {
            Node node = new Node(data);
            Node temp = this.head;

            while (temp != null)
            {
                if (temp.data == 56)
                {
                    //next of 50 assigned to new node
                    //new node is assigning to 50 
                    node.next = temp.next;
                    temp.next = node;
                    Console.WriteLine("New data is inserted in between 56 and 70");
                    break;

                }
                temp = temp.next;
            }
        }

        public void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
