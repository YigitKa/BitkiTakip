using System;
using Bitky_API.DTOs.SubclassDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.SubclassRepository
{
	public class SubclassRepository : ISubclassRepository
    {
        private readonly Context _context;
        public SubclassRepository(Context context)
        {
            _context = context;
        }

        public bool CreateSubclass(CreateSubclassDTO createSubclassDTO)
        {
            string query = "INSERT INTO Subclasses (SubclassNameLat, SubclassNameTr, SubclassNameEn)" +
                " VALUES (@SubclassNameLat, @SubclassNameTr, @SubclassNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@SubclassNameLat", createSubclassDTO.SubclassNameLat);
            parameters.Add("@SubclassNameTr", createSubclassDTO.SubclassNameTr);
            parameters.Add("@SubclassNameEn", createSubclassDTO.SubclassNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteSubclass(DeleteSubclassDTO deleteSubclassDTO)
        {
            string query = "DELETE FROM Subclasses WHERE SubclassID = @SubclassID";

            var parameters = new DynamicParameters();
            parameters.Add("@SubclassID", deleteSubclassDTO.SubclassID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultSubclassDTO>> GetAllSubclassesAsync()
        {
            string query = "SELECT SubclassID, SubclassNameLat, SubclassNameTr, SubclassNameEn FROM Subclasses";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultSubclassDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateSubclass(UpdateSubclassDTO updateSubclassDTO)
        {
            string query = "UPDATE Subclasses SET " +
               "SubclassNameLat = @SubclassNameLat," +
               "SubclassNameTr = @SubclassNameTr," +
               "SubclassNameEn = @SubclassNameEn " +
               "WHERE SubclassID = @SubclassID";

            var parameters = new DynamicParameters();
            parameters.Add("@SubclassNameLat", updateSubclassDTO.SubclassNameLat);
            parameters.Add("@SubclassNameTr", updateSubclassDTO.SubclassNameTr);
            parameters.Add("@SubclassNameEn", updateSubclassDTO.SubclassNameEn);
            parameters.Add("@SubclassID", updateSubclassDTO.SubclassID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

