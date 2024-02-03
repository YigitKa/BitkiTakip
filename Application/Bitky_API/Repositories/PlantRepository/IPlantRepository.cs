using System;
using Bitky_API.DTOs.PlantDTOs;

namespace Bitky_API.Repositories.PlantRepository
{
	public interface IPlantRepository
	{
		Task<List<ResultPlantDTO>> GetAllPlantsAsync();
        bool DeletePlant(DeletePlantDTO deletePlantDTO);
        bool UpdatePlant(UpdatePlantDTO updatePlantDTO);
        bool CreatePlant(CreatePlantDTO createPlantDTO);
        Task<ResultPlantDTO> GetPlantPhotos(int plantID);
    }
}

