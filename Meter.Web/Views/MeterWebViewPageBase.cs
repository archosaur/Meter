using Abp.Web.Mvc.Views;

namespace Meter.Web.Views
{
    public abstract class MeterWebViewPageBase : MeterWebViewPageBase<dynamic>
    {

    }

    public abstract class MeterWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MeterWebViewPageBase()
        {
            LocalizationSourceName = MeterConsts.LocalizationSourceName;
        }
    }
}