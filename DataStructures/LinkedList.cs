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

        public void BubbleSort()//UC10
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            var current = head;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                while (current.next != null)
                {
                    if (current.data.CompareTo(current.next.data) > 0)
                    {
                        var temp = current.data;
                        current.data = current.next.data;
                        current.next.data = temp;
                        swapped = true;
                    }
                    current = current.next;
                }
            }
        }

        public void DeleteNode(int value)//UC9
        {
            Node current = head;
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            if (head.data.Equals(value))
            {
                head = head.next;
                return;
            }
            while (current.next != null)
            {
                if (current.next.data.Equals(value))
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            throw new InvalidOperationException("node with given value not found.");
        }

        public void InsertAfter(int targetValue, int newValue)//UC8
        {
            Node targetNode = FindNode(targetValue);
            if (targetNode == null)
            {
                throw new InvalidOperationException("targetNode not found");
            }
            Node newNode = new Node(newValue);

            newNode.next = targetNode.next;
            targetNode.next = newNode;
            head.next = targetNode;
        }

        public Node FindNode(object value)//UC8
        {
            if (head == null)
            {
                return null;
            }
            var current = head;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    return current;
                }
                Console.WriteLine($"Found {current.data}");

                current = current.next;
            }
            return null;
        }

        public void DeleteLastNode()//UC7
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                var current = head;
                while (current.next.next != null)
                {
                    current = current.next;
                }
                current.next = null;
            }
        }

        public object Pop()//UC5
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            object value = head.data;
            head = head.next;
            count--;
            return value;
        }

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