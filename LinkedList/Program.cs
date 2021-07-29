using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {




            //SinglyLinkedList myList = new SinglyLinkedList();
            //myList.InsertFirst(100);
            //myList.InsertFirst(50);
            //myList.InsertFirst(99);
            //myList.InsertFirst(80);
            //myList.InsertFirst(20);
            //myList.insertLast(18);
            //myList.DisplayList();

        }
    }

    //
    public class SinglyLinkedList
    {
        private Node First;
        private bool IsEmpty()
        {
            return (First == null);
        }
        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }
        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("List (first -- last)");
            Node currentNode = First;
            while (currentNode != null)
            {
                currentNode.DisplayNode();
                currentNode = currentNode.Next;
            }
            Console.WriteLine();



        }

        public void insertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode; 
        }

    }
    public class Node
    {
        public int Data;

        public Node Next;

        public void DisplayNode()
        {
            Console.WriteLine("<" + Data + ">");
        }

    }
}
