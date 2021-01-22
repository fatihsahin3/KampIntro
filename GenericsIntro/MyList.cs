using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) {

            T[] tempArray = items; // Created a temporary array to keep content of items array.
            items = new T[items.Length + 1]; // Renewed items array by increasing its length 1 more.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        
        }

        public int Length
        {
            get { return items.Length; }
        }
        
    }
}
