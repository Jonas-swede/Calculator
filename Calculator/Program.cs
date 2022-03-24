using System;

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
                Console.WriteLine("----Calculator----");
                Console.WriteLine("Choose method\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nESC. Quit\n");
                keyPressed = Console.ReadKey();
                Console.WriteLine("");
                
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Enter first number");
                        Double.TryParse(Console.ReadLine(),out term1);
                        Console.WriteLine("Enter second number");
                        Double.TryParse(Console.ReadLine(), out term2);
                        result = Addition(term1, term2);
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Enter first number");
                        Double.TryParse(Console.ReadLine(), out term1);
                        Console.WriteLine("Enter second number");
                        Double.TryParse(Console.ReadLine(), out term2);
                        result = Subtraction(term1, term2);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Enter first number");
                        Double.TryParse(Console.ReadLine(), out term1);
                        Console.WriteLine("Enter second number");
                        Double.TryParse(Console.ReadLine(), out term2);
                        result = Multiplication(term1, term2);
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine("Enter first number");
                        Double.TryParse(Console.ReadLine(), out term1);
                        Console.WriteLine("Enter second number");
                        Double.TryParse(Console.ReadLine(), out term2);
                        result = Division(term1, term2);
                        break;

                    
                }

                Console.WriteLine("Result: {0}", result);

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
                Console.WriteLine("Error. Division by zero");
                return 0;
            }
            returnValue = term1 / term2;
            return returnValue;
        }
    }
}
