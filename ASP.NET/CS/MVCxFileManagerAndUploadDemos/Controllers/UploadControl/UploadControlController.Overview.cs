using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class UploadControlController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
