using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.SpeciyDTOs;
using Bitky_API.Repositories.SpeciyRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class SpeciyController : Controller
    {
        private readonly ISpeciyRepository _speciyRepository;
        public SpeciyController(ISpeciyRepository speciyRepository)
        {
            _speciyRepository = speciyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> SpeciyList()
        {
            var values = await _speciyRepository.GetAllSpeciesAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSpeciy([FromBody] DeleteSpeciyDTO deleteSpeciyDTO)
        {
            bool result = _speciyRepository.DeleteSpeciy(deleteSpeciyDTO);
            if (!result)
            {
                return Problem("Tür silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpeciy([FromBody] CreateSpeciyDTO createSpeciyDTO)
        {
            bool result = _speciyRepository.CreateSpeciy(createSpeciyDTO);

            if (!result)
            {
                return Problem("Tür eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSpeciy([FromBody] UpdateSpeciyDTO updateSpeciyDTO)
        {
            bool result = _speciyRepository.UpdateSpeciy(updateSpeciyDTO);

            if (!result)
            {
                return Problem("Tür eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

