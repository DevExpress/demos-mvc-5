using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {
        public ActionResult PopupMenu() {
            return DemoView("PopupMenu", new PopupMenuOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PopupMenu([Bind]PopupMenuOptions options) {
            return DemoView("PopupMenu", options);
        }
        public ActionResult PopupMenuGridViewPartial(string sortColumn) {
            ViewBag.SortColumn = sortColumn;
            return PartialView("PopupMenuGridViewPartial", PopulationAreaProvider.GetPopulationAreaStructure());
        }
    }
}
