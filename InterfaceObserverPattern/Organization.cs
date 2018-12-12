using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceObserverPattern
{
    class Organization
    {
        public string Name { get; }
        public string Adress;

        public Organization(string name)
        {
            Name = name;
        }
    }
}
