using System.Drawing;
using System.Windows.Forms;
using SusuTester.Json.Models;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SusuTester
{
    public partial class QuestionScreen : UserControl
    {
        private QuestionModel QuestionInstance;


        public QuestionScreen(QuestionModel question)
        {
            InitializeComponent();
            this.QuestionInstance = question;
            LoadQuestionToUI();
        }


        private void LoadQuestionToUI()
        {
            if (!string.IsNullOrEmpty(QuestionInstance.Question))
                QuestionText.Text = QuestionInstance.Question;

            if (!string.IsNullOrEmpty(QuestionInstance.QuestionImg) && File.Exists(QuestionInstance.QuestionImg))
                QuestionImage.Image = Image.FromFile(QuestionInstance.QuestionImg);


            foreach (AnswerModel answer in QuestionInstance.Answers)
            {
                if (!QuestionInstance.IsMultiSelect)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.ImageAlign = ContentAlignment.MiddleLeft;
                    radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;



                    if (!string.IsNullOrEmpty(answer.Answer))
                        radioButton.Text = answer.Answer;

                    if (!string.IsNullOrEmpty(answer.AnswerImg) && File.Exists(answer.AnswerImg))
                    {
                        Image image = Image.FromFile(answer.AnswerImg);

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
                else {
                    CheckBox checkBox = new CheckBox();
                    checkBox.ImageAlign = ContentAlignment.MiddleLeft;
                    checkBox.TextImageRelation = TextImageRelation.ImageBeforeText;

                    if (!string.IsNullOrEmpty(answer.Answer))
                        checkBox.Text = answer.Answer;

                    if (!string.IsNullOrEmpty(answer.AnswerImg) && File.Exists(answer.AnswerImg))
                    {
                        Image image = Image.FromFile(answer.AnswerImg);

                        float scaleHeight = 200 / (float)image.Height;
                        float scaleWidth = 200 / (float)image.Width;
                        float scale = Math.Min(scaleHeight, scaleWidth);

                        Bitmap bmp = new Bitmap(image, (int)(image.Width * scale), (int)(image.Height * scale));
                        checkBox.Image = bmp;

                        image.Dispose();
                    }
                    checkBox.MaximumSize = new Size(0, 250);
                    checkBox.AutoSize = true;

                    AnswersGroup.Controls.Add(checkBox);
                }


                
            }
        }

        public bool IsRightAnswered()
        {
            if (!QuestionInstance.IsMultiSelect)
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

                return QuestionInstance.RightAnswerIndex == answerIndex;
            }
            else
            {
                List<int> AnswerIndexArray = new List<int>();
                for (int i = 0; i < AnswersGroup.Controls.Count; i++)
                {
                    CheckBox radioButton = (CheckBox)AnswersGroup.Controls[i];
                    if (radioButton.Checked)
                        AnswerIndexArray.Add(i);
                }

                return Enumerable.SequenceEqual(AnswerIndexArray, QuestionInstance.RightAnswerIndexArray);
            }
        }
    }
}