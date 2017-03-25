using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint arrLength;
            if (!Utils.TryEnterNumFromConsole(out arrLength))
            {
                Console.Read();
                return;
            }

            double[] array = new double[arrLength];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 100;
            }

            PrintDoubleArray(array);

            for (int j = array.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        double tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }

            PrintDoubleArray(array);

            Console.ReadLine();
        }

        static void PrintDoubleArray(double[] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.Write(arrayForPrint[i].ToString("0.00") + " ");
            }
            Console.Write('\n');
        }
    }
}
