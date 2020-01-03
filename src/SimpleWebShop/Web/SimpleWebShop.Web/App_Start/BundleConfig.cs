namespace SimpleWebShop.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/mdb.min.css",
                      "~/Content/css/style.css",
                      //"~/Content/css/sidebar.css",
                      "~/Content/css/sidebarBootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/AdminCss").Include(
                    "~/Content/css/adminPanel.css"));

            bundles.Add(new ScriptBundle("~/Content/js/bundles").Include(
                    "~/Content/js/jquery-3.4.1.min.js",
                    "~/Content/js/popper.min.js",
                    "~/Content/js/bootstrap.min.js",
                    "~/Content/js/mdb.min.js"));

            bundles.Add(new ScriptBundle("~/Content/js/scripts").Include(
                    "~/Content/js/loadCategories.js"));
        }
    }
}
