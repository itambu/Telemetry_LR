using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public interface ISignal
    {
        public object? Value { get; }
        public DateTime Created { get; }
    }
}
