using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult TokenBox() {            
            return DemoView("TokenBox", new TokenBoxOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TokenBox([Bind] TokenBoxOptions options) {            
            return DemoView("TokenBox", options);
        }
    }
}
