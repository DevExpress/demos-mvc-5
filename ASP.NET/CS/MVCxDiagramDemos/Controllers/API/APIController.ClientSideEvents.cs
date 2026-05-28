using DevExpress.Web.Demos.Models;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class APIController : DemoController {
        public ActionResult ClientSideEvents() {
            ViewData["ShowEventListPanel"] = true;
            ViewData["ClientSideEvents"] = new string[] {
                "ItemClick",
                "ItemDblClick",
                "SelectionChanged",
                "DiagramChanged",
                "BeginSynchronization",
                "EndSynchronization",
                "Init"
            };

            return DemoView("ClientSideEvents", WorkflowDataProvider.LoadData());
        }

        public ActionResult ClientSideEventsUpdate(MVCxDiagramNodeUpdateValues<EditableFlowObject, int> nodeUpdateValues, MVCxDiagramEdgeUpdateValues<EditableFlowConnection, int> edgeUpdateValues) {
            foreach(var item in nodeUpdateValues.Update)
                WorkflowDataProvider.UpdateObject(item);
            foreach(var itemKey in nodeUpdateValues.DeleteKeys)
                WorkflowDataProvider.DeleteObject(itemKey);
            foreach(var item in nodeUpdateValues.Insert) {
                var insertedItem = WorkflowDataProvider.InsertObject(item);
                nodeUpdateValues.MapInsertedItemKey(item, insertedItem.ID);
            }

            foreach(var item in edgeUpdateValues.Update)
                WorkflowDataProvider.UpdateConnection(item);
            foreach(var itemKey in edgeUpdateValues.DeleteKeys)
                WorkflowDataProvider.DeleteConnection(itemKey);
            foreach(var item in edgeUpdateValues.Insert) {
                var insertedItem = WorkflowDataProvider.InsertConnection(item);
                edgeUpdateValues.MapInsertedItemKey(item, insertedItem.ID);
            }

            return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues, edgeUpdateValues);
        }
    }
}
