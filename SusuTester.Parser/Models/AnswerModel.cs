using Newtonsoft.Json;

namespace SusuTester.Json.Models
{
    /// <summary>
    /// Модель представления ответа на вопрос
    /// </summary>
    public  class AnswerModel
    {
        /// <summary>
        /// Строка содержащая текст ответа
        /// </summary>
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }


        /// <summary>
        /// Строка содержащая путь до файла изображения ответа
        /// </summary>
        [JsonProperty(PropertyName = "answer_img")]
        public string AnswerImg { get; set; }
    }
}