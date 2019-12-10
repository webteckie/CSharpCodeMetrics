using System;
using System.Collections.Generic;
using System.Text;

namespace MaintainabilityIndex
{
    class BetterMaintainabilityIndex
    {
        public void Test()
        {
            Console.WriteLine("Hello World!");

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();

            ShowOddEven();
        }

        private static void ShowOddEven()
        {
            for (var i = 0; i < 1000000; i++)
            {
                ShowIfSmallOddEven(i);
                ShowIfLargeOddEven(i);
            }
        }

        private static void ShowIfLargeOddEven(int i)
        {
            ShowIfLargeEven(i);
            ShowIfLargeOdd(i);
        }

        private static void ShowIfSmallOddEven(int i)
        {
            ShowIfSmallEven(i);
            ShowIfSmallOdd(i);
        }

        private static void ShowIfLargeOdd(int i)
        {
            if (i % 2 != 0 && i >= 100000)
                Console.WriteLine($"{i}  == large odd");
        }

        private static void ShowIfLargeEven(int i)
        {
            if (i % 2 == 0 && i >= 100000)
                Console.WriteLine($"{i} == large even");
        }

        private static void ShowIfSmallOdd(int i)
        {
            if (i % 2 != 0 && i < 100000)
                Console.WriteLine($"{i}  == small odd");
        }

        private static void ShowIfSmallEven(int i)
        {
            if (i % 2 == 0 && i < 100000)
                Console.WriteLine($"{i} == small even");
        }
    }
}
