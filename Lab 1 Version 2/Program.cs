using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            int heightFeet;
            double heightInches;
            double totalInches;
            double totalHeightCM;
            bool isCitizen;
            bool canVote;


            Console.WriteLine("First Name     : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Middle Initial : ");
            middleInitial = Console.ReadLine();
            Console.WriteLine("Last Name      : ");
            lastName = Console.ReadLine();
            fullName = firstName + middleInitial + ". " + lastName;

            Console.WriteLine("Age            : ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Height Feet    : ");
            heightFeet = int.Parse(Console.ReadLine());
            Console.WriteLine("Extra Inches   : ");
            heightInches = double.Parse(Console.ReadLine());
            double totalInches = heightFeet * 12 + heightInches;
            totalHeightCm = 2.54 * totalInches;

            Console.WriteLine("Citizen?       : ");
            isCitizen = bool.Parse(Console.ReadLine());
            bool isOldEnoughToVote = age >= 18;
            canVote = isCitizen && isOldEnoughToVote;

            Console.WriteLine();
            Console.WriteLine("Your Full Name Is    ---> " + fullName);
            Console.WriteLine("Your Height in CM Is ---> " + totalHeightCm);
            Console.WriteLine("Your Voter Status Is ---> " + canVote);
            Console.ReadKey(); 
        }
    }
}
