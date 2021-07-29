using System;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Jaws 2");
            theStack.push("Titanic");
            theStack.push("Rocky");

            WriteLine("================== \nAbout to peek:");
            WriteLine("'" + theStack.peek() + "'" + " is at the top of the stack.\n");

            WriteLine("================== \nThe Stack contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);
            }
        }
        public class Stack
        {
            private int maxSize;
            private string[] stackArray;
            private int top;

            public Stack(int size)
            {
                maxSize = size;
                stackArray = new string[maxSize];
                top = -1;
            }

            public void push(string m)
            {
                if (isFull())
                {
                    WriteLine("This stack is full");
                }
                else
                {
                    top++;
                    stackArray[top] = m;
                }
            }

            public string pop()
            {
                if (isEmpty())
                {
                    WriteLine("The stack is empty.");
                    return "--";
                }
                else
                {
                    int old_top = top;
                    top--;
                    return stackArray[old_top];
                }
            }

            public string peek()
            {
                return stackArray[top];
            }

            public bool isEmpty()
            {
                return (top == -1);
            }

            private bool isFull()
            {
                return (maxSize - 1 == top);
            }
        }
    }
}
