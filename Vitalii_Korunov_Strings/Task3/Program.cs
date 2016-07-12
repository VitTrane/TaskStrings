using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите текст, содержащий дату в формате dd-mm-yyyy:");
                string text = Console.ReadLine();

                string pattern = @"(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[012])-(19|20)\d\d";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(text))
                    Console.WriteLine("В тексте \"{0}\" содержиться дата", text);
                else
                    Console.WriteLine("В тексте даты нету");

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
