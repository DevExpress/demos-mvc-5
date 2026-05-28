using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Demos;

namespace DevExpress.Web.Demos.Charts {
    public static class SeriesDataGenerator {
        static List<DataPoint> SetUpSeriesData(int seriesCount, int pointsCount, SeriesDataType seriesType, double offset = 0.0) {
            List<DataPoint> data = new List<DataPoint>(seriesCount * pointsCount);
            for (int i = 0; i < seriesCount; i++) {
                var generator = new DataGenerator(i, (seriesCount - i) * 10 + offset);
                data.AddRange(generator.GenerateData(seriesType, pointsCount));
            }
            return data;
        }

        public static List<DataPoint> GenerateSeries(SeriesDataType seriesTypes) {
            if (seriesTypes == SeriesDataType.Financial)
                return SetUpSeriesData(1, 30, seriesTypes);
            if (seriesTypes == SeriesDataType.Funnel)
                return SetUpSeriesData(1, 9, seriesTypes, 100);
            return SetUpSeriesData(3, 11, seriesTypes);
        }
    }

    public static class ViewTypesItemsHelper {
        static List<ListEditItem> CreateItems(List<ViewType> viewTypes) {
            List<ListEditItem> viewItems = new List<ListEditItem>();
            foreach (ViewType viewType in viewTypes) {
                viewItems.Add(new ListEditItem(DevExpress.XtraCharts.Native.SeriesViewFactory.GetStringID(viewType), viewType));
            }
            return viewItems;
        }
        static List<ViewType> CreateLineViewTypes() {
            return new List<ViewType>() {
                ViewType.Line,
                ViewType.Spline,
                ViewType.Area,
                ViewType.SplineArea
            };
        }
        public static List<ViewType> CreateViewTypes() {
            return new List<ViewType>() {
                ViewType.Bar,
                ViewType.StackedBar,
                ViewType.FullStackedBar,
                ViewType.SideBySideStackedBar,
                ViewType.SideBySideFullStackedBar,
                ViewType.Point,
                ViewType.Bubble,
                ViewType.Line,
                ViewType.StackedLine,
                ViewType.FullStackedLine,
                ViewType.StepLine,
                ViewType.Spline,
                ViewType.Area,
                ViewType.StackedArea,
                ViewType.FullStackedArea,
                ViewType.StackedStepArea,
                ViewType.FullStackedStepArea,
                ViewType.StepArea,
                ViewType.SplineArea,
                ViewType.StackedSplineArea,
                ViewType.FullStackedSplineArea,
                ViewType.RangeBar,
                ViewType.SideBySideRangeBar,
                ViewType.RangeArea,
                ViewType.Pie,
                ViewType.Doughnut,
                ViewType.NestedDoughnut,
                ViewType.Funnel,
                ViewType.RadarPoint,
                ViewType.RadarLine,
                ViewType.RadarArea,
                ViewType.RadarRangeArea,
                ViewType.Stock,
                ViewType.CandleStick,
            };
        }
        public static List<ListEditItem> CreateItems() {
            return CreateItems(CreateViewTypes());
        }
        public static List<ListEditItem> CreateLineViewItems() {
            return CreateItems(CreateLineViewTypes());
        }
        public static List<ListEditItem> CreateHistogramItems() {
            return CreateItems(new List<ViewType>() { ViewType.RangeBar, ViewType.SplineArea });
        }
    }
}
