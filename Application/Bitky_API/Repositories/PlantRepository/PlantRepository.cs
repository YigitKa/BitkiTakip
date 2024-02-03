using System;
using Bitky_API.DTOs.PlantDTOs;
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

        public bool UpdatePlant(UpdatePlantDTO updatePlantDTO)
        {
            throw new NotImplementedException();
        }
    }
}

