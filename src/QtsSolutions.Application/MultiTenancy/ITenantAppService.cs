using Abp.Application.Services;
using QtsSolutions.MultiTenancy.Dto;

namespace QtsSolutions.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

