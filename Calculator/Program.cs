using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double term1, term2, result=0;
            ConsoleKeyInfo keyPressed;
            do
            {
                WriteLine("----Calculator----");
                WriteLine("Choose method\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nESC. Quit\n");
                keyPressed = ReadKey();
                WriteLine("");
                
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        WriteLine("Enter first number");
                        Double.TryParse(ReadLine(),out term1);
                        WriteLine("Enter second number");
                        Double.TryParse(ReadLine(), out term2);
                        result = Addition(term1, term2);
                        break;

                    case ConsoleKey.D2:
                        WriteLine("Enter first number");
                        Double.TryParse(ReadLine(), out term1);
                        WriteLine("Enter second number");
                        Double.TryParse(ReadLine(), out term2);
                        result = Subtraction(term1, term2);
                        break;

                    case ConsoleKey.D3:
                        WriteLine("Enter first number");
                        Double.TryParse(ReadLine(), out term1);
                        WriteLine("Enter second number");
                        Double.TryParse(ReadLine(), out term2);
                        result = Multiplication(term1, term2);
                        break;

                    case ConsoleKey.D4:
                        WriteLine("Enter first number");
                        Double.TryParse(ReadLine(), out term1);
                        WriteLine("Enter second number");
                        Double.TryParse(ReadLine(), out term2);
                        result = Division(term1, term2);
                        break;

                    
                }

                WriteLine("Result: {0}", result);

            } while (keyPressed.Key!=ConsoleKey.Escape);
        }

        static double Addition(double term1, double term2)
        {
            double returnValue;
            returnValue = term1 + term2;
            return returnValue;
        }

        static double Subtraction(double term1, double term2)
        {
            double returnValue;
            returnValue = term1 - term2;
            return returnValue;
        }

        static double Multiplication(double term1, double term2)
        {
            double returnValue;
            returnValue = term1 * term2;
            return returnValue;
        }

        static double Division(double term1, double term2)
        {
            double returnValue;
            if (term2 == 0)
            {
                WriteLine("Error. Division by zero");
                return 0;
            }
            returnValue = term1 / term2;
            return returnValue;
        }
    }
}
