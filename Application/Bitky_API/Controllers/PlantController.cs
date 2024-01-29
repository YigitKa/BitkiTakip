using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.Repositories.PlantRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    [Route("api/[controller]")]
    public class PlantController : Controller
    {
        private readonly IPlantRepository _plantRepository;
        public PlantController(IPlantRepository plantRepository)
        {
            _plantRepository = plantRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _plantRepository.GetAllPlantsAsync();
            return Ok(values);
        }
    }
}

