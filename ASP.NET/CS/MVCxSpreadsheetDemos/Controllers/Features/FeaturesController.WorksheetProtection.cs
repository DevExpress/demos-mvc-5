using System;
using System.Web.Mvc;
using DevExpress.Spreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        protected readonly string Password = System.Configuration.ConfigurationManager.AppSettings["DemoPassword"]; // "123";

        public ActionResult WorksheetProtection() {
            return DemoView("WorksheetProtection");
        }

        public ActionResult WorksheetProtectionSpreadsheetPartial() {
            return PartialView("WorksheetProtectionSpreadsheetPartial");
        }

        public ActionResult WorksheetProtectionCallbackPanelPartial(SpreadsheetWorksheetProtectionOptions options) {
            WorksheetProtectionPermissions selectedPermissions = WorksheetProtectionPermissions.SelectLockedCells | WorksheetProtectionPermissions.SelectUnlockedCells;

            if(options.FormatCells) 
                selectedPermissions |= WorksheetProtectionPermissions.FormatCells;
            if(options.FormatColumns) 
                selectedPermissions |= WorksheetProtectionPermissions.FormatColumns;
            if(options.FormatRows) 
                selectedPermissions |= WorksheetProtectionPermissions.FormatRows;
            if(options.InsertColumns) 
                selectedPermissions |= WorksheetProtectionPermissions.InsertColumns;
            if(options.InsertRows) 
                selectedPermissions |= WorksheetProtectionPermissions.InsertRows;
            if(options.InsertHyperlinks) 
                selectedPermissions |= WorksheetProtectionPermissions.InsertHyperlinks;
            if(options.DeleteColumns) 
                selectedPermissions |= WorksheetProtectionPermissions.DeleteColumns;
            if(options.DeleteRows) 
                selectedPermissions |= WorksheetProtectionPermissions.DeleteRows;
            if(options.Sort) 
                selectedPermissions |= WorksheetProtectionPermissions.Sort;
            if(options.UseAutoFilter) 
                selectedPermissions |= WorksheetProtectionPermissions.AutoFilters;
            if(options.EditObjects) 
                selectedPermissions |= WorksheetProtectionPermissions.Objects;

            UnprotectAllWorksheets(Password);
            ProtectAllWorksheets(Password, selectedPermissions);

            return PartialView("WorksheetProtectionCallbackPanelPartial");
        }

        protected void ProtectAllWorksheets(string password, WorksheetProtectionPermissions permissions) {
            foreach (Worksheet worksheet in SpreadsheetExtension.GetCurrentDocument("Spreadsheet").Worksheets)
                worksheet.Protect(password, permissions);
        }

        protected void UnprotectAllWorksheets(string password) {
            foreach (Worksheet worksheet in SpreadsheetExtension.GetCurrentDocument("Spreadsheet").Worksheets)
                if (worksheet.IsProtected)
                    worksheet.Unprotect(password);
        }
    }
}
