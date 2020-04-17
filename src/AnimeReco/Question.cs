using System;
using System.Collections.Generic;

namespace AnimeReco
{
    class Question
    {
        string text;
        public Choice[] Choices { get; set; }

        public Question(string text, Choice[] choices)
        {
            this.text = text;
            this.Choices = choices;
        }

        public Choice AskQuestion()
        {
            // Ask the question
            Console.WriteLine(text);

            // Display each choice
            foreach (Choice choice in Choices)
            {
                Console.WriteLine(choice.Name);
            }
            
            // Get User Input
            var userInput = Console.ReadLine();
            int userResponse = 0;

            try 
            {
                userResponse = Int32.Parse(userInput);
            }
            catch (FormatException)
            {
                if (userInput == "exit")
                {
                    // Return special Choice signalling exit
                    return new Choice("exit", -1, -1);
                }
            }

            // Match user input with question choices
            foreach (Choice choice in Choices)
            {
                if (userResponse == choice.Key)
                {
                    return choice;
                }
            }

            // This is point is reached if the user's input is invalid
            return null;
        }
    }
}