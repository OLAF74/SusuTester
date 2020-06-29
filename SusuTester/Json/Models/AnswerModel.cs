using Newtonsoft.Json;

namespace SusuTester.Json.Models
{
    public  class AnswerModel
    {
        [JsonProperty(PropertyName = "answer")]
        public string answer { get; set; }


        [JsonProperty(PropertyName = "answer_img")]
        public string answerImg { get; set; }
    }
}