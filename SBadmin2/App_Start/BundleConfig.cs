using System.Collections.Generic;
using System.Web.Optimization;

namespace SBadmin2
{
    public class BundleConfig
    {
        private const string CSS_PATH = "~/Content/";
        private const string JS_PATH = "~/Scripts/";

        public struct Bootstrap
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH + "bootstrap/";
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "bootstrap.css";
                public const string CDN = "//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css";
            }
            public struct Js
            {
                public const string VirtualPath = JS_PATH + "bootstrap.js";
                public const string CDN = "//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js";
            }
        }
        public struct SbAdmin2
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH;
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "sb-admin-2.css";
            }

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "sb-admin-2.js";
            }

            public struct Plugin
            {
                private const string CSS_PATH = SbAdmin2.CSS_PATH + "plugins/";
                private const string JS_PATH = SbAdmin2.JS_PATH + "plugins/";

                public struct MetisMenu
                {
                    private const string CSS_PATH = Plugin.CSS_PATH + "metisMenu/";
                    private const string JS_PATH = Plugin.JS_PATH + "metisMenu/";

                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "metisMenu.min.css";
                    }
                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "metisMenu.min.js";
                    }
                }
                public struct TimeLine
                {
                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "timeline.css";
                    }
                }
                public struct Morris
                {
                    private const string JS_PATH = Plugin.JS_PATH + "morris/";

                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "morris.css";
                    }
                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "morris.js";

                        static public string[] All
                        {
                            get
                            {
                                return new string[]{
                                        Rapheal.Js.VirtualPath,
                                        Js.VirtualPath,
                                        Data.Js.VirtualPath          
                                    };
                            }
                        }
                    }
                    public struct Data
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "morris-data.js";
                        }
                    }
                    public struct Rapheal
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "raphael.min.js";
                        }
                    }
                }
                public struct SocialButtons
                {
                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "social-buttons.css";
                    }
                }
                public struct Flot
                {
                    private const string JS_PATH = Plugin.JS_PATH + "flot/";

                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "jquery.flot.js";

                        static public string[] All
                        {
                            get
                            {
                                return new string[]{
                                        EXCANVAS.Js.VirtualPath,
                                        Js.VirtualPath,
                                        Pie.Js.VirtualPath,
                                        Resize.Js.VirtualPath,
                                        ToolTip.Js.VirtualPath,
                                        Data.Js.VirtualPath
                                    };
                            }
                        }
                    }
                    public struct EXCANVAS
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "excanvas.min.js";
                        }
                    }
                    public struct Data
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "flot-data.js";
                        }
                    }
                    public struct Pie
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.pie.js";
                        }
                    }
                    public struct Resize
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.resize.js";
                        }
                    }
                    public struct ToolTip
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.tooltip.js";
                        }
                    }
                }
            }
        }
        public struct FontAwesome
        {
            const string CSS_PATH = BundleConfig.CSS_PATH + "fontawesome/";

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "font-awesome.min.css";
                public const string CDN = "//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.2.0/css/font-awesome.min.css";
            }

        }
        public struct JQuery
        {
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "jquery-{version}.js";
                public const string CDN = "//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js";
            }

        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle(ScriptName.JQuery, JQuery.Js.CDN).Include(JQuery.Js.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Bootstrap, Bootstrap.Js.CDN).Include(Bootstrap.Js.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Flot).Include(SbAdmin2.Plugin.Flot.Js.All));
            bundles.Add(new ScriptBundle(ScriptName.Morris).Include(SbAdmin2.Plugin.Morris.Js.All));
            bundles.Add(new ScriptBundle(ScriptName.SbAdmin2).Include(
                                SbAdmin2.Plugin.MetisMenu.Js.VirtualPath,
                                SbAdmin2.Js.VirtualPath
                                ));

            bundles.Add(new StyleBundle(StyleName.Morris).Include(SbAdmin2.Plugin.Morris.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.SocialButtons).Include(SbAdmin2.Plugin.SocialButtons.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.Bootstrap, Bootstrap.Css.CDN).Include(Bootstrap.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.FontAwesome, FontAwesome.Css.CDN).Include(FontAwesome.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.SbAdmin2).Include(
                        SbAdmin2.Plugin.MetisMenu.Css.VirtualPath,
                        SbAdmin2.Plugin.TimeLine.Css.VirtualPath,
                        SbAdmin2.Css.VirtualPath
                ));
        }
    }
}