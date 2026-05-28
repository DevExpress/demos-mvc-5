using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public enum HeadphoneCardsSortMode { Recomended, Discount, LowPrice, HighPrice };

    public partial class CustomizationController : DemoController {
        public ActionResult Toolbar() {
            ViewBag.IsCardView = true;
            ViewBag.SortMode = HeadphoneCardsSortMode.Recomended;
            return DemoView("Toolbar", HeadphonesDataProvider.Headphones);
        }
        public ActionResult ToolbarPartial(bool? isCardView, HeadphoneCardsSortMode? sortMode) {
            ViewBag.IsCardView = isCardView ?? true;
            ViewBag.SortMode = sortMode ?? HeadphoneCardsSortMode.Recomended;
            return PartialView("ToolbarPartial", HeadphonesDataProvider.Headphones);
        }
    }
}
