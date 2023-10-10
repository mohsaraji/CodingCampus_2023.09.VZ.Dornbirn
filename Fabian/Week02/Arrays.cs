﻿namespace Fabian.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            //NumberArray();
            int[] originial = { 1, 2, 3, 4 };
            //MakeACopy(originial);
            RandomNumberArray();
        }

        public static void NumberArray()
        {
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            for (int i = 1; i < nums1.Length; i++)
            {
                nums1[i] = i;
                nums2[i] = i;
                Console.WriteLine(nums1[i]);
                Console.WriteLine(nums2[^i]);
            }
            Console.WriteLine();
        }

        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
                Console.WriteLine(copy[i]);
            }
            return copy;
        }

        public static void RandomNumberArray()
        {
            Random rnd = new Random();
            int[] randomNums = new int[10];

            Console.WriteLine("array in foreach loop: ");
            foreach (int i in randomNums)
            {
                randomNums[i] = rnd.Next(100);
                Console.WriteLine(randomNums[i]);
            }
            Console.WriteLine("\narray in for loop: ");
            Console.Write("[");
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(100);
            }
            Console.Write($"{randomNums}]");

            Console.WriteLine($"\n2nd value = {randomNums[1]}");
            Console.WriteLine($"5th value = {randomNums[4]}");
            Console.WriteLine($"10th value = {randomNums[9]}\n");

            Console.WriteLine("every second value: ");
            for (int i = 0; i < randomNums.Length-1; i+=2)
            {
                Console.WriteLine($"{i} = {randomNums[i]}");
            }
        }


 
    }
}
