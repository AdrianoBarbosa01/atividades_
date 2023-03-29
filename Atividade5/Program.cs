using System;
using System.Collections.Generic;

namespace Temperatura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperatura!");
            Console.Write("Digite uma temperatura em Celsius: ");
            var celsius = float.Parse(Console.ReadLine());

            var fahrenheit = celsius * 1.8f + 32;
            Console.WriteLine("\nConsiderando que F = C * 1.8 + 32:");
            Console.WriteLine($"{celsius.ToString("F1")}ºC = {fahrenheit.ToString("F1")}ºF");
        }
    }
}