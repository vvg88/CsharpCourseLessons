using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Utils
    {
        public static bool TryEnterNumFromConsole(out uint number)
        {
            Console.Write("Введите неотрицательное число: ");
            string numasStr = Console.ReadLine();

            if (!uint.TryParse(numasStr, out number))
            {
                Console.Write("It's not a number!");
                return false;
            }
            return true;
        }
    }
}
