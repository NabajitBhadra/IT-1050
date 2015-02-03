
namespace IT_1050_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nabajit";
            char middleInitial = 'A';
            string lastName = "Bhadra";
            string fullName = firstName + middleInitial + "." + lastName;
            int age = 23;
            int heightFeet = 5;
            double heightInches = 10.0;
            double totalInches = ((heightFeet * 12) + heightInches);
            double totalHeightCM = totalInches * 2.54;
            bool isCitizen = false;
            bool canVote = age >= 18 && isCitizen;  

        }
    }
}
