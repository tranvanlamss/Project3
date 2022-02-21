using System.Web;
using System.Web.Optimization;

namespace RechargeOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // add css theme
            bundles.Add(new StyleBundle("~/adminLTE/css").Include(
                      "~/Content/adminLTE/plugins/fontawesome-free/css/all.min.css",
                       "~/Content/adminLTE/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                       "~/Content/adminLTE/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                       "~/Content/adminLTE/plugins/jqvmap/jqvmap.min.css",
                       "~/Content/adminLTE/dist/css/adminlte.min.css",
                       "~/Content/adminLTE/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                       "~/Content/adminLTE/plugins/daterangepicker/daterangepicker.css",
                       "~/Content/adminLTE/plugins/summernote/summernote-bs4.min.css"
                ));
            // add js theme
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/adminLTE/plugins/jquery/jquery.min.js",
                         "~/Content/adminLTE/plugins/jquery-ui/jquery-ui.min.js",
                         "~/Content/adminLTE/plugins/bootstrap/js/bootstrap.bundle.min.js",
                         "~/Content/adminLTE/plugins/chart.js/Chart.min.js",
                         "~/Content/adminLTE/plugins/sparklines/sparkline.js",
                         "~/Content/adminLTE/plugins/jqvmap/jquery.vmap.min.js",
                         "~/Content/adminLTE/plugins/jqvmap/maps/jquery.vmap.usa.js",
                         "~/Content/adminLTE/plugins/jquery-knob/jquery.knob.min.js",
                         "~/Content/adminLTE/plugins/moment/moment.min.js",
                         "~/Content/adminLTE/plugins/daterangepicker/daterangepicker.js",
                         "~/Content/adminLTE/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                         "~/Content/adminLTE/plugins/summernote/summernote-bs4.min.js",
                         "~/Content/adminLTE/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                         "~/Content/adminLTE/dist/js/adminlte.js",
                         "~/Content/adminLTE/dist/js/demo.js",
                         "~/Content/adminLTE/dist/js/pages/dashboard.js"
                ));
        }
    }
}
