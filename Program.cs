using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome the Simple Calculator");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Sbration");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("0 - Exit calculator");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Choose a mathematical operation");
            short res = short.Parse(Console.ReadLine());
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"The result of the sum is: {resultado}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
        }
        static void Subtration()
        {
            Console.Clear();

            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"The result of the subtration is: {resultado}");
            Console.ReadKey();
        }
        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"The result of the division is: {resultado}");
            Console.ReadKey();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"The result of the multiplication is: { resultado}");
            Console.ReadKey();

        }

    }
}
