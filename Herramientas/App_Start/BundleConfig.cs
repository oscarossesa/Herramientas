using System.Web;
using System.Web.Optimization;

namespace Herramientas
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
            
            //bundles.UseCdn = true;   //enable CDN support

            //add link to jquery on the CDN
            //var jqueryCdnPath = "https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js";

            //bundles.Add(new ScriptBundle("~/bundles/jquery", jqueryCdnPath).Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-2.1.4.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/handlebars").Include("~/Scripts/handlebars-v2.0.0.js"));
            //bundles.Add(new ScriptBundle("~/bundles/componentes").Include("~/Scripts/componentes/*.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/*.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}