﻿namespace Fabian.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSum(20, 50);
            Console.WriteLine();
            PrintFactorial(1, 20);
            Console.WriteLine();
            //PrintDecimalNums(0, 100);
            Console.WriteLine();
            PrintDivideAndConquer();
            Console.WriteLine();
            PrintCalculatePiLeibniz();
            Console.WriteLine();
            //PrintCalculatePiNilakantha();
            Console.WriteLine();
            //PrintSecretRow();
        }

        public static void PrintSum(int minNum, int maxNum)
        {
            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($" {i} + {i} = {i + i}");
            }
        }

        public static void PrintFactorial(int minNum, int maxNum)
        {
            long fac = 1;
            for (int i = minNum; i <= maxNum; i++)
            {
                fac *= i;

                Console.WriteLine($"{i,2}! = {fac,20}");

            }
        }

        public static void PrintDecimalNums(float minNum, float maxNum)
        {
            for (float i = minNum; i <= maxNum; i += 0.1f)
            {

                Console.WriteLine($"Result 1 digit = {i,-3:N1}");
                Console.WriteLine($"Result 2 digit = {i,9:N2}");
            }
        }

        public static void PrintDivideAndConquer()
        {
            for (double x = 0; x <= 20; x++)
            {
                Console.WriteLine($"{x,2} / 5 = {x / 5, 5}");
                Console.WriteLine($"{x,2} / 5.0 = {x / 5.0, 3}");
            }
        }


        public static void PrintCalculatePiLeibniz()
        {
            double pi = 0;

            for (double i = 1; i <= 1000000; i += 4)
            {
                pi += 4 / i;
                Console.WriteLine($"pi = {pi}");
            }

            for (double j = 3; j <= 1000000; j += 4)
            {
                pi -= 4 / j;
                Console.WriteLine($"pi = {pi}");
            }


        }

        public static void PrintCalculatePiNilakantha()
        {
            double pi = 3;

            for (double i = 2; i <= 100; i += 4)
            {
                pi += 4 / (i * (i + 1) * (i + 2));
                Console.WriteLine($"pi = {pi}");
            }

            for (double j = 4; j <= 100; j += 4)
            {
                pi -= 4 / (j * (j + 1) * (j + 2));
                Console.WriteLine($"pi = {pi}");
            }
        }

        public static void PrintSecretRow()
        {
            double value = 1;

            for(double i = 0; i < 10000; i++)
            {
                value = value / 2 + 1 / value;
                Console.WriteLine($"{value}");
            }

        }

    }
}
