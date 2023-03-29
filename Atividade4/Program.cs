using System;
using System.Collections.Generic;

namespace NegativoOuPositivo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Número Negativo e Positivo!");
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"O número {numero} é positivo.");
            }
            else if (numero == 0)
            {
                Console.WriteLine($"O número {numero} é igual a zero.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é negativo.");
            }

            Console.WriteLine("Você quer reiniciar o programa? s/n");
            string restart = Console.ReadLine();

            if (restart == "s")
            {
                Console.Clear();
                Console.WriteLine("Reiniciando...");
                Main(args);
            }
            else
            {
                Console.WriteLine("Encerrando o programa...");
            }
        }
    }
}