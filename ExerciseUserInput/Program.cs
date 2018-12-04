using System;

namespace ExerciseUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);
            Console.WriteLine("Here is your number multiplied by 50!");
            Console.WriteLine(userNum * 50 );
            

            Console.WriteLine("Please Enter Another Number");
            string userNumberTwo = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userNumberTwo);
            Console.WriteLine("Here is your number plus 25!");
            Console.WriteLine(userNum2 + 25);
          
            Console.WriteLine("Please Enter Another Number");
            string userNumberThree = Console.ReadLine();
            double userNum3 = Convert.ToInt32(userNumberThree);
            Console.WriteLine("Here is your number divided by 12.5!");
            Console.WriteLine(userNum3 / 12.5);
            

            Console.WriteLine("Please Enter Another Number. The next step will tell you if your number is greater than 50.");
            string userNumberFour = Console.ReadLine();
            int userNum4 = Convert.ToInt32(userNumberFour);
            bool trueOrFalse = userNum4 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            

            Console.WriteLine("Please Enter Another Number.");
            string userNumberFive = Console.ReadLine();
            int userNum5 = Convert.ToInt32(userNumberFive);
            Console.WriteLine("Here is your number divided by 7");
            Console.WriteLine(userNum5 / 7);
            Console.ReadLine();
            





        }
    }
}
