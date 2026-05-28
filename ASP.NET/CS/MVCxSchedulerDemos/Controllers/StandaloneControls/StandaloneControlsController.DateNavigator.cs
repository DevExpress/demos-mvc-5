using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class StandaloneControlsController: DemoController {
        public ActionResult DateNavigator() {
            return DemoView("DateNavigator", DateNavigatorDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DateNavigator([Bind]DateNavigatorDemoOptions options) {
            DateNavigatorDemoOptions = options;
            return DemoView("DateNavigator", options);
        }
        public ActionResult DateNavigatorPartial() {
            return PartialView("DateNavigatorPartial", DateNavigatorDemoOptions);
        }
        public ActionResult DateNavigatorAgendaPartial() {
            return PartialView("DateNavigatorAgendaPartial", DateNavigatorDemoOptions);
        }

        public const string DateNavigatorSessionName = "DateNavigatorDemoOptions";
        public DateNavigatorDemoOptions DateNavigatorDemoOptions {
            get {
                DateNavigatorDemoOptions demoOptions = Session[DateNavigatorSessionName] as DateNavigatorDemoOptions;
                return demoOptions != null ? demoOptions : new DateNavigatorDemoOptions();
            }
            set { Session[DateNavigatorSessionName] = value; }
        }
    }
}
