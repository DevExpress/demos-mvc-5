using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {        
        public ActionResult ColorEditor(ColorEditDemoModel model) {
            return DemoView("ColorEditor", model);
        }
        public ActionResult ColorEditorRoundPanelPartial(RoundPanelAppearance roundPanelAppearance) {
            return PartialView("ColorEditorRoundPanelPartial", roundPanelAppearance);
        }
        public ActionResult ColorEditorColorSettingsPartial(ColorEditDemoModel model) {
            if (DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Color Editors updating.
                System.Threading.Thread.Sleep(500);
            return PartialView("ColorEditorColorSettingsPartial", model);
        }
    }
}
