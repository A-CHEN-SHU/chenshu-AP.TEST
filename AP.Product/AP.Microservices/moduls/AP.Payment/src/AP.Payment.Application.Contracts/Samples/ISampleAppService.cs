using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AP.Payment.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
