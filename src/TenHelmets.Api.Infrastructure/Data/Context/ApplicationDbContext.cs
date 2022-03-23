using TenHelmets.API.Core.Entities;
using TenHelmets.API.Infrastructure.Data.Config;
using TenHelmets.API.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Context
{
    public sealed class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Espense> Espenses { get; set; }
        public DbSet<EspenseType> EspenseTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Cal> Cals { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertType> AlertTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Priority> Priotities { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceRequest> ResourceRequests { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Rol> Roles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectBudget> ProjectBudgets { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data source=localhost\\MSSQLSERVER_2012;Initial catalog=10Helmets;Persist Security Info=True;User= sa;Password=y18010611m")
        //        .EnableSensitiveDataLogging(true)
        //        .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        //}

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
    }
}
