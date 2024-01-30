using System;
using Bitky_API.DTOs.GenusDTOs;

namespace Bitky_API.Repositories.GenusRepository
{
	public interface IGenusRepository
	{
		Task<List<ResultGenusDTO>> GetAllGenusesAsync();
        bool DeleteGenus(DeleteGenusDTO deleteGenusDTO);
        bool UpdateGenus(UpdateGenusDTO updateGenusDTO);
        bool CreateGenus(CreateGenusDTO createGenusDTO);
    }
}

