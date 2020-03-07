using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Text;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;
using TenHelmets.API.Core.Services;
using TenHelmets.API.Infrastructure.Data.Context;
using TenHelmets.API.Infrastructure.Data.Repositories;
using TenHelmets.API.Infrastructure.Identity;
using TenHelmets.API.Infrastructure.Logging;
using TenHelmets.API.UI.CentralManagement.WebApi.Mapper;

namespace TenHelmets.API.UI.CentralManagement.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // EF
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("10HelmetsConnectionString")));

            // Identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

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
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IActivityTypeRepository, ActivityTypeRepository>();
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddTransient<IProjectBudgetRepository, ProjectBudgetRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IServiceOrderRepository, ServiceOrderRepoitory>();

            // Enable swagger
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                {
                    Title = "10Helmets API RESTful"
                });

                config.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "Inserte el token JWT con Bearer por delante",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                config.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Bearer", new string[] { } }
                });

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //config.IncludeXmlComments(xmlPath);
            });

            //JWT
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build();
            });

            var issuer = Configuration["Authentication:Issuer"];
            var audience = Configuration["Authentication:Audience"];
            var signingKey = Configuration["Authentication:SigningKey"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:SigningKey"])),
                    ClockSkew = TimeSpan.Zero
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

            // Enable MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile(@"C:\TenHelmetsLogs\Log-{Date}.txt");

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
    }
}