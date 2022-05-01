using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace exco_api.ServiceImpl
{
    public class CartServiceImpl : ICartService
    {
        private readonly ExcoDbContext _context;
        private readonly IConfiguration _config;

        public CartServiceImpl(ExcoDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
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

        public async Task SendMail(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user != null)
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_config["MailSettings:Mail"]);
                email.To.Add(MailboxAddress.Parse(user.email));
                email.Subject = "Overdue";

                var builder = new BodyBuilder();
                builder.HtmlBody = "You book has overdue";
                email.Body = builder.ToMessageBody();

                var smtp = new SmtpClient();
                smtp.Connect(_config["MailSettings:Host"], int.Parse(_config["MailSettings:Port"]), SecureSocketOptions.StartTls);
                smtp.Authenticate(_config["MailSettings:Mail"], _config["MailSettings:Password"]);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }

        public async Task<Item> UpdateItem(Item item)
        {
            var itemObj = await _context.Items.FindAsync(item.id);

            if (itemObj != null)
            {
                itemObj = item;

                await _context.SaveChangesAsync();
            }

            return itemObj;

        }
    }
}