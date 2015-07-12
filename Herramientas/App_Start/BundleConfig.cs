using System.Web.Optimization;

namespace Herramientas
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {            
            // Homer style
            bundles.Add(new StyleBundle("~/bundles/homer/css").Include(
                      "~/Content/style.css", new CssRewriteUrlTransform()));

            // Homer script
            bundles.Add(new ScriptBundle("~/bundles/homer/js").Include(
                      "~/Vendor/metisMenu/dist/metisMenu.min.js",
                      "~/Vendor/iCheck/icheck.min.js",
                      "~/Vendor/peity/jquery.peity.min.js",
                      "~/Vendor/sparkline/index.js",
                      "~/Scripts/homer.js",
                      "~/Scripts/charts.js"));

            // Animate.css
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                      "~/Vendor/animate.css/animate.min.css"));

            // Pe-icon-7-stroke
            bundles.Add(new StyleBundle("~/bundles/peicon7stroke/css").Include(
                      "~/Icons/pe-icon-7-stroke/css/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                      "~/Vendor/fontawesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Vendor/bootstrap/dist/css/bootstrap.min.css", new CssRewriteUrlTransform()));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Vendor/bootstrap/dist/js/bootstrap.min.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                      "~/Vendor/jquery/dist/jquery.min.js"));

            // handlebars
            bundles.Add(new ScriptBundle("~/bundles/handlebars/js").Include(
                      "~/Scripts/handlebars-v2.0.0.js"));

            // Datatables
            bundles.Add(new ScriptBundle("~/bundles/datatables/js").Include(
                      "~/Vendor/datatables/media/js/jquery.dataTables.min.js"));

            // Datatables bootstrap
            bundles.Add(new ScriptBundle("~/bundles/datatablesBootstrap/js").Include(
                      "~/Vendor/datatables_plugins/integration/bootstrap/3/dataTables.bootstrap.min.js"));

            // Datatables style
            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include(
                      "~/Vendor/datatables_plugins/integration/bootstrap/3/dataTables.bootstrap.css"));

            // Datatables tableTools script
            bundles.Add(new ScriptBundle("~/bundles/datatablesTool/js").Include(
                      "~/Scripts/dataTables.tableTools.js"));

            // Datatables tableTools style
            bundles.Add(new StyleBundle("~/bundles/dataTables.tableTools/css").Include(
                      "~/Content/dataTables.tableTools.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}