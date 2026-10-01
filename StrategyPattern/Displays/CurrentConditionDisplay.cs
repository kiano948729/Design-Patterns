using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public CurrentConditionDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        public void Display()
        {
            // Print the current conditions of the weather
            Console.WriteLine("Current conditions: {0} temperature, {1}% humidity, and {2} pressure", temperature, humidity, pressure
  );
        }
    }
}
