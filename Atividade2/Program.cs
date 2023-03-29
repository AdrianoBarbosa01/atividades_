using System;
using System.Collections.Generic;

namespace DolarReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter Dolár em Real");
            Console.Write("Digite um valor em reais: ");
            var real = float.Parse(Console.ReadLine());

            var dolar = real / 5.22f;

            Console.WriteLine("\nConsiderando que $1.00 = R$5.22");
            Console.WriteLine($"R${real.ToString("F2")} = ${dolar.ToString("F2")}");
        }
    }
}