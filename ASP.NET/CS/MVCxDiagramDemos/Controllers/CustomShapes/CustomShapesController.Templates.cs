using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.ASPxDiagram;
using DevExpress.Web.Demos;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class CustomShapesController : DemoController {

        public ActionResult Templates() {
            ViewBag.DepartmentShapes = GetDepartmentShapes();
            ViewBag.DepartmentInfo = DepartmentDataProvider.GetDepartments();

            return DemoView("Templates", DepartmentDataProvider.GetEditableDepartments().Select(d => new { 
                ID = d.ID,
                Type = "dep" + d.ID,
                ParentID = d.ParentID
            }));
        }

        static IEnumerable<DiagramCustomShape> GetDepartmentShapes() {
            return DepartmentDataProvider.GetDepartments().Select(d =>
                new DiagramCustomShape {
                    Type = "dep" + d.ID,
                    BaseType = DiagramShapeType.Rectangle,
                    DefaultWidth = 2m,
                    DefaultHeight = 0.75m,
                    AllowEditText = false,
                    AllowResize = false
                }
            );
        }
        public ActionResult TemplatesUpdate(MVCxDiagramNodeUpdateValues<EditableDepartment, int> nodeUpdateValues) {
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
