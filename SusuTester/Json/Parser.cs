using Newtonsoft.Json;
using SusuTester.Json.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SusuTester.Json
{
    class Parser
    {
        private QuestionsRootModel QuestionsRoot;


        public Parser(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с вопросами не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (StreamReader streamReader = new StreamReader(filePath)) {
                string rawString = streamReader.ReadToEnd();
                //rawString = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(rawString)); //uncomments if you use encrypted file with questions
                
                try {
                    QuestionsRoot = JsonConvert.DeserializeObject<QuestionsRootModel>(rawString);
                }
                catch (JsonReaderException) {
                    QuestionsRoot = null;
                    MessageBox.Show("Ошибка при разборе файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public List<QuestionModel> GetQuestions() {
            if (QuestionsRoot != null)
                return QuestionsRoot.Questions;

            return null;
        }

        public int GetQuestionsCount() {
            if (QuestionsRoot != null && QuestionsRoot.Questions != null)
                return QuestionsRoot.Questions.Count;

            return 0;
        }

        public bool IsQuestionsEmpty() {
            return QuestionsRoot == null || GetQuestionsCount() == 0;
        }
    }
}