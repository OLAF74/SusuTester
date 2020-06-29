using Newtonsoft.Json;

namespace SusuTester.Json.Models
{
    public  class AnswerModel
    {
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }


        [JsonProperty(PropertyName = "answer_img")]
        public string AnswerImg { get; set; }
    }
}