using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmGenerics
{
    interface BaseName
    {
        public string Name { get; set; }
    }

    class Targilhaharon :BaseName
    {
        public string Name { get; set; } = "classic";
        public string printname()
        {
            return Name;
        }
        public override string ToString()
        {
            return GetType().Name;
        }

    }
}
