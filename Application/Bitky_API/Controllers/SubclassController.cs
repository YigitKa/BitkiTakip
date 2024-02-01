using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.SubclassDTOs;
using Bitky_API.Repositories.SubclassRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class SubclassController : Controller
    {
        private readonly ISubclassRepository _subclassRepository;
        public SubclassController(ISubclassRepository subclassRepository)
        {
            _subclassRepository = subclassRepository;
        }

        [HttpGet]
        public async Task<IActionResult> SubclassList()
        {
            var values = await _subclassRepository.GetAllSubclassesAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSubclass([FromBody] DeleteSubclassDTO deleteSubclassDTO)
        {
            bool result = _subclassRepository.DeleteSubclass(deleteSubclassDTO);
            if (!result)
            {
                return Problem("Alt cins silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubclass([FromBody] CreateSubclassDTO createSubclassDTO)
        {
            bool result = _subclassRepository.CreateSubclass(createSubclassDTO);

            if (!result)
            {
                return Problem("Alt cins eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubclass([FromBody] UpdateSubclassDTO updateSubclassDTO)
        {
            bool result = _subclassRepository.UpdateSubclass(updateSubclassDTO);

            if (!result)
            {
                return Problem("Alt cins eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

