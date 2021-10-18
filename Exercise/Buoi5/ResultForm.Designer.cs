
namespace Exercise.Buoi5
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.lbYourAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQuestion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(21)))), ((int)(((byte)(204)))));
            this.lbQuestion.Location = new System.Drawing.Point(10, 10);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(388, 154);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correct answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your answer:";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(180, 184);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(20, 19);
            this.lbCorrectAnswer.TabIndex = 3;
            this.lbCorrectAnswer.Text = "A";
            // 
            // lbYourAnswer
            // 
            this.lbYourAnswer.AutoSize = true;
            this.lbYourAnswer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourAnswer.Location = new System.Drawing.Point(180, 219);
            this.lbYourAnswer.Name = "lbYourAnswer";
            this.lbYourAnswer.Size = new System.Drawing.Size(20, 19);
            this.lbYourAnswer.TabIndex = 4;
            this.lbYourAnswer.Text = "A";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 252);
            this.Controls.Add(this.lbYourAnswer);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.Label lbYourAnswer;
    }
}