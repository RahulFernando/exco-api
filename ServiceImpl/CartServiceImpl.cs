using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.EntityFrameworkCore;

namespace exco_api.ServiceImpl
{
    public class CartServiceImpl : ICartService
    {
        private readonly ExcoDbContext _context;

        public CartServiceImpl(ExcoDbContext context)
        {
            _context = context;
        }

        public async Task<Cart> AddToCart(Cart cart)
        {
            var exist = await _context.Carts.FirstOrDefaultAsync(c => c.userid == cart.userid);

            if (exist != null)
            {
                exist.items = cart.items;
            }
            else
            {
                await _context.Carts.AddAsync(cart);

            }

            await _context.SaveChangesAsync();

            return cart;
        }

        public async Task<Cart> GetCart(int id)
        {
            return await _context.Carts.Where(c => c.userid == id).Include(c => c.items).FirstAsync();
        }
    }
}