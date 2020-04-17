using System;

namespace AnimeReco
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The goal is to suggest anime based on user preference
            This program will follow the ultimate anime recommendation flowchart
            I'll accommodate the short version first as an MVP
            One QuestionsList instance for the whole program */
            var questionsList = new QuestionsList();
            // TODO: Rename flow to questions list

            int currentQuestionId = 0;
            // -1 is considered as endState

            Choice userChoice = new Choice("default", 0);

            while (currentQuestionId != -1)
            {
                userChoice = questionsList.AskQuestion(currentQuestionId);
                Console.WriteLine();
                // From user response, determine if an endstate is reached
                if (userChoice == null) continue;

                currentQuestionId = userChoice.NextQuestion;
            }

            // GAME OVER
            Console.WriteLine(userChoice.ExitMessage);
        }
    }
}
