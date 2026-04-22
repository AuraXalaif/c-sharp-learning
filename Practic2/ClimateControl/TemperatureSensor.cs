using System;

namespace ClimateControl
{
    public class TemperatureSensor
    {
        public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;

        private double _temperature;
        public double Temperature
        {
            get => _temperature;
            set
            {
                if (Math.Abs(_temperature - value) > 1e-6)
                {
                    _temperature = value;
                    TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(_temperature));
                }
            }
        }
    }
}