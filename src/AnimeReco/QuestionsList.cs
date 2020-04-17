using System;
using System.Collections.Generic;

namespace AnimeReco
{
    class QuestionsList
    {
        // Contains the full QuestionsList
        List<Question> questions;

        public QuestionsList()
        {
            questions = new List<Question>();
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            questions.Add(new Question(
                "Hi! Are you looking for your first anime? Enter the number you wanna see.",
                new Choice[] 
                {
                    new Choice("[1] Something epic like Avatar: The Last Airbender", 1, 
                        exitMessage: "Fullmetal Alchemist: Brotherhood"),
                    new Choice("[2] Space western (Firefly, Guardians of the Galaxy)", 2,
                        exitMessage: "Cowboy Bebop"),
                    new Choice("[3] Crime drama mindgames with the Grim Reaper", 3,
                        exitMessage: "Death Note"),
                    new Choice("[4] Seen these 3 already (or need something different)", 4,
                        nextQuestion: 1)
                }
            ));

            questions.Add(new Question(
                "Need a good laugh?",
                new Choice[] 
                {
                    new Choice("[1] Popular action comedy (and some drama)", 1, 
                        exitMessage: "Angel Beats!"),
                    new Choice("[2] Popular romance comedy (evolves into drama)", 2,
                        exitMessage: "Toradora!"),
                    new Choice("[3] Popular workplace comedy (no drama!)", 3,
                        exitMessage: "The Devil is a Part-Timer!"),
                    new Choice("[4] Let's stick to the action-adventure", 4,
                        nextQuestion: 2)
                }
            ));
        }

        /* Asks the question and returns either: 
            (a) The ID of the next question to be asked
            (b) -1 if an end state is reached
         */
        public Choice AskQuestion(int questionId)
        {
            return questions[questionId].AskQuestion();
        }
    }
}