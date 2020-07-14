using Newtonsoft.Json;
using System.Collections.Generic;

namespace SusuTester.Json.Models
{
    /// <summary>
    /// Модель представления вопроса
    /// </summary>
    public class QuestionModel
    {
        /// <summary>
        /// Строка содержащая текст вопроса
        /// </summary>
        [JsonProperty(PropertyName = "queston")]
        public string Question { get; set; }


        /// <summary>
        /// Строка содержащая путь до файла изображения вопроса
        /// </summary>
        [JsonProperty(PropertyName = "question_img")]
        public string QuestionImg { get; set; }


        /// <summary>
        /// Значение, указывающие на возможность выбора нескольких вариантов ответа
        /// </summary>
        [JsonProperty(PropertyName = "is_multi_select")]
        public bool IsMultiSelect { get; set; }


        /// <summary>
        /// Массив ответов на вопрос
        /// </summary>
        [JsonProperty(PropertyName = "answers")]
        public List<AnswerModel> Answers { get; set; }


        /// <summary>
        /// Значение, указывающее на позицию правильного ответа в объекте <see cref="Answers"/>
        /// <br/>
        /// При условии, что <see cref="IsMultiSelect"/> <c>== false</c>
        /// </summary>
        [JsonProperty(PropertyName = "right_answer_index")]
        public int RightAnswerIndex { get; set; }


        /// <summary>
        /// Массив значний, указывающих на позицию правильных ответов в объекте <see cref="Answers"/>
        /// <br/>
        /// При условии, что <see cref="IsMultiSelect"/> <c>== true</c>
        /// </summary>
        [JsonProperty(PropertyName = "right_answer_index_array")]
        public int[] RightAnswerIndexArray { get; set; }
    }
}