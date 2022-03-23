using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository employeeRepository)
            : base(employeeRepository)
        {

        }
    }
}
