using System.Threading.Tasks;
using Hangfire.Annotations;
using Hangfire.RecurringJobAdminNext.Core;
using Newtonsoft.Json;

namespace Hangfire.RecurringJobAdminNext.Pages
{
    internal sealed class GetTimeZonesDispatcher : Dashboard.IDashboardDispatcher
    {
        public async Task Dispatch([NotNull] Dashboard.DashboardContext context)
        {
            await context.Response.WriteAsync(JsonConvert.SerializeObject(Utility.GetTimeZones()));
        }
    }
}
