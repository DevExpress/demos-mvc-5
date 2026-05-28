using DevExpress.XtraCharts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController: DemoController {
        public override string Name { get { return "Miscellaneous"; } }
        public int Angle { get; set; }           

        public ActionResult Index() {
            return RedirectToAction("HitTesting");
        }
    }
}
