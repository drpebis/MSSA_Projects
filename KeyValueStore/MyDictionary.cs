using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    class MyDictionary
    {
        public MyDictionary()
        {
            count = this.keyValueArray.Length;
        }

        private int count;//Used to keep track of number of stored values 

        KeyValue[] keyValueArray = new KeyValue[5] {
                new KeyValue("cats", 1),
                new KeyValue("logs", 2),
                new KeyValue("bogs", 3),
                new KeyValue("cogs", 4),
                new KeyValue("pogs", 5)
            }; //Array of the KeyValue struct
                
        public object this[string key] //Indexer
        {
            get
            {  
                for (int i = 0; i < keyValueArray.Length; i++) 
                {
                    if (keyValueArray[i].Key.ToLower() == key.ToLower())
                    {
                        return keyValueArray[i].Value;
                    }
                }
                throw new KeyNotFoundException($"Key not found {key}");
            }
            set
            {
                bool hasKey = keyValueArray.Any(x => x.Key.ToLower() == key.ToLower());
                if (hasKey)
                {
                    for (int i = 0; i < keyValueArray.Length; i++)
                    {
                        if (keyValueArray[i].Key.ToLower() == key.ToLower())
                        {
                            keyValueArray[i] = new KeyValue(key, value);
                        }

                    }
                }
                else
                {
                    KeyValue[] temp = new KeyValue[count + 1];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (j < temp.Length - 1)
                        {
                            temp[j] = new KeyValue(keyValueArray[j].Key, keyValueArray[j].Value);
                        }
                        else
                        {
                            temp[j] = new KeyValue(key, value);
                        }
                    }
                    Array.Clear(keyValueArray, 0, count);
                    Array.Resize(ref keyValueArray, count + 1);
                    for (int j = 0; j < keyValueArray.Length; j++)
                    {
                        keyValueArray[j] = new KeyValue(temp[j].Key, temp[j].Value); 
                    }
                }
            }
        }
    }
}
