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

        public ForecastDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            statusWeather = temperature > 16;

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
