using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi5
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void SetData(Quiz quiz)
        {
            lbQuestion.Text = quiz.Question;
            if (quiz.AnswerCorrect == "A")
                lbCorrectAnswer.Text = quiz.Answers[0];
            else if (quiz.AnswerCorrect == "B")
                lbCorrectAnswer.Text = quiz.Answers[1];
            else if (quiz.AnswerCorrect == "C")
                lbCorrectAnswer.Text = quiz.Answers[2];
            else if (quiz.AnswerCorrect == "D")
                lbCorrectAnswer.Text = quiz.Answers[3];

            if (quiz.YourAnswer == "A")
                lbYourAnswer.Text = quiz.Answers[0];
            else if (quiz.YourAnswer == "B")
                lbYourAnswer.Text = quiz.Answers[1];
            else if (quiz.YourAnswer == "C")
                lbYourAnswer.Text = quiz.Answers[2];
            else if (quiz.YourAnswer == "D")
                lbYourAnswer.Text = quiz.Answers[3];
            lbYourAnswer.ForeColor = quiz.IsCorrect ? Color.Green : Color.Red;
        }
    }
}
