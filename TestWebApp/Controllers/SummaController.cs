using TestWebApp.Interfaces;
using TestWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestWebApp.Controllers
{
    [Route("Summa")]
    public class SummaController : Controller
    {
        private readonly ISummator _summator;
        private readonly ILogger _logger;

        public SummaController(ISummator summator, ILogger<SummaController> logger)
        {
            _summator = summator;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("PostJson")]
        [HttpPost]
        public JsonResult GetPostJsonResult([FromBody]Numbers number) 
        {
            _logger.LogInformation($"Processing request a = {number.a} , b = {number.b}");
            ResultJson resultJson = new ResultJson(_summator.Sum(number.a, number.b));
            _logger.LogInformation($"Processing response c = {resultJson.c}");
            return Json(resultJson);
        }
    }
}