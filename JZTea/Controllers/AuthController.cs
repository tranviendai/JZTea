using Azure;
using JZTea.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using JZTea.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Authorization;

namespace Librarian.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly JZTeaContext _context;

        public AuthController(JZTeaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        private string hashPass(string pass)
        {
            var sha = SHA256.Create();
            var asByteArr = Encoding.Default.GetBytes(pass);
            var hash = sha.ComputeHash(asByteArr);
            return Convert.ToBase64String(hash);
        }
        [HttpGet("current")]
        [Authorize]
        public async Task<ActionResult<Product>> getCurrentUser()
        {
            string id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _context.User.FirstOrDefault(e => e.UserName == id);
                return Ok(user);
            
        }
        [HttpPost]
        [Route("login")]
        public ActionResult<User> Login([FromBody] MLoginModel model)
        {
            string password = hashPass(model.PasswordHash);
            var user = _context.User.Where(u => u.UserName == model.Username && u.PasswordHash == password).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("UserName and Password is incorrect");
            }
            if (_context.User == null) return NotFound();
            string token = GenerateToken(user);
            return Ok(token);
        }
        // To generate token
        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserName)
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Token").Value!));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );
            var jwt  = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        //api/Auth
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] MSignUpModel model)
        {
            try
            {
                string password = hashPass(model.Password);
                var user = await _context.User.Where(u => u.UserName == model.UserName).FirstOrDefaultAsync();
                if (user != null)
                {
                    return BadRequest("UserName already exists");
                }
                else
                {
                    User u = new User();
                    u.Id = Guid.NewGuid().ToString();
                    u.UserName = model.UserName;
                    u.PasswordHash = password;
                    u.DateCreated = DateTime.Now;
                    u.Image = "https://www.nicepng.com/png/full/128-1280406_view-user-icon-png-user-circle-icon-png.png";
                    u.IsActive = true;
                    u.FullName = model.FullName;
                    u.PhoneNumber = "";
                    u.Email = "";
                    u.Role = "EMPLOYEE";
                    _context.User.Add(u);
                    await _context.SaveChangesAsync();
                    return Ok("User is successfully registered");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
