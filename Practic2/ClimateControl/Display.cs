using System;

namespace ClimateControl
{
    public class Display
    {
        public void Subscribe(TemperatureSensor sensor) => sensor.TemperatureChanged += OnTemperatureChanged;
        public void Unsubscribe(TemperatureSensor sensor) => sensor.TemperatureChanged -= OnTemperatureChanged;

        private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Display: Current temperature {e.Temperature:F1}°C");
        }
    }
}