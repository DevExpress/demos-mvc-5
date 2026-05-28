using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        [HttpGet]
        public ActionResult DetectingChanges() {            
            return DemoView("DetectingChanges", new DetectingChangesModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DetectingChanges([Bind] DetectingChangesModel model) {            
            return DemoView("DetectingChanges", model);
        }
    }
}
