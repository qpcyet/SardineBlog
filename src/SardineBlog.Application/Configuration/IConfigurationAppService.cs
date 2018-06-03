using System.Threading.Tasks;
using SardineBlog.Configuration.Dto;

namespace SardineBlog.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
