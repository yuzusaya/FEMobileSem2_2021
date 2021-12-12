using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Models
{
    public class PostRecord
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
