using System;
using Bitky_API.DTOs.GenusDTOs;
using Bitky_API.DTOs.GenusDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.GenusRepository
{
	public class GenusRepository : IGenusRepository
    {
        private readonly Context _context;
        public GenusRepository(Context context)
        {
            _context = context;
        }

        public bool CreateGenus(CreateGenusDTO createGenusDTO)
        {
            string query = "INSERT INTO Genuses (GenusNameLat, GenusNameTr, GenusNameEn)" +
                 " VALUES (@GenusNameLat, @GenusNameTr, @GenusNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@GenusNameLat", createGenusDTO.GenusNameLat);
            parameters.Add("@GenusNameTr", createGenusDTO.GenusNameTr);
            parameters.Add("@GenusNameEn", createGenusDTO.GenusNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteGenus(DeleteGenusDTO deleteGenusDTO)
        {
            string query = "DELETE FROM Genuses WHERE GenusID = @GenusID";

            var parameters = new DynamicParameters();
            parameters.Add("@GenusID", deleteGenusDTO.GenusID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultGenusDTO>> GetAllGenusesAsync()
        {
            string query = "SELECT GenusID, GenusNameLat, GenusNameTr, GenusNameEn FROM Genuses";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultGenusDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateGenus(UpdateGenusDTO updateGenusDTO)
        {
            string query = "UPDATE Genuses SET " +
                "GenusNameLat = @GenusNameLat," +
                "GenusNameTr = @GenusNameTr," +
                "GenusNameEn = @GenusNameEn " +
                "WHERE GenusID = @GenusID";

            var parameters = new DynamicParameters();
            parameters.Add("@GenusNameLat", updateGenusDTO.GenusNameLat);
            parameters.Add("@GenusNameTr", updateGenusDTO.GenusNameTr);
            parameters.Add("@GenusNameEn", updateGenusDTO.GenusNameEn);
            parameters.Add("@GenusID", updateGenusDTO.GenusID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

