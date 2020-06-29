﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace SusuTester.Json.Models
{
    public class QuestionModel
    {
        [JsonProperty(PropertyName = "queston")]
        public string Question { get; set; }


        [JsonProperty(PropertyName = "question_img")]
        public string QuestionImg { get; set; }


        [JsonProperty(PropertyName = "is_multi_select")]
        public bool IsMultiSelect { get; set; }


        [JsonProperty(PropertyName = "answers")]
        public List<AnswerModel> Answers { get; set; }


        [JsonProperty(PropertyName = "right_answer_index")]
        public int RightAnswerIndex { get; set; }

        [JsonProperty(PropertyName = "right_answer_index_array")]
        public int[] RightAnswerIndexArray { get; set; }


    }
}