using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController: DemoController {
        public ActionResult Overview() {
            object folder = "~/Content/Images/widescreen";
            return DemoView("Overview", folder);
        }
    }
}
