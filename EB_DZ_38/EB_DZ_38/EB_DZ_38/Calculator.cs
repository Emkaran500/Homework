using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_DZ_38;
public static class Calculator
{
    private static double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    private static double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    private static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    private static double Division(double num1, double num2)
    {
        return num1 / num2;
    }

    public static double Menu()
    {
        char choice = 'c';
        double num1 = default;
        double num2 = default;
        double result = default;



        while (choice < '1' || choice > '5')
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine("\n\n");
        }

        do
        {
            Console.Write("Input the first number: ");
        } while (double.TryParse(Console.ReadLine(), out num1) == false);

        do
        {
            Console.Write("Input the second number: ");
        } while (double.TryParse(Console.ReadLine(), out num2) == false);

        switch (choice)
        {
            case '1':
                result = Addition(num1, num2);
                break;
            case '2':
                result = Subtraction(num1, num2);
                break;
            case '3':
                result = Multiplication(num1, num2);
                break;
            case '4':
                result = Division(num1, num2);
                break;
            case '5':
                Console.WriteLine("Goodbye!");
                System.Environment.Exit(0);
                break;
            default:
                break;
        }

        return result;
    }
}
