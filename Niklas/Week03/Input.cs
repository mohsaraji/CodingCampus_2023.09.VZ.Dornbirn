﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Niklas.Week03
{
    internal class Input
    {
        public static void Start()
        {
            int readString = StringEinlesen("Please enter your a Number: ");

            int readNumber = ZahlEinlesen("Please enter a number: ", "That's not a number! Try again: ");
            Console.WriteLine("Your number is: " + readNumber);

            RateSpiel();

            int max = RateSpielCustom(Convert.ToInt32("How large do you want the number to be?"));

        }

        static int StringEinlesen(string input)
        {
            Console.WriteLine(input);

            input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            return number;
        }





        static int ZahlEinlesen(string promt, string error)
        {
            Console.WriteLine(promt);

            while (true)
            {
                try
                {
                    string input2 = Console.ReadLine();
                    int number = Convert.ToInt32(input2);
                    return number;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(error);
                }
            }
        }

        static void RateSpiel()
        {
            Random rand = new Random();
            int min = 0;
            int max = 100;
            int guess;
            int number;
            string response;

            guess = 0;
            response = "";
            number = rand.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                if (guess > number && guess < max)
                {
                    Console.WriteLine("Your number is too big!");
                }
                if (guess < number && guess > min)
                {
                    Console.WriteLine("Your number is too low!");
                }
                if (guess == number)
                {
                    Console.WriteLine("You have won! The number was: " + number);
                }
                else if (guess < min || guess > max)
                {
                    Console.WriteLine(guess + " is not a valid number!");
                }
            }


        }

        static int RateSpielCustom(int max)
        {

            Random rand = new Random();
            int min = 0;
            max = Convert.ToInt32(Console.ReadLine());
            int guess;
            int number;
            string response;

            guess = 0;
            response = "";
            number = rand.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                if (guess > number && guess <= max)
                {
                    Console.WriteLine("Your number is too big!");
                }
                if (guess < number && guess >= min)
                {
                    Console.WriteLine("Your number is too low!");
                }
                if (guess == number)
                {
                    Console.WriteLine("You have won! The number was: " + number);
                }
                else if (guess < min || guess > max)
                {
                    Console.WriteLine(guess + " is not a valid number!");
                }
            }
            return number;
        }
    }
}