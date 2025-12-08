using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor {
    internal class Alarm {
        private int _threshold = 30;

        public void changeThreshold(int newThreshold) {
            _threshold = newThreshold;
        }

        public void subscribeToBroker(Broker broker) {
            broker.subscribe("Temperature-Changed", listenToTemperature);
        }

        public void listenToTemperature(TemperatureArguments args) {
            if (args.Temperature >= _threshold) {
                Console.WriteLine("ALARM FIRED!\n");
            }
        }
    }
}
