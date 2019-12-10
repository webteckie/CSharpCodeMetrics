using System;
using System.Collections.Generic;
using System.Text;

namespace MaintainabilityIndex
{
    class GoodMaintainabilityIndex
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
                if (i % 2 == 0 && i < 100000)
                    Console.WriteLine($"{i} == small even");
                else if (i % 2 != 0 && i < 100000)
                    Console.WriteLine($"{i}  == small odd");
                if (i % 2 == 0 && i >= 100000)
                    Console.WriteLine($"{i} == large even");
                else if (i % 2 != 0 && i >= 100000)
                    Console.WriteLine($"{i}  == large odd");
            }
        }
    }
}
