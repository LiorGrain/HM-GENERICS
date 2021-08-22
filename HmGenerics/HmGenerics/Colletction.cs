using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmGenerics
{
    interface Collections<T>
    {
        public string GetType(T type);

    }
    class Colletction<T> : Collections<T>
    {
        public string GetType(T type)
        {
            return type.GetType().ToString();
        }
    }
}
