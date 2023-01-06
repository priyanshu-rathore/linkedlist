using System;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int Data)
        {
            this.data = Data;
            this.next = null;
        }
    }

    public class linkedList
    {
        Node head;
        Node tail;

        private int count;

        public void AddFirst(int value)// UC1 
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            if (tail == null)
            {
                tail = head;
            }
            System.Console.WriteLine(head.data + " is added");
            count++;

        }

        public void AddLast(int data)//UC2
        {
            Node node = new Node(data);
            Node temp = head;
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            System.Console.WriteLine(node.data + " is added");
            count++;
        }
        public void Insert(int value, int position)
        {
            // Check if position is valid
            if (position < 0 || position > count)
            {
                return;
            }

            Node newNode = new Node(value);

            // Insert at beginning
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                if (tail == null)
                {
                    tail = head;
                }
            }
            // Insert at end
            // else if (position == count)
            // {
            //     tail.next = newNode;
            //     tail = newNode;
            // }
            // Insert in middle
            else
            {
                Node current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
            count++;
        }


        public void Display()

        {

            if (this.head == null)
            {
                System.Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    System.Console.Write(temp.data + " ");

                    temp = temp.next;

                }
                System.Console.Write(temp.data);
            }
        }
    }
}