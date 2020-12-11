using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TutorialProject.Models.Entitys;

namespace TutorialProject.Models.JsonFileProductServices
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {

            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }
        public IEnumerable<Product> GetProducts()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    }
                    );
            }
        }
        public void addRate(string idProduct, int rate)
        {
            IEnumerable<Product> products = GetProducts();
            //Product product = products.Where(x =>
            // {
            //     return x.Id == idProduct;
            // }).First();
            Product product = products.First<Product>(x=> x.Id == idProduct);

            if (product.Ratings == null)
            {
                product.Ratings = new int[] { rate };
            }
            else
            {
                List<int> list = product.Ratings.ToList();
                list.Add(rate);
                product.Ratings = list.ToArray();
            }
            using (var ouputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(ouputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products);
            }
        }

    }
}
