namespace AnimeReco
{
    class Choice
    {
        public string Name { get; set; }
        public int Key { get; set; }
        public int NextQuestion { get; set; }

        public string ExitMessage { get; set; }

        public Choice(string name, int key, int nextQuestion = -1, string exitMessage = "")
        {
            this.Name = name;
            this.Key = key;
            this.NextQuestion = nextQuestion;
            this.ExitMessage = exitMessage;
        }
    }
}