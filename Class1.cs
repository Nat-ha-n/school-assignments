using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    class NumberStack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Enter the size of your stack");
            int size = Convert.ToInt32(Console.ReadLine());

            Stack mystack = new(size);

            while (true)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("*Choose one of the options*");
                Console.WriteLine("1. Add Items(Push)");
                Console.WriteLine("2. Remove Items(Pop)");
                Console.WriteLine("3. Show the top Item(Peek)");
                Console.WriteLine("4. Show all Items");
                Console.WriteLine("5. Exit");
                Console.WriteLine("**********************************************\n");

                Console.Write("Enter your choice:");
                string response = Console.ReadLine();

                if (response == "1")
                {
                    Console.Write("Enter the number you want to add:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    mystack.Push(number);

                }

                else if (response == "2")
                {
                    mystack.Pop();
                }

                else if (response == "3")
                {
                    mystack.Peek();
                }

                else if (response == "4")
                {
                    mystack.Display();
                }

                else if (response == "5")
                {
                    Console.WriteLine("Bye, See you Next Time");
                    break;
                }

                else
                {
                    Console.WriteLine("Please Choose a Valid Option");
                }
            }

        }
    }
    class Stack
    {
        private int[] item;
        private int top;
        private int size;

        public Stack(int stacksize)
        {
            size = stacksize;
            item = new int[size];
            top = -1;

        }
        
        public void Push(int value)
        {
            if(top == size - 1)
            {
                Console.WriteLine("The stack is full. Cannot insert anymore.\n");
            }
            else
            {
                top++;
                item[top] = value;
                Console.WriteLine($"Added {value} to the stack.\n");
            }
        }

        public void Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty. No more items to be removed.\n");
            }
            else
            {
                int removed = item[top];
                top--;
                Console.WriteLine($"Removed {removed} from the stack.\n");

            }
        }

        public void Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("The stack is empty.\n");
            }
            else
            {
                Console.WriteLine($"The top item is {item[top]}.\n");
            }
        }


        public void Display()
        {
            if(top == -1)
            {
                Console.WriteLine("The stack is empty\n");
            }
            else
            {
                Console.WriteLine("Stack items (Top to Bottom)");

                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(item[i]);
                }
            }
        }

    }



  
}