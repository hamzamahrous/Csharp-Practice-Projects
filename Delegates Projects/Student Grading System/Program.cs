
namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Welcome to our grading system!\n");

            while (true) {
                Console.WriteLine("Please enter student name or enter 'done' when finished ...");
                var studentName = Console.ReadLine();

                if(studentName == "done") break;

                Console.WriteLine("Please enter your five subjects grades:");
                List<int> studentGrades = new List<int>();
                for(int i = 0; i < 5; i++) {
                    var grade = Console.ReadLine();
                    int.TryParse(grade, out int result);

                    studentGrades.Add(result);
                }

                Student student = new Student() {
                    Name = studentName ?? "Defualt Name",
                    grades = studentGrades
                };

                students.Add(student);
                Console.WriteLine($"Student {student.Name} added successfully!");
            }

            GradingSystem gradingSys = new GradingSystem();
            gradingSys.displayGradingInfo(students, calculateAverage, passingMethod, displayStudentStatus);
        }

        private static double calculateAverage(List<int> grades) {
            return grades.Sum() / grades.Count;
        }

        private static bool passingMethod(double avg) {
            return avg >= 50;
        }

        private static void displayStudentStatus(Student student, double avg, bool isPassed) {
            Console.WriteLine($"Student {student.Name} has got an average of {avg}");
            
            if (isPassed) Console.WriteLine($"Student {student.Name} passed the exams!");
            else Console.WriteLine($"Student {student.Name} didn't pass the exams.");
        }
    }
}
