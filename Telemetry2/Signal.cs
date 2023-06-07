using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public class Signal<T> : ISensorSignal
    {
        public T? Value { get; init; }
        object? ISensorSignal.Value => this.Value;

        public DateTime? Created { get; init; }

        public Signal(T value, DateTime? created)
        {
            this.Value = value;
            this.Created = created;
        }

        public override string ToString() => $"Signal {this.Value} {this.Created}";
    }
}