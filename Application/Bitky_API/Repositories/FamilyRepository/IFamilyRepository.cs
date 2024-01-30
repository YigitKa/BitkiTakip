using System;
using Bitky_API.DTOs.FamilyDTOs;

namespace Bitky_API.Repositories.FamilyRepository
{
	public interface IFamilyRepository
	{
		Task<List<ResultFamilyDTO>> GetAllFamiliesAsync();
        bool DeleteFamily(DeleteFamilyDTO deleteFamilyDTO);
        bool UpdateFamily(UpdateFamilyDTO updateFamilyDTO);
        bool CreateFamily(CreateFamilyDTO createFamilyDTO);
    }
}

