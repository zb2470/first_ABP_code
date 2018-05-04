using Abp.Web.Mvc.Views;

namespace first_abp_02.Web.Views
{
    public abstract class first_abp_02WebViewPageBase : first_abp_02WebViewPageBase<dynamic>
    {

    }

    public abstract class first_abp_02WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected first_abp_02WebViewPageBase()
        {
            LocalizationSourceName = first_abp_02Consts.LocalizationSourceName;
        }
    }
}