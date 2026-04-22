using System;

namespace ClimateControl
{
    public class SecuritySystem
    {
        public void Subscribe(TemperatureSensor sensor) => sensor.TemperatureChanged += OnTemperatureChanged;
        public void Unsubscribe(TemperatureSensor sensor) => sensor.TemperatureChanged -= OnTemperatureChanged;

        private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
        {
            double t = e.Temperature;
            if (t > 40) Console.WriteLine("SecuritySystem: ALERT! Overheat detected!");
            if (t < 5) Console.WriteLine("SecuritySystem: WARNING! Risk of freezing systems!");
        }
    }
}