using ClimateControl;
using System;

namespace ClimateControl
{
    class Program
    {
        static void Main()
        {
            var sensor = new TemperatureSensor();
            var display = new Display();
            var ac = new AirConditioner();
            var security = new SecuritySystem();

            // Подписка на событие
            display.Subscribe(sensor);
            ac.Subscribe(sensor);
            security.Subscribe(sensor);

            // Последовательные изменения температуры
            double[] temps = { 20, 15.5, 26, 41, 3, 22 };
            foreach (var t in temps)
            {
                Console.WriteLine($"\n-- Setting temperature to {t}°C --");
                sensor.Temperature = t;
            }
        }
    }
}