using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.Models;

namespace exco_api.IService
{
    public interface IReferenceService
    {
        Task<List<Reference>> GetAllReferences();
        Task<Reference> GetReferenceById(int id);
    }
}