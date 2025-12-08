using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor {
    internal class DisplayScreen {
        public void subscribeToBroker(Broker broker) {
            broker.subscribe("Temperature-Changed", displayTemperatureOnScreen);
        }

        public void displayTemperatureOnScreen(TemperatureArguments args) {
            Console.WriteLine($"The temperature has changed, the new temperature is {args.Temperature}");
        }
    }
}
