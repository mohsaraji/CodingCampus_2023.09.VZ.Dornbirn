﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {/*
            PrintSumme(20);
            Console.WriteLine();

            Console.WriteLine("\nFaktorial: ");
            PrintFaktorial(1);
            Console.WriteLine();

            Console.WriteLine("\nCount: ");
            Count(0);
            Console.WriteLine();

            Console.WriteLine("\nCount2: ");
            Count2(0, 0);
            Console.WriteLine();

            Console.WriteLine("\nTeilen und Herrschen: ");
            Teilen(0);
            Console.WriteLine(); */

            Console.WriteLine("\nPi: ");
            Pi();
            Console.WriteLine();

            Console.WriteLine("\nPi2: ");
            Pi2();
            Console.WriteLine();

        }

        static void PrintSumme(int times)
        {
            int rows = 20;
            int times2 = 21;
            while (rows <= 50)
            {
                Console.WriteLine("Summe = " + (times + times2));
                times += times2;
                times2++;
                if (times % 2 != 0)
                {
                    Console.Write("");
                }
                else { }
                rows++;
            }
        }
        static void PrintFaktorial(long times)
        {
            long rows = 1;
            long times2 = 1;
            while (rows <= 20)
            {
                if (rows == 2 && times == 1)
                {
                    Console.Write("");
                    times++;
                }
                else
                {
                    Console.Write($"{rows,2}! = ");
                    Console.WriteLine($"{times,20}");
                    times *= times2;
                    times2++;
                    if (times % 2 != 0)
                    {
                        Console.Write("");
                    }
                    else { }
                    rows++;
                }
            }

        }
        static void Count(double times)
        {
            times = 0;
            Console.WriteLine($"number = {times / 10.0:N1} ");

            for (int i = 0; i < 1000; i++)
            {
                times = times + 10.0;
                Console.WriteLine($"number = {times / 100.0:N1} ");
            }
        }
        static void Count2(double times, double times2)
        {
            times = 0;
            Console.WriteLine($"result 1 digit = {times / 10.0:N1} ");

            times = 0;
            Console.WriteLine($"result 2 digit = {times2 / 100.0,10:N1}0");

            for (int i = 0; i < 1000; i++)
            {
                times = times + 10.0;
                Console.WriteLine($"result 1 digit = {times / 100.0:N1} ");

                times2 = times2 + 100.0;
                Console.WriteLine($"result 2 digit = {times2 / 1000.00,10:N2} ");
            }
        }

        static void Teilen(double times)
        {

            for (int rows = 0; rows <= 20; rows++)
            {
                Console.Write($"{rows,2} / 5   = {times / 5,1:N1}");
                Console.WriteLine();
                Console.Write($"{rows,2} / 5.0 = {times / 5:N2} ");
                Console.WriteLine();
                times++;
            }
        }

        static void Pi()
        {
            double result = 0;
            for (long index = 1; index < 500000000; index += 4)
            {

                result += (4.0 / index);
                result -= (4.0 / (index + 2));

            }

            Console.WriteLine(result);

        }
        static void Pi2()
        {
            double result = 3;
            for (double index = 2 * 3 * 4; index < 500000000;index += 1)
            {

                result += (4.0 / index);
                result -= (4.0 / (index + 1));

            }

            Console.WriteLine(result);

        }

    }
}
