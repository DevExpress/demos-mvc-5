using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Linq;
using System.Web;
namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        const string DemoOptionsSessionName = "PlaceholdersDemoOptions";
        HtmlEditorPlaceholdersDemoOptions DemoOptions {
            get {
                if(Session[DemoOptionsSessionName] == null) {
                    HtmlEditorPlaceholdersDemoOptions options = new HtmlEditorPlaceholdersDemoOptions();
                    FillListBoxItems(options.ListEditItems);
                    DemoOptions = options;
                }
                return (HtmlEditorPlaceholdersDemoOptions)Session[DemoOptionsSessionName];
            }
            set { Session[DemoOptionsSessionName] = value; }
        }

        public ActionResult Placeholders() {
            return DemoView("Placeholders", DemoOptions);
        }
        public ActionResult PlaceholdersHtmlEditorPartial() {
            return PartialView("PlaceholdersHtmlEditorPartial", DemoOptions);
        }
        public ActionResult PlaceholdersRoundPanelPartial(string selectedItemValue, string html) {
            IList<EmployeeData> employees = EmployeesDataProvider.GetEmployees();
            EmployeeData employee = employees.First(e => e.FirstName == selectedItemValue);
            DemoOptions.DocumentHtml = MVCxHtmlEditor.ReplacePlaceholders(HttpUtility.UrlDecode(html), employee);
            return PartialView("PlaceholdersRoundPanelPartial", DemoOptions);
        }
        void FillListBoxItems(ListEditItemCollection items) {
            IList<EmployeeData> employees = EmployeesDataProvider.GetEmployees();
            foreach(EmployeeData employee in employees)
                items.Add(string.Format("{0}: {1}", employee.FirstName, employee.HomePhone), employee.FirstName);
        }
    }
}
