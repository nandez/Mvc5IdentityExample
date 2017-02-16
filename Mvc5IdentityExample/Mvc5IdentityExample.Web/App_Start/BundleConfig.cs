using System.Web;
using System.Web.Optimization;

namespace Mvc5IdentityExample.Web
{
    public class BundleConfig
    {

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);

            

        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            // Site Styles
            bundles.Add(new StyleBundle("~/Styles/Boostrap").Include("~/Content/bootstrap.css",
                                                                     "~/Content/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Styles/SiteStyle").Include("~/Content/site.css"));


            // Plugin Styles
            bundles.Add(new StyleBundle("~/Styles/Plugins/BootgridStyle").Include("~/Content/jquery.bootgrid.min.css"));
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            // Site Main Scripts
            bundles.Add(new ScriptBundle("~/Scripts/JQuery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Scripts/JQueryVal").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/Scripts/Modernizr").Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include("~/Scripts/bootstrap.js",
                                                                        "~/Scripts/respond.js"));

            // Plugins Scripts
            bundles.Add(new ScriptBundle("~/Scripts/Plugins/BootgridScript").Include("~/Scripts/jquery.bootgrid.min.js",
                                                                                     "~/Scripts/jquery.bootgrid.fa.min.js"));
        }
    }
}
    
