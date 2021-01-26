using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMyDictonary
{
    class MyDictonary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        TKey[] tempKeys;
        TValue[] tempValues;

        public MyDictonary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add (TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length & i < tempValues.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int CountKey
        {
            get { return keys.Length; }
        }

        public int CountValue
        {
            get { return values.Length; }
        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }




    }
}
