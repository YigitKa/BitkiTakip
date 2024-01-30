using System;
using Bitky_API.DTOs.FamilyDTOs;

namespace Bitky_API.Repositories.FamilyRepository
{
	public class FamilyRepository : IFamilyRepository
	{
		public FamilyRepository()
		{
		}

        public bool CreateFamily(CreateFamilyDTO createFamilyDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFamily(DeleteFamilyDTO deleteFamilyDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultFamilyDTO>> GetAllFamiliesAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateFamily(UpdateFamilyDTO updateFamilyDTO)
        {
            throw new NotImplementedException();
        }
    }
}

