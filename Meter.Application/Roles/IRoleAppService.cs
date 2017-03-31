using System.Threading.Tasks;
using Abp.Application.Services;
using Meter.Roles.Dto;

namespace Meter.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
