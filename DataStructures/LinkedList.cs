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

        public void AddFirst(int value)// UC1 
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            if (tail == null)
            {
                tail = head;
            }
            System.Console.WriteLine(head.data+" is added");
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