using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEx3
{
    public class Dictionary<TKey, TValue>
    {
        TKey[] arrayKey;
        TValue[] arrayValue;
        int position = 0;

        public Dictionary()
        {
            arrayKey = new TKey[0];
            arrayValue = new TValue[0];
        }

        public int KeyCount
        {
            get { return arrayKey.Count(); }
        }

        public int ValueCount
        {
            get { return arrayValue.Count(); }
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = new TKey[arrayKey.Length + 1];
            TValue[] tempValue = new TValue[arrayValue.Length + 1];

            for (int i = 0; i < arrayKey.Length && i < arrayValue.Length; i++)
            {
                tempKey[i] = arrayKey[i];
                tempValue[i] = arrayValue[i];
            }
            tempKey[position] = key;
            tempValue[position] = value;
            arrayKey = tempKey;
            arrayValue = tempValue;
            position++;
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < arrayKey.Length; i++)
                {
                    if (arrayKey[i].Equals(key))
                        return arrayValue[i];
                }
                Console.WriteLine("Not exist key: {0}", key);
                return default;
            }
            set
            {
                int tempPosition = 0;
                while(tempPosition< arrayKey.Length) 
                {
                    if (arrayKey[tempPosition].Equals(key))
                    {
                        arrayValue[tempPosition] = value;
                        return;
                    }
                    tempPosition++;
                }
                Console.WriteLine("Not exist key: {0}", key);
            }
        }

        public IEnumerable<TKey> Key
        {
            get
            {
                for(int i=0;i<arrayKey.Length;i++)
                    yield return arrayKey[i];
            }
        }

        public IEnumerable<TValue> Values
        {
            get
            {
                for(int i = 0; i < arrayValue.Length; i++)
                    yield return arrayValue[i];
            }
        }
    }
}
