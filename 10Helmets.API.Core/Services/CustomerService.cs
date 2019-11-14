namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CustomerService : BaseService<Customer>, ICustomerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerRepository"></param>
        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {

        }
    }
}
