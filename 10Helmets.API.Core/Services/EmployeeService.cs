namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeRepository"></param>
        public EmployeeService(IEmployeeRepository employeeRepository)
            : base(employeeRepository)
        {

        }
    }
}
