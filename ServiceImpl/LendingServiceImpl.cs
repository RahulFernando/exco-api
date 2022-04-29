using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.EntityFrameworkCore;

namespace exco_api.ServiceImpl
{
    public class LendingServiceImpl : ILendingService
    {
        private readonly ExcoDbContext _context;

        public LendingServiceImpl(ExcoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lending>> GetAllLendings()
        {
            return await _context.Lendings.ToListAsync();
        }

        public async Task<Lending> GetLendingById(int id)
        {
            return await _context.Lendings.FindAsync(id);
        }
    }
}