using System.Collections.Generic;
using System.Threading.Tasks;
using Macaroons;

namespace LSATAuthenticationHandler.MacaroonMinter
{
    public interface IServiceLimiter
    {
        Task<IEnumerable<Caveat>> ServiceCapabilities();
        Task<IEnumerable<Caveat>> ServiceConstraints();
    }
}