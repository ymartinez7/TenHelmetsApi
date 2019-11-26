namespace _10Helmets.API.UI.Operations.WebApi.Controllers
{
    using _10Helmets.API.Core.DTOs;
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Enums;
    using _10Helmets.API.Core.Interfaces.Services;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Linq.Expressions;
    using System.Net.Mime;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [Route("Projects/{projectId}/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class ProjectBudgetsController : BaseController
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private readonly IProjectBudgetService _projectBudgetService;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="mapper"></param>
        /// <param name="environment"></param>
        /// <param name="projectBudgetService"></param>
        public ProjectBudgetsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            IProjectBudgetService projectBudgetService)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._projectBudgetService = projectBudgetService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Get(int projectId)
        {
            try
            {
                Expression<Func<ProjectBudget, bool>> expression = (p => p.ProjectId == projectId);

                var projectBudgets = await this._projectBudgetService.FindAsync(expression);

                if (projectBudgets == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                projectBudgets));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectBudgetsController.Get()",
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
        /// <param name="projectBudgetId"></param>
        /// <returns></returns>
        [HttpGet("{projectBudgetId}", Name = "GetProjectBudgetBypId")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> GetById(int projectBudgetId)
        {
            try
            {
                var projectBudget = await this._projectBudgetService.FindAsync(projectBudgetId);

                if (projectBudget == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                projectBudget));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectBudgetsController.GetById()",
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
        /// <param name="projectBudgetId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Post(int projectBudgetId, ProjectBudget model)
        {
            try
            {
                model.Id = projectBudgetId;

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var projectBudget = await this._projectBudgetService.AddAsync(model);

                if (projectBudget == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return CreatedAtRoute("GetProjectBudgetBypId",
                    projectBudget.Id,
                    projectBudget);
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectBudgetsController.Post()",
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
        /// <param name="projectBudgetId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{projectBudgetId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Put(int projectBudgetId, ProjectBudget model)
        {
            try
            {
                if (model.Id != projectBudgetId)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotEqualParameter),
                        ModelState));
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                await this._projectBudgetService.UpdateAsync(model);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                model));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectBudgetsController.Put()",
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
        /// <param name="projectBudgetId"></param>
        /// <returns></returns>
        [HttpDelete("{projectBudgetId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Delete(int projectBudgetId)
        {
            try
            {
                var projectBudget = await this._projectBudgetService.FindAsync(projectBudgetId);

                if (projectBudget == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                await this._projectBudgetService.DeleteAsync(projectBudget);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                projectBudget));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectBudgetsController.Delete()",
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