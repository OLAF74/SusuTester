using Newtonsoft.Json;
using System.Collections.Generic;

namespace SusuTester.Json.Models
{
    public class QuestionModel
    {
        [JsonProperty(PropertyName = "queston")]
        public string question { get; set; }


        [JsonProperty(PropertyName = "question_img")]
        public string questionImg { get; set; }


        [JsonProperty(PropertyName = "answers")]
        public List<AnswerModel> answers { get; set; }


        [JsonProperty(PropertyName = "right_answer_index")]
        public int rightAnswerIndex { get; set; }
    }
}