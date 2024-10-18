using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sugarcat.MathGame
{
    public class Operations
    {
       // create a method to house addition input
       public void AdditionInput()
        {
            // getting input for first number
            Console.WriteLine("Enter a number to be added:");

            string firstnum;
            firstnum = Console.ReadLine();
            int num1 = Int32.Parse(firstnum);

            // getting input for second number
            Console.WriteLine($"Enter another number to be added to {firstnum}:");

            string secondnum;
            secondnum = Console.ReadLine();
            int num2 = Int32.Parse(secondnum);

            // if number1 or number2 is not an integer, repeat the method

            int result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} is {result}");
            Console.ReadLine();
        }

        public void SubtractionInput()
        {
            // getting input for first number
            Console.WriteLine("Enter a number to be subtracted from:");

            string firstnum;
            firstnum = Console.ReadLine();
            int num1 = Int32.Parse(firstnum);

            // getting input for second number
            Console.WriteLine($"Enter a number to subtract from {firstnum}:");

            string secondnum;
            firstnum = Console.ReadLine();
            int num2 = Int32.Parse(firstnum);

            int result = num1 - num2;

            Console.WriteLine($"{num1} + {num2} is {result}");
            Console.ReadLine();
        }

        public void MultiplicationInput()
        {
            // getting input for first number
            Console.WriteLine("Enter a number to be multiplied:");

            string firstnum;
            firstnum = Console.ReadLine();
            int num1 = Int32.Parse(firstnum);

            // getting input for second number
            Console.WriteLine($"Enter a number to be multiplied to {firstnum}:");

            string secondnum;
            firstnum = Console.ReadLine();
            int num2 = Int32.Parse(firstnum);

            int result = num1 * num2;

            Console.WriteLine($"{num1} + {num2} is {result}");
            Console.ReadLine();
        }

        public void DivisionInput()
        {
            // getting input for first number
            Console.WriteLine("Enter a number to be divided from:");

            string firstnum;
            firstnum = Console.ReadLine();
            int num1 = Int32.Parse(firstnum);

            // getting input for second number
            Console.WriteLine($"Enter a number to divide by {firstnum}:");

            string secondnum;
            firstnum = Console.ReadLine();
            int num2 = Int32.Parse(firstnum);

            int result = num1 / num2;

            Console.WriteLine($"{num1} + {num2} is {result}");
            Console.ReadLine();
        }
    }
}
