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
        private float pressure;
        private bool statusWeather;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            if (temperature > 16)
            {
                statusWeather = true;

            }
            else
            {
                statusWeather = false;
            }
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (statusWeather)
            {
                Console.WriteLine("ahh het wordt weer een lekker weer, wunderbar!");
            }
            else
            {
                Console.WriteLine("ahh ik ben niet van suiker ;)");
            }
            Console.WriteLine("voorspellingen worden: {0} temperature, {1} humidity and {2} pressure", temperature, humidity, pressure);
            Console.WriteLine("--------------------------------------------------------");

        }
    }
}
