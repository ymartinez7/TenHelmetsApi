namespace _10Helmets.API.Infrastructure.Data.Setup
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AppSetup
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private static readonly object _thread;

        /// <summary>
        /// 
        /// </summary>
        private static AppSetup _instancia;
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public static AppSetup ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_thread)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new AppSetup();
                        }
                    }
                }
                return _instancia;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        private AppSetup()
        {
            //var configurationBuilder = new ConfigurationBuilder();
            //var ruta = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            //configurationBuilder.AddJsonFile(ruta, false);

            //var root = configurationBuilder.Build();

            //// Obtiene la cadena de conexión
            //ConnectionString = root.GetConnectionString("ISVConnectionString");

            //// Obtiene los Key de configuración
            //var appSetting = root.GetSection("AppSettings");
            //this.TimeOut = int.Parse(appSetting["TimeOut"]);
        }

        /// <summary>
        /// 
        /// </summary>
        static AppSetup()
        {
            _thread = new object();
        }
        #endregion
    }
}
