using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome the Simple Calculator");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtration");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Choose a mathematical operation");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtration();
                    break;
                case 3:
                    Division();
                    break;
                case 4:
                    Multiplication();
                    break;
                default:
                    Menu();
                    break;
            }
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();

        }

    }
}
