﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week03
{
    public class rehearsal
    {

        public static void Start()
        {


            Console.WriteLine("Orginal");
            int[] orginal = Array(10);

            Console.WriteLine("[{0}]", string.Join(", ", orginal));

            Console.WriteLine();
            Console.WriteLine("=========");
            Console.WriteLine("Copy");
            int[] copy = MakeACopy(orginal);

            Console.WriteLine("[{0}]", string.Join(", ", copy));


            Console.WriteLine();
            Console.WriteLine("=============");
            Console.WriteLine("Änderung orginal");
            orginal[3] = 200;
            Console.WriteLine("[{0}]", string.Join(", ", orginal));
            Console.WriteLine();
            Console.WriteLine("Änderung Copy");

            Console.WriteLine("[{0}]", string.Join(", ", copy));
            Console.WriteLine();

           

            int[] array = Array(31);
            int[] array2 = Array(49);
            int[] array3 = Array(3);
            int[] array4 = Array(51);
            int[] array5 = Array(41);



        }

        public static int[] Array(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
            
        }

        public static int[] MakeACopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for (int i = 0;i < orginal.Length;i++)
            {
                copy[i] = orginal[i];
            }
            return copy;

        }


    }
}