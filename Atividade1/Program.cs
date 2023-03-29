using System;
using System.Collections.Generic;

namespace ImpostoRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular Imposto de Renda!");
            Console.Write("Digite o seu salário:");
            var salario = float.Parse(Console.ReadLine());
            float imposto;

            if (salario <= 1903.98f)
            {
                Console.WriteLine("Você está isento do imposto de renda!");
            }
            else
            {
                if (salario > 4644.68f)
                {
                    imposto = salario * .275f;
                }
                else if (salario >= 3751.06f)
                {
                    imposto = salario * .225f;
                }
                else if (salario >= 2826.66f)
                {
                    imposto = salario * .15f;
                }
                else
                {
                    imposto = salario * .075f;
                }

                Console.WriteLine($"Como o seu salário é de {salario.ToString("F2")} seu imposto de renda é de {imposto.ToString("F2")}");
            }
        }
    }
}