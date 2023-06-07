using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class PressureSensor : Sensor<Pressure>
    {
        public override ISignal GetInstance()
        {
            return new Signal<Pressure>(100, DateTime.Now);
        }
    }
}
