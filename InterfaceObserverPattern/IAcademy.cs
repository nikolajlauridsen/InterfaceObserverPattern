using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceObserverPattern
{
    public interface IAcademy
    {
        void Attach(IStudent student);
        void Detach(IStudent student);
        void Notify();
    }
}
