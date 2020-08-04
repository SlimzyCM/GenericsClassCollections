using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;

namespace GenericsClassCollections
{
    class MyLinkedList<T>
    {
        internal Node<T> Head;


        // add item at the beginning of the list and return its new size
        public int AddAtStart( T data)
        {
            var newNode = new Node<T>(data) {Next = Head, Prev = null};

            if (Head != null)
            {
                Head.Prev = newNode;
            }

            Head = newNode;

            return Size();

        }



        // Get the tail node 
        internal Node<T> GetTailNode()
        {
            var temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }



        // add item at the end of the list and return its new size
        internal int AddAtEnd(T data)
        {
            var newNode = new Node<T>(data);
            if (Head == null)
            {
                newNode.Prev = null;
                Head = newNode;
                return Size();
            }

            var lastNode = GetTailNode();

            lastNode.Next = newNode;
            newNode.Prev = lastNode;
            return Size();
            
           
        }


        
        // print all items in the list
        public void Print()
        {
            var print = Head;
            while (print != null)
            {
                Console.WriteLine(print.Data + " ");
                print = print.Next;
            }
        }


        // return the size of the list
        public int Size()
        {
            var count = 0;
            var size = Head;
            while (size != null)
            {
                count++;
                size = size.Next;
            }
            return count;

        }

        
        // Check if an item is present, return true else return false
        public bool Contains( T item)
        {
            var print = Head;
            while (print != null)
            {
                if (print.Data.Equals(item)) return true;

                print = print.Next;
            }

            return false;
        }
        
        //search for an item and return it if found otherwise return null
        public object Search (T item)
        {
            var print = Head;
            while (print != null)
            {
                if (print.Data.Equals(item)) return print.Data;

                print = print.Next;
            }

            return null;
        }


        // method to remove an item
        public void Remove(T item)
        {
            var temp = Head;

            //head is not null and item to remove is the head
            if (temp != null && temp.Data.Equals(item))
            {
                Head = temp.Next;
                Head.Prev = null;
                return;
            }

            //head is not null, loop to find the item to remove
            while (temp != null && !temp.Data.Equals(item))
            {
                temp = temp.Next;
            }
            
            // if it is not found return
            if (temp == null) return;
            
            //check that it is not tail
            if (temp.Next != null) temp.Next.Prev = temp.Prev;
            
            if (temp.Prev != null) temp.Prev.Next = temp.Next;

        }

        // call size method and check if it contains no item
        public bool IsEmpty()
        {
            var size = Size();
            return size < 1;
        }


        // find index of item in the list, if found return zero based indexing else return -1
        internal int IndexOf(T item )
        {

            var count = 0;
            var findIndex = Head;

            while (findIndex != null)
            {
                if (findIndex.Data.Equals(item)) return count;

                count++;
                findIndex = findIndex.Next;
            }

            return -1;
        }


        // Insert item at the given position "Zero based" indexing
        internal void Insert(int index, T item)
        {
            
            if(index > Size()) throw new IndexOutOfRangeException();
            var newNode = new Node<T>(item);
            if (index == 0) AddAtStart(item);

            else
            {
                var count = 0;
                
                var temp = Head;



                while (temp != null && count <= index)
                {

                    if (count == index)
                    {
                        var insertNode = temp;
                        insertNode.Prev.Next = newNode;
                        insertNode.Prev = newNode.Prev;
                        newNode.Next = insertNode;
                        //Console.WriteLine(temp.Data);
                    }

                    count++;
                    temp = temp.Next;
                }

            }
            

        }







    }
}
