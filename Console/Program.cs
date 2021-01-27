using System;

namespace ConsoleUI
{

    //  Sherlock and The Beast  -- HackerRank
    class Program
    {
        static void Main(string[] args)
        {

            DecentNumber(1); // -1
            DecentNumber(3); // 555
            DecentNumber(5); // 33333
            DecentNumber(11); // 55555533333
            DecentNumber(2); // -1
            DecentNumber(15); // 555555555555555
            DecentNumber(13); // 5553333333333

            Console.ReadKey();
        }
        public static void DecentNumber(int n)
        {
            int fivesNumber = 0;
            int i = n;
            while (i > 0)
            {
                if (i % 3 == 0)
                {
                    fivesNumber = i;
                    break;
                }
                i--;
            }
           
            int threesNumber = n - fivesNumber;
            while (threesNumber % 5 != 0 && fivesNumber > 0)
            {
                threesNumber += 3;
                fivesNumber -= 3;
            }
            if (fivesNumber % 3 == 0 && threesNumber % 5 == 0)
            {
                Console.WriteLine($"{new string('5', fivesNumber)}{new string('3', threesNumber)}");
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
