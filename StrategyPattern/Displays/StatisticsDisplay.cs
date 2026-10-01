using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            sumTemperature += temp;
            countUpdated++;

            if (countUpdated == 1)
            {
                maxTemp = temp;
                minTemp = temp;
            }
            else
            {
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                }
            }

            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            float averageTemperature = sumTemperature / countUpdated;
            Console.WriteLine("Statistics: gemiddelde temperature: {0}, Maximum temperature: {1}, Minimum temperature: {2}", averageTemperature, maxTemp, minTemp);      
        }
    }
}
