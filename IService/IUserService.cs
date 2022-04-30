using System.Threading.Tasks;
using exco_api.Models;

namespace exco_api.IService
{
    public interface IUserService
    {
        Task<LoginResponse> UserLoging(Login user);
    }
}