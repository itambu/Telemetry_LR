using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public interface ISensor
    {
        ISensorSignal GetInstance();
//        ISensorSignal<T> GetInstance();
    }
}