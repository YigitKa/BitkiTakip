using System;
using Bitky_API.DTOs.GenusDTOs;

namespace Bitky_API.Repositories.GenusRepository
{
	public class GenusRepository : IGenusRepository
	{
		public GenusRepository()
		{
		}

        public bool CreateGenus(CreateGenusDTO createGenusDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGenus(DeleteGenusDTO deleteGenusDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultGenusDTO>> GetAllGenusesAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateGenus(UpdateGenusDTO updateGenusDTO)
        {
            throw new NotImplementedException();
        }
    }
}

