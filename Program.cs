using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
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
        }
    }
}
