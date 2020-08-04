using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsClassCollections
{
    internal class Node<T>
    {

        internal T Data;
        internal Node<T> Prev;
        internal Node<T> Next;


        // Constructor to create a new node
        // Next and Prev is by default set to null
        public Node(T d)
        {
            Prev = null;
            Next = null;
            Data = d;

        }
    }
}
