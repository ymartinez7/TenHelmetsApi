using TenHelmets.API.Core.DTOs;
using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Enums;
using TenHelmets.API.Core.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace TenHelmets.API.WebApi.Controllers
{
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class ProjectsController : BaseController
    {
        private readonly IProjectService _projectService;


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


        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Get()
        {
            try
            {
                var projects = await this._projectService.FindAsync();

                if (projects == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                projects));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectsController.Get()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpGet("{projectId}", Name ="GetProjectById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> GetById(int projectId)
        {
            try
            {
                var project = await this._projectService.FindAsync(projectId);

                if (project == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                project));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectsController.GetById()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Post(Project model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var project = await this._projectService.AddAsync(model);

                if (project == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return CreatedAtRoute("GetProjectById", 
                    project.Id, 
                    project);
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectsController.Post()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPut("{projectId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Put(int projectId, Project model)
        {
            try
            {
                if (model.Id != projectId)
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

                await this._projectService.UpdateAsync(model);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                model));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectsController.Put()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpDelete("{projectId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Delete(int projectId)
        {
            try
            {
                var project = await this._projectService.FindAsync(projectId);

                if (project == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                await this._projectService.DeleteAsync(project);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                project));
            }
            catch (Exception ex)
            {
                this.HandleException("ProjectsController.Delete()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }
    }
}