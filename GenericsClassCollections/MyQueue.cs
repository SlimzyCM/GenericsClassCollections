using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsClassCollections
{
    internal class MyQueue<T>
    {
        // List to hold the class item
        private readonly List<T> _queueList = new List<T>();

        // method to check if the stack is empty
        public bool IsEmpty()
        {
            return _queueList.Count == 0;
        }

        // add to the list in a queue format 
        public void Enqueue(T item)
        {
            _queueList.Add(item);
        }

        //remove from the list the first element
        public T Dequeue()
        {
            var remove = _queueList[0];
            _queueList.RemoveAt(0);
            return remove;

        }

        //print the items in the list to the console
        public void Print()
        {
            foreach (var item in _queueList)
            {
                Console.WriteLine(item);
            }
        }

        //return the count of item in the list
        public int Size()
        {
            return _queueList.Count;
        }


    }


}
