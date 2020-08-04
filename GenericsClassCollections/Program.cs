using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace GenericsClassCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue<int>();
            var stack = new MyStack<int>();

            stack.Push(0);
            stack.Push(45);
            stack.Push(17);
            Console.WriteLine("-------------------");
            foreach(int item in stack)
            {
               Console.WriteLine(item + "/"); 
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine("-------------------");

            stack.Push(11);

            Console.WriteLine("-------------------");
            //stack.Print();

            queue.Enqueue(0);
            queue.Enqueue(45);
            queue.Enqueue(17);
            Console.WriteLine("-------------------");

            var s =queue.Dequeue();
            Console.WriteLine(s);

            Console.WriteLine("-------------------");
            queue.Enqueue(11);

            queue.Print();
            //Console.WriteLine(result);
            //queue.Print();
            

            var linked = new MyLinkedList<int>();
            linked.AddAtEnd(2);
            linked.AddAtEnd(3);
            linked.AddAtEnd(4);
            linked.AddAtEnd(5);
            linked.AddAtEnd(8);
            linked.AddAtEnd(09);

            //linked.Print();
            //linked.AddAtStart(7);
            //Console.WriteLine(linked.Contains(5));
            //Console.WriteLine(linked.Search(2));
            //linked.Remove(3);
            linked.Insert(4,27);
            linked.Insert(7, 0);

            linked.Print();

            var link = new MyLinkedList<string>();
            link.AddAtStart("hey");
            link.AddAtStart("hi");

            //Console.WriteLine(link.Search("hey"));
            Console.WriteLine("----------------");
            //Console.WriteLine(linked.IndexOf(4));
            link.Print();

            //Console.WriteLine("\n");
            //Console.WriteLine("Size of list :" + linked.Size());
        }
    }
}
