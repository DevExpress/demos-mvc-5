using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class CommonController : DemoController {

        [HttpGet]
        public ActionResult MaskedInput() {
            return DemoView("MaskedInput", new MaskedInputOptions());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MaskedInput([Bind] MaskedInputOptions options) {
            return DemoView("MaskedInput", options);
        }
    }
}
