using SusuTester.Forms;
using SusuTester.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SusuTester
{
    public partial class Form1 : Form
    {
        private Parser ParserInstance;
        private List<QuestionScreen> QuestionScreens = new List<QuestionScreen>();
        private int CurrentQuestionIndex = 0;


        public Form1()
        {
            InitializeComponent();
        }



        private void ParseQuestons()
        {
            OpenFileDialog Filedialog = new OpenFileDialog();
            Filedialog.Filter = "json|*.json";
            Filedialog.InitialDirectory = Environment.CurrentDirectory;
            Filedialog.Title = "Выберите файл с вопросами";

            if (Filedialog.ShowDialog() == DialogResult.OK)
            {
                ParserInstance = new Parser(Filedialog.FileName);

                if (ParserInstance.IsQuestionsEmpty())
                {
                    MessageBox.Show("Вы точно выбрали правильный файл с вопросами?", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ParseQuestons();
                }
                else
                    LoadQuestions();
            }
        }

        private void LoadQuestions()
        {
            QuestionsHolder.Controls.Clear();
            QuestionScreens.Clear();
            CurrentQuestionIndex = 0;

            for (int i = 0; i < ParserInstance.GetQuestionsCount(); i++)
                QuestionScreens.Add(new QuestionScreen(ParserInstance.GetQuestions()[i]));

            LoadQuestionsToUI();
        }

        private void LoadQuestionsToUI(int index = 0)
        {
            QuestionsHolder.Controls.Clear();
            QuestionsHolder.Controls.Add(QuestionScreens[index]);
            Text = string.Format("Susu Tester [Вопрос {0} из {1}]", index + 1, QuestionScreens.Count);


            if (index != 0)
                GoPrev.Enabled = true;
            else
                GoPrev.Enabled = false;


            if (index != QuestionScreens.Count - 1)
                GoNext.Enabled = true;
            else
                GoNext.Enabled = false;

        }


        private void FormShown(object sender, EventArgs e)
        {
            ParseQuestons();
        }

        private void OpenQuestionsMenuItem_Click(object sender, EventArgs e)
        {
            ParseQuestons();
        }

        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            if (ParserInstance == null || ParserInstance.IsQuestionsEmpty())
                return;

            int RightAnswersCount = 0;
            for (int i = 0; i < QuestionScreens.Count; i++)
            {
                QuestionScreen QuestionScreenInstance = QuestionScreens[i];

                if (QuestionScreenInstance.IsRightAnswered())
                    RightAnswersCount++;
            }
            double RightAnswersPercentage = RightAnswersCount / (double)QuestionScreens.Count * 100;
            MessageBox.Show(string.Format("Тест пройден, правильных ответов {0} из {1}({2}%)", RightAnswersCount, QuestionScreens.Count, Math.Round(RightAnswersPercentage, 2)),
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

        private void GoNext_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex < QuestionScreens.Count - 1)
            {
                CurrentQuestionIndex++;
                LoadQuestionsToUI(CurrentQuestionIndex);
            }
        }

        private void GoPrev_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex > 0)
            {
                CurrentQuestionIndex--;
                LoadQuestionsToUI(CurrentQuestionIndex);
            }
        }
    }
}