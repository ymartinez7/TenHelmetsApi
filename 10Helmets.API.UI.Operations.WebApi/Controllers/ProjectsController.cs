namespace _10Helmets.API.UI.Operations.WebApi.Controllers
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
    public class ProjectsController : BaseController
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private readonly IProjectService _projectService;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="mapper"></param>
        /// <param name="environment"></param>
        /// <param name="projectService"></param>
        public ProjectsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            IProjectService projectService) 
            : base(configuration,
                  mapper,
                  environment)
        {
            this._projectService = projectService;
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
                var organizations = await this._projectService.FindAsync();

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