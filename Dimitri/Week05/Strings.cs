﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Dimitri.Week05
{
    internal class Strings
    {
        public static Random random = new Random();
        public static void Main()
        {
            //string string1 = "Today is " + DateTime.Now.ToString("t") + ".";
            //Console.WriteLine(string1);

            //string sentence = "This sentence has five words.";
            //int startPosition = sentence.IndexOf(" ") + 1;
            //string word2 = sentence.Substring(startPosition,
            //                                  sentence.IndexOf(" ", startPosition) - startPosition);

            //Console.WriteLine("int 1. Summand length: " + sentence.IndexOf(" ", startPosition));
            //Console.WriteLine("second summand length " + startPosition);
            //Console.WriteLine("result length " + (sentence.IndexOf(" ", startPosition) - startPosition));
            //Console.WriteLine("Second word: " + word2);

            //DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            //double temperature = 68.3;
            //string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
            //                              dateAndTime, temperature);
            //Console.WriteLine(result);
            //Console.WriteLine("BubblesortLength asc:");
            //String[] names1 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLength(names1, true);
            //PrintArray(names1, ",");

            //Console.WriteLine("BubblesortLength desc:");
            //String[] names2 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLength(names2, false);
            //PrintArray(names2, ",");

            //Console.WriteLine("BubblesortLex asc:");
            //String[] names3 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLex(names3, true);
            //PrintArray(names3, ",");

            //Console.WriteLine("BubblesortLex desc:");
            //String[] names4 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLex(names4, false);
            //PrintArray(names4, ",");

            //Console.WriteLine("BubblesortLex asc:");
            //String[] names5 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLexIndex(names5, true, 0);
            //PrintArray(names5, ",");

            //Console.WriteLine("BubblesortLex desc:");
            //String[] names6 = new String[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };
            //BubbleSortStringLexIndex(names6, false, 0);
            //PrintArray(names6, ",");

            //string word = Reverse("Nicht");
            //Console.WriteLine(word);

            //string randomWord = Random("Nicht");
            //Console.WriteLine(randomWord);

            ListLetterCount();
        }

        public static string[] BubbleSortStringLength(string[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if ((arr[j].Length > arr[j + 1].Length) == asc)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;

        }
        public static string[] BubbleSortStringLex(string[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0 && asc == true)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j].CompareTo(arr[j + 1]) < 0 && asc == false)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            return arr;
        }

        public static string CharAtIndex(string stringAtIndex, int indexLetter)
        {
            string result = "";

            try
            {
                result = char.ToString(stringAtIndex.ElementAt(indexLetter));
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                return result;
            }


            return result;
        }

        public static string CharAtIndexByGyula(string stringAtIndex, int indexLetter)
        {
            return char.ToString(stringAtIndex[indexLetter]);
        }

        public static string[] BubbleSortStringLexIndex(string[] arr, bool asc, int index)
        {
            // check if index of letter is out of range for string at all indexes
            string check = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (check.CompareTo(CharAtIndex(arr[i], index)) == 0)
                {
                    Console.WriteLine("Index out of range.");
                    Console.WriteLine();
                    return arr;
                }
            }

            //bubblesort with Letter at index

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {


                    if (CharAtIndex(arr[j], index).CompareTo(CharAtIndex(arr[j + 1], index)) > 0 && asc == true)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    if (CharAtIndex(arr[j], index).CompareTo(CharAtIndex(arr[j + 1], index)) < 0 && asc == false)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            return arr;

        }


        public static string[] BubbleSortStringLexIndexByGyula(string[] arr, bool asc, int index)
        {
            //bubblesort with Letter at index

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j+1].Length <= index || (arr[j].Length > index && arr[j][index] > arr[j + 1][index]))
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;

        }


        public static string ReverseOwn(string str)
        {
            char[] charArr = str.ToCharArray();

            string result = "";

            for(int i = charArr.Length - 1; i >= 0; i--)
            {
                result += charArr[i];
            }

            return result;
        }

        public static string Reverse(string str)
        {
            char[] charArr = str.ToCharArray();
            int j = 0;

            for (int i = charArr.Length - 1; i >= charArr.Length/2; i--)
            {
                char tmp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = tmp;
                j++;
            }

            return new string(charArr);
        }

        public static string Random(string str)
        {
            Random random = new Random();

            char[] charArr = str.ToCharArray();

            while (new string(charArr).CompareTo(str) == 0)
            {

                for (int i = charArr.Length - 1; i > charArr.Length; i--)
                {

                    int j = random.Next(charArr.Length);
                    char tmp = charArr[i];
                    charArr[i] = charArr[j];
                    charArr[j] = tmp;
                }
            }

            return new string(charArr);

        }

        public static string RandomByGyula(string str)
        {
            char[] charArr = str.ToCharArray();


                for (int i = 0; i < 3 * charArr.Length; i++)
                {
                    int t1 = random.Next(charArr.Length);
                    int t2 = random.Next(charArr.Length);
                    char tmp = charArr[t1];
                    charArr[t1] = charArr[t2];
                    charArr[t2] = tmp;
                }


            return new string(charArr);

        }


        public static void ListLetterCount()
        {
            int[] arr = new int[char.MaxValue];

            Console.WriteLine(arr.Length);

            Console.WriteLine(Ressources.StringRessources.getText());
        }


    }
}
