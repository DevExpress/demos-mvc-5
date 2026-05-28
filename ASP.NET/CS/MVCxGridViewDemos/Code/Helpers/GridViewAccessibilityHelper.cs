using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class GridViewAccessibilityDemoHelper {

        public static List<SelectListItem> GetLanguages() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "English", Value = "en" },
                new SelectListItem() { Text = "Deutsch", Value = "de" }
            };
        }
        public static void ApplyCurrentCulture(string language) {
            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == language)
                return;            
            var ci = CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);
        }
    }
}
