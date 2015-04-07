using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public bool Married;
    
    public static Person Create(string Person01)
    {
        Question.SetPromptPrefix(Person01);

        Person Person = new Person();
        Person.FirstName = Question.AskForString("First Name");
        Person.LastName = Question.AskForString("Last Name");
        Person.Age = Question.AskForInteger ("Age");
        Person.Married = Question.AskForBoolean ("Married(Y/N)");

        if (Person.Married)
        {
            Person.Spouse = new Person();
            Person.Spouse.FirstName = Question.AskForString("Spouse Name");
            Person.Spouse.Age = Question.AskForInteger("Spouse Age");
            Person.Spouse.Spouse = Person;

        }
            Console.WriteLine();
            return Person;
        }
    }
}


