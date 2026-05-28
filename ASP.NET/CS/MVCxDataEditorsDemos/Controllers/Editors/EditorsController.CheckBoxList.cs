using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult CheckBoxList() {            
            return DemoView("CheckBoxList", new CheckListDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckBoxList([Bind] CheckListDemoOptions options) {            
            return DemoView("CheckBoxList", options);
        }
    }
}
