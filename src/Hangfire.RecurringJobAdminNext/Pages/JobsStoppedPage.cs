using Hangfire.Dashboard.Pages;
using Hangfire.RecurringJobAdminNext.Core;

namespace Hangfire.RecurringJobAdminNext.Pages
{
    internal sealed class JobsStoppedPage : PageBase
    {
        public const string Title = "Stopped Jobs";
        public const string PageRoute = "/jobs/stopped";

        private static readonly string PageHtml;

        static JobsStoppedPage()
        {
            PageHtml = Utility.ReadStringResource("Hangfire.RecurringJobAdminNext.Dashboard.JobsStopped.html");
        }

        public override void Execute()
        {
            WriteEmptyLine();
            Layout = new LayoutPage(Title);
            Write(Html.JobsSidebar());
            WriteLiteralLine(PageHtml);
            WriteEmptyLine();
        }
    }
}
