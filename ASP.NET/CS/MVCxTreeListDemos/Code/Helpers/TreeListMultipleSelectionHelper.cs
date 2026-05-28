using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class TreeListMultipleSelectionDemoHelper {
        public static List<SelectListItem> GetSelectModes() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "All nodes", Value = "All" },
                new SelectListItem() { Text = "Child nodes", Value = "Child" },
                new SelectListItem() { Text = "Parent nodes", Value = "Parent" },
                new SelectListItem() { Text = "Level > 2", Value = "DepthOverTwo" }
            };
        }
    }
}
