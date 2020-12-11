using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TutorialProject.Models.Entitys;
using TutorialProject.Models.JsonFileProductServices;

namespace TutorialProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiMobileController : ControllerBase
    {
        public ApiMobileController(JsonFileProductService jsonFileProductService) {
            this.productService = jsonFileProductService;
        }

        private JsonFileProductService productService;


        [HttpGet]
        public string Get()
        {
            IEnumerable<Product> products = productService.GetProducts();
            return JsonSerializer.Serialize<IEnumerable<Product>>(products);
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string idProduct, [FromQuery] int rating) {
            productService.addRate(idProduct, rating);

            return Ok();
        }



        [HttpGet("{a}")] ///Link se kieu /apimobile/1      . Nghia la a=1 va no nhan tat ca cac tham so luon nhe ahihi. Sai tham so thi no se loi nhe baby
        public string GetSecond(int a) {

            return "Gia tri nhap vao: " + a;
        }










    }
}
