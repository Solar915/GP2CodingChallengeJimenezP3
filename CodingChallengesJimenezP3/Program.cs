using System;
using System.Security.Cryptography.X509Certificates;
class Challenges
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. Please pick one");

        //Console.WriteLine("Today we are going to use this number added called SUM. Please input two numbers for us to add.");

        //var number1 = Console.ReadLine();
        //int number1int = int.Parse(number1);

        //Console.WriteLine("Awesome Please input a 2nd number");

        //var number2 = Console.ReadLine();
        //int number2int = int.Parse(number2);

        //Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal is: " + Sum(number1int, number2int());

        //Console.WriteLine("Lets try converting minutes into seconds.\ngive me a number to convert from minutes to second");

        //var number3 = Console.ReadLine();
        //int number3int = int.Parse(number3);

        //Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int) + " seconds");

        //Console.WriteLine("Let's try adding 1 to a number. Go ahead and pick any number you want");

        //var number4 = Console.ReadLine();
        //var number4int = int.Parse(number4);
        
        //Console.WriteLine(number4 + " + 1 is " + 5);

        //Console.WriteLine("Today we are going to take voltage and current and return it's calculated power");

        //var voltage = Console.ReadLine();
        //var voltageint = int.Parse(voltage);

        //Console.WriteLine("Now give me a number for the current");

        //var current = Console.ReadLine();
        //var currentint = int.Parse(current);

        //Console.WriteLine("the voltage of " + voltageint + " +currentint+ we can calculate the power which is +Circuit(voltageint * currentint");


      //Console.WriteLine("Today we are going to take a number in years and return it into days");

      //var ageYrs = Console.ReadLine();
      //int ageint = int.Parse(ageYrs);

      //Console.WriteLine("if you are now " + ageYrs + " then you would be " + Aged(ageint) + " days old");


      //Console.WriteLine("Today we are going to take a number as it's only argument and return true if it's less or equal to zero, if it's not then return false");

      //var returnTrue = Console.ReadLine();

        Console.WriteLine("Today we are going to make the challenges selectable by you, choose which function you want to run")
        bool running = true;

        while (running)
        {
            Console.WriteLine("/nPlease choose which function you want to use:");
            Console.WriteLine("1. Sum of two numbers");
            Console.WriteLine("2. Convert minutes into seconds");
            Console.WriteLine("3. Adding 1 to a number");
            Console.WriteLine("4. Calculate the circuit power");
            Console.WriteLine("5. Calculate your age in days");
            Console.WriteLine("6. Calculate the area of a triangle");
            Console.WriteLine("7. Check if a number is either negative or positive");

        }


        Console.WriteLine("Today we will give two numbers and return true if both numbers are less than 100 and return false if it is more than 100");



        //public static int Sum(int number1, int number2)
        {
            //return number1 + number2;
            // }
            // }

        }


    }

    public static int Convert(int number)
    {
        return number * 60;

    }

    public static int Aged(int number)
    {
        return number * 365;
    }
}
      



