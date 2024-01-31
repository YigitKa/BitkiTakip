using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.ClassDTOs;
using Bitky_API.Repositories.ClassRepository;
using Bitky_API.Repositories.PlantRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ClassList()
        {
            var values = await _classRepository.GetAllClassesAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClass([FromBody] DeleteClassDTO deleteClassDTO)
        {
            bool result = _classRepository.DeleteClass(deleteClassDTO);
            if (!result)
            {
                return Problem("Sınıf silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClass([FromBody] CreateClassDTO createClassDTO)
        {
            bool result = _classRepository.CreateClass(createClassDTO);

            if (!result)
            {
                return Problem("Sınıf eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClass([FromBody] UpdateClassDTO updateClassDTO)
        {
            bool result = _classRepository.UpdateClass(updateClassDTO);

            if (!result)
            {
                return Problem("Sınıf eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

