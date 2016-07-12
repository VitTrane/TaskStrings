using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static char[] SEPARATORS = {' ', '.', ',', ';', ':', '!', '?' };
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите строку: ");
                string text = Console.ReadLine();

                Console.WriteLine("Средняя длина слова: {0}", AverageWordLegthInText(text));

                Console.WriteLine();
                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    _isRepeat = false;
                Console.WriteLine();
            }            
        }

        private static int AverageWordLegthInText(string text) 
        {
            string[] words = text.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries);
            int average = (int)words.Average(word => word.Length);
            return average;
        }
    }
}
