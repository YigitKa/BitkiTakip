using System;
using Bitky_API.DTOs.ClassDTOs;

namespace Bitky_API.Repositories.ClassRepository
{
	public interface IClassRepository
    {
        Task<List<ResultClassDTO>> GetAllClassesAsync();
        bool DeleteClass(DeleteClassDTO deleteClassDTO);
        bool UpdateClass(UpdateClassDTO updateClassDTO);
        bool CreateClass(CreateClassDTO createClassDTO);
    }
}

