using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    public struct KeyValue
    {
        public readonly string Key; //public readonly string Key
        public readonly object Value; //public readonly object Value

        public KeyValue(string key, object value) //Contrutor for KeyValue setting the instance fields
        {
            this.Key = key;
            this.Value = value;
        }

    }
}
