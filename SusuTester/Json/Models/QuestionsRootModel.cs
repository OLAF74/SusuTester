using Newtonsoft.Json;
using System.Collections.Generic;

namespace SusuTester.Json.Models
{
    class QuestionsRootModel
    {
        [JsonProperty(PropertyName = "questions")]
        public List<QuestionModel> Questions { get; set; }
    }
}