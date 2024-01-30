using System;
using Bitky_API.DTOs.SubkingdomDTOs;
using Bitky_API.DTOs.SubkingdomDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.SubkingdomRepository
{
	public class SubkingdomRepository : ISubkingdomRepository
    {
        private readonly Context _context;
        public SubkingdomRepository(Context context)
        {
            _context = context;
        }

        public bool CreateSubkingdom(CreateSubkingdomDTO createSubkingdomDTO)
        {
            string query = "INSERT INTO Subkingdoms (SubkingdomNameLat, SubkingdomNameTr, SubkingdomNameEn)" +
    " VALUES (@SubkingdomNameLat, @SubkingdomNameTr, @SubkingdomNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@SubkingdomNameLat", createSubkingdomDTO.SubkingdomNameLat);
            parameters.Add("@SubkingdomNameTr", createSubkingdomDTO.SubkingdomNameTr);
            parameters.Add("@SubkingdomNameEn", createSubkingdomDTO.SubkingdomNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteSubkingdom(DeleteSubkingdomDTO deleteSubkingdomDTO)
        {
            string query = "DELETE FROM Subkingdoms WHERE SubkingdomID = @SubkingdomID";

            var parameters = new DynamicParameters();
            parameters.Add("@SubkingdomID", deleteSubkingdomDTO.SubkingdomID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultSubkingdomDTO>> GetAllSubkingdomsAsync()
        {
            string query = "SELECT SubkingdomID, SubkingdomNameLat, SubkingdomNameTr, SubkingdomNameEn FROM Subkingdoms";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultSubkingdomDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateSubkingdom(UpdateSubkingdomDTO updateSubkingdomDTO)
        {
            string query = "UPDATE Subkingdoms SET " +
                 "SubkingdomNameLat = @SubkingdomNameLat," +
                 "SubkingdomNameTr = @SubkingdomNameTr," +
                 "SubkingdomNameEn = @SubkingdomNameEn " +
                 "WHERE SubkingdomID = @SubkingdomID";

            var parameters = new DynamicParameters();
            parameters.Add("@SubkingdomNameLat", updateSubkingdomDTO.SubkingdomNameLat);
            parameters.Add("@SubkingdomNameTr", updateSubkingdomDTO.SubkingdomNameTr);
            parameters.Add("@SubkingdomNameEn", updateSubkingdomDTO.SubkingdomNameEn);
            parameters.Add("@SubkingdomID", updateSubkingdomDTO.SubkingdomID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

