using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        private const int N = 100;

        private static string _str = "";
        private static StringBuilder _stringBuilder = new StringBuilder();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Анализ скорости работы классов String и StringBuilder для операции сложения строк");            

            Console.WriteLine("Для сложения 100 раз \"*\" классу String потребовалось: {0} миллисекунд",
                WorkingTimeFunction(AddString));

            Console.WriteLine("Для сложения 100 раз \"*\" классу StringBuilder потребовалось: {0} миллисекунд",
                WorkingTimeFunction(AddStringBuilder));

            Console.ReadLine();
        }

        private static void AddString() 
        {
            for (int i = 0; i < N; i++)
            {
                _str += "*";
            }
        }

        private static void AddStringBuilder() 
        {
            for (int i = 0; i < N; i++)
            {
                _stringBuilder.Append("*");
            }
        }

        private static double WorkingTimeFunction(Action action) 
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            sw.Stop();

            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
