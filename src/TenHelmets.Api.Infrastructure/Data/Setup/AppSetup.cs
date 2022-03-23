namespace TenHelmets.API.Infrastructure.Data.Setup
{
    public sealed class AppSetup
    {
        private static readonly object _thread;
        private static AppSetup _instancia;

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

        static AppSetup()
        {
            _thread = new object();
        }
    }
}
