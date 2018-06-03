using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SardineBlog.MultiTenancy.Dto;

namespace SardineBlog.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
