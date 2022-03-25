using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result=0;
            
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
                        result = Addition(QueryUser());
                        break;

                    case ConsoleKey.D2:
                        result = Subtraction(QueryUser());
                        break;

                    case ConsoleKey.D3:
                        result = Multiplication(QueryUser());
                        break;

                    case ConsoleKey.D4:
                        result = Division(QueryUser());
                        break;
                }

                WriteLine("Result: {0}", result);

            } while (keyPressed.Key!=ConsoleKey.Escape);
        }

        static double[] QueryUser()
        {
            double[] terms= new double[2];
            do
            {
                WriteLine("Enter first number");
            } while (!Double.TryParse(ReadLine(), out terms[0]));
            do
            {
                WriteLine("Enter second number");
            }
            while(!Double.TryParse(ReadLine(), out terms[1]));
            return terms;
        }

        static double Addition(double[] terms)
        {
            double returnValue;
            returnValue = terms[0] + terms[1];
            return returnValue;
        }

        static double Subtraction(double[] terms)
        {
            double returnValue;
            returnValue = terms[0] - terms[1];
            return returnValue;
        }

        static double Multiplication(double[] terms)
        {
            double returnValue;
            returnValue = terms[0] * terms[1];
            return returnValue;
        }

        static double Division(double[] terms)
        {
            double returnValue;
            if (terms[1] == 0)
            {
                WriteLine("Error. Division by zero");
                return 0;
            }
            returnValue = terms[0] / terms[1];
            return returnValue;
        }
    }
}
