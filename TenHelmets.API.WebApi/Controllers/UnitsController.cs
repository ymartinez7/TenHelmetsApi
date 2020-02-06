using TenHelmets.API.Core.DTOs;
using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Enums;
using TenHelmets.API.Core.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Threading.Tasks;

namespace TenHelmets.API.WebApi.Controllers
{
    [Route("Organizations/{organizationId}/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class UnitsController : BaseController
    {
        private readonly IUnitService _unitService;

        public UnitsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            IUnitService unitService,
            ILogger<UnitsController> logger)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._unitService = unitService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> Get(int organizationId)
        {
            try
            {
                Expression<Func<Unit, bool>> expression = (p => p.OrganizationId == organizationId);

                var units = await this._unitService.FindAsync(expression);

                if (units == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                units));
            }
            catch (Exception ex)
            {
                this.HandleException("UnitsController.Get()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpGet("{unitId}", Name = "GetUnitById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> GetById(int unitId)
        {
            try
            {
                var unit = await this._unitService.FindAsync(unitId);

                if (unit == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                unit));
            }
            catch (Exception ex)
            {
                this.HandleException("UnitsController.GetById()",
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
        public async Task<ActionResult<ResponseDTO>> Post(int unitId, Unit model)
        {
            try
            {
                model.Id = unitId;

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var unit = await this._unitService.AddAsync(model);

                if (unit == null)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InternalError),
                        null));
                }

                return CreatedAtRoute("GetUnitById",
                    unit.Id,
                    unit);
            }
            catch (Exception ex)
            {
                this.HandleException("UnitsController.Post()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPut("{unitId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Put(int unitId, Unit model)
        {
            try
            {
                if (model.Id != unitId)
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

                await this._unitService.UpdateAsync(model);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                model));
            }
            catch (Exception ex)
            {
                this.HandleException("UnitsController.Put()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpDelete("{unitId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ResponseDTO>> Delete(int unitId)
        {
            try
            {
                var unit = await this._unitService.FindAsync(unitId);

                if (unit == null)
                {
                    return NotFound(new ResponseDTO(false,
                        this.GetMessage((int)Message.NotFound),
                        null));
                }

                await this._unitService.DeleteAsync(unit);

                return Ok(new ResponseDTO(true,
                this.GetMessage((int)Message.Correct),
                unit));
            }
            catch (Exception ex)
            {
                this.HandleException("UnitsController.Delete()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }
    }
}