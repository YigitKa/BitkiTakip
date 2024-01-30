using System;
using Bitky_API.DTOs.SpeciesDTOs;
using Bitky_API.DTOs.SpeciyDTOs;

namespace Bitky_API.Repositories.SpeciyRepository
{
	public class SpeciyRepository : ISpeciyRepository
	{
		public SpeciyRepository()
		{
		}

        public bool CreateSpeciy(CreateSpeciyDTO createSpeciyDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSpeciy(DeleteSpeciyDTO deleteSpeciyDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSpeciyDTO>> GetAllSpeciesAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSpeciy(UpdateSpeciyDTO updateSpeciyDTO)
        {
            throw new NotImplementedException();
        }
    }
}

