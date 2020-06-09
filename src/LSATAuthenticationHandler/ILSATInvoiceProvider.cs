using System.Threading.Tasks;
using DotNetLightning.Payment;
using DotNetLightning.Utils;

namespace LSATAuthenticationHandler
{
    public interface ILSATInvoiceProvider
    {
        Task<PaymentRequest> GetNewInvoiceAsync(LNMoney amount);
    }
}