using System;
using Bitky_API.DTOs.SpeciesDTOs;
using Bitky_API.DTOs.SpeciyDTOs;

namespace Bitky_API.Repositories.SpeciyRepository
{
	public interface ISpeciyRepository
	{
		Task<List<ResultSpeciyDTO>> GetAllSpeciesAsync();
        bool DeleteSpeciy(DeleteSpeciyDTO deleteSpeciyDTO);
        bool UpdateSpeciy(UpdateSpeciyDTO updateSpeciyDTO);
        bool CreateSpeciy(CreateSpeciyDTO createSpeciyDTO);
    }
}

