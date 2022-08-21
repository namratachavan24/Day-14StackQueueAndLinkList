using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class InsertAfterLinklist
    {
        public Node head;
        public void Add(int data)
        {
            Node newnode = new Node(data);
            Node temp = head;
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;

            }
            Console.WriteLine("{0} this value is added", newnode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty Linked list");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void insertBetweenPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
            }
            Console.WriteLine("\nHead is value" + head.data);
        }
        public Node removeFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node removeLastNode()
        {
            Node temp = head;
            Node prev = temp;
            if (head == null)
            {
                return head;
            }
            else
            {
                if (temp.next.next == null)
                {
                    temp.next = null;
                }
                temp = temp.next;
                return this.head;
            }
        }
        public int findNodeWithValue(int value)
        {
            bool flag = true;
            int count = 1;
            Node temp = head;
            while (flag)
            {
                if (temp.data == value)
                {
                    flag = false;
                }
                else
                {
                    temp = temp.next;
                    count++;
                }
            }
            return count;
        }
        public void AddAfterAtPerticulatPosition(int data)
        {
            Node newnode = new Node(40);
            Node temp = head;

            while (temp.next != null)
            {
                if (temp.data == data)
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                }
                temp = temp.next;
            }
            Console.WriteLine("Given LinkedList = " + head.data);
        }
    }
}
