using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class PaymentTypeService : BaseService<PaymentType>, IPaymentTypeService
    {
        public PaymentTypeService(IPaymentTypeRepository paymentTypeRepository)
            : base(paymentTypeRepository)
        {

        }
    }
}
