using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using first_abp_02.MultiTenancy;

namespace first_abp_02.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}