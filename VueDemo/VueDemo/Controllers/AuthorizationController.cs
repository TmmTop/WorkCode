using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace VueDemo.Controllers
{
    //[Produces("application/json")]
    [Route("Auth/RequestToken")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// 登录获取token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] TokenRequest request)
        {
            if (request.Username == "admin" && request.Password == "123")
            {
                var claims = new[]
                {
                  new Claim(ClaimTypes.Name, request.Username)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    //issuer: "yourdomain.com",
                    //audience: "yourdomain.com",
                    claims: claims, 
                    expires: DateTime.Now,//发给客户端缓存的失效的开始时间（到了结束时间后计算之间的时间差，如果小于等于0则需要重新申请令牌）
                    signingCredentials: creds);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            return BadRequest("用户名或密码有误!");
        }
 
    }
    
    public class TokenRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}