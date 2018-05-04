using Abp.AutoMapper;
using first_abp_02.Sessions.Dto;

namespace first_abp_02.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}