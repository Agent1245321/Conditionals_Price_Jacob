using System;

namespace Conditionals_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we ask the user for a number
            Console.WriteLine("Give Me An Integer");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //then we use a tennerary operator to set the string evod to even or odd via the remaider of the num1 divided by 2
            string evod = (num1 % 2 == 0) ? "even" : "odd";
            
            // Then, we assign a string "pone" to tell if the inputted number is positive or negative
            string pone;
            if (num1 > 0) pone = "possitive";
            else if (num1 == 0) pone = "Zero";
            else pone = "negative";

            //then we print to the console revealing the information
            Console.WriteLine($" The number {num1} is a {pone}, {evod} number");

            //Now we ask for two more intergers from the user
            Console.WriteLine("Now give me two more intergers");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("...");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //Now we check to see the largest number of the three inputs;
            Console.WriteLine(MathF.Max(num1, Math.Max(num2, num3)) + " is the largest number of the three inputs so far.");

            Console.WriteLine("Now give me a Letter based grade for a class");
            char grade = Convert.ToChar(Console.ReadLine());

            string gradeDescriptor;

            switch (grade)
            {
                case 'a':
                    gradeDescriptor = "Amazing";
                    break;
                case 'b':
                    gradeDescriptor = "Very Good";
                    break;
                case 'c':
                    gradeDescriptor = "Average";
                    break;
                case 'd':
                    gradeDescriptor = "Below Average";
                    break;
                case 'f':
                    gradeDescriptor = "Failing";
                    break;
                default:
                    gradeDescriptor = "unacceptable letter";
                    break;   
            }
            Console.WriteLine($"{Char.ToUpper(grade)}, is a/n {gradeDescriptor} grade");

        }
        
    }
}
