using System;
using System.Collections.Generic;
using Hangfire.Dashboard;

namespace WebAPI.Pages
{
    public static class ManagementSidebarMenu
    {
        public static readonly List<Func<RazorPage, MenuItem>> Items
            = new List<Func<RazorPage, MenuItem>>();

        static ManagementSidebarMenu()
        {
            Items.Add(page => new MenuItem("Index", page.Url.To("/management/index"))
            {
                Active = page.RequestPath.StartsWith("/management/index")
            });

            Items.Add(page => new MenuItem("Import", page.Url.To("/management/import"))
            {
                Active = page.RequestPath.StartsWith("/management/import")
            });

            Items.Add(page => new MenuItem("Misc", page.Url.To("/management/misc"))
            {
                Active = page.RequestPath.StartsWith("/management/misc")
            });

            Items.Add(page => new MenuItem("Email", page.Url.To("/management/email"))
            {
                Active = page.RequestPath.StartsWith("/management/email")
            });
        }
    }
}