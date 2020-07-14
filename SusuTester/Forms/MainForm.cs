using SusuTester.Forms;
using SusuTester.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace SusuTester
{
    public partial class Form1 : Form
    {
        #region VARS

        private Parser ParserInstance;
        private List<QuestionScreen> QuestionScreens = new List<QuestionScreen>();
        private int CurrentQuestionIndex = 0;
        Configuration Configuration;

        #endregion VARS


        public Form1()
        {
            InitializeComponent();
            Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        #region LOAD LOGIC
        private void ParseQuestons()
        {
            string filePath = Configuration.AppSettings.Settings["QuestionsFileDirectory"].Value;



            //QuestionsFileDirectory
            if (string.IsNullOrEmpty(filePath))
            {

                OpenFileDialog Filedialog = new OpenFileDialog
                {
                    Filter = "json|*.json",
                    InitialDirectory = Environment.CurrentDirectory,
                    Title = "Выберите файл с вопросами"
                };

                if (Filedialog.ShowDialog() == DialogResult.OK)
                    CreateParser(Filedialog.FileName);

            }
            else
                CreateParser(filePath);
        }

        private void CreateParser(string path)
        {
            ParserInstance = new Parser(path);

            if (ParserInstance.IsQuestionsEmpty())
            {
                MessageBox.Show("Вы точно выбрали правильный файл с вопросами?", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ParseQuestons();
            }
            else
                LoadQuestions();
        }

        private void LoadQuestions()
        {
            Configuration.AppSettings.Settings["QuestionsFileDirectory"].Value = ParserInstance.QuestionsFileDirectory;
            Configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            SendAnswersButton.Enabled = true;
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
            Text = $"Susu Tester [Вопрос {index + 1} из {QuestionScreens.Count}]";


            if (index != 0)
                GoPrev.Enabled = true;
            else
                GoPrev.Enabled = false;


            if (index != QuestionScreens.Count - 1)
                GoNext.Enabled = true;
            else
                GoNext.Enabled = false;

        }
        #endregion LOAD LOGIC

        #region UI
        private void FormShown(object sender, EventArgs e)
        {
            ParseQuestons();
        }

        private void OpenQuestionsMenuItem_Click(object sender, EventArgs e)
        {
            Configuration.AppSettings.Settings["QuestionsFileDirectory"].Value = null;
            Configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            ParseQuestons();
        }

        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            if (ParserInstance == null || ParserInstance.IsQuestionsEmpty())
                return;

            Configuration.AppSettings.Settings["QuestionsFileDirectory"].Value = null;
            Configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            IEnumerable<QuestionScreen> RightAnswers = QuestionScreens.Where(screen => screen.IsRightAnswered());

            double RightAnswersPercentage = RightAnswers.Count() / (double)QuestionScreens.Count * 100;
            string resultString = $"Тест пройден, правильных ответов { RightAnswers.Count()} из {QuestionScreens.Count}({Math.Round(RightAnswersPercentage, 2)}%)\nХотите просмотртеь правильные варианты ответов?";



            if (MessageBox.Show(resultString, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (QuestionScreen questionScreen in QuestionScreens)
                    questionScreen.ShowRightAnswer();

                SendAnswersButton.Enabled = false;
            }
            else
            {
                Text = "Susu Tester";
                QuestionsHolder.Controls.Clear();
                ParseQuestons();
            }

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

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion UI
    }
}