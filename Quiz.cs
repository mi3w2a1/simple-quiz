using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuiz
{
    internal class Quiz
    {
        public Quiz(string question, string[] choices, string answer)
        {
            Question = question;
            Choices = choices;
            Answer = answer;
        }

        public string Question = "";
        public string[] Choices = null;
        public string Answer = "";
    }
}
