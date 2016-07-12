using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
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

                string pattern = @"\b(0*[0-9]|1[0-9]|2[0-3])(:[0-5][0-9])\b";
                Regex regex = new Regex(pattern);
                Console.WriteLine("Время в тексте присутствует {0} раз(а)", regex.Matches(text).Count);

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
