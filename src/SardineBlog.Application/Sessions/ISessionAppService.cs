using System.Threading.Tasks;
using Abp.Application.Services;
using SardineBlog.Sessions.Dto;

namespace SardineBlog.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
