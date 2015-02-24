using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            A.FirstName = "Abhi";
            A.LastName = "Bhadra";

            Person B = new Person();
            B.FirstName = "Kanye";
            B.LastName = "West";

            Pet pA = new Pet();
            pA.Name = "Laddu";
            pA.Age = 12;
            pA.Species = "dog";
            pA.Owner = A;

            Pet pB = new Pet();
            pB.Name = "Garfield";
            pB.Age = 6;
            pB.Species = "cat";
            pB.Owner = B;

            Pet pC = new Pet();
            pC.Name = "Chance";
            pC.Age = 4;
            pC.Species = "gerbil";
            pC.Owner = B;

            String AB = A.GetFullName();
            String KW = B.GetFullName();

            Console.WriteLine (pA.Name + "\t" + "\t" + "\t" + "\t" + pB.Name + "\t" + "\t" + "\t" + pC.Name);
            Console.WriteLine (pA.Age + "\t" + "\t" + "\t" + "\t" + pB.Age + "\t" + "\t" + "\t" + "\t" +  pC.Age);
            Console.WriteLine (pA.Species + "\t" + "\t" + "\t" + "\t" + pB.Species +"\t" + "\t" + "\t" + "\t" + pC.Species);
            Console.WriteLine (AB + "\t" + "\t" + "\t" + KW + "\t" + "\t" + "\t" + KW);
            Console.ReadLine ();

        }
    }
}
