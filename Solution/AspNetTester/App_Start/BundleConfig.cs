﻿using System.Web;
using System.Web.Optimization;

namespace AspNetTester
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/forIE").Include("~/Scripts/html5shiv.min.js","~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/fractionslider").Include("~/Scripts/jquery.fractionslider.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scroller").Include("~/Scripts/smooth-scroll.js", "~/Scripts/skrollr.min.js", "~/Scripts/wow.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include("~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/init").Include("~/Scripts/init.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/Site.css", "~/Content/fractionslider.css", "~/Content/font-awesome.css", "~/Content/animate.css"));
			
			BundleTable.EnableOptimizations = false;
        }
    }
}
