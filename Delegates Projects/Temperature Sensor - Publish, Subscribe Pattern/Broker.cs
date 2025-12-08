using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor {
    internal class Broker {
        Dictionary<string, List<Action<TemperatureArguments>>> _subscrbtionsList = new();

        public void publish(string eventTitle, TemperatureArguments message) {
            if (_subscrbtionsList.ContainsKey(eventTitle)) {
                foreach (Action<TemperatureArguments> action in _subscrbtionsList[eventTitle]) {
                    action(message);
                }
            }
        }

        public void subscribe(string eventTitle, Action<TemperatureArguments> action) {
            if (!_subscrbtionsList.ContainsKey(eventTitle)) _subscrbtionsList.Add(eventTitle, new List<Action<TemperatureArguments>>());

            _subscrbtionsList[eventTitle].Add(action);
        }
    }
}
