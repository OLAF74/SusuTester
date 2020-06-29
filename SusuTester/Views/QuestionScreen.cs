using System.Drawing;
using System.Windows.Forms;
using SusuTester.Json.Models;
using System.IO;
using System;

namespace SusuTester
{
    public partial class QuestionScreen : UserControl
    {
        private QuestionModel question;


        public QuestionScreen(QuestionModel question)
        {
            InitializeComponent();
            this.question = question;
            LoadQuestionToUI();
        }


        private void LoadQuestionToUI()
        {
            if (!string.IsNullOrEmpty(question.question))
                QuestionText.Text = question.question;

           if (!string.IsNullOrEmpty(question.questionImg) && File.Exists(question.questionImg))
                QuestionImage.Image = Image.FromFile(question.questionImg);


            foreach (AnswerModel answer in question.answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.ImageAlign = ContentAlignment.MiddleLeft;
                radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                
              
                
                if (!string.IsNullOrEmpty(answer.answer))
                    radioButton.Text = answer.answer;

                if (!string.IsNullOrEmpty(answer.answerImg) && File.Exists(answer.answerImg)) {
                    Image image = Image.FromFile(answer.answerImg);

                    float scaleHeight = 200 / (float)image.Height;
                    float scaleWidth = 200 / (float)image.Width;
                    float scale = Math.Min(scaleHeight, scaleWidth);

                    Bitmap bmp = new Bitmap(image, (int)(image.Width * scale), (int)(image.Height * scale));
                    radioButton.Image = bmp;
                  
                    image.Dispose();
                }
                radioButton.MaximumSize = new Size(0, 250);
                radioButton.AutoSize = true;

                AnswersGroup.Controls.Add(radioButton);
            }
        }

        public bool IsRightAnswered()
        {
            int answerIndex = -1;
            for (int i = 0; i < AnswersGroup.Controls.Count; i++)
            {
                RadioButton radioButton = (RadioButton)AnswersGroup.Controls[i];
                if (radioButton.Checked)
                {
                    answerIndex = i;
                    break;
                }
            }

            return question.rightAnswerIndex == answerIndex;
        }
    }
}