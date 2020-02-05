namespace _10Helmets.API.Infrastructure.Data.Context
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Infrastructure.Data.Config;
    using _10Helmets.API.Infrastructure.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationDbContext : IdentityDbContext<User>
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Bill> Bills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Espense> Espenses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<EspenseType> EspenseTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<PaymentType> PaymentTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Provider> Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Purchase> Purchases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Sale> Sales { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<SaleDetail> SaleDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Inspection> Inspections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<InspectionType> InspectionTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Cal> Cals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Survey> Surveys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ActionType> ActionTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Alert> Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AlertType> AlertTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Brand> Brands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<File> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Model> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Organization> Organizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Priority> Priotities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Request> Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<RequestType> RequestTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Resource> Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ResourceRequest> ResourceRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ResourceType> ResourceTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Sector> Sectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Status> Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Unit> Units { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<DocumentType> DocumentTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //public DbSet<Rol> Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Activity> Activities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ActivityType> ActivityTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Note> Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProjectBudget> ProjectBudgets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data source=localhost\\MSSQLSERVER_2012;Initial catalog=10Helmets;Persist Security Info=True;User= sa;Password=y18010611m")
        //        .EnableSensitiveDataLogging(true)
        //        .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BillConfig());
            modelBuilder.ApplyConfiguration(new EspenseConfig());
            modelBuilder.ApplyConfiguration(new EspenseTypeConfig());
            modelBuilder.ApplyConfiguration(new PaymentTypeConfig());
            modelBuilder.ApplyConfiguration(new ProviderConfig());
            modelBuilder.ApplyConfiguration(new PurchaseConfig());
            modelBuilder.ApplyConfiguration(new PurchaseDetailConfig());
            modelBuilder.ApplyConfiguration(new SaleConfig());
            modelBuilder.ApplyConfiguration(new SaleDetailConfig());
            modelBuilder.ApplyConfiguration(new InspectionConfig());
            modelBuilder.ApplyConfiguration(new InspectionTypeConfig());
            modelBuilder.ApplyConfiguration(new ActionTypeConfig());
            modelBuilder.ApplyConfiguration(new AlertConfig());
            modelBuilder.ApplyConfiguration(new AlertTypeConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new FileConfig());
            modelBuilder.ApplyConfiguration(new ModelConfig());
            modelBuilder.ApplyConfiguration(new OrganizationConfig());
            modelBuilder.ApplyConfiguration(new PriorityConfig());
            modelBuilder.ApplyConfiguration(new RequestConfig());
            modelBuilder.ApplyConfiguration(new RequestTypeConfig());
            modelBuilder.ApplyConfiguration(new ResourceConfig());
            modelBuilder.ApplyConfiguration(new ResourceRequestConfig());
            modelBuilder.ApplyConfiguration(new ResourceTypeConfig());
            modelBuilder.ApplyConfiguration(new SectorConfig());
            modelBuilder.ApplyConfiguration(new StatusConfig());
            modelBuilder.ApplyConfiguration(new UnitConfig());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new ActivityConfig());
            modelBuilder.ApplyConfiguration(new ActivityTypeConfig());
            modelBuilder.ApplyConfiguration(new NoteConfig());
            modelBuilder.ApplyConfiguration(new ProjectBudgetConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new ServiceOrderConfig());
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
