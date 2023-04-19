using EStore.Model;
using EStore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EStore.Controllers
{
    [Authorize]
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAccountRepo _accountRepo;
        private readonly IConfiguration _config;

        public LoginController(IAccountRepo accountRepo, IConfiguration config)
        {
            _accountRepo = accountRepo;
            _config = config;
        }
        private string GenerateToken(account acc)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"],
                null, expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(account account)
        {
            IActionResult response = Unauthorized();
            var rs = _accountRepo.CheckExist(account);
            if (rs != null)
            {
                var token = GenerateToken(rs);
                response = Ok(new { token });
            }
            return response;
        }
    }
}
