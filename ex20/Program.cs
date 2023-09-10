using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = 30;
            int[] array = new int[sizeOfArray];
            int lastElementOfArray = sizeOfArray - 1;
            int randomMinValue = -100;
            int randomMaxValue = 100;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMinValue, randomMaxValue);
                Console.Write($"{array[i]}|");
            }

            if (sizeOfArray > 1)
            {
                Console.WriteLine("\n");

                if (array[0] > array[1])
                {
                    Console.WriteLine($"Локальный максимум: {array[0]}");
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i > 0 && i < lastElementOfArray)
                    {
                        if (array[i] > array[i - 1] && array[i] > array[i + 1])
                        {
                            Console.WriteLine($"Локальный максимум: {array[i]}");
                        }
                    }
                }

                if (array[lastElementOfArray] > array[lastElementOfArray - 1])
                {
                    Console.WriteLine($"Локальный максимум: {array[lastElementOfArray]}");
                }
            }
            else
            {
                Console.WriteLine($"\nЛокальный максимум: {array[0]}");
            }
        }
    }
}
