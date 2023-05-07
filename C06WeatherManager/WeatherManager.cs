using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C06WeatherManager
{
    internal class WeatherManager
    {
        public void GetTemperature(string city, string type)
        {
            string searchChar = "°";
            string endChar = ">";
            string address = $"https://www.google.com/search?q=weather+{city}";

            WebClient wc = new WebClient();
            string data = wc.DownloadString(address);


            try
            {
                int index = data.IndexOf(searchChar);
                int currentPosition = index;
                int iterationCount = 0;

                while (data.Substring(currentPosition, 1) != endChar)
                {
                    iterationCount++;
                    currentPosition--;
                }

                string result = data.Substring(currentPosition + 1, index - currentPosition + 1);

                double temperature = Convert.ToDouble(result.Substring(0, result.Length - 2));
                string TemperatureWUnit = result;


                if (type == "F")
                {
                    temperature = temperature * 1.8 + 32;
                    TemperatureWUnit = Convert.ToString(temperature) + "°F";
                }

                else if (type == "K")
                {
                    temperature = temperature + 273.15;
                    TemperatureWUnit = Convert.ToString(temperature) + " K";
                }
                else if (type != "C")
                    throw new Exception();
                 
               Console.WriteLine(TemperatureWUnit);

            }
             catch (Exception)
            {
                Console.WriteLine("Failed to retrive temperature");

            }
}
    }
}
