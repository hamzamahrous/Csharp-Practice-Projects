using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_Pattern {
    internal class DisplayScreen {
        public void watchSensor(Sensor sensor) {
            sensor.temperatureChangedEvent += displayTemperatureOnScreen;
        }

        public void displayTemperatureOnScreen(object? sender, TemperatureArguments args) {
            Console.WriteLine($"The temperature has changed, the new temperature is {args.Temperature}");
        }
    }
}
