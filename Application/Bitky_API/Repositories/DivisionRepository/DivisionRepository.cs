using System;
using Bitky_API.DTOs.DivisionDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.DivisionRepository
{
	public class DivisionRepository : IDivisionRepository
    {
        private readonly Context _context;
        public DivisionRepository(Context context)
        {
            _context = context;
        }

        public bool CreateDivision(CreateDivisionDTO createDivisionDTO)
        {
            string query = "INSERT INTO Divisions (DivisionNameLat, DivisionNameTr, DivisionNameEn)" +
                          " VALUES (@DivisionNameLat, @DivisionNameTr, @DivisionNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@DivisionNameLat", createDivisionDTO.DivisionNameLat);
            parameters.Add("@DivisionNameTr", createDivisionDTO.DivisionNameTr);
            parameters.Add("@DivisionNameEn", createDivisionDTO.DivisionNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteDivision(DeleteDivisionDTO deleteDivisionDTO)
        {
            string query = "DELETE FROM Divisions WHERE DivisionID = @DivisionID";

            var parameters = new DynamicParameters();
            parameters.Add("@DivisionID", deleteDivisionDTO.DivisionID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultDivisionDTO>> GetAllDivisionsAsync()
        {
            string query = "SELECT DivisionID, DivisionNameLat, DivisionNameTr, DivisionNameEn FROM Divisions";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultDivisionDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateDivision(UpdateDivisionDTO updateDivisionDTO)
        {
            string query = "UPDATE Divisions SET " +
                "DivisionNameLat = @DivisionNameLat," +
                "DivisionNameTr = @DivisionNameTr," +
                "DivisionNameEn = @DivisionNameEn " +
                "WHERE DivisionID = @DivisionID";

            var parameters = new DynamicParameters();
            parameters.Add("@DivisionNameLat", updateDivisionDTO.DivisionNameLat);
            parameters.Add("@DivisionNameTr", updateDivisionDTO.DivisionNameTr);
            parameters.Add("@DivisionNameEn", updateDivisionDTO.DivisionNameEn);
            parameters.Add("@DivisionID", updateDivisionDTO.DivisionID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

