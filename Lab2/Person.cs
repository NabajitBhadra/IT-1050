using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            string FName = this.FirstName;
            string LName = this.LastName;
            return FirstName + " " + LastName;
        }
    }
}
