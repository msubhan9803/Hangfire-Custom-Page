using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Hangfire.Dashboard;
using Hangfire.Dashboard.Pages;
using Hangfire.Dashboard.Resources;

namespace WebAPI.Pages
{
    public class ManagementPage : RazorPage
    {
        public override void Execute()
        {
            WriteLiteral("\r\n");
            Layout = new LayoutPage("Management");

            // Reading Html file
            string html = File.ReadAllText("./Pages/management.html");

            WriteLiteral(html);
        }
    }
}