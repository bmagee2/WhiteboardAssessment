using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables. One of type int, one of type string, and one of type DateTime.

            int number = 2;

            string name = "linda";

            DateTime currentTime = DateTime.Now;

            // Create a method that subtracts two numbers and returns the value.
            Methods methodOne = new Methods();
            //methodOne.Subtract(22, 11);
            Console.WriteLine("Subtraction Method Result: " + methodOne.Subtract(33, 11));

            Console.WriteLine(); // space

            // Create a method that takes two strings from the user and outputs a string.

            Methods methodTwo = new Methods();
            Console.WriteLine(methodTwo.GetFullName("String Method Result: " + "Linda", "Pepper"));

            Console.WriteLine(); // space

            // Write a switch case that asks the user if they are wearing clothes.
            Console.WriteLine("Switch Case Example: \n" + "Are you wearing clothes?");
            string response = Console.ReadLine();

            switch (response)
            {
                case "no":
                    Console.WriteLine("Please keep your video turned off!");
                    break;
                default:
                    Console.WriteLine("Thank god.");
                    break;

            }

            Console.WriteLine(); // space

            // Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;

            Console.WriteLine("If/Else Example: \n" + "Are you happy? Yes or No.");
            string reply = Console.ReadLine();
            //bool happy = false;

            if (reply == "yes")
            {
                Console.WriteLine("Yay! That's awesome.");
            }
            else
            {
                Console.WriteLine("Let's get some wine.");
            }

            Console.WriteLine(); // space 

            // Write an if, else if, else that asks the user how much money they make a year. 
            //Check ranges between 1,000-10,000,  11,000-50,000, and 51,000-100,000. 
            //Output to the test runner based on each salary range. 
            //Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking.

            Console.WriteLine("If, Else If, Else Example: \n" + "How much $$ do you make in a year? Yes, I know that's a rude question.");
            string salaryInput = Console.ReadLine();
            int salary = Convert.ToInt32(salaryInput);

            if (salary >= 1000 && salary <= 10999)
            {
                Console.WriteLine("Money is money.");
            }

            else if (salary >= 11000 && salary <= 50999)
            {
                Console.WriteLine("That's not great but not bad.");
            }

            else if (salary >= 51000 && salary <= 100000)
            {
                Console.WriteLine("What do you do for a living?");
            }

            else if (salary < 1000)
            {
                Console.WriteLine("I'll buy you a drink.");
            }
            else
            {
                Console.WriteLine("Can I have some money?");
            }



            Console.ReadLine();
        }
    }
}
