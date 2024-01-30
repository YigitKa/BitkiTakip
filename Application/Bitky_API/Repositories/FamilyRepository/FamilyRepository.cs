using System;
using Bitky_API.DTOs.FamilyDTOs;
using Bitky_API.DTOs.FamilyDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.FamilyRepository
{
	public class FamilyRepository : IFamilyRepository
    {
        private readonly Context _context;
        public FamilyRepository(Context context)
        {
            _context = context;
        }

        public bool CreateFamily(CreateFamilyDTO createFamilyDTO)
        {
            string query = "INSERT INTO Families (FamilyNameLat, FamilyNameTr, FamilyNameEn)" +
                 " VALUES (@FamilyNameLat, @FamilyNameTr, @FamilyNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@FamilyNameLat", createFamilyDTO.FamilyNameLat);
            parameters.Add("@FamilyNameTr", createFamilyDTO.FamilyNameTr);
            parameters.Add("@FamilyNameEn", createFamilyDTO.FamilyNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteFamily(DeleteFamilyDTO deleteFamilyDTO)
        {
            string query = "DELETE FROM Families WHERE FamilyID = @FamilyID";

            var parameters = new DynamicParameters();
            parameters.Add("@FamilyID", deleteFamilyDTO.FamilyID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultFamilyDTO>> GetAllFamiliesAsync()
        {
            string query = "SELECT FamilyID, FamilyNameLat, FamilyNameTr, FamilyNameEn FROM Families";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultFamilyDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateFamily(UpdateFamilyDTO updateFamilyDTO)
        {
            string query = "UPDATE Families SET " +
                "FamilyNameLat = @FamilyNameLat," +
                "FamilyNameTr = @FamilyNameTr," +
                "FamilyNameEn = @FamilyNameEn " +
                "WHERE FamilyID = @FamilyID";

            var parameters = new DynamicParameters();
            parameters.Add("@FamilyNameLat", updateFamilyDTO.FamilyNameLat);
            parameters.Add("@FamilyNameTr", updateFamilyDTO.FamilyNameTr);
            parameters.Add("@FamilyNameEn", updateFamilyDTO.FamilyNameEn);
            parameters.Add("@FamilyID", updateFamilyDTO.FamilyID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

