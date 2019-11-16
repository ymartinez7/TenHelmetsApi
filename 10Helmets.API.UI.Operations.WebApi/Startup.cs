namespace _10Helmets.API.UI.Operations.WebApi
{
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;
    using _10Helmets.API.Core.Services;
    using _10Helmets.API.Infrastructure.Data.Context;
    using _10Helmets.API.Infrastructure.Data.Repositories;
    using _10Helmets.API.UI.Operations.WebApi.Mapper;
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.IO;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            // EF
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("10HelmetsConnectionString")));

            // Configuraciòn del auto mapeador
            var configuracionMapeo = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperConfig());
            });
            IMapper mapeador = configuracionMapeo.CreateMapper();
            services.AddSingleton(mapeador);

            // Service injection
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IActivityTypeService, ActivityTypeService>();
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<IProjectBudgetService, ProjectBudgetService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IServiceOrderService, ServiceOrderService>();

            // Repositories injection
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IActivityTypeRepository, ActivityTypeRepository>();
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddTransient<IProjectBudgetRepository, ProjectBudgetRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IServiceOrderRepository, ServiceOrderRepoitory>();

            // Enable MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Enable swagger
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                {
                    Title = "10Helmets APIs RESTful Operations"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                config.IncludeXmlComments(xmlPath);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("../swagger/v1/swagger.json", "Backend API Operations");
            });

            app.UseMvc();
        }
        #endregion
    }
}
