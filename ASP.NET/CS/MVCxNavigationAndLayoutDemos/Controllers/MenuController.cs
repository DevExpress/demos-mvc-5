using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {
        public override string Name { get { return "Menu"; } }

        public ActionResult Index() {
            return DataBinding();
        }
    }
}
