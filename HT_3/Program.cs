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
            Reaction NewTest = new Reaction();
            NewTest.StartTestReaction();
        }
    }

}
