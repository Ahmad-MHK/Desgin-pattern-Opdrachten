using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Display();
            this.temperature = temp;
            this.humidity = humidity;

        }

        public void Display()
        {
            float forecastTemperature = temperature + (0.11f * humidity) + (0.2f * (temperature - 14.5f));
            Console.WriteLine($"Forecast: {forecastTemperature}°C");
        }
    }
}
