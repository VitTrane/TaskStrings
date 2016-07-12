using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите HTML текст: ");
                string text = Console.ReadLine();

                string pattern = "(<[^>]+>)";
                string replacement = "_";
                string resultString = Regex.Replace(text, pattern, replacement, RegexOptions.IgnoreCase);
                Console.WriteLine("Результат замены: {0}", resultString);

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
