using System;
using System.Threading;

namespace HT_3
{
    class Program
    {
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
            Thread.Sleep(randomAlpha.Next(1000,3000));
            DateTime timeStart = DateTime.Now;
            char alphaRandom = alpha[randomAlpha.Next(0, alpha.Length)];
            Console.WriteLine(alphaRandom);
            Console.WriteLine();
            while ((char)Console.ReadKey().KeyChar != alphaRandom) { }
            Console.WriteLine();
            TimeSpan timeReaction = DateTime.Now - timeStart;
            Console.WriteLine($"Время реакции {timeReaction.TotalSeconds} сек.");
            Console.WriteLine();
        }
    }

}
