using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.GenusDTOs;
using Bitky_API.Repositories.GenusRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class GenusController : Controller
    {
        private readonly IGenusRepository _genusRepository;
        public GenusController(IGenusRepository GenusRepository)
        {
            _genusRepository = GenusRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GenusList()
        {
            var values = await _genusRepository.GetAllGenusesAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenus([FromBody] DeleteGenusDTO deleteGenusDTO)
        {
            bool result = _genusRepository.DeleteGenus(deleteGenusDTO);
            if (!result)
            {
                return Problem("Cins silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGenus([FromBody] CreateGenusDTO createGenusDTO)
        {
            bool result = _genusRepository.CreateGenus(createGenusDTO);

            if (!result)
            {
                return Problem("Cins eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGenus([FromBody] UpdateGenusDTO updateGenusDTO)
        {
            bool result = _genusRepository.UpdateGenus(updateGenusDTO);

            if (!result)
            {
                return Problem("Cins eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

