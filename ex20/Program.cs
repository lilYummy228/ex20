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
            int nearbyElement = 1;
            int randomMinValue = -100;
            int randomMaxValue = 101; 
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMinValue, randomMaxValue);
                Console.Write($"{array[i]}|");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0 && i < lastElementOfArray)
                {
                    if (array[i] > array[i - nearbyElement] && array[i] > array[i + nearbyElement])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }
                }
                else if (i == lastElementOfArray)
                {
                    if (array[i] > array[i - nearbyElement])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }
                }
                else if (i == 0)
                {
                    if (array[i] > array[i + nearbyElement])
                    {
                        Console.WriteLine($"Локальный максимум: {array[i]}");
                    }
                }
            }
        }
    }
}
