using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public override string Name { get { return "Columns"; } }
     
        public ActionResult Index() {
            return RedirectToAction("Bands");
        }
    }
}
