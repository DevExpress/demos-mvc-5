using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Customization;

namespace DevExpress.Web.Demos {
    public class PivotGridLayoutDemosHelper {
        static PivotGridSettings compactLayoutPivotGridSettings;
        public static PivotGridSettings CompactLayoutPivotGridSettings {
            get {
                if(compactLayoutPivotGridSettings == null)
                    compactLayoutPivotGridSettings = CreateCompactLayoutPivotGridSettings();
                return compactLayoutPivotGridSettings;
            }
        }
        static PivotGridSettings CreateCompactLayoutPivotGridSettings() {
            PivotGridSettings settings = new PivotGridSettings();
            settings.Name = "pivotGrid";
            settings.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            settings.OptionsFilter.FilterPanelMode = FilterPanelMode.Filter;
            settings.CallbackRouteValues = new { Controller = "Layout", Action = "CompactLayoutPartial" };
            settings.OptionsPager.Visible = false;
            settings.OptionsView.HorizontalScrollBarMode = ScrollBarMode.Auto;
            settings.OptionsView.VerticalScrollBarMode = ScrollBarMode.Auto;
            settings.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
            settings.OptionsView.ShowTotalsForSingleValues = true;
            settings.OptionsView.ShowColumnHeaders = false;
            settings.OptionsView.ShowDataHeaders = false;
            settings.OptionsView.ShowFilterHeaders = false;
            settings.OptionsView.ShowRowHeaders = false;
            settings.Width = Unit.Pixel(550);
            settings.Height = Unit.Pixel(500);


            settings.PivotCustomizationExtensionSettings.Name = "pivotCustomization";
            settings.PivotCustomizationExtensionSettings.AllowedLayouts = CustomizationFormAllowedLayouts.BottomPanelOnly1by4 | CustomizationFormAllowedLayouts.BottomPanelOnly2by2 |
                CustomizationFormAllowedLayouts.StackedDefault | CustomizationFormAllowedLayouts.StackedSideBySide;
            settings.PivotCustomizationExtensionSettings.Layout = CustomizationFormLayout.BottomPanelOnly2by2;
            settings.PivotCustomizationExtensionSettings.AllowSort = true;
            settings.PivotCustomizationExtensionSettings.AllowFilter = true;
            settings.PivotCustomizationExtensionSettings.Height = Unit.Pixel(500);
            settings.PivotCustomizationExtensionSettings.Width = Unit.Pixel(350);

            settings.Fields.Add(field => {
                field.DataBinding = new DataSourceColumnBinding("Country");
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 0;
            });
            settings.Fields.Add(field => {
                field.Caption = "Category Name";
                field.DataBinding = new DataSourceColumnBinding("CategoryName");
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 1;
            });
            settings.Fields.Add(field => {
                field.Caption = "Product Name";
                field.DataBinding = new DataSourceColumnBinding("ProductName");
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 2;
            });
            settings.Fields.Add(field => {
                field.Caption = "Customer";
                field.DataBinding = new DataSourceColumnBinding("Sales_Person");
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 3;
            });
            settings.Fields.Add(field => {
                field.Caption = "Order Year";
                field.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear);
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 4;
            });
            settings.Fields.Add(field => {
                field.Caption = "Order Quarter";
                field.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter);
                field.Area = PivotArea.ColumnArea;
                field.AreaIndex = 0;
                field.ValueFormat.FormatString = "Qtr {0}";
                field.ValueFormat.FormatType = FormatType.Numeric;
            });
            settings.Fields.Add("Quantity", PivotArea.DataArea);
            settings.Fields.Add("UnitPrice", PivotArea.FilterArea);

            settings.PreRender = (sender, e) => {
                MVCxPivotGrid pivotGrid = (MVCxPivotGrid)sender;
                pivotGrid.CollapseAll();
                pivotGrid.ExpandValue(false, new object[] { "UK" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1996 });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1997 });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu", "Michael Suyama" });
            };
            return settings;
        }
    }
}
