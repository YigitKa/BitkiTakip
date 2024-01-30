using System;
using Bitky_API.DTOs.KingdomDTOs;
using Bitky_API.DTOs.KingdomDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.KingdomRepository
{
	public class KingdomRepository : IKingdomRepository
    {
        private readonly Context _context;
        public KingdomRepository(Context context)
        {
            _context = context;
        }

        public bool CreateKingdom(CreateKingdomDTO createKingdomDTO)
        {
            string query = "INSERT INTO Kingdoms (KingdomNameLat, KingdomNameTr, KingdomNameEn)" +
                " VALUES (@KingdomNameLat, @KingdomNameTr, @KingdomNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@KingdomNameLat", createKingdomDTO.KingdomNameLat);
            parameters.Add("@KingdomNameTr", createKingdomDTO.KingdomNameTr);
            parameters.Add("@KingdomNameEn", createKingdomDTO.KingdomNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteKingdom(DeleteKingdomDTO deleteKingdomDTO)
        {
            string query = "DELETE FROM Kingdoms WHERE KingdomID = @KingdomID";

            var parameters = new DynamicParameters();
            parameters.Add("@KingdomID", deleteKingdomDTO.KingdomID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultKingdomDTO>> GetAllKingdomsAsync()
        {
            string query = "SELECT KingdomID, KingdomNameLat, KingdomNameTr, KingdomNameEn FROM Kingdoms";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultKingdomDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateKingdom(UpdateKingdomDTO updateKingdomDTO)
        {
            string query = "UPDATE Kingdoms SET " +
                "KingdomNameLat = @KingdomNameLat," +
                "KingdomNameTr = @KingdomNameTr," +
                "KingdomNameEn = @KingdomNameEn " +
                "WHERE KingdomID = @KingdomID";

            var parameters = new DynamicParameters();
            parameters.Add("@KingdomNameLat", updateKingdomDTO.KingdomNameLat);
            parameters.Add("@KingdomNameTr", updateKingdomDTO.KingdomNameTr);
            parameters.Add("@KingdomNameEn", updateKingdomDTO.KingdomNameEn);
            parameters.Add("@KingdomID", updateKingdomDTO.KingdomID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

