using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Models;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class UserInteractionController : DemoController {
        public ActionResult EditingRestrictions() {
            return DemoView("EditingRestrictions", DevelopmentOrgItemsDataProvider.LoadData());
        }

        public ActionResult DevelopmentOrgItemsUpdate(MVCxDiagramNodeUpdateValues<EditableDevelopmentOrgItem, int> nodeUpdateValues) {
            foreach(var item in nodeUpdateValues.Update) {
                if(IsUpdateAllowed(item))
                    DevelopmentOrgItemsDataProvider.UpdateItem(item);
            }
            foreach(var itemKey in nodeUpdateValues.DeleteKeys) {
                if(IsDeleteAllowed(itemKey))
                    DevelopmentOrgItemsDataProvider.DeleteItem(itemKey);
            }
            foreach(var item in nodeUpdateValues.Insert) {
                if(IsInsertAllowed(item)) {
                    var insertedItem = DevelopmentOrgItemsDataProvider.InsertItem(item);
                    nodeUpdateValues.MapInsertedItemKey(item, insertedItem.Id);
                }
            }

            return DiagramExtension.GetBatchUpdateResult(nodeUpdateValues);
        }

        protected bool IsInsertAllowed(EditableDevelopmentOrgItem item) {
            // Implement server-side validation here
            return true;
        }
        protected bool IsUpdateAllowed(EditableDevelopmentOrgItem item) {
            // Implement server-side validation here
            return true;
        }
        protected bool IsDeleteAllowed(int itemKey) {
            // Implement server-side validation here
            return true;
        }
    }
}
