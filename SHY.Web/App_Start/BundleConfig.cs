using System.Web;
using System.Web.Optimization;
using SHY.Common;

namespace SHY.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include( "~/Assets/client/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/js/plugins").Include(
                 "~/Assets/admin/libs/jquery-ui/jquery-ui.min.js",
                 "~/Assets/admin/libs/mustache/mustache.js",
                 "~/Assets/admin/libs/numeral/numeral.js",
                 "~/Assets/admin/libs/jquery-validation/dist/jquery.validate.js",
                 "~/Assets/client/themes/js/jstarbox.js",
                 "~/Assets/client/themes/js/simpleCart.min.js",
                 "~/Assets/client/themes/js/bootstrap.min.js",
                 "~/Assets/client/themes/js/jquery.chocolat.js",
                 "~/Assets/client/themes/js/jquery.magnific-popup.js",
                 "~/Assets/client/js/common.js"
                ));

            bundles.Add(new StyleBundle("~/css/base")
                .Include("~/Assets/client/themes/css/bootstrap.css",new CssRewriteUrlTransform())
                .Include("~/Assets/client/font-awesome-4.6.3/css/font-awesome.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/themes/css/chocolat.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/themes/css/popuo-box.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/themes/css/jstarbox.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/themes/css/style.css", new CssRewriteUrlTransform())
                .Include("~/Assets/client/themes/css/style4.css", new CssRewriteUrlTransform())
                );
            BundleTable.EnableOptimizations = bool.Parse(ConfigHelper.GetByKey("EnableBundles"));
        }
    }
}
