namespace _10Helmets.API.UI.CentralManagement.WebApi.Controllers
{
    using _10Helmets.API.Core.DTOs;
    using _10Helmets.API.Core.Enums;
    using _10Helmets.API.Core.Interfaces.Services;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Net.Mime;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class OrganizationsController : BaseController
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private readonly IOrganizationService _organizationService;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="mapper"></param>
        /// <param name="environment"></param>
        /// <param name="organizationService"></param>
        public OrganizationsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            IOrganizationService organizationService) : base(configuration,
                  mapper,
                  environment)
        {
            this._organizationService = organizationService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                var organizations = await this._organizationService.FindAsync();

                if (organizations == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                organizations));
            }
            catch (Exception ex)
            {
                this.HandleException("OrganizationsController.Get()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }
        #endregion
    }
}