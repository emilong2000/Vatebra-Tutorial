using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            Console.WriteLine($"The number is {thirdNumber}");
        */

            /*
            //Get the first number
            Console.WriteLine("Enter a the firstNumber;");
            string firstText = Console.ReadLine();
            int firstNumber = int.Parse(firstText);

            //Get the Second number
            Console.WriteLine("Enter the second number;");
            string secondText = Console.ReadLine();
            int secondNumber = int.Parse(secondText);

            //Add the two numbers together
            int result = 0;

            if(firstNumber > secondNumber)
            {
                result = firstNumber - secondNumber;
            }
            else
            {
                result = secondNumber - firstNumber;
            }
            //Display the Result
           

            switch (firstNumber)
            {
                
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                default: Console.WriteLine("Three and above"); break;
                Console.WriteLine($"The difference is {result}");
                
                case 0:
                case 1:
                    Console.WriteLine("Zero or One");
                    result = 1;
                        break;
                case 2:
                    Console.WriteLine("Two");
                    result = 2;
                    break;
                default:
                    Console.WriteLine("Three and above");
                    result = 3;
                    break;
                
                */
            //write a program that will diplay invalid when the number is greater than zero or less than 10 and will else will display even or odd number.

            Console.WriteLine("Enter a number");
            string myNumber = Console.ReadLine();
            int number = int.Parse(myNumber);

            if (number < 0 || number > 10)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                if (number < 10 && number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            
            }
   
        }
    }
}
