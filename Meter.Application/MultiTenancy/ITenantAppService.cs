using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Meter.MultiTenancy.Dto;

namespace Meter.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
