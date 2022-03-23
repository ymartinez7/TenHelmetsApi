using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using TenHelmets.API.Core.DTOs;
using TenHelmets.API.Core.DTOs.Organizations;
using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Enums;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.WebApi.Controllers
{
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
            _organizationService = organizationService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ResponseDTO>> Get()
        {
            try
            {
                var organizations = await _organizationService.FindAsync();

                if (organizations == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        GetMessage((int)Message.InternalError),
                        null));
                }

                return Ok(new ResponseDTO(true,
                    GetMessage((int)Message.Correct),
                    _mapper.Map<List<OrganizationDetailDTO>>(organizations)));
            }
            catch (Exception ex)
            {
                HandleException("OrganizationsController.Get()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpGet("{organizationId}",Name = "GetById")]
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
                GetMessage((int)Message.Correct),
                _mapper.Map<OrganizationDetailDTO>(organization)));
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
        public async Task<ActionResult<ResponseDTO>> Post(OrganizationInput model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var organization = await this._organizationService.AddAsync(_mapper.Map<Organization>(model));

                if (organization == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        GetMessage((int)Message.InternalError),
                        null));
                }

                return CreatedAtAction("GetById",
                    new { organizationId = organization.Id },
                    organization);
            }
            catch (Exception ex)
            {
                HandleException("OrganizationsController.Post()",
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
        public async Task<ActionResult<ResponseDTO>> Put(int organizationId, OrganizationDetailDTO model)
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

                await this._organizationService.UpdateAsync(_mapper.Map<Organization>(model));

                return Ok(new ResponseDTO(true,
                GetMessage((int)Message.Correct),
                model));
            }
            catch (Exception ex)
            {
                HandleException("OrganizationsController.Put()",
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
                _mapper.Map<OrganizationDetailDTO>(organization)));
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