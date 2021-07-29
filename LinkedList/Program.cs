using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.insertLast(999000);
            myList.displayList();

            myList.deleteFirst();
            myList.displayList();

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
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }
        public Node deleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }
        public void displayList()
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
