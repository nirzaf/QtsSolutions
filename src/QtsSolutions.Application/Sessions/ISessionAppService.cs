using System.Threading.Tasks;
using Abp.Application.Services;
using QtsSolutions.Sessions.Dto;

namespace QtsSolutions.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
