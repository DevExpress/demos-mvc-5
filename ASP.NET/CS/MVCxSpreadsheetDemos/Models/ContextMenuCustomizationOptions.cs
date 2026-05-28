using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using DevExpress.Web.ASPxSpreadsheet;

namespace DevExpress.Web.Demos {
    public class ContextMenuCustomizationDemoOptions {
        public static string PathToDocument {
            get {
                return Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "ContextMenu.xlsx");
            }
        }
    }
}
