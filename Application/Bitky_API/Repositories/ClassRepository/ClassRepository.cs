using System;
using Bitky_API.DTOs.ClassDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.ClassRepository
{
	public class ClassRepository : IClassRepository
    {
        private readonly Context _context;
        public ClassRepository(Context context)
		{
            _context = context;
		}

        public bool CreateClass(CreateClassDTO createClassDTO)
        {
            string query = "INSERT INTO Classes (ClassNameLat, ClassNameTr, ClassNameEn)" +
                " VALUES (@classNameLat, @classNameTr, @classNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@classNameLat", createClassDTO.ClassNameLat);
            parameters.Add("@classNameTr", createClassDTO.ClassNameTr);
            parameters.Add("@classNameEn", createClassDTO.ClassNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount =Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteClass(DeleteClassDTO deleteClassDTO)
        {
            string query = "DELETE FROM Classes WHERE ClassID = @classID";

            var parameters = new DynamicParameters();
            parameters.Add("@classID", deleteClassDTO.ClassID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultClassDTO>> GetAllClassesAsync()
        {
            string query = "SELECT ClassID, ClassNameLat, ClassNameTr, ClassNameEn FROM Classes";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultClassDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateClass(UpdateClassDTO updateClassDTO)
        {
            string query = "UPDATE Classes SET " +
                "ClassNameLat = @classNameLat," +
                "ClassNameTr = @classNameTr," +
                "ClassNameEn = @classNameEn " +
                "WHERE ClassID = @classID";

            var parameters = new DynamicParameters();
            parameters.Add("@classNameLat", updateClassDTO.ClassNameLat);
            parameters.Add("@classNameTr", updateClassDTO.ClassNameTr);
            parameters.Add("@classNameEn", updateClassDTO.ClassNameEn);
            parameters.Add("@classID", updateClassDTO.ClassID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

