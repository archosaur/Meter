using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Meter.MultiTenancy;

namespace Meter.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}