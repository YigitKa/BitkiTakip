using System;
using Bitky_API.DTOs.KingdomDTOs;

namespace Bitky_API.Repositories.KingdomRepository
{
	public class KingdomRepository : IKingdomRepository
	{
		public KingdomRepository()
		{
		}

        public bool CreateKingdom(CreateKingdomDTO createKingdomDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteKingdom(DeleteKingdomDTO deleteKingdomDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultKingdomDTO>> GetAllKingdomsAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateKingdom(UpdateKingdomDTO updateKingdomDTO)
        {
            throw new NotImplementedException();
        }
    }
}

