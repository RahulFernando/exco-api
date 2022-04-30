using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Security.Claims;

namespace exco_api.ServiceImpl
{
    public class UserServiceImpl : IUserService
    {
        private readonly ExcoDbContext _context;
        private IConfiguration _config;

        public UserServiceImpl(ExcoDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        private string GenereateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("user_id", user.id.ToString()),
                new Claim("user_role", user.user_type.ToString()),
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"], claims, expires: System.DateTime.Now.AddHours(4), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<LoginResponse> UserLoging(Login user)
        {
            var obj = await _context.Users.FirstOrDefaultAsync(u => u.user_name == user.password);

            if (obj != null)
            {
                bool verified = BCrypt.Net.BCrypt.Verify(user.password, obj.password);

                if (verified)
                {
                    var token = GenereateToken(obj);
                    return new LoginResponse()
                    {
                        user_name = obj.user_name,
                        token = token
                    };
                }
            }

            return null;
        }
    }
}