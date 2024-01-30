using Bitky_WebApp.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_WebApp.Controllers
{
    public class PlantController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PlantController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7048/api/Plant");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultPlantDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

