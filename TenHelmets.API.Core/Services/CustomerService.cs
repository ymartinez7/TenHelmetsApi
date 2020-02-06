using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class CustomerService : BaseService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {

        }
    }
}
