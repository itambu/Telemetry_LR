// See https://aka.ms/new-console-template for more information
using ConsoleApp34;



var sensors = new List<ISensor>() { new PressureSensor() };
var signals = new List<ISignal>();

var cp = new CentralPost(sensors, signals);

cp.GetAll();
cp.OutputAll(Console.Out);
