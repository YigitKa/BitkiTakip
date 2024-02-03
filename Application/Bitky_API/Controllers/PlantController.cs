using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.PlantDTOs;
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
        public async Task<IActionResult> PlantList()
        {
            var values = await _plantRepository.GetAllPlantsAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlant([FromBody] DeletePlantDTO deletePlantDTO)
        {
            bool result = _plantRepository.DeletePlant(deletePlantDTO);
            if(!result)
            {
                return Problem("Bitki silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlant([FromBody] CreatePlantDTO createPlantDTO)
        {
            bool result = _plantRepository.CreatePlant(createPlantDTO);

            if (!result)
            {
                return Problem("Bitki eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlant([FromBody] UpdatePlantDTO updatePlantDTO)
        {
            bool result = _plantRepository.UpdatePlant(updatePlantDTO);

            if (!result)
            {
                return Problem("Bitki eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlant(int id)
        {
            var value = await _plantRepository.GetPlantPhotos(id);
            return Ok(value);
        }
    }
}

