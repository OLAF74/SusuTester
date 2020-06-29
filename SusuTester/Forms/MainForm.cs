using SusuTester.Forms;
using SusuTester.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SusuTester
{
    public partial class Form1 : Form
    {
        private Parser parser;
        private List<QuestionScreen> questionScreens = new List<QuestionScreen>();
        int currentQuestion = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void FormShown(object sender, EventArgs e)
        {
            ParseQuestons();
        }

        private void OpenQuestionsMenuItem_Click(object sender, EventArgs e)
        {
            ParseQuestons();
        }

       


        private void ParseQuestons()
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "json|*.json";
            filedialog.InitialDirectory = Environment.CurrentDirectory;
            filedialog.Title = "Выберите файл с вопросами";

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                parser = new Parser(filedialog.FileName);

                if (parser.IsQuestionsEmpty())
                {
                    MessageBox.Show("Вы точно выбрали правильный файл с вопросами?", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ParseQuestons();
                }
                else
                    LoadQuestions();
            }
        }

        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            if (parser == null || parser.IsQuestionsEmpty())
                return;

            int rightAnswers = 0;
            for (int i = 0; i < questionScreens.Count; i++)
            {
                QuestionScreen questionScreen = questionScreens[i];

                if (questionScreen.IsRightAnswered())
                    rightAnswers++;
            }
            double rightAnswersPercentage = rightAnswers / (double)questionScreens.Count * 100;
            MessageBox.Show(string.Format("Тест пройден, правильных ответов {0} из {1}({2}%)", rightAnswers, questionScreens.Count, Math.Round(rightAnswersPercentage, 2)),
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            Text = "Susu Tester";
            QuestionsHolder.Controls.Clear();
            ParseQuestons();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void LoadQuestions()
        {
            QuestionsHolder.Controls.Clear();
            questionScreens.Clear();
            currentQuestion = 0;

            for (int i = 0; i < parser.GetQuestionsCount(); i++)
                questionScreens.Add(new QuestionScreen(parser.GetQuestions()[i]));

            LoadQuestionsToUI(0);
        }

        private void LoadQuestionsToUI(int index)
        {
            QuestionsHolder.Controls.Clear();
            QuestionsHolder.Controls.Add(questionScreens[index]);
            Text = string.Format("Susu Tester [Вопрос {0} из {1}]", index + 1, questionScreens.Count);
           
       
            if (index != 0)
                GoPrev.Enabled = true;
            else
                GoPrev.Enabled = false;


            if (index != questionScreens.Count - 1)
                GoNext.Enabled = true;
            else 
                GoNext.Enabled = false;

        }

        private void GoNext_Click(object sender, EventArgs e)
        {
            if (currentQuestion < questionScreens.Count - 1)
            {
                currentQuestion++;
                LoadQuestionsToUI(currentQuestion);
            }
        }

        private void GoPrev_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                currentQuestion--;
                LoadQuestionsToUI(currentQuestion);
            }
        }

       
    }
}