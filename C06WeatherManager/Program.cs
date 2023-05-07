using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06WeatherManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherManager wm = new WeatherManager();
            wm.GetTemperature("Krakow", "C");
            wm.GetTemperature("Krakow", "K");
            wm.GetTemperature("Krakow", "F");


        }
    }
}
