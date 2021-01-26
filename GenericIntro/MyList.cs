using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        T[] tempItems;
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item)
        {
            tempItems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

        public  T[] Items
        {
            get { return items; }
        }
    }
}
