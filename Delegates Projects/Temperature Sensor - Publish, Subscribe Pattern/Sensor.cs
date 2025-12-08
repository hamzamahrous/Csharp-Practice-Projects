using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor {
    internal class Sensor {
        private int _temperature;
        private Broker _broker;
        
        public Sensor(Broker broker) {
            _broker = broker;
        }
        
        public void changeTemperature(int newTemperature) {
            _temperature = newTemperature;

            TemperatureArguments tempArgs = new TemperatureArguments() {
                Temperature = newTemperature
            };

            _broker.publish("Temperature-Changed", tempArgs);
        }
    }
}
