namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PaymentTypeService : BaseService<PaymentType>, IPaymentTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentTypeRepository"></param>
        public PaymentTypeService(IPaymentTypeRepository paymentTypeRepository)
            : base(paymentTypeRepository)
        {

        }
    }
}
