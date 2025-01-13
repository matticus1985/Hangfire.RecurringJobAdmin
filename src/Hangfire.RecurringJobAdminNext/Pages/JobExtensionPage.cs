using Hangfire.Dashboard.Pages;
using Hangfire.RecurringJobAdminNext.Core;

namespace Hangfire.RecurringJobAdminNext.Pages
{
    internal sealed class JobExtensionPage : PageBase
    {
        public const string Title = "Job Configuration";
        public const string PageRoute = "/JobConfiguration";

        private static readonly string PageHtml;

        static JobExtensionPage()
        {
            PageHtml = Utility.ReadStringResource("Hangfire.RecurringJobAdminNext.Dashboard.JobExtension.html");
        }

        public override void Execute()
        {
            WriteEmptyLine();
            Layout = new LayoutPage(Title);
            WriteLiteralLine(PageHtml);
            WriteEmptyLine();
        }
    }
}
