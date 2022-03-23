using TenHelmets.API.Infrastructure.Logging;
using AutoMapper;
using TenHelmets.API.Core.DTOs;
using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Enums;
using TenHelmets.API.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TenHelmets.API.WebApi.Controllers
{
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class AccountsController : BaseController
    {
        protected readonly ILogger<AccountsController> _logger;
        protected readonly Serilog.ILogger _seriLogger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<AccountsController> logger,
            Serilog.ILogger seriLogger)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._logger = logger;
            this._seriLogger = seriLogger;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpPost]
        [Route("Create")]
        [AllowAnonymous]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> CreateUser(UserInfo model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var user = new User { UserName = model.Email, Email = model.Email };
                var result = await this._userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.UserOrPasswordInvalid),
                        null));
                }

                return BuildToken(model);
            }
            catch (Exception ex)
            {
                this.HandleException("AccountController.CreateUser()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [AllowAnonymous]
        public async Task<ActionResult<ResponseDTO>> Login(UserInfo model)
        {
            try
            {
                //this._logger.LogWarning("Inicio del método: Login");
                //this._seriLogger.Warning("Inicio del método: Login");

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var signInResult = await this._signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (!signInResult.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.UserOrPasswordInvalid),
                        ModelState));
                }

                //this._logger.LogWarning("Final del método: Login");
                //this._seriLogger.Warning("Inicio del método: Login");

                return BuildToken(model);
            }
            catch (Exception ex)
            {
                this.HandleException("AccountController.Login()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        private ActionResult BuildToken(UserInfo model)
        {
            /*  Todo: colocar log de trazas de inicio
             *  long date = Utilities.InitMethod(log, "BuildToken");
             */

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["Authentication:SigningKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(2);

            var token = new JwtSecurityToken(
                issuer: this._configuration["Authentication:Issuer"],
                audience: this._configuration["Authentication:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: credentials);

            //return Ok(new
            //{
            //    new JwtSecurityTokenHandler().WriteToken(token),
            //    //Token = new JwtSecurityTokenHandler().WriteToken(token),
            //    //Expiration = expiration
            //});

            /*  Todo: colocar log de trazas de fin
             *  Utilities.EndMethod(log, "BuildToken", date);
             */

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}