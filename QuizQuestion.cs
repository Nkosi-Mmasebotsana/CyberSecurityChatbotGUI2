

namespace CyberSecurityChatbotGUI
{
    internal class QuizQuestion
    {

        public string Question { get; set; }
        public string[] Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public string Explanation { get; set; }

        public QuizQuestion(string question, string[] options, int correctOptionIndex, string explanation)
        {
            Question = question;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
            Explanation = explanation;
        }
    }
}
