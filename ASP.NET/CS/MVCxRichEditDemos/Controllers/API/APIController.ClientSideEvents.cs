using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class APIController : DemoController {
        public ActionResult ClientSideEvents() {
            ViewData["ClientSideEvents"] = new string[] {
                "ActiveSubDocumentChanged",
                "BeginSynchronization",
                "CharacterPropertiesChanged",
                "DocumentChanged",
                "DocumentLoaded",
                "EndSynchronization",
                "HyperlinkClick",
                "Init",
                "KeyDown",
                "KeyUp",
                "PointerDown",
                "PointerUp",
                "LostFocus",
                "GotFocus",
                "ParagraphPropertiesChanged",
                "PopupMenuShowing",
                "SelectionChanged",
                "DocumentFormatted",
                "ContentInserted",
                "ContentRemoved"
            };
            ViewData["ShowEventListPanel"] = true;
            return DemoView("ClientSideEvents");
        }
        public ActionResult ClientSideEventsPartial() {
            return PartialView("ClientSideEventsPartial");
        }
    }
}
