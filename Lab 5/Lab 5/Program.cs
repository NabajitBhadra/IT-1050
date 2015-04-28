using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int classSize;
            bool correct = false; 

            while (!correct)
            {
            Course course = new Course();
 
            Console.WriteLine("Please provide the name of the course?      ");
            course.courseName = Console.ReadLine();
            Console.WriteLine("What is the Course number?    ");
            course.courseID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Students in Course?     ");
            classSize = Convert.ToInt32(Console.ReadLine());
               
            course.classStudents = new Student[classSize];
           
            for (int i = 0; i < classSize; i++)
            {
                
                Console.WriteLine(String.Format("What is Student {0} name?   ",i+1));
                string studentName = Console.ReadLine();
                Console.WriteLine(String.Format("What is Student {0} ID?   ",i+1));
                int studentID = Convert.ToInt32(Console.ReadLine());

                course.classStudents[i] = new Student(studentName, studentID);
                Student[] classStudents = new Student[i];
                
            }

            Console.Write("Please recheck the information.Is it correct (yes/no)?     ");
            correct = Console.ReadLine().StartsWith("y");


            }

        }
    }
}
