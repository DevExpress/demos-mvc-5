using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;
using System.Linq;
namespace DevExpress.Web.Demos {
    public class PivotGridSampleReportsDemosHelper {
        public static void UpdatePivotGridLayoutForSampleReportsDemo(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            ChangePivotGridFieldLayout(pivotGrid, options ?? new PivotGridReportsDemoOptions());
        }
        static void ChangePivotGridFieldLayout(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            pivotGrid.BeginUpdate();
            PivotGridField fieldYear = pivotGrid.Fields["fieldYear"];
            PivotGridField fieldQuarter = pivotGrid.Fields["fieldQuarter"];
            PivotGridField fieldCustomer = pivotGrid.Fields["fieldCustomer"];
            PivotGridField fieldProductName = pivotGrid.Fields["fieldProductName"];
            PivotGridField fieldProductAmount = pivotGrid.Fields["fieldProductAmount"];
            fieldYear.Area = PivotArea.ColumnArea;
            fieldYear.AreaIndex = 0;
            fieldQuarter.Area = PivotArea.ColumnArea;
            fieldQuarter.AreaIndex = 1;
            fieldProductAmount.Area = PivotArea.DataArea;
            fieldCustomer.Area = PivotArea.RowArea;
            fieldCustomer.AreaIndex = 0;
            fieldCustomer.SortOrder = options.DemoKind == CustomerReportKind.Top10Customers ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            fieldCustomer.TopValueCount = 0;
            fieldCustomer.SortBySummaryInfo.FieldName = string.Empty;
            fieldProductName.Area = PivotArea.FilterArea;
            fieldProductName.SortOrder = options.DemoKind == CustomerReportKind.Top2Products ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            fieldProductName.TopValueCount = 0;
            fieldProductName.SortBySummaryInfo.FieldName = string.Empty;
            fieldCustomer.SortOrder = options.DemoKind == CustomerReportKind.Top10Customers ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            fieldProductName.SortOrder = options.DemoKind == CustomerReportKind.Top2Products ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;

            switch(options.DemoKind) {
                case CustomerReportKind.Customers:
                    break;
                case CustomerReportKind.Filtered:
                    fieldCustomer.Area = PivotArea.FilterArea;
                    fieldProductName.Area = PivotArea.RowArea;
                    break;
                case CustomerReportKind.Top2Products:
                    fieldProductName.Area = PivotArea.RowArea;
                    fieldProductName.TopValueCount = 2;
                    fieldProductName.SortBySummaryInfo.Field = fieldProductAmount;
                    fieldYear.Area = fieldQuarter.Area = PivotArea.FilterArea;
                    break;
                case CustomerReportKind.Top10Customers:
                    fieldCustomer.TopValueCount = 10;
                    fieldCustomer.SortBySummaryInfo.Field = fieldProductAmount;
                    fieldYear.Area = fieldQuarter.Area = PivotArea.FilterArea;
                    break;
            }
            if (options.DemoKind == CustomerReportKind.Filtered)
                ApplyFilter(pivotGrid, options);
            pivotGrid.EndUpdate();
        }
        static void ApplyFilter(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            pivotGrid.BeginUpdate();
            ApplyFilter(pivotGrid.Fields["fieldYear"], options.FilterYearIndex);
            ApplyFilter(pivotGrid.Fields["fieldQuarter"], options.FilterQuarterIndex);
            pivotGrid.EndUpdate();
        }
        static void ApplyFilter(ASPxPivotGrid.PivotGridField field, int selectedIndex) {
            field.FilterValues.Clear();
            if(selectedIndex > 0) {
                field.FilterValues.FilterType = PivotFilterType.Included;
                field.FilterValues.Add(selectedIndex);
            } else
                field.FilterValues.FilterType = PivotFilterType.Excluded;

            field.FilterValues.ShowBlanks = field.FilterValues.FilterType == PivotFilterType.Excluded;
        }
    }
}
