using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceCustomizationController: DemoController {
        public ActionResult ConditionalFormatting() {
            return DemoView("ConditionalFormatting", HomesDataProvider.Homes);
        }
        public ActionResult ConditionalFormattingPartial() {
            return PartialView("ConditionalFormattingPartial", HomesDataProvider.Homes);
        }
    }
}
