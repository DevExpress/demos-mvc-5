using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;

namespace DevExpress.Web.Demos {
    public class PivotGridFeaturesDemosHelper {
        static PivotGridSettings drillDownPivotGridSettings;
        public static PivotGridSettings DrillDownPivotGridSettings {
            get {
                if(drillDownPivotGridSettings == null)
                    drillDownPivotGridSettings = CreateDrillDownPivotGridSettings();
                return drillDownPivotGridSettings;
            }
        }
        static PivotGridSettings CreateDrillDownPivotGridSettings() {
            var settings = new PivotGridSettings();
            settings.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            settings.OptionsFilter.FilterPanelMode = FilterPanelMode.Filter;
            settings.Name = "pivotGrid";
            settings.CallbackRouteValues = new { Controller = "Summary", Action = "DrillDownPivotGridPartial" };
            settings.Width = Unit.Percentage(100);

            settings.Fields.Add(field => {
                field.Area = PivotArea.FilterArea;
                field.AreaIndex = 0;
                field.Caption = "Product";
                field.DataBinding = new DataSourceColumnBinding("ProductName");
                field.ID = "fieldProduct";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 0;
                field.Caption = "Customer";
                field.DataBinding = new DataSourceColumnBinding("CompanyName");
                field.ID = "fieldCustomer";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.ColumnArea;
                field.AreaIndex = 0;
                field.Caption = "Year";
                field.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear);
                field.ID = "fieldYear";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.DataArea;
                field.AreaIndex = 0;
                field.Caption = "Product Amount";
                field.DataBinding = new DataSourceColumnBinding("ProductAmount");
                field.CellFormat.FormatString = "c";
                field.CellFormat.FormatType = FormatType.Custom;
                field.ID = "fieldProductAmount";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.FilterArea;
                field.AreaIndex = 1;
                field.Caption = "Quarter";
                field.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter);
                field.ID = "fieldQuarter";
            });

            settings.Styles.CellStyle.Cursor = "pointer";
            settings.OptionsView.ShowFilterHeaders = false;
            settings.ClientSideEvents.CellClick = "onPivotGridCellClick";

            settings.Fields["fieldYear"].ID = "Year";
            settings.Fields["fieldProduct"].Area = PivotArea.RowArea;
            return settings;
        }
    }
}
