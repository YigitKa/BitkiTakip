using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitky_API.DTOs.KingdomDTOs;
using Bitky_API.Repositories.KingdomRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bitky_API.Controllers
{
    public class KingdomController : Controller
    {
        private readonly IKingdomRepository _kingdomRepository;
        public KingdomController(IKingdomRepository KingdomRepository)
        {
            _kingdomRepository = KingdomRepository;
        }

        [HttpGet]
        public async Task<IActionResult> KingdomList()
        {
            var values = await _kingdomRepository.GetAllKingdomsAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteKingdom([FromBody] DeleteKingdomDTO deleteKingdomDTO)
        {
            bool result = _kingdomRepository.DeleteKingdom(deleteKingdomDTO);
            if (!result)
            {
                return Problem("Alem silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateKingdom([FromBody] CreateKingdomDTO createKingdomDTO)
        {
            bool result = _kingdomRepository.CreateKingdom(createKingdomDTO);

            if (!result)
            {
                return Problem("Alem eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateKingdom([FromBody] UpdateKingdomDTO updateKingdomDTO)
        {
            bool result = _kingdomRepository.UpdateKingdom(updateKingdomDTO);

            if (!result)
            {
                return Problem("Alem eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

