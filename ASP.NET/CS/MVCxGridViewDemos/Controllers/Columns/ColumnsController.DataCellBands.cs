using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public ActionResult DataCellBands() {
            ViewBag.ColumnMoveMode = GridColumnMoveMode.ThroughHierarchy;
            return DemoView("DataCellBands", HomesDataProvider.Homes);
        }
        public ActionResult DataCellBandsPartial(GridColumnMoveMode columnMoveMode = GridColumnMoveMode.ThroughHierarchy) {
            ViewBag.ColumnMoveMode = columnMoveMode;
            return PartialView("DataCellBandsPartial", HomesDataProvider.Homes);
        }
    }
}
