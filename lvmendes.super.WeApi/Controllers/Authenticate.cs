﻿using Lvmendes.Prova.Entidade;
using Lvmendes.Super.WeApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Super.WeApi.Controllers
{
    public class AuthenticateController : Controller
    {

        //private UserManager<ApplicationUser> userManager;

        //public AuthenticateController(UserManager<ApplicationUser> userManager)
        //{
        //    //this.userManager = userManager;
        //}

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (model.Username == "123")
            {
                var authClaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, model.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("7S79jvOkEdwoRqHx"));
                var token = new JwtSecurityToken(
                    issuer: "https://dotnetdetail.net",
                    audience: "https://dotnetdetail.net",
                    expires: DateTime.Now.AddDays(5),
                    claims: authClaims,
                    signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }


      

    }
}
