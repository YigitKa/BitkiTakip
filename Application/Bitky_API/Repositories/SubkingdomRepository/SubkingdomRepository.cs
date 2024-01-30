using System;
using Bitky_API.DTOs.SubkingdomDTOs;

namespace Bitky_API.Repositories.SubkingdomRepository
{
	public class SubkingdomRepository : ISubkingdomRepository
	{
		public SubkingdomRepository()
		{
		}

        public bool CreateSubkingdom(CreateSubkingdomDTO createSubkingdomDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSubkingdom(DeleteSubkingdomDTO deleteSubkingdomDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSubkingdomDTO>> GetAllSubkingdomsAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubkingdom(UpdateSubkingdomDTO updateSubkingdomDTO)
        {
            throw new NotImplementedException();
        }
    }
}

