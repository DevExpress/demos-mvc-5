using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TreeViewController: DemoController {
        public override string Name { get { return "TreeView"; } }

        public ActionResult Index() {
            return DataBindingToXML();
        }
    }
}
