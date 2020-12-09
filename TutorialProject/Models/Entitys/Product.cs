using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TutorialProject.Models.Entitys
{
    public class Product
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("maker")]
        public String Maker { get; set; }
        [JsonPropertyName("img")]
        public string Img { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
