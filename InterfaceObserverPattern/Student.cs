using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceObserverPattern
{
    class Student : Person, IStudent
    {
        private IAcademy _acedemy;
        public string Message;

        public Student(IAcademy acedemy, string name) : base(name)
        {
            this._acedemy = acedemy;
        }
        public void Update()

        {   
            Message = ((Academy)_acedemy).Message;
            string acadName = ((Academy)_acedemy).Name;
            Console.WriteLine(String.Format("Studerende {0} modtog nyheden '{1}' fra akademiet {2}", Name, Message, acadName));
        }
    }
}
