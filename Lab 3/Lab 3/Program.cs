using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Snack smallSoda = new Snack();
            smallSoda.name = "small soda";
            smallSoda.price = 3.50;

            Snack largeSoda = new Snack();
            largeSoda.name = "large soda";
            largeSoda.price = 5.99;

            Snack hotdog = new Snack();
            hotdog.name = "hotdog";
            hotdog.price = 3.99;

            Snack popcorn = new Snack();
            popcorn.name = "popcorn";
            popcorn.price = 4.50;

            Snack candy = new Snack();
            candy.name = "candy";
            candy.price = 1.99;

            double ticketPrice = 0;
           
            
            
            Console.Write("Want to know how much it will cost to go to the movies? (yes/no)    ");
            bool wantToKnow = Console.ReadLine().ToLower().StartsWith("y");
            if (wantToKnow)
            {
                Console.WriteLine("No Problem");
            }
            else
            {
                Console.WriteLine("Huh?...What?....Just answer the questions below.");
            }

            Console.Write("How many adults will attend?     ");
            int adultCount = int.Parse(Console.ReadLine());
           
            Console.Write("How many children will attend?   ");
            int childrenCount = int.Parse(Console.ReadLine());
           
            Console.Write("How many seniors will attend?    ");
            int seniorCount = int.Parse(Console.ReadLine());

           
            Console.Write("Is this a Matinee? (yes/no)      ");
            bool isMatinee = Console.ReadLine().ToLower().StartsWith("y");


            if (isMatinee)
            {
                ticketPrice += adultCount * 5.99;

                ticketPrice += childrenCount * 3.99;

                ticketPrice += seniorCount * 4.50;
            }
            else
            {
                ticketPrice += adultCount * 10.99;

                ticketPrice += childrenCount * 6.99;

                ticketPrice += seniorCount * 8.50;
            }

            Console.WriteLine("ticket price =  " + ticketPrice);

            int popcornCount = 0;
            int largeSodaCount = 0;
            int smallSodaCount = 0;
            int discountPrice = 0;
            int candyCount = 0;
            double concessionPrice = 0;

            Console.Write("Would you like any snacks? (yes/no)      ");
            bool wantSnack = Console.ReadLine().ToLower().StartsWith("y");

            if (wantSnack)
            {
                Console.Write("Would you like any popcorn? (yes/no)    ");
                bool wantPopcorn = Console.ReadLine().ToLower().StartsWith("y");
                if (wantPopcorn)
                {
                    Console.Write("How much popcorn would you like?     ");
                    popcornCount = int.Parse(Console.ReadLine());
                }

                Console.Write("Would you like a soda? (yes/no)        ");
                bool yesSoda = Console.ReadLine().ToLower().StartsWith("y");

                if (yesSoda)
                {
                    Console.Write("How many large sodas would you like?     ");
                    largeSodaCount = int.Parse(Console.ReadLine());
                    Console.Write("How many small sodas would you like?     ");
                    smallSodaCount = int.Parse(Console.ReadLine());
                }
                Console.Write("Would you like any candy? (yes/no)       ");
                bool wantCandy = Console.ReadLine().ToLower().StartsWith("y");
                if (wantCandy)
                {
                    Console.Write("How many orders of candy would you like?      ");
                    candyCount = int.Parse(Console.ReadLine());
                }
                Console.Write("Would you like any hotdogs? (yes/no)      ");
                bool wantHotdog = Console.ReadLine().ToLower().StartsWith("y");

                Console.Write("How many hotdogs would you like?        ");
                int hotdogCount = int.Parse(Console.ReadLine());

                concessionPrice += (popcornCount * popcorn.price) + (largeSodaCount * largeSoda.price) + (smallSodaCount * smallSoda.price) + (candyCount * candy.price) + (hotdogCount * hotdog.price);

                Console.WriteLine("Concession price =  " + concessionPrice);
                }

                if (popcornCount > 0 & largeSodaCount > 0)
                {
                    Console.WriteLine("Congratulations, you will receive a two dollar discount!");
                    discountPrice = 2;
                }
                else
                {
                    discountPrice = 0;
                }

                if ((adultCount + seniorCount + childrenCount) > 3)
                {
                    Console.WriteLine("Congratulations, you will receive a free popcorn!");
                }

            double moviePrice = ticketPrice + concessionPrice - discountPrice;
            Console.WriteLine("Total price for night at movies:  " + moviePrice);
            Console.ReadKey();

        }
    }
}
