using System;
using System.Threading;

namespace HT_3
{
    class Reaction
    {
        /// <summary>
        /// Минимальное значение времени отсчета
        /// </summary>
        private const int timeMin = 1000;
        /// <summary>
        /// Максимальное значение времени отсчета
        /// </summary>
        private const int timeMax = 3000;

        private Random randomAlpha;
        /// <summary>
        /// Клавиши ввода
        /// </summary>
        public char[] Alpha { get; set; }
        /// <summary>
        /// Время реакции
        /// </summary>
        public TimeSpan TimeReaction { get; private set; }
        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public Reaction():this("ABCDEFGHIJKLMNOPQRSTUVWXYZ") {           
        }
        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        /// <param name="alphabet">Алфавит для теста</param>
        public Reaction(string alphabet) {
            randomAlpha = new Random();
            Alpha = alphabet.ToCharArray();
        }
        /// <summary>
        /// Запускаем тест на рекцию
        /// </summary>
        public void StartTestReaction() {
            Console.WriteLine("\tТест на реакцию");   // \t - табуляция для выделения заголовка
            Console.WriteLine("Введите букву, которую увидите на экране.");
            Console.WriteLine("Жми Enter, чтобы продолжить....");
            Console.ReadLine();
            Console.Write("\t");
            Thread.Sleep(randomAlpha.Next(timeMin, timeMax));
            DateTime timeStart = DateTime.Now;
            char alphaRandom = Alpha[randomAlpha.Next(0, Alpha.Length)];
            Console.WriteLine(alphaRandom);
            Console.WriteLine();
            Console.Write("\t");
            while (Char.ToUpper(Console.ReadKey().KeyChar) != alphaRandom) { }
            Console.WriteLine(); 
            TimeReaction = DateTime.Now - timeStart;
            Console.WriteLine($"Время реакции {TimeReaction.TotalSeconds} сек.");
            Console.WriteLine();
        }
    }
}