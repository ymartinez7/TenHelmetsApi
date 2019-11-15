namespace _10Helmets.API.UI.CentralManagement.WebApi.Controllers
{
    using _10Helmets.API.Core.Enums;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System;

    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class BaseController : ControllerBase
    {
        #region Fields
        /// <summary>
        /// Mapea las entidades a viemodels
        /// </summary>
        protected readonly IMapper _mapper;

        /// <summary>
        /// Contiene las variables 
        /// de configuración de la aplicación
        /// </summary>
        protected readonly IConfiguration _configuration;

        /// <summary>
        /// 
        /// </summary>
        protected readonly IHostingEnvironment _environment;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="mapper"></param>
        /// <param name="environment"></param>
        public BaseController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment)
        {
            this._mapper = mapper;
            this._environment = environment;
            this._configuration = configuration;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueName"></param>
        /// <returns></returns>
        protected string GetConfigurationValue(string valueName)
        {
            return this._configuration.GetSection("AppSettings").GetSection(valueName).Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageCode"></param>
        /// <returns></returns>
        protected string GetMessage(int messageCode)
        {
            switch (messageCode)
            {
                case (int)Message.Correct:
                    return "Correcto";
                case (int)Message.RequestError:
                    return "Ha ocurrido un error en la llamada al API";
                case (int)Message.InternalError:
                    return "Ha ocurrido un error internp";
                case (int)Message.NullParameter:
                    return "Se envió un prámetro nulo al método";
                default:
                    throw new Exception("El código mensaje no corresponde a ninguno");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        protected void HandleException(string source,
            string description,
            string date)
        {
            //this._servicioLog.ErrorLogInsertar(strOrigen,
            //    strDescripcion,
            //    "0",
            //    this._configuracion.GetConnectionString("ISVConnectionString"));
        }
        #endregion
    }
}