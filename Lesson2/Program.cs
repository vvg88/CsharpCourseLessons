using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void PrintFibNumLessThenNum(uint number)
        {
            Console.Write("Числа Фибоначчи меньше числа " + number + ": ");
            uint firstFibNum = 0;
            uint secFibNum = 1;
            if (number != 0)
                Console.Write(firstFibNum + " ");

            while (secFibNum < number)
            {
                Console.Write(secFibNum + " ");
                uint next = firstFibNum + secFibNum;
                firstFibNum = secFibNum;
                secFibNum = next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(default(int));

            uint num1, num2, num3;
            if (!Common.Utils.TryEnterNumFromConsole(out num1) ||
                !Common.Utils.TryEnterNumFromConsole(out num2) ||
                !Common.Utils.TryEnterNumFromConsole(out num3))
            {
                Console.Read();
                return;
            }
            
            var min = Math.Min(Math.Min(num1, num2), num3);
            Console.Write("Minimal number: ");
            Console.WriteLine(min);
            
            PrintFibNumLessThenNum(num1);
            PrintFibNumLessThenNum(num2);
            PrintFibNumLessThenNum(num3);
            
            Console.ReadLine();
        }
    }
}
