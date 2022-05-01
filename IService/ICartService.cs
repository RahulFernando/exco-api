using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.Models;

namespace exco_api.IService
{
    public interface ICartService
    {
        Task<Cart> AddToCart(Cart cart);
        Task<Cart> GetCart(int id);
        Task<Item> UpdateItem(Item item);
        Task SendMail(int id);
    }
}