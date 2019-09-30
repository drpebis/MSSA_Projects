using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class GenericList<T> 
    {
        public List<T> GenList = new List<T>();

        public List<T> LoadList(T value)
        {
            GenList.Add(value);
            return GenList;
        }

        public List<T> DeloadList()
        {
            return GenList;
        }
    }
}
