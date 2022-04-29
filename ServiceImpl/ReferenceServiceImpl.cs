using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.EntityFrameworkCore;

namespace exco_api.ServiceImpl
{
    public class ReferenceServiceImpl : IReferenceService
    {
        private readonly ExcoDbContext _context;

        public ReferenceServiceImpl(ExcoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Reference>> GetAllReferences()
        {
            return await _context.References.ToListAsync();
        }

        public async Task<Reference> GetReferenceById(int id)
        {
            return await _context.References.FindAsync(id);
        }
    }
}