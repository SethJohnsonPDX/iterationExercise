using System;
using System.Collections.Generic;

namespace iterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIRST //
            string welcomeMessage = "Welcome to the rapper name builder. Enter a word please!";
            Console.WriteLine(welcomeMessage);

            string[] rapNames = { "Lil' ", "Young ", "A$AP ", "Crunk " };
            string input = Console.ReadLine();

            for (int i = 0; i < rapNames.Length; i++)
            {
                Console.WriteLine(rapNames[i] + input);
                Console.ReadLine();
            }

            // SECOND - Infinite Loop//
            string welcomeMessage = "Welcome to the rapper name builder. Enter a word please!";
            Console.WriteLine(welcomeMessage);

            string[] rapNames = { "Lil' ", "Young ", "A$AP ", "Crunk " };
            string input = Console.ReadLine();

            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine(input);
            }

            // THIRD //
            string welcomeMessage = "Welcome to the rapper name builder. Enter a word please!";
            Console.WriteLine(welcomeMessage);

            string[] rapNames = { "Lil' ", "Young ", "A$AP ", "Crunk " };
            string input = Console.ReadLine();

            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine(input);
                Console.ReadLine();
            }

            // FOURTH //
            string welcomeMessage = "Welcome to the score guesser. Pick a score above 100!";
            Console.WriteLine(welcomeMessage);

            int[] popShotScore = { 102, 136, 178, 197 };
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < popShotScore.Length; i++)
            {
                if (input < popShotScore[i])
                {
                    Console.WriteLine(input + " is less than " + popShotScore[i]);
                }
            }
            Console.ReadLine();

            // FIFTH //
            string welcomeMessage = "Welcome to the score guesser. Pick a score above 100!";
            Console.WriteLine(welcomeMessage);

            int[] popShotScore = { 102, 136, 178, 197 };
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < popShotScore.Length; i++)
            {
                if (input <= popShotScore[i])
                {
                    Console.WriteLine(input + " is less than or equal to " + popShotScore[i]);
                }
            }
            Console.ReadLine();

            // SIXTH & SEVENTH //
            string welcomeMessage = "Welcome to the text guesser. Enter some text to see if it matches!";
            Console.WriteLine(welcomeMessage);

            string[] textOptions = { "word", "seth", "fun", "complete" };
            string input = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < textOptions.Length; i++)
            {
                if (input == textOptions[i])
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Sorry, not a match");
                }
            }
            Console.ReadLine();

            // EIGHTH //
            string welcomeMessage = "Welcome to the text guesser. Enter some text to see if it matches!";
            Console.WriteLine(welcomeMessage);

            string[] textOptions = { "word", "seth", "coding", "running" };
            string input = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < textOptions.Length; i++)
            {
                if (input == textOptions[i])
                {
                    Console.WriteLine(textOptions[i]);
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, not a match");
                }
            }
            Console.ReadLine();

            // NINTH & TENTH //
            string welcomeMessage = "Welcome to the text guesser. Enter some text to see how many matches you get!";
            Console.WriteLine(welcomeMessage);

            string[] textOptions = { "word", "seth", "word", "running" };
            List<int> matches = new List<int>();

            string input = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < textOptions.Length; i++)
            {
                if (input == textOptions[i])
                {
                    Console.WriteLine(i);
                    matches.Add(i);
                }
            }
            //TENTH
            int count = matches.Count;
            if (count == 0)
            {
                Console.WriteLine("No match.");
            }
            Console.ReadLine();


            // ELEVENTH //
            string welcomeMessage = "Welcome to the text guesser. Enter some text to see how many matches you get!";
            Console.WriteLine(welcomeMessage);

            List<string> textOptions = new List<string> { "word", "seth", "word", "running" };
            List<string> matches = new List<string>();

            string input = Convert.ToString(Console.ReadLine());

            foreach (string text in textOptions)
            {
                if (input == text)
                {
                    Console.WriteLine(text);
                    matches.Add(text);
                    Console.ReadLine();
                }
            }
            int count = matches.Count;
            if (count > 1)
            {
                Console.WriteLine(input + " Has already appeared before.");
                Console.ReadLine();
            }


        }
    }
}
