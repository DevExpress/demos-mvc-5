using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.ASPxSpreadsheet;

namespace DevExpress.Web.Demos {
    public class RibbonCustomizationDemoOptions {
        public RibbonCustomizationDemoOptions() {
            ShowFormulaBar = true;
            ShowSheetTabs = true;
            RibbonMode = SpreadsheetRibbonMode.Ribbon;
        }

        public SpreadsheetRibbonMode RibbonMode { get; set; }
        public bool ShowFormulaBar { get; set; }
        public bool ShowSheetTabs { get; set; }

        public bool IsExternalRibbonMode { get { return RibbonMode == SpreadsheetRibbonMode.ExternalRibbon; } }
    }
}
