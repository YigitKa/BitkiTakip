using System;
using Bitky_API.DTOs.SubclassDTOs;

namespace Bitky_API.Repositories.SubclassRepository
{
	public interface ISubclassRepository
	{
		Task<List<ResultSubclassDTO>> GetAllSubclassesAsync();
        bool DeleteSubclass(DeleteSubclassDTO deleteSubclassDTO);
        bool UpdateSubclass(UpdateSubclassDTO updateSubclassDTO);
        bool CreateSubclass(CreateSubclassDTO createSubclassDTO);
    }
}

