using System;
using Bitky_API.DTOs.SubkingdomDTOs;

namespace Bitky_API.Repositories.SubkingdomRepository
{
	public interface ISubkingdomRepository
	{
		Task<List<ResultSubkingdomDTO>> GetAllSubkingdomsAsync();
        bool DeleteSubkingdom(DeleteSubkingdomDTO deleteSubkingdomDTO);
        bool UpdateSubkingdom(UpdateSubkingdomDTO updateSubkingdomDTO);
        bool CreateSubkingdom(CreateSubkingdomDTO createSubkingdomDTO);
    }
}

