using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.DivisionDTOs;
using Bitky_API.Repositories.DivisionRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class DivisionController : Controller
    {
        private readonly IDivisionRepository _divisionRepository;
        public DivisionController(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> DivisionList()
        {
            var values = await _divisionRepository.GetAllDivisionsAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDivision([FromBody] DeleteDivisionDTO deleteDivisionDTO)
        {
            bool result = _divisionRepository.DeleteDivision(deleteDivisionDTO);
            if (!result)
            {
                return Problem("Bölüm silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDivision([FromBody] CreateDivisionDTO createDivisionDTO)
        {
            bool result = _divisionRepository.CreateDivision(createDivisionDTO);

            if (!result)
            {
                return Problem("Bölüm eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDivision([FromBody] UpdateDivisionDTO updateDivisionDTO)
        {
            bool result = _divisionRepository.UpdateDivision(updateDivisionDTO);

            if (!result)
            {
                return Problem("Bölüm eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

