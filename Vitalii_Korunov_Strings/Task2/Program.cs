using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static bool _isRepeat = true;

        static void Main(string[] args)
        {
            while (_isRepeat)
            {
                Console.WriteLine("Введите первую строку:");
                string firstString = Console.ReadLine();

                Console.WriteLine("Введите вторую строку:");
                string secondString = Console.ReadLine();

                string resultString = DoubleCharInString(firstString, secondString);
                Console.WriteLine("Результирующая строка: {0}", resultString);


                Console.WriteLine();
                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    _isRepeat = false;
                Console.WriteLine();
            }            

        }

        /// <summary>
        /// Удваивает символы в строке, которые присутствуют во второй строке
        /// </summary>
        /// <param name="firstString">Строка, в которой следует удвоить символы</param>
        /// <param name="secondString">Строка, из которой беруться символы</param>
        private static string DoubleCharInString(string firstString, string secondString) 
        {
            StringBuilder resultString = new StringBuilder();
            foreach (char ch in firstString)
            {
                if (secondString.Contains(ch))
                {
                    resultString.Append(ch, 2);
                }
                else
                {
                    resultString.Append(ch);
                }
            }

            return resultString.ToString();
        }
    }
}
