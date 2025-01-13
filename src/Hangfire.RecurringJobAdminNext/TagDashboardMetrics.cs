using Hangfire.Dashboard;
using Hangfire.RecurringJobAdminNext.Core;

namespace Hangfire.RecurringJobAdminNext
{
    public static class TagDashboardMetrics
    {
        public static readonly DashboardMetric JobsStoppedCount = new DashboardMetric("JobsStopped:count", razorPage =>
            {
                return new Metric(JobAgent.GetAllJobStopped().Count);
            });
    }
}
