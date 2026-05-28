using System.Web.Mvc;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult AgendaView() {
            return DemoView("AgendaView", AgendaViewDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgendaView([Bind]SchedulerAgendaViewDemoOptions options) {
            AgendaViewDemoOptions = options;
            return DemoView("AgendaView", options);
        }
        public ActionResult AgendaViewPartial() {
            return PartialView("AgendaViewPartial", AgendaViewDemoOptions);
        }

        public const string AgendaViewSessionName = "AgendaViewDemoOptions";
        public SchedulerAgendaViewDemoOptions AgendaViewDemoOptions {
            get {
                SchedulerAgendaViewDemoOptions demoOptions = Session[AgendaViewSessionName] as SchedulerAgendaViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerAgendaViewDemoOptions();
            }
            set { Session[AgendaViewSessionName] = value; }
        }
    }
}
