using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsClassCollections
{
    internal class MyStack<T> :  IEnumerator,IEnumerable
    {
        //variable for the IEnumerable
        private int _position = -1;

        // List to hold the class item
        private readonly List<T> _stackList = new List<T>();

        // method to check if the stack is empty
        public bool IsEmpty()
        {
            return _stackList.Count == 0;
        }

        //output to the console
        public void Print()
        {
            foreach (var item in _stackList)
            {
                Console.WriteLine(item);
            }
        }



        //method to add item to the list
        public void Push(T item)
        {
            _stackList.Insert(0, item);

        }


        // remove and return the last added item in the list
        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            else
            {
                var remove = _stackList[0];
                _stackList.RemoveAt(0);
                return remove;


                // var remove = _stackList[^1];
                // _stackList.RemoveAt(_stackList.Count - 1);
                // return remove;
            }
        }


        //return the last added item in the list
        public T Peep()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            else return _stackList[0];
        }



        // Make the class enumerable
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //IEnumerator
        public bool MoveNext()
        {
            _position++;
            return (_position < _stackList.Count);
        }
        //IEnumerable
        public void Reset()
        {
            _position = 0;
        }
        //IEnumerable
        public object Current => _stackList[_position];

        public int Size()
        {
            return _stackList.Count;
        }



    }
}
