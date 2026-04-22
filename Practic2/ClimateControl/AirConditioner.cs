using System;

namespace ClimateControl
{
    public class AirConditioner
    {
        public void Subscribe(TemperatureSensor sensor) => sensor.TemperatureChanged += OnTemperatureChanged;
        public void Unsubscribe(TemperatureSensor sensor) => sensor.TemperatureChanged -= OnTemperatureChanged;

        private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
        {
            double t = e.Temperature;
            if (t < 17) Console.WriteLine("AirConditioner: Turning on heating");
            else if (t <= 25) Console.WriteLine("AirConditioner: Turned off");
            else Console.WriteLine("AirConditioner: Turning on cooling");
        }
    }
}