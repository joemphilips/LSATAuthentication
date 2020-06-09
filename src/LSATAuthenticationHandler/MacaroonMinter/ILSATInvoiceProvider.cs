using System.Threading.Tasks;
using DotNetLightning.Payment;
using DotNetLightning.Utils;

namespace LSATAuthenticationHandler.MacaroonMinter
{
    public interface ILSATInvoiceProvider
    {
        Task<PaymentRequest> GetNewInvoiceAsync(LNMoney price);
    }
}