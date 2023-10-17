﻿using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

namespace Niklas.Week03
{
    internal class ArrayNumber
    {
        public static Random random = new Random();
        public static void Start()
        {

            int[] arr1 = CreateArrayRandom(10, 0, 101);
            int[] arr2 = CreateArrayRandom(100, 0, 101);

            Console.WriteLine("\nAscending: ");
            int[] arr = new int[1];
            CreateArrayAsc(arr1);

            Console.WriteLine("\nDescending: ");
            CreateArrayDesc(10);

            Console.WriteLine("\nCopy: ");
            int[] original = CreateArray(10);
            int[] newArray = MakeACopy(original);

            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", newArray));
            PrintArray(original);
            PrintArray(newArray);
            Console.WriteLine("==================================");

            Console.WriteLine("\nRandom Number: ");
            RandomNumber();

            Console.WriteLine("\nSecond, fifth and thenth: ");
            PrintSecondFifthandTenth();

            Console.WriteLine("\nEvery second value: ");
            EverySecondValue();

            /*
            newArray[0] = -10;
            PrintArray(original);
            PrintArray(newArray);
            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", newArray));

            Console.WriteLine("=================================");
            Console.WriteLine("[{0}]", string.Join(", ", original));
            PrintArray(original); */

            Console.WriteLine("\nRandom Crazy Number: ");
            CrazyRandomNumber();

            Console.WriteLine("......................");
            int treshhold = 30;
            int cnt = countBiggerThen(original, treshhold);
            Console.WriteLine("Count bigger then {0}: {1}", treshhold, cnt);

            Console.WriteLine("[{0}]", string.Join(", ", arr1));

            Console.WriteLine("______________________");
            Console.WriteLine("Summe: {0,4}", ArraySumme(arr1));

            Console.WriteLine("______________________");
            Console.WriteLine("Average: {0,4}", ArrayAvg(arr1));
            Console.WriteLine("Min: {0,4}", ArrayMin(arr1));
            Console.WriteLine("Max: {0,4}", ArrayMax(arr1));

            Console.WriteLine("______________________");
            Console.WriteLine("Unsorted: [{0}]", string.Join(", ", arr1));
            BubbleSortAsc(arr1);
            Console.WriteLine("Bubblesort Ascending: " + string.Join(", ", arr1));
            BubbleSortDesc(arr1);
            Console.WriteLine("Bubblesort Descending: " + string.Join(", ", arr1));

            Console.WriteLine("______________________");
            TwoDArray(arr2);

        }



        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[i]);
            }
            Console.WriteLine("]");
        }

        public static int[] CreateArrayAsc(int[] size)
        {
            int[] myArray = CountUp(10);

            Console.WriteLine("[{0}]", string.Join(", ", myArray));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return arr;
        }

        public static int[] CreateArrayDesc(int size)
        {
            int[] myArray = CountDown(10);

            Console.WriteLine("[{0}]", string.Join(", ", myArray));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            return arr;
        }

        public static int[] MakeACopy(int[] arr)
        {
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                copy[i] = arr[i];
            }
            return copy;
        }


        public static void RandomNumber()
        {
            int[] myArray = CreateArray(10);

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value);
            }


            Console.WriteLine("[{0}]", string.Join(", ", myArray));
        }

        public static void PrintSecondFifthandTenth()
        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = PrintXth(11);

            for (int i = 1; i <= fixArray.Length; i++)
            {
                if (i == 2 || i == 5 || i == 10)
                {
                    Console.WriteLine(i + " = " + "[{0}]", string.Join(", ", myArray[i]));
                }
            }

        }

        public static void EverySecondValue()
        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = CreateArrayTwo(11);

            for (int i = 2; i <= fixArray.Length; i += 2)
            {
                Console.WriteLine(i + " = " + "[{0}]", string.Join(", ", myArray[i]));
            }


        }

        public static void CrazyRandomNumber()
        {
            int[] myArray = CreateArray(10);

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value - 50);
            }
        }


        public static int countBiggerThen(int[] arr, int value)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if (x > value)
                {
                    ++count;
                }
            }
            return count;
        }

        public static int ArraySumme(int[] arr)
        {
            int sum = 0;
            foreach (int value in arr)
            {
                sum += value;
            }
            return sum;
        }

        public static double ArrayAvg(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                return ArraySumme(arr) / (double)arr.Length;
            }
        }

        public static double ArrayMin(int[] arr)
        {
            int min = Int32.MaxValue;

            foreach (int value in arr)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        public static double ArrayMax(int[] arr)
        {
            int max = Int32.MinValue;

            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public static int[] BubbleSortAsc(int[] arr)
        {
            int steps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    steps++;
                }
            }
            Console.WriteLine("Size: " + arr.Length + " Steps: " + steps);
            return arr;

        }

        public static int[] BubbleSortDesc(int[] arr)
        {
            int steps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    steps++;
                }
            }
            Console.WriteLine("Size: " + arr.Length + " Steps: " + steps);
            return arr;

        }

        public static void TwoDArray(int[] size)
        {
            int[] arr = new int[100];
            int sum = 0;
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int randomNumber = random.Next(10, 100);
                arr[i] = randomNumber;

                sum = 0;
                foreach (int value in arr)
                {
                    sum += value;
                }
            }

            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i % 10 == 0 && i > 0)
                {
                    Console.WriteLine(" | Summe = " + sum);
                }
                Console.Write(arr[i] + " ");
            }
            sum = 0;
        }

        //===================================================================================================================================================================\\

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            return arr;
        }



        public static int[] CountUp(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                {
                    arr[i] = i + 1;
                }
            }
            return arr;
        }

        public static int[] CountDown(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                {
                    arr[i] = size - i;
                }
            }

            return arr;
        }

        public static int[] PrintXth(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = random.Next(100);

            }
            return arr;
        }

        public static int[] CreateArrayTwo(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = random.Next(100);

            }

            return arr;
        }

        public static int[] CreateArrayRandom(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
            return arr;
        }
    }

}