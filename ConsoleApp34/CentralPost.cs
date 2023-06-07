using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class CentralPost
    {
        protected ICollection<ISensor> Sensors { get; init; }

        protected ICollection<ISignal> Signals { get; init; }

        public CentralPost(ICollection<ISensor> sensors, ICollection<ISignal> signals) 
        { 
            Sensors = sensors; 
            Signals = signals;
        }

        public void GetAll()
        {
            foreach (ISensor sensor in Sensors) 
            {
                var signal = sensor.GetInstance();
                Signals.Add(signal);
            }
        }

        public void OutputAll(TextWriter writer)
        {
            foreach (ISignal signal in Signals)
            {
                writer.WriteLine(signal);
            }
        }

    }
}
