using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите строку: ");
                string text = Console.ReadLine();

                string pattern = @"([\w]+[._-]?)*\w+@(\w+[-_]?)+\.[A-Za-z]{2,6}";
                Regex regex = new Regex(pattern);

                Console.WriteLine("Найденные адреса электронной почты:");
                foreach (Match match in regex.Matches(text))
                {
                    Console.WriteLine(match.Value);
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
