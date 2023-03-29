using System;
using System.Collections.Generic;

namespace ListaNumeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Números");
            Console.WriteLine("Digite uma sequência de números separadas por ', ': ");
            string[] numeros_str = Console.ReadLine().Split(", ");
            int[] numeros = new int[numeros_str.Length];

            for (int i = 0; i < numeros_str.Length; ++i)
            {
                numeros[i] = int.Parse(numeros_str[i]);
            }

            int avg = GetAverage(numeros);
            Console.WriteLine($"O valor médio desses números é {avg}");

            int max = GetMaxNumber(numeros);
            Console.WriteLine($"O valor máximo desses números é {max}");

            int min = GetMinNumber(numeros);
            Console.WriteLine($"O valor mínimo desses números é {min}");
        }
        public static int GetMaxNumber(int[] array)
        {
            int max = int.MinValue;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        public static int GetMinNumber(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
        public static int GetAverage(int[] array)
        {
            int avg = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                avg += array[i];
            }
            avg /= array.Length;

            return avg;
        }
    }
}