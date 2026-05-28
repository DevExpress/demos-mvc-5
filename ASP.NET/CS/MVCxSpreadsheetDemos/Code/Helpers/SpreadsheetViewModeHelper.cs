using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class SpreadsheetViewModeDemoHelper {
        public static void PrepareSpreadsheetControl(MVCxSpreadsheet spreadsheet, SpreadsheetViewMode mode) {
            bool readingViewIsOn = (mode == SpreadsheetViewMode.Reading);

            spreadsheet.ShowFormulaBar = !readingViewIsOn;
            spreadsheet.ShowSheetTabs = !readingViewIsOn;

            if(readingViewIsOn) {
                spreadsheet.CreateDefaultRibbonTabs(true);
                RibbonTab readingViewTab = spreadsheet.RibbonTabs.Find(tab => tab is SRReadingViewTab);
                if(readingViewTab != null)
                    readingViewTab.Groups[0].Items.Add(new SRFullScreenCommand());
            } else {
                SpreadsheetDemoUtils.HideFileTab(spreadsheet);
                spreadsheet.ActiveTabIndex = 6;
            }
        }
    }
}
