using System;

namespace AnimeReco
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The goal is to suggest anime based on user preference
            This program will follow the ultimate anime recommendation flowchart
            I'll accommodate the short version first as an MVP */
            bool continueAsking = true;

            while (continueAsking)
            {
                StartRecommender();
                
                Console.Write("\nDo you want to try again [Y/N]? ");
                string response = Console.ReadLine();

                continueAsking = (response.ToUpper() == "Y");

            }
        }

        static void StartRecommender()
        {
            var questionsList = new QuestionsList();
            // TODO: Rename flow to questions list

            int currentQuestionId = 0;
            // -1 is considered as endState

            Choice userChoice = new Choice("default", 0);

            while (currentQuestionId != -1)
            {
                userChoice = questionsList.AskQuestion(currentQuestionId);
                // From user response, determine if an endstate is reached
                if (userChoice == null) continue;

                currentQuestionId = userChoice.NextQuestion;
            }

            // What if I want to try again? TODO: Ask user for retry
            // GAME OVER
            Console.WriteLine(userChoice.ExitMessage);
        } 
    }
}
