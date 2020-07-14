using Newtonsoft.Json;
using System.Collections.Generic;

namespace SusuTester.Json.Models
{
    /// <summary>
    /// Модель представления списка вопросов
    /// </summary>
    class QuestionsRootModel
    {
        /// <summary>
        /// Возвращает список вопросов
        /// </summary>
        [JsonProperty(PropertyName = "questions")]
        public List<QuestionModel> Questions { get; set; }
    }
}