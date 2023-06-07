// See https://aka.ms/new-console-template for more information
using Telemetry2;

Console.WriteLine("Hello, World!");


ICollection<ISensorSignal> signals = new List<ISensorSignal>();
ICollection<ISensor> sensors = new List<ISensor>();


var cp = new CentralPost(signals, sensors);
sensors.Add(new TemperatureSensor());


cp.GetAll();
cp.Serialize(Console.Out);