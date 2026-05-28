using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class NavBarController: DemoController {
        public override string Name { get { return "NavBar"; } }

        public ActionResult Index() {
            return DataBinding();
        }
    }
}
