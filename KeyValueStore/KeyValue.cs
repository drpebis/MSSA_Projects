using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    public struct KeyValue<T> where T : struct //Modified to become a generic type perameter 
    {
        public readonly string Key; //public readonly string Key
        public readonly T Value; //This used to be an Object value, now is a generic type

        public KeyValue(string key, T value) //Contrutor for KeyValue setting the instance fields
        {
            this.Key = key;
            this.Value = value;
        }

    }
}
