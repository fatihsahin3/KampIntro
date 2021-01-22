using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keys; // Initial arrays are stated.
        T2[] values;
        T1[] tempKeys; // Initial temporary arrays are stated.
        T2[] tempValues;

        public MyDictionary()
        {
            keys = new T1[0]; //Initial arrays are created with 0 item when the constructor is called by new keyword.
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            tempKeys = keys; // Temporary arrays store the data in keys and values arrays. 
            tempValues = values;

            keys = new T1[keys.Length + 1]; // New keys and values arrays are created with 1 more index.
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++) // Items of tempKeys array are copied into new "keys" array.
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++) // Items of tempValues array are copied into new "values" array.
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key; // New key is assigned into last index of new "keys" array.
            values[values.Length - 1] = value; // New value is assigned into last index of new "values" array.
        }

        public T2 GetValue(T1 key) 
        {
            int indexOfKey = 0; // An initial index number is created and set to zero in each call of this method.

            for (int i = 0; i < keys.Length; i++) // Index number of the method parameter "key" is searched within "keys" array.
            {
                if (keys[i].Equals(key))
                {
                    indexOfKey = i; // Index is found and assigned to indexOfKey.
                }
            }

            return values[indexOfKey]; // Value corresponding to given key is returned back by the same index number they have with key.              
        }

        public int GetLength()
        {
            return keys.Length; // Returns the length of keys array which also equals to Dictionary row number.
        }


    }
}
