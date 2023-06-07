using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp34
{
    public readonly struct Pressure
    {
        private readonly double pressure;
        public static implicit operator double(Pressure p) => p.pressure;
        public static implicit operator Pressure(double b) => new Pressure(b);

        public Pressure(double pressure)
        {
            if (pressure <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pressure), "Pressure must be positive");
            }
            this.pressure = pressure;
        }

        public override string ToString()
        {
            return $"{pressure}";
        }
    }
}
