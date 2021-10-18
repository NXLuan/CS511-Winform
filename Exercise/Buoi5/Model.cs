using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Buoi5
{ 
    public class Quiz
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public string AnswerCorrect { get; set; }

        private string _yourAnswer;
        public string YourAnswer 
        { 
            get => _yourAnswer;
            set
            {
                _yourAnswer = value;
                IsCorrect = value.Trim().Equals(AnswerCorrect.Trim());
            } 
        }
        public bool IsCorrect { get; set; }
    }
}
