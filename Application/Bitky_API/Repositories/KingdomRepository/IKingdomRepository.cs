using System;
using Bitky_API.DTOs.KingdomDTOs;

namespace Bitky_API.Repositories.KingdomRepository
{
	public interface IKingdomRepository
	{
		Task<List<ResultKingdomDTO>> GetAllKingdomsAsync();
        bool DeleteKingdom(DeleteKingdomDTO deleteKingdomDTO);
        bool UpdateKingdom(UpdateKingdomDTO updateKingdomDTO);
        bool CreateKingdom(CreateKingdomDTO createKingdomDTO);
    }
}

