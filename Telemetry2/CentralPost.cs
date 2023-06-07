using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telemetry2
{
    public class CentralPost
    {
        protected ICollection<ISensorSignal> Signals { get; private set; }

        //protected ICollection<ISensorSignal<object>>? Signals2 { get; private set; }

        protected ICollection<ISensor> Sensors { get; private set; }

        public CentralPost(ICollection<ISensorSignal> signals, ICollection<ISensor> sensors) 
        {
            if (signals is null)
            {
                throw new ArgumentNullException(nameof(signals));
            }

            if (sensors is null)
            {
                throw new ArgumentNullException(nameof(signals));
            }

            Signals = signals;
            Sensors = sensors;
        }

        public void GetAll()
        {
            foreach (var sensor in Sensors) 
            {
                var signal = sensor.GetInstance();
                Signals.Add(signal);
            }
        }

        public void Serialize(TextWriter writer)
        {
            foreach(var signal in Signals)
            {
                writer.WriteLine(signal);
            }
        }
    }
}