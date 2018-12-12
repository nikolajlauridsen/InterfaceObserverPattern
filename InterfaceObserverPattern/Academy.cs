using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceObserverPattern
{
    class Academy : Organization, IAcademy
    {
        private List<IStudent> students = new List<IStudent>();
        private string message;
        public string Message {
            get {
                return message;
            }
            set {
                message = value;
                Notify();
            }
        }

        public Academy(string name, string adress) : base(name)
        {
            Adress = adress;
        }

        public void Attach(IStudent student)
        {
            students.Add(student);
        }

        public void Detach(IStudent student)
        {
            students.Remove(student);
        }

        public void Notify()
        {
            foreach(IStudent student in students) {
                student.Update();
            }
        }
    }
}
