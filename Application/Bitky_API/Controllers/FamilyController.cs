using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.FamilyDTOs;
using Bitky_API.Repositories.FamilyRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class FamilyController : Controller
    {
        private readonly IFamilyRepository _FamilyRepository;
        public FamilyController(IFamilyRepository FamilyRepository)
        {
            _FamilyRepository = FamilyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> FamilyList()
        {
            var values = await _FamilyRepository.GetAllFamiliesAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFamily([FromBody] DeleteFamilyDTO deleteFamilyDTO)
        {
            bool result = _FamilyRepository.DeleteFamily(deleteFamilyDTO);
            if (!result)
            {
                return Problem("Aile silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFamily([FromBody] CreateFamilyDTO createFamilyDTO)
        {
            bool result = _FamilyRepository.CreateFamily(createFamilyDTO);

            if (!result)
            {
                return Problem("Aile eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFamily([FromBody] UpdateFamilyDTO updateFamilyDTO)
        {
            bool result = _FamilyRepository.UpdateFamily(updateFamilyDTO);

            if (!result)
            {
                return Problem("Aile eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

