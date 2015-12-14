using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBadmin2
{
    public struct StyleName
    {
        //此目錄階層會影響~/Content/font
        private const string css = "~/Content/css/";
        public const string SbAdmin2 = css + "SbAdmin2";
        public const string SocialButtons = css + "SocialButtons";
        public const string Morris = css + "Morris";
        public static string FontAwesome = css + "FontAwesome";
        public static string Bootstrap = css + "Bootstrap";
    }

    public struct ScriptName
    {
        private const string js = "~/Scripts/";
        public const string Flot = js + "Flot";
        public const string Morris = js + "Morris";
        public const string JQuery = js + "JQuery";
        public const string Bootstrap = js + "Bootstrap";
        public const string SbAdmin2 = js + "SbAdmin2";
    }
}
