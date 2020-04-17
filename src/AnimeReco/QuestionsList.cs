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

            questions.Add(new Question(
                "Something dark and serious, then?",
                new Choice[]
                {
                    new Choice("[1] Psychological police in a cyberpunk setting", 1,
                        exitMessage: "Psycho-Pass"),
                    new Choice("[2] Superpowers, X-Men style (Chinese Electric Batman)", 2,
                        exitMessage: "Darker than Black"),
                    new Choice("[3] Time travel experiment thriller", 3,
                        exitMessage: "Steins;Gate"),
                    new Choice("[4] Don't overdo it", 4,
                        nextQuestion: 3)
                }
            ));

            questions.Add(new Question(
                "Want something typically Japanese?",
                new Choice[]
                {
                    new Choice("[1] Samurai are cool (even cooler with hip-hop music)", 1,
                        exitMessage: "Samurai Champloo)"),
                    new Choice("[2] I'VE HEARD THERE ARE SOME GIANT ROBOTS", 2,
                        exitMessage: "TENGEN TOPPA GURREN LAGANN"),
                    new Choice("[3] I like the Ghibli movies, especially the spirit stuff", 3,
                        exitMessage: "Mushishi"),
                    new Choice("[4] Something more Western, please", 4, 4)
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