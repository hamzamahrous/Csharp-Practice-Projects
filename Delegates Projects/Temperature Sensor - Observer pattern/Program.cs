namespace Temperature_Sensor___Observer_Pattern {
    internal class Program {
        static void Main(string[] args) {
            Sensor sensor = new Sensor();
            DisplayScreen screen = new DisplayScreen();
            Alarm alarm = new Alarm();

            screen.watchSensor(sensor);
            alarm.listenToSensor(sensor);

            Console.WriteLine("Welcome to the temperature system!\n");

            while (true) {
                Console.WriteLine("1. Set the temperature");
                Console.WriteLine("2. Set the alarm threshold (default 30)");
                Console.WriteLine("3. Exit");

                Console.Write("Please enter your option number: ");

                var userChoice = Console.ReadLine();
                int.TryParse(userChoice, out int userChoiceNumber);

                switch (userChoiceNumber) {
                    case 1:
                        Console.Write("Please enter the temperature value: ");
                        var temperature = Console.ReadLine();
                        int.TryParse(temperature, out int newTemp);
                        sensor.changeTemperature(newTemp);

                        break;
                    case 2:
                        Console.Write("Please enter the alarm threshold: ");
                        var alarmThreshold = Console.ReadLine();
                        int.TryParse(alarmThreshold, out int newAlarmThreshold);
                        alarm.changeThreshold(newAlarmThreshold);

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid number!");
                        break;
                }
            }
        }
    }
}
