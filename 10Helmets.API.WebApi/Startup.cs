﻿namespace _10Helmets.API.UI.CentralManagement.WebApi
{
    using _10Helmets.API.Core.Interfaces.Cross_cutting;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;
    using _10Helmets.API.Core.Services;
    using _10Helmets.API.Infrastructure.Data.Context;
    using _10Helmets.API.Infrastructure.Data.Repositories;
    using _10Helmets.API.Infrastructure.Identity;
    using _10Helmets.API.Infrastructure.Logging;
    using _10Helmets.API.UI.CentralManagement.WebApi.Mapper;
    using AutoMapper;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;
    using Serilog;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

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

            // Identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => 
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "yourdomain.com",
                    ValidAudience = "yourdomain.com",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Secret_Key"])),
                    ClockSkew = TimeSpan.Zero
                });

            // Configuraciòn del auto mapeador
            var configuracionMapeo = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperConfig());
            });
            IMapper mapeador = configuracionMapeo.CreateMapper();
            services.AddSingleton(mapeador);

            // Service injection
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddTransient<IActionTypeService, ActionTypeService>();
            services.AddTransient<IAlertService, AlertService>();
            services.AddTransient<IAlertTypeService, AlertTypeService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IModelService, ModelService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IPriorityService, PriorityService>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IRequestTypeService, RequestTypeService>();
            services.AddTransient<IResourceRequestService, ResourceRequestService>();
            services.AddTransient<IResourceService, ResourceService>();
            services.AddTransient<IResourceTypeService, ResourceTypeService>();
            services.AddTransient<ISectorService, SectorService>();
            services.AddTransient<IUnitService, UnitService>();
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IActivityTypeService, ActivityTypeService>();
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<IProjectBudgetService, ProjectBudgetService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IServiceOrderService, ServiceOrderService>();

            // Repositories injection
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IActionTypeRepository, ActionTypeRepository>();
            services.AddTransient<IAlertRepository, AlertRepository>();
            services.AddTransient<IAlertTypeRepository, AlertTypeRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IModelRepository, ModelRepository>();
            services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            services.AddTransient<IPriorityRepository, PriorityRepository>();
            services.AddTransient<IRequestRepository, RequestRepository>();
            services.AddTransient<IRequestTypeRepository, RequestTypeRepository>();
            services.AddTransient<IResourceRequestRepository, ResourceRequestRepository>();
            services.AddTransient<IResourceRepository, ResourceRepository>();
            services.AddTransient<IResourceTypeRepository, ResourceTypeRepository>();
            services.AddTransient<ISectorRepository, SectorRepository>();
            services.AddTransient<IUnitRepository, UnitRepository>();
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
                    Title = "10Helmets API RESTful"
                });

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //config.IncludeXmlComments(xmlPath);
            });

            // Logger
            services.AddScoped(typeof(IApplicationLogger<>), typeof(LoggerAdapter<>));
            services.AddSingleton<Serilog.ILogger>(options =>
            {
                var connectionString = Configuration["ConnectionStrings:10HelmetsConnectionString"];
                var tableName = "Logs";
                return new LoggerConfiguration().WriteTo.MSSqlServer(connectionString,
                    tableName, 
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning,
                    autoCreateSqlTable: true).CreateLogger();
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile(@"C:\10HelmetsLogs\Log-{Date}.txt");

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
                config.SwaggerEndpoint("../swagger/v1/swagger.json", "10Helmets API");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
        #endregion
    }
}