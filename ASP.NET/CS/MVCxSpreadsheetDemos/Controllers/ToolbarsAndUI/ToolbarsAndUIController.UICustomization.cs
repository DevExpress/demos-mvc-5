using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Spreadsheet;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        Worksheet CurrentWorksheet {
            get {
                return SpreadsheetExtension.GetCurrentDocument("Spreadsheet").Worksheets.ActiveWorksheet;
            }
        }

        public ActionResult UICustomization() {
            Session["RibbonCustomizationOptions"] = new RibbonCustomizationDemoOptions();
            return DemoView("UICustomization");
        }

        public ActionResult UICustomizationSpreadsheetPartial() {
            return PartialView("UICustomizationSpreadsheetPartial");
        }

        public ActionResult ApplySpreadsheetSettings() {
            RibbonCustomizationDemoOptions options = (RibbonCustomizationDemoOptions)Session["RibbonCustomizationOptions"];
            ApplySpreadsheetSettings(options);
            Session["RibbonCustomizationOptions"] = options;

            ApplyDocumentSettings(Request.Params["ElementName"]);
            
            return PartialView("UICustomizationCallbackPartial");
        }

        private SpreadsheetRibbonMode GetCurrentRibbonMode(string ribbonMode) {
            return (SpreadsheetRibbonMode)Enum.Parse(typeof(SpreadsheetRibbonMode), ribbonMode);
        }

        private void ApplySpreadsheetSettings(RibbonCustomizationDemoOptions options) {
            if (!string.IsNullOrEmpty(Request.Params["RibbonMode"]))
                options.RibbonMode = GetCurrentRibbonMode(Request.Params["RibbonMode"]);
            if (!string.IsNullOrEmpty(Request.Params["ShowFormulaBar"]))
                options.ShowFormulaBar = Convert.ToBoolean(Request.Params["ShowFormulaBar"]);
            if (!string.IsNullOrEmpty(Request.Params["ShowSheetTabs"]))
                options.ShowSheetTabs = Convert.ToBoolean(Request.Params["ShowSheetTabs"]);
        }

        private void ApplyDocumentSettings(string parameter) {
            if (parameter == "headings")
                CurrentWorksheet.ActiveView.ShowHeadings = !CurrentWorksheet.ActiveView.ShowHeadings;
            else if (parameter == "grid")
                CurrentWorksheet.ActiveView.ShowGridlines = !CurrentWorksheet.ActiveView.ShowGridlines;
        }
    }
}
