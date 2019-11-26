namespace _10Helmets.API.UI.CentralManagement.WebApi.Controllers
{
    using _10Helmets.API.Core.DTOs;
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Enums;
    using _10Helmets.API.Infrastructure.Identity;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Net.Mime;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class AccountsController : BaseController
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// 
        /// </summary>
        private readonly SignInManager<User> _signInManager;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="mapper"></param>
        /// <param name="environment"></param>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AccountsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

                var user = new User { UserName = model.Email, Email = model.Email};
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Login(UserInfo model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var result = await this._signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Invalid logoin attempt.");
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.UserOrPasswordInvalid),
                        ModelState));
                }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private ActionResult BuildToken(UserInfo model)
        {
            var claims = new[] 
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["Secret_Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(5);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "yourdomain.com",
                audience: "yourdomain.com",
                claims: claims,
                expires: expiration,
                signingCredentials: credentials);

            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            });
        }
        #endregion
    }
}