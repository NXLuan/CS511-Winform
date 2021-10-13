using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi5
{
    public partial class ExamForm : Form
    {
        int indexCurrentQuiz;
        List<Quiz> exam;
        public ExamForm()
        {
            InitializeComponent();
            pnImport.Visible = false;
            pnTest.Visible = false;
            btnResult.Enabled = false;
            pbBack.Enabled = false;
            pbNext.Enabled = false;
            exam = new List<Quiz>();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!pnImport.Visible)
            {
                pnImport.Visible = true;
                pnTest.Visible = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!pnTest.Visible)
            {
                pnImport.Visible = false;
                pnTest.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbImportQuiz_Click(object sender, EventArgs e)
        {
            var lines = ReadTextFromFile();
            if (lines != null)
            {
                txtQuiz.Text = string.Join("\n", lines);

                for (int i = 0; i < lines.Length; i += 2)
                {
                    Quiz quiz = new Quiz()
                    {
                        Question = lines[i],
                        Answers = lines[i + 1].Split('\t'),
                    };
                    exam.Add(quiz);
                }
            }
        }

        private void pbImportAnswer_Click(object sender, EventArgs e)
        {
            if (exam.Count == 0)
            {
                MessageBox.Show("Chưa import câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = ReadTextFromFile();
            if (lines != null)
            {
                if (lines.Length != exam.Count)
                {
                    MessageBox.Show("Số câu trả lời không khớp số câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string richtex = "";
                for (int i = 0; i < lines.Length; i++)
                {
                    richtex += "Question " + (i + 1) + ": " + lines[i] + "\n";
                    exam[i].AnswerCorrect = lines[i];
                }
                txtAnswer.Text = richtex;
                btnResult.Enabled = true;
                pbBack.Enabled = true;
                pbNext.Enabled = true;
                SetCurrentQuiz(0);
            }
        }

        public void SetCurrentQuiz(int index)
        {
            if (index == 0)
            {
                pbBack.Enabled = false;
            }
            else if (index == exam.Count - 1)
            {
                pbNext.Enabled = false;
            }
            else
            {
                pbBack.Enabled = true;
                pbNext.Enabled = true;
            }

            indexCurrentQuiz = index;
            Quiz currentQuiz = exam[index];
            lbQuestion.Text = currentQuiz.Question;
            rdAnswerA.Text = currentQuiz.Answers[0];
            rdAnswerB.Text = currentQuiz.Answers[1];
            rdAnswerC.Text = currentQuiz.Answers[2];
            rdAnswerD.Text = currentQuiz.Answers[3];

            if (currentQuiz.YourAnswer != null)
            {
                if (currentQuiz.YourAnswer == "A")
                    rdAnswerA.Checked = true;
                else if (currentQuiz.YourAnswer == "B")
                    rdAnswerB.Checked = true;
                else if (currentQuiz.YourAnswer == "C")
                    rdAnswerC.Checked = true;
                else if (currentQuiz.YourAnswer == "D")
                    rdAnswerD.Checked = true;
            }
            else
            {
                rdAnswerA.Checked = false;
                rdAnswerB.Checked = false;
                rdAnswerC.Checked = false;
                rdAnswerD.Checked = false;
            }
        }

        public string[] ReadTextFromFile()
        {
            string[] lines = null;

            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lines = File.ReadAllLines(opentext.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lines = null;
                }
            }

            return lines;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            SetCurrentQuiz(indexCurrentQuiz - 1);
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (rdAnswerA.Checked)
                exam[indexCurrentQuiz].YourAnswer = "A";
            else if (rdAnswerB.Checked)
                exam[indexCurrentQuiz].YourAnswer = "B";
            else if (rdAnswerC.Checked)
                exam[indexCurrentQuiz].YourAnswer = "C";
            else if (rdAnswerD.Checked)
                exam[indexCurrentQuiz].YourAnswer = "D";
            SetCurrentQuiz(indexCurrentQuiz + 1);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            btnResult.Enabled = false;
            pbBack.Enabled = false;
            pbNext.Enabled = false;

            int CorrectAnswer = 0;
            int FailAnwer = 0;
            for (int i = 0; i <= indexCurrentQuiz; i++)
            {
                if (exam[i]?.YourAnswer != null)
                {
                    if (exam[i].IsCorrect) CorrectAnswer++;
                    else FailAnwer++;
                    ResultControl resultControl = new ResultControl()
                    {
                        Index = i,
                        Quiz = exam[i]
                    };

                    resultBoard.Controls.Add(resultControl);
                }
            }

            lbCountTrue.Text = CorrectAnswer.ToString();
            lbCountFalse.Text = FailAnwer.ToString();
        }
    }
}
