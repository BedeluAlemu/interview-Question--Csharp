using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
        public Node()
        { 
            
        }

    }
    class LinkedList
    {
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Insert(int data)
        {
            if (head == null)
            {
                head = new Node(data);

            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node(data);
            }
        }

        public void RemoveDuplicate(Node temp)
        {
            while (temp != null)
            {
                Node curr = temp;

                while (curr.Next != null)
                {
                    if (curr.Next.data == temp.data)
                    {
                        curr.Next = curr.Next.Next;
                    }
                    else
                    {
                        curr = curr.Next;
                    }
                }

                temp = temp.Next;
            }
        }

        
        public int nthNodeFromEnd(int n)
        {
            // First we determine the length of the linked list
            int length = 0;

            Node iterator = head;

            while (iterator != null)
            {
                length++;
                iterator = iterator.Next;
            }

            if (length < n)
            {
                // n is larger than the length of linked list 
                return 0;
            }

            // Now we determine the required position 

            int position = length - n + 1;

            // Now we start iterating the linked list again 
            // this time till we reach the required position

            iterator = head;

            int count = 1;

            while (count < position)
            {
                iterator = iterator.Next;
                count++;
            }

            return iterator.data;
        }
        public void Print()
        {
            Node iterator = head;

            while (iterator != null)
            {
                Console.Write("{0}=>", iterator.data);
                iterator = iterator.Next;
            }
        }


        
        public void Split ()
        {
            
            Node head1 = new Node();
            Node head2 = new Node();

            if (head == null&& head.Next == null) return; // Setting the first 2 nodes as heads of 


            head1 = head;
            head2 = head.Next;
             
            
           

            head = head.Next.Next;

            while(head != null)
            { 
                head1.Next = head;
                head2.Next = head.Next;
                head = head.Next;
                head1 = head1.Next;
                head2 = head2.Next;
            }

            Node iterator = head1;

            while (iterator != null)
            {
                Console.Write("{0}=>", iterator.data);
                iterator = iterator.Next;
            }
            Console.Write("\n");
            iterator = head2;

            while (iterator != null)
            {
                Console.Write("{0}=>", iterator.data);
                iterator = iterator.Next;
            }


        }





    }
    
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList lk = new LinkedList();
           
            lk.Insert(1);
            lk.Insert(2);
            lk.Insert(3);
            lk.Insert(4);
            lk.Insert(5);
            lk.Insert(6);
            lk.Print();
            Console.WriteLine("\n");
            int x = lk.nthNodeFromEnd(2);

            lk.Split();
             
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
