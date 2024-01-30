using System;
using Bitky_API.DTOs.DivisionDTOs;

namespace Bitky_API.Repositories.DivisionRepository
{
	public class DivisionRepository : IDivisionRepository
	{
		public DivisionRepository()
		{
		}

        public bool CreateDivision(CreateDivisionDTO createDivision)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDivision(DeleteDivisionDTO deleteDivisionDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultDivisionDTO>> GetAllDivisionsAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDivision(UpdateDivisionDTO updateDivisionDTO)
        {
            throw new NotImplementedException();
        }
    }
}

