using System;
using Bitky_API.DTOs.SpeciyDTOs;
using Bitky_API.DTOs.SpeciesDTOs;
using Bitky_API.DTOs.SpeciyDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.SpeciyRepository
{
	public class SpeciyRepository : ISpeciyRepository
    {
        private readonly Context _context;
        public SpeciyRepository(Context context)
        {
            _context = context;
        }

        public bool CreateSpeciy(CreateSpeciyDTO createSpeciyDTO)
        {
            string query = "INSERT INTO Species (SpeciyNameLat, SpeciyNameTr, SpeciyNameEn)" +
                " VALUES (@SpeciyNameLat, @SpeciyNameTr, @SpeciyNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@SpeciyNameLat", createSpeciyDTO.SpeciyNameLat);
            parameters.Add("@SpeciyNameTr", createSpeciyDTO.SpeciyNameTr);
            parameters.Add("@SpeciyNameEn", createSpeciyDTO.SpeciyNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteSpeciy(DeleteSpeciyDTO deleteSpeciyDTO)
        {
            string query = "DELETE FROM Species WHERE SpeciyID = @SpeciyID";

            var parameters = new DynamicParameters();
            parameters.Add("@SpeciyID", deleteSpeciyDTO.SpeciyID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultSpeciyDTO>> GetAllSpeciesAsync()
        {
            string query = "SELECT SpeciyID, SpeciyNameLat, SpeciyNameTr, SpeciyNameEn FROM Species";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultSpeciyDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateSpeciy(UpdateSpeciyDTO updateSpeciyDTO)
        {
            string query = "UPDATE Species SET " +
                "SpeciyNameLat = @SpeciyNameLat," +
                "SpeciyNameTr = @SpeciyNameTr," +
                "SpeciyNameEn = @SpeciyNameEn " +
                "WHERE SpeciyID = @SpeciyID";

            var parameters = new DynamicParameters();
            parameters.Add("@SpeciyNameLat", updateSpeciyDTO.SpeciyNameLat);
            parameters.Add("@SpeciyNameTr", updateSpeciyDTO.SpeciyNameTr);
            parameters.Add("@SpeciyNameEn", updateSpeciyDTO.SpeciyNameEn);
            parameters.Add("@SpeciyID", updateSpeciyDTO.SpeciyID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

