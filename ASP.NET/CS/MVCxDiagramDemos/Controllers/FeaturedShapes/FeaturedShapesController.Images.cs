using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Models;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class FeaturedShapesController : DemoController {
        public ActionResult Images() {
            return DemoView("Images", OrgItemsDataProvider.LoadData());
        }
        public ActionResult ImagesPartial() {
            return PartialView("ImagesPartial", OrgItemsDataProvider.LoadData());
        }

        public ActionResult NodesAndEdgesUpdate(MVCxDiagramNodeUpdateValues<EditableOrgItem, int> nodeUpdateValues, MVCxDiagramEdgeUpdateValues<EditableOrgLink, int> edgeUpdateValues) {
            foreach(var item in nodeUpdateValues.Update)
                OrgItemsDataProvider.UpdateItem(item);
            foreach(var itemKey in nodeUpdateValues.DeleteKeys)
                OrgItemsDataProvider.DeleteItem(itemKey);
            foreach(var item in nodeUpdateValues.Insert) {
                var insertedItem = OrgItemsDataProvider.InsertItem(item);
                nodeUpdateValues.MapInsertedItemKey(item, insertedItem.ID);
            }

            foreach(var item in edgeUpdateValues.Update)
                OrgItemsDataProvider.UpdateLink(item);
            foreach(var itemKey in edgeUpdateValues.DeleteKeys)
                OrgItemsDataProvider.DeleteLink(itemKey);
            foreach(var item in edgeUpdateValues.Insert) {
                var insertedItem = OrgItemsDataProvider.InsertLink(item);
                edgeUpdateValues.MapInsertedItemKey(item, insertedItem.ID);
            }

            return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues, edgeUpdateValues);
        }
    }
}
