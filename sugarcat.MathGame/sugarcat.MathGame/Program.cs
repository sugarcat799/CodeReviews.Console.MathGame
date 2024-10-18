using System;
using sugarcat.MathGame;

namespace sugarcat.MathGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to sugarcat's Math Game!");
            Console.WriteLine("Hit Enter");
            Console.ReadLine();

            // Create a math game involving the 4 basic arithmetic operations
            // addition, subtraction, multiplication, and division
            Operations operation = new Operations();

            operation.AdditionInput();
            operation.SubtractionInput();
            operation.MultiplicationInput();
            operation.DivisionInput();

            Console.WriteLine("Congrats! You've won!");
            Console.ReadLine();
        }
    }
}
