using System;
using Bitky_API.DTOs.SubclassDTOs;

namespace Bitky_API.Repositories.SubclassRepository
{
	public class SubclassRepository : ISubclassRepository
	{
		public SubclassRepository()
		{
		}

        public bool CreateSubclass(CreateSubclassDTO createSubclassDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSubclass(DeleteSubclassDTO deleteSubclassDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSubclassDTO>> GetAllSubclassesAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubclass(UpdateSubclassDTO updateSubclassDTO)
        {
            throw new NotImplementedException();
        }
    }
}

