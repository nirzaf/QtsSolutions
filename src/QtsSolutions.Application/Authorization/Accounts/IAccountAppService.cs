using System.Threading.Tasks;
using Abp.Application.Services;
using QtsSolutions.Authorization.Accounts.Dto;

namespace QtsSolutions.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
