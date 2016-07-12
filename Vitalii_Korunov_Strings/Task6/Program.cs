using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите число");
                string text = Console.ReadLine();
                if (Regex.IsMatch(text, @"^(-?\d)\d*$|^(-?\d)\d*\.\d+$")) 
                {
                    Console.WriteLine("Это число в обычной нотации");
                }
                else if (Regex.IsMatch(text, @"(^(-?\d).\d+e-?\d+$)|(^(-?\d).\d+\*-?\d+\^-?\d+$)"))
                {
                    Console.WriteLine("Это число в научной нотации");
                }
                else
                {
                    Console.WriteLine("Это не число");
                }

                Console.WriteLine();
                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    _isRepeat = false;
                Console.WriteLine();
            }
        }
    }
}
