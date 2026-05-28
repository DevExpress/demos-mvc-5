using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        [HttpGet]
        public ActionResult NullText() {            
            return DemoView("NullText", new NullTextOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NullText([Bind] NullTextOptions options) {            
            return DemoView("NullText", options);
        }
    }
}
