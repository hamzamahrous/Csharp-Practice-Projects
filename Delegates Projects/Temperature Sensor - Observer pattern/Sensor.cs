using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_Pattern {
    internal class Sensor {
        private int _temperature;
        public event EventHandler<TemperatureArguments> temperatureChangedEvent;

        public void changeTemperature(int newTemperature) {
            _temperature = newTemperature;

            TemperatureArguments tempArgs = new TemperatureArguments() {
                Temperature = newTemperature
            };

            temperatureChangedEvent(this, tempArgs);
        }
    }
}
