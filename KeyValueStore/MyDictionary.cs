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
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        KeyValue<int>[] keyValueArray = new KeyValue<int>[5] { //Generic type parameter is now defined as int
                new KeyValue<int>("Rats", 1),
                new KeyValue<int>("logs", 2),
                new KeyValue<int>("bogs", 3),
                new KeyValue<int>("cogs", 4),
                new KeyValue<int>("pogs", 5)
            }; //Array of the KeyValue struct
                
        public object this[string key] //Indexer, don't think I'm doing this right...
        {
            get
            {  
                for (int i = 0; i < keyValueArray.Length; i++) 
                {
                    if (keyValueArray[i].Key.ToLower() == key.ToLower())
                    {
                        //return new KeyValue(key, i);
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
                            keyValueArray[i] = new KeyValue<int>(key, (int)value);
                        }

                    }
                }
                else
                {
                    KeyValue<int>[] keyValueArray2 = new KeyValue<int>[count + 1];
                    for (int j = 0; j < keyValueArray2.Length; j++)
                    {
                        if (j < keyValueArray2.Length - 1)
                        {
                            keyValueArray2[j] = new KeyValue<int>(keyValueArray[j].Key, keyValueArray[j].Value);
                        }
                        else
                        {
                            keyValueArray2[j] = new KeyValue<int>(key, (int)value);
                        }
                    }
                    Array.Clear(keyValueArray, 0, count);
                    Array.Resize(ref keyValueArray, count + 1);
                    count++;
                    for (int j = 0; j < keyValueArray.Length; j++)
                    {
                        keyValueArray[j] = new KeyValue<int>(keyValueArray2[j].Key, keyValueArray2[j].Value); 
                    }
                }
            }
        }
    }
}
