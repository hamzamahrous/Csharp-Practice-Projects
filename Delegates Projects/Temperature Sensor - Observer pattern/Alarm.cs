using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_Pattern {
    internal class Alarm {
        private int _threshold = 30;

        public void changeThreshold(int newThreshold) {
            _threshold = newThreshold;
        }

        public void listenToSensor(Sensor sensor) {
            sensor.temperatureChangedEvent += listenToTemperature;
        }

        public void listenToTemperature(object? sender, TemperatureArguments args) {
            if(args.Temperature >= _threshold) {
                Console.WriteLine("ALARM FIRED!\n");
            }
        }
    }
}
