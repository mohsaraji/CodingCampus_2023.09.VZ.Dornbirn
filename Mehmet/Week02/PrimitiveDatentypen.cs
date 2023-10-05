﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week02
{
    internal class PrimitiveDatentypen
    {

        public static void start()
        {
            int result = Add(20, 50);
            Console.WriteLine("i = " + result);
            Console.WriteLine("--------------------------");

            long result2 = Add2(1, 20);
            Console.WriteLine("--------------------------");

            double result3 = Add3(1000);
            Console.WriteLine("--------------------------");

            float result4 = Add4(1000);
            Console.WriteLine("--------------------------");

            int result5 = Add5(20);
            Console.WriteLine("--------------------------");

            double result6 = Add6();
            Console.WriteLine("--------------------------");


        }


        public static int Add(int x, int y)
        {
            int result = 0;
            for (int i = x; i <= y; i++)
            {
                result += i;
            }
            return result;
        }


        public static long Add2(int x, int y)

        {

            long result2 = x;

            for (long i = result2; i <= y; i++)
            {
                result2 *= i;
                Console.Write($"{i,2}" + "! = ");
                Console.Write($"{result2,20}");
                Console.WriteLine();
            }
            return result2;
        }

        public static double Add3(int x)
        {

            double result3 = x;

            for (double y = 0; y <= x; y++)
            {
                result3 = y;

                Console.WriteLine(result3 / 10);
            }

            return result3;
        }

        public static float Add4(float x)
        {

            float result4 = 0;
            Console.WriteLine($"{result4,-3:0.00}");
            for (float y = 0; y < x; y++)
            {
                result4 += x;
                Console.WriteLine($"{result4 / x / 10,-3:0.00}");
            }
            return result4;
        }

        public static int Add5(int y)
        {
            int result5 = 5;
            double n2 = 5;
            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine($"{i}" + " / " + $"{result5}" + " = " + i / result5);
                Console.WriteLine($"{i}" + " / " + $"{n2,-3:0.0}" + " = " + $"{i / n2,2:0.0}");
            }
            return result5;
        }

        public static double Add6()
        {
            //double: 3,1415926535895253
            //        3.14159265358979323846
            //long:   3,1415926535977925

            double x = 2;
            double z = 3;
            for (int y = 0; y < 100000000; y++)
            {

                double g = 4.0 / (x * (x + 1) * (x + 2));
                if (y % 1000000 == 0)
                {
                    Console.WriteLine(x * (x + 1) * (x + 2));
                }
                x++;
                x++;
                double h = 4.0 / (x * (x + 1) * (x + 2));
                x++;
                x++;

                z = z + (g - h);
            }

            Console.WriteLine(z);
            return z;

        }

        
    }
}