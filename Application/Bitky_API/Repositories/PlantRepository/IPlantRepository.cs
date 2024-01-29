using System;
using Bitky_API.DTOs.PlantDTOs;

namespace Bitky_API.Repositories.PlantRepository
{
	public interface IPlantRepository
	{
		Task<List<ResultPlantDTO>> GetAllPlantsAsync();
	}
}

