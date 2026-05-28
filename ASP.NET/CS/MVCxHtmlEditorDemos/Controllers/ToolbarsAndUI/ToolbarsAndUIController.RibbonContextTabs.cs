using System;
using System.Web.Mvc;
using DevExpress.Utils;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using DevExpress.Web.Internal;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        public ActionResult RibbonContextTabs() {
            return DemoView("RibbonContextTabs");
        }
        public ActionResult RibbonContextTabsPartial() {
            return PartialView("RibbonContextTabsPartial");
        }
    }
}
