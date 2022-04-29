using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.Models;

namespace exco_api.IService
{
    public interface ILendingService
    {
        Task<List<Lending>> GetAllLendings();
        Task<Lending> GetLendingById(int id);
    }
}