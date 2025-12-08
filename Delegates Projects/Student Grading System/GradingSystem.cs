using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System {
    internal class GradingSystem {
        public void displayGradingInfo(List<Student> students, 
            Func<List<int>, double> avgMethod,
            Predicate<double> passingMethod,
            Action<Student, double, bool> displayStudentData
            ) {
            foreach(var student in students) {
                double avg = avgMethod(student.grades);
                bool passed = passingMethod(avg);
                displayStudentData(student, avg, passed);
            }
        }
    }
}
