using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public abstract class Sensor<T> : ISensor
    {
        public abstract ISensorSignal GetInstance();
    }
}