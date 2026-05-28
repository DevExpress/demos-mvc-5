using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult Calendar() {            
            return DemoView("Calendar", new CalendarDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calendar([Bind] CalendarDemoOptions options) {            
            if(!string.IsNullOrEmpty(Request.Params["selectedDates"])) {
                string[] calendarSelection = Request.Params["selectedDates"].Split(',');
                DateTime[] selectedDates = new DateTime[calendarSelection.Length];
                for(int i = 0; i < calendarSelection.Length; i++) {
                    selectedDates[i] = DateTime.ParseExact(calendarSelection[i], "d", CultureInfo.InvariantCulture);
                }
                ViewData["SelectedDates"] = selectedDates;
            }
            if(options.DisableDates) {
                List<DateTime> disabledDates = new List<DateTime>();
                disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 7));
                disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 11));
                disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 13));
                disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 17));
                disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 19));
                ViewData["DisabledDates"] = disabledDates;
            }
            return DemoView("Calendar", options);
        }
    }
}
