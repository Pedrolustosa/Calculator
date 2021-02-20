using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtration();
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Bem-Vindo");
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
        }

        static void Subtration()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
    }
}
