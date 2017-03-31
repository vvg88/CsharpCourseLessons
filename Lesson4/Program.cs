using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string str = Console.ReadLine();

            StringHelper strHelper = new StringHelper(str);
            //strHelper.InputString = str;

            Console.WriteLine(strHelper.IsPolyndrome() ? "Является палиндромом" : "Не является палиндромом");
            Console.WriteLine(string.Format("Количество слов: {0}", strHelper.GetCountWords()));
            Console.WriteLine($"Перевернутая строка: {strHelper.GetInverseString()}");

            Console.ReadLine();
            /*try
            {
                Array a;
                int[,] intArr = new int[3, 3];
                a = intArr;
                (a as IList)[0] = 1000;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.ReadLine();
            }*/
        }
    }
    
}
