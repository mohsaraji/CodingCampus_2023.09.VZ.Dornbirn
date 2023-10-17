﻿using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Transactions;
using Timo.Week01;

namespace Timo.Week03
{
    public class ConsoleInputs
    {
        public static void Start()
        {
            /*
            //Aufgabe1
            Console.WriteLine("Aufgabe1: String einlesen");

            Console.WriteLine("Please enter your String");
            String stringInput = Console.ReadLine();
            Console.WriteLine("The input was : " + stringInput);

            Console.WriteLine("=======================================");


            //Aufgabe2.2 Zahl einlesen
            Console.WriteLine("Aufgabe2: Zahl einlesen");

            int readNumber = ReadNumber("Please enter your number:", "Thats not a number. Please try again:");
            Console.WriteLine("Read number is: " + readNumber);

            Console.WriteLine("=======================================");
            

            //Aufgabe3+4 Ratespiel
            Console.WriteLine("Aufgabe3+4: Ratespiel");
            Guessinggame(0,100, "Ich will nicht mehr");

            Console.WriteLine("=======================================");
            

            //Aufgabe5 Menü
            Console.WriteLine("Aufgabe5: Menü");
            Menue("exit");

            Console.WriteLine("=======================================");
            */

            //Aufgabe6 Taschenrechner
            Console.WriteLine("Aufgabe6: Taschenrechner");
            Calculator();
        }

        //Aufgabe1
        public static string ReadString(String input)
        {
            String myInput = Console.ReadLine();
            return myInput;
        }

        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        //Ergänzung ReadChar
        public static char ReadChar(String prompt, String onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    char myChar = Convert.ToChar(input);
                    return myChar;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------


        //Aufgabe2
        public static int ReadNumber(String prompt, String onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();

                    int myNumber = Convert.ToInt32(input);

                    return myNumber;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe3+4 Ratespiel
        public static void Guessinggame(int startNumber, int endNumber, String exitCode)
        {
            Console.WriteLine("Welcome to the game! Try to guess the correct number: enter a number between {0} and {1}. \nWrite '{2}' to leave the game", startNumber, endNumber, exitCode);
            Random random = new Random();
            int count = 1;
            int i = random.Next(startNumber, endNumber + 1);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    string exit = exitCode;
                    if (input == exit)
                    {
                        Console.WriteLine("Sad to see you going, hope to see you soon :)");
                        return;
                    }
                    int output = Convert.ToInt32(input);
                    if (output == i)
                    {
                        Console.WriteLine("You have won! Number of guesses: " + count);
                        return;
                    }
                    else if (output < i)
                    {
                        Console.WriteLine("Your number is too small, try again");
                    }
                    else if (output > i)
                    {
                        Console.WriteLine("Your number is too big, try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Please choose an integer ");
                }
                count++;
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe5 Menü
        public static void Menue(string exitCode)
        {
            Console.WriteLine("Welcome!");
            while (true)
            {
                Console.WriteLine("What do you want to draw ? \n1) Square \n2) Pyramid \n3) Christmastree \nWhat do you want to choose? ");
                string k = "Please choose an valid integer";
                string o = "What character should be used?";
                string l = "Please choose an valid character";
                try
                {
                    String input = Console.ReadLine();
                    string exit = exitCode;
                    if (input == exit)
                    {
                        Console.WriteLine("Sad to see you going, hope to see you soon :)");
                        return;
                    }
                    int output = Convert.ToInt32(input);
                    if (output == 1)
                    {
                        MethodenUndSchleifen.PrintSquare(ReadChar(o, l), ReadNumber("What should be the size of the square?", k));
                        Console.WriteLine("new?");
                        //ToDo Methode für Retry schreiben
                        int x = 1;
                        while (x == 1)
                        {
                            try
                            {
                                String answerIn = Console.ReadLine();
                                char answer = Convert.ToChar(answerIn);

                                if (answer == 'j')
                                {
                                    Console.WriteLine("haha");
                                    x = 0;
                                }
                                else if (answer == 'n')
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter 'j' or 'n'");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Please enter 'j' or 'n'");
                            }
                        }
                    }
                    else if (output == 2)
                    {
                        MethodenUndSchleifen.PrintPyramid(ReadChar(o, l), ReadNumber("What should be the size of the pyramid?", k));
                    }
                    else if (output == 3)
                    {
                        MethodenUndSchleifen.PrintChristmasTree(ReadChar(o, l), ReadNumber("What should be the size of the christmastree?", k));
                    }
                    else
                    {
                        Console.WriteLine("Please choose an valid integer");
                    }
                }
                catch
                {
                    Console.WriteLine("Please choose an valid integer");
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Taschenrechner
        public static float Calculator()
        {
            bool again = true;
            while (again)
            {
                float result = 0;
                float x1 = ReadNumberFloat("Please enter your first number", "Please enter a valid number");
                char myOperator = ReadOperator("Please enter your operator", "Please enter a valid operator");
                float x2 = ReadNumberFloat("Please enter your second number", "Please enter a valid number");
                if (myOperator == '+')
                {
                    result = x1 + x2;
                }
                else if (myOperator == '-')
                {
                    result = x1 - x2;
                }
                else if (myOperator == '*')
                {
                    result = x1 * x2;
                }
                else if (myOperator == '^')
                {
                    result = x1;
                    for (int i = 0; i < x2 - 1; i++)
                    {
                        result = result * x1;
                    }
                }
                else if (myOperator == '/')
                {
                    if (x2 != 0)
                    {
                        result = x1 / x2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero error");
                    }
                }
                Console.WriteLine(result);
                while (true)
                {
                    Console.WriteLine("Try agin? (j/n)");
                    char ans = Convert.ToChar(Console.ReadLine());

                    if (ans == 'n')
                    {
                        Console.WriteLine("Thank you for using my calculator!");
                        again = false;
                    }
                    else if (ans == 'j')
                    {
                        break;
                    }
                    return result;
                }

            }
                return 0;
        }
        //ReadFloat
        public static float ReadNumberFloat(String prompt, String onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();

                    float myNumber = (float)Convert.ToDouble(input);

                    return myNumber;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
        //ReadOperator
        //Ergänzung ReadChar
        public static char ReadOperator(String prompt, String onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    char myChar = Convert.ToChar(input);
                    if (myChar == '+' || myChar == '-' || myChar == '*' || myChar == '^' || myChar == '/')
                    {
                        return myChar;
                    }
                    else
                    {
                        Console.Error.WriteLine(onError);
                    }
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }
    }
}