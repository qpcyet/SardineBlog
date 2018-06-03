using System.Threading.Tasks;
using Abp.Application.Services;
using SardineBlog.Authorization.Accounts.Dto;

namespace SardineBlog.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
