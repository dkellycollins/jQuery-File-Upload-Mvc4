using System.Web;
using System.Web.Optimization;

namespace jQuery_File_Upload_Mvc4
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            //Bootstrap bundles

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-migrate-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery.validate.js",
                "~/scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate.unobtrusive-custom-for-bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/content/bootstrap").Include(
                "~/Content/bootstrap.css",
                "~/Content/body.css",
                "~/Content/bootstrap-responsive.css",
                "~/Content/bootstrap-mvc-validation.css"
                ));

            //jQueryFileUpload bundles

            bundles.Add(new ScriptBundle("~/bundles/jQueryFileUplaod-basic").Include(
                    "~/Scripts/jquery.iframe-transport.js",
                    "~/Scripts/jquery.fileupload.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jQueryFileUplaod-basicplus").Include(
                    "~/Scripts/jquery.iframe-transport.js",
                    "~/Scripts/jquery.fileupload.js",
                    "~/Scripts/jquery.fileupload-process.js",
                    "~/Scripts/jquery.fileupload-resize.js",
                    "~/Scripts/jquery.fileupload-validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQueryFileUplaod-basicplusui").Include(
                    "~/Scripts/jquery.iframe-transport.js",
                    "~/Scripts/jquery.fileupload.js",
                    "~/Scripts/jquery.fileupload-process.js",
                    "~/Scripts/jquery.fileupload-resize.js",
                    "~/Scripts/jquery.fileupload-validate.js",
                    "~/Scripts/jquery.fileupload-ui.js",
                    "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQueryFileUplaod-angularjs").Include(
                    "~/Scripts/jquery.iframe-transport.js",
                    "~/Scripts/jquery.fileupload.js",
                    "~/Scripts/jquery.fileupload-process.js",
                    "~/Scripts/jquery.fileupload-resize.js",
                    "~/Scripts/jquery.fileupload-validate.js",
                    "~/Scripts/jquery.fileupload-angular.js",
                    "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/content/jQueryFileUpload").Include(
                "~/Content/jquery.fileupload-ui.css",
                "~/Content/style.css"
                ));

            bundles.Add(new StyleBundle("~/content/jQueryFileUpload-noscript").Include(
                "~/Content/jquery.fileupload-ui-noscript.css"));

            //Angular bundles

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js"));
        }
    }
}