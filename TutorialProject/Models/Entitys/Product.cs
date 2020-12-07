using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TutorialProject.Models.Entitys
{
    public class Product
    {
        [JsonPropertyName("id")]
        string Id;
        [JsonPropertyName("maker")]
        String Maker;
        [JsonPropertyName("img")]
        string Img;
        [JsonPropertyName("url")]
        string Url;
        [JsonPropertyName("title")]
        string Title;
        [JsonPropertyName("description")]
        string Description;
    }
}
