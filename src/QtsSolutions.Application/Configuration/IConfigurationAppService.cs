using System.Threading.Tasks;
using QtsSolutions.Configuration.Dto;

namespace QtsSolutions.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
