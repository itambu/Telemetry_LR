using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public struct Signal<T> : ISignal
    {
        public T? Value { get; init; }
        public DateTime Created { get; init; }
        object? ISignal.Value { get => this.Value; }
        public Signal(T value) { Value = value; }

        public override string ToString()
        {
            return String.Format($"{Value} {Created}");
        }

        public Signal(T? value, DateTime created)
        {
            Value = value;
            Created = created;
        }
    }
}
