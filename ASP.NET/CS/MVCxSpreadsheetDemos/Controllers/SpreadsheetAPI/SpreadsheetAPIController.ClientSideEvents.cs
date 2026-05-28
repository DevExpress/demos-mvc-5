using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public ActionResult ClientSideEvents() {
            return ClientSideEventsDemoView(new string[]{
                "Init",
                "SelectionChanged",
                "ViewModeChanged",
                "PopupMenuShowing",
                "HyperlinkClick",
                "CustomCommandExecuted",
                "CellEndEdit",
                "CellBeginEdit",
                "CellCancelEdit",
                "BeginSynchronization",
                "EndSynchronization"
            });
        }
        public ActionResult ClientSideEventsPartial() {
            return PartialView("ClientSideEventsPartial");
        }
    }
}
