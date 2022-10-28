using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   internal class GenericTypes1
    {
        public void Stack()
        {
            Stack<int> numbers = new Stack<int>();
            //push
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);

            foreach (var item in numbers)
                Console.Write(item + ",");
            Console.WriteLine("Number of elements in Stack: {0}", numbers.Count);

            Console.WriteLine(numbers.Contains(4));

        }

        public void Pop()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.WriteLine();
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            
        }

        public void Peek()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek());
             
            }

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
        }

        public void Queue()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.WriteLine(id);
        }
    }
    }


