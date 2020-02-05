namespace _10Helmets.API.WebApi.Controllers
{
    using AutoMapper;
    using Core.DTOs;
    using Core.Entities;
    using Core.Enums;
    using Core.Interfaces.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Net.Mime;
    using System.Threading.Tasks;

    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class OrganizationsController : BaseController
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            IOrganizationService organizationService,
            ILogger<AccountsController> logger)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._organizationService = organizationService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ResponseDTO>> Get()
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

        [HttpGet("{organizationId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> GetById(int organizationId)
        {
            try
            {
                var organization = await this._organizationService.FindAsync(organizationId);

                if (organization == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                organization));
            }
            catch (Exception ex)
            {
                this.HandleException("OrganizationsController.GetById()",
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
        public async Task<ActionResult<ResponseDTO>> Post(Organization model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var organization = await this._organizationService.AddAsync(model);

                if (organization == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return CreatedAtAction("GetById",
                    new { id = organization.Id },
                    organization);
            }
            catch (Exception ex)
            {
                this.HandleException("OrganizationsController.Post()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPut("{organizationId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Put(int organizationId, Organization model)
        {
            try
            {
                if (model.Id != organizationId)
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

                await this._organizationService.UpdateAsync(model);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                model));
            }
            catch (Exception ex)
            {
                this.HandleException("OrganizationsController.Put()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpDelete("{organizationId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Delete(int organizationId)
        {
            try
            {
                var organization = await this._organizationService.FindAsync(organizationId);

                if (organization == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                await this._organizationService.DeleteAsync(organization);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                organization));
            }
            catch (Exception ex)
            {
                this.HandleException("OrganizationsController.Delete()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }
    }
}