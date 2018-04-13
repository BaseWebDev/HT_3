using System;
using System.Threading;

namespace HT_3
{
    class Program
    {   
        /// <summary>
        /// Минимальное значение времени отсчета
        /// </summary>
        const int timeMin = 1000;  
        /// <summary>
        /// Максимальное значение времени отсчета
        /// </summary>
        const int timeMax = 3000;
        /// <summary>
        /// Программа теста на реакцию
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\tТест на реакцию");   // \t - табуляция для выделения заголовка
            Console.WriteLine("Введите букву, которую увидите на экране.");
            Console.WriteLine("Жми Enter, чтобы продолжить....");
            Console.ReadLine();
            Random randomAlpha = new Random();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.Write("\t");
            Thread.Sleep(randomAlpha.Next(timeMin, timeMax));
            DateTime timeStart = DateTime.Now;
            char alphaRandom = alpha[randomAlpha.Next(0, alpha.Length)];
            Console.WriteLine(alphaRandom);
            Console.WriteLine();
            Console.Write("\t");
            while (Char.ToUpper((char)Console.ReadKey().KeyChar) != alphaRandom) { }
            Console.WriteLine();
            TimeSpan timeReaction = DateTime.Now - timeStart;
            Console.WriteLine($"Время реакции {timeReaction.TotalSeconds} сек.");
            Console.WriteLine();
        }
    }

}
