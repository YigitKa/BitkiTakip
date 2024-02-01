using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.SubkingdomDTOs;
using Bitky_API.Repositories.SubkingdomRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class SubkingdomController : Controller
    {
        private readonly ISubkingdomRepository _subkingdomRepository;
        public SubkingdomController(ISubkingdomRepository subkingdomRepository)
        {
            _subkingdomRepository = subkingdomRepository;
        }

        [HttpGet]
        public async Task<IActionResult> SubkingdomList()
        {
            var values = await _subkingdomRepository.GetAllSubkingdomsAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSubkingdom([FromBody] DeleteSubkingdomDTO deleteSubkingdomDTO)
        {
            bool result = _subkingdomRepository.DeleteSubkingdom(deleteSubkingdomDTO);
            if (!result)
            {
                return Problem("Alt cins silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubkingdom([FromBody] CreateSubkingdomDTO createSubkingdomDTO)
        {
            bool result = _subkingdomRepository.CreateSubkingdom(createSubkingdomDTO);

            if (!result)
            {
                return Problem("Alt cins eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubkingdom([FromBody] UpdateSubkingdomDTO updateSubkingdomDTO)
        {
            bool result = _subkingdomRepository.UpdateSubkingdom(updateSubkingdomDTO);

            if (!result)
            {
                return Problem("Alt cins eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

