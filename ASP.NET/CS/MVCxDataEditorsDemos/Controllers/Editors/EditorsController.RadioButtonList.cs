using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult RadioButtonList() {            
            return DemoView("RadioButtonList", new CheckListDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadioButtonList([Bind] CheckListDemoOptions options) {            
            return DemoView("RadioButtonList", options);
        }
    }
}
