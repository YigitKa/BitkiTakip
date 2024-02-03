using System;
using Bitky_API.DTOs.PlantDTOs;
using Bitky_API.DTOs.PlantPhotoDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.PlantRepository
{
	public class PlantRepository : IPlantRepository
	{
        private readonly Context _context;
		public PlantRepository(Context context)
		{
            _context = context;
		}

        public bool CreatePlant(CreatePlantDTO createPlantDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlant(DeletePlantDTO deletePlantDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPlantDTO>> GetAllPlantsAsync()
        {
            string query = "SELECT * FROM vw_PlantDetails";

            using (var con = _context.ConnectSQL())
            {
                var values = await con.QueryAsync<ResultPlantDTO>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultPlantPhotoDTO>> GetPlantPhotos(int plantID)
        {
            string query = "SELECT * FROM PlantPhotos WHERE PlantID = @plantID";
            var parameters = new DynamicParameters();
            parameters.Add("@plantID", plantID);

            using (var con = _context.ConnectSQL())
            {
                var value = await con.QueryAsync<ResultPlantPhotoDTO>(query, parameters);
                return value.ToList();
            }
        }

        public bool UpdatePlant(UpdatePlantDTO updatePlantDTO)
        {
            throw new NotImplementedException();
        }
    }
}

