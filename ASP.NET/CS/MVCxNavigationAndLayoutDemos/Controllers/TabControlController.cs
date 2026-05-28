using System;
using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TabControlController: DemoController {
        public override string Name { get { return "TabControl"; } }

        public ActionResult Index() {
            return DataBindingToXML();
        }
    }
}
