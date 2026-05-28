using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Web.Demos.Mvc;
using DevExpress.XtraCharts;

namespace DevExpress.Web.Demos.Charts {
    public class ChartSeriesBindingDemoOptions {
        public const string DefaultCategory = "Confections";

        bool showLabels;
        object data;
        string category = DefaultCategory;
        SeriesPointKey sortingKey = SeriesPointKey.Value_1;
        SortingMode sortingMode = SortingMode.Ascending;
        ICollection categories;

        public bool ShowLabels {
            get { return showLabels; }
            set { showLabels = value; }
        }
        [DisplayName("Filter by Category")]
        public string Category {
            get { return category; }
            set { category = value; }
        }
        [DisplayName("Sort by")]
        public SeriesPointKey SortingKey {
            get { return sortingKey; }
            set { sortingKey = value; }
        }
        [DisplayName("Sort Order")]
        public SortingMode SortingMode {
            get { return sortingMode; }
            set { sortingMode = value; }
        }
        public object Data {
            get { return data; }
            set { data = value; }
        }
        public ICollection Categories { get { return categories; } }

        public ChartSeriesBindingDemoOptions() {
            categories = CreateCategoriesList(NorthwindDataProvider.GetCategoriesNames());
        }
        ICollection CreateCategoriesList(IEnumerable categories) {
            List<object> categoriesList = new List<object>();
            foreach (object category in categories) {
                categoriesList.Add(category);
            }
            return categoriesList;
        }
    }
}
