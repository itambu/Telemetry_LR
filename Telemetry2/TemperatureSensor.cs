using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public class TemperatureSensor : Sensor<double>
    {
        public override ISensorSignal GetInstance()
        {
            return new Signal<double>(100, DateTime.Now);
        }
    }
}