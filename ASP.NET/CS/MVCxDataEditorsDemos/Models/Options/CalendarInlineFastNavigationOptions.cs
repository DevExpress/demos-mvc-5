using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class CalendarInlineFastNavigationOptions {
        public CalendarInlineFastNavigationOptions() {
            MinZoomLevel = InlineFastNavigationZoomLevel.Century;
            EnablePeriodNavigation = true;
            ShowFastNavHeaderBackElement = true;
        }
        public InlineFastNavigationZoomLevel? MinZoomLevel { get; set; }
        public bool? EnablePeriodNavigation { get; set; }
        public bool? ShowFastNavHeaderBackElement { get; set; }
    }
}
