using DevExpress.Web.Demos;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class DataBindingController : DemoController {
        public ActionResult Linear() {
            return DemoView("Linear", DepartmentDataProvider.GetEditableDepartments());
        }
        public ActionResult LinearUpdate(MVCxDiagramNodeUpdateValues<EditableDepartment, int> nodeUpdateValues) {
            foreach(var item in nodeUpdateValues.Update)
                DepartmentDataProvider.Update(item);
            foreach(var itemKey in nodeUpdateValues.DeleteKeys)
                DepartmentDataProvider.Delete(itemKey);
            foreach(var item in nodeUpdateValues.Insert) {
                var insertedItem = DepartmentDataProvider.Insert(item);
                nodeUpdateValues.MapInsertedItemKey(item, insertedItem.ID);
            }
            return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues);
        }
    }
}
