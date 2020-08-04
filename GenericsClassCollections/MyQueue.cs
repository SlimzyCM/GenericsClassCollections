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

        //
        public T Dequeue()
        {
            var remove = _queueList[0];
            _queueList.RemoveAt(0);
            return remove;

        }


        public void Print()
        {
            foreach (var item in _queueList)
            {
                Console.WriteLine(item);
            }
        }

        public int Size()
        {
            return _queueList.Count;
        }


    }


}
