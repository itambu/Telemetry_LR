using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public interface ISensorSignal
    {
        object? Value { get; }
        DateTime? Created { get; }
    }

    //public interface ISensorSignal<T>
    //{
    //    T? Value { get; }
    //    DateTime? Created { get; }
    //}
}