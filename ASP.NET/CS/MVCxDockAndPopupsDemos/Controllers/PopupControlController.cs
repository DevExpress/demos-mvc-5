using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PopupControlController: DemoController {
        public override string Name { get { return "PopupControl"; } }

        public ActionResult Index() {
            return DataBinding();
        }
    }
}
