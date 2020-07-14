using Newtonsoft.Json;
using SusuTester.Json.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SusuTester.Json
{
    /// <summary>
    /// Представляет класс для загрузки и получения списка вопросов
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// Экземпляр класса с вопросами
        /// </summary>
        private QuestionsRootModel QuestionsRoot;


        /// <summary>
        /// Строка, содержащая путь до файла с вопросами;
        /// </summary>
        public string QuestionsFileDirectory;


        /// <summary>
        /// Создает экземпляр класса и загружает вопросы из файла по указанному пути
        /// </summary>
        /// <param name="filePath">Путь к json файлу с вопросами</param>
        public Parser(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с вопросами не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string rawString = streamReader.ReadToEnd();
                //rawString = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(rawString)); //uncomment if you use encrypted(base64) file with questions

                try
                {
                    QuestionsRoot = JsonConvert.DeserializeObject<QuestionsRootModel>(rawString);
                    QuestionsFileDirectory = filePath;
                }
                catch (JsonReaderException)
                {
                    QuestionsRoot = null;
                    MessageBox.Show("Ошибка при разборе файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Возвращает массив вопросов
        /// </summary>
        public List<QuestionModel> GetQuestions()
        {
            if (QuestionsRoot != null)
                return QuestionsRoot.Questions;

            return null;
        }


        /// <summary>
        /// Возвращает целое число - количество вопросов
        /// </summary>
        public int GetQuestionsCount()
        {
            if (QuestionsRoot != null && QuestionsRoot.Questions != null)
                return QuestionsRoot.Questions.Count;

            return 0;
        }


        /// <summary>
        /// Возвращает значение, указывающие присутствуют ли вопросы в списке
        /// </summary>
        public bool IsQuestionsEmpty()
        {
            return QuestionsRoot == null || GetQuestionsCount() == 0;
        }
    }
}