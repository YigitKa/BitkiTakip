using System;
using Bitky_API.DTOs.DivisionDTOs;

namespace Bitky_API.Repositories.DivisionRepository
{
	public interface IDivisionRepository
	{
		Task<List<ResultDivisionDTO>> GetAllDivisionsAsync();
        bool DeleteDivision(DeleteDivisionDTO deleteDivisionDTO);
        bool UpdateDivision(UpdateDivisionDTO updateDivisionDTO);
        bool CreateDivision(CreateDivisionDTO createDivisionDTO);
    }
}

