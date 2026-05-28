using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using System.Linq;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        [HttpGet]
        public ActionResult ToolTip() {
            ChartToolTipDemoOptions options = new ChartToolTipDemoOptions();
            var model = NorthwindDataProvider.GetEmployeesOrders();
            Dictionary<string, int> toolTipImageDictionary = new Dictionary<string, int>();
            foreach (EmployeeOrder employee in model) {
                toolTipImageDictionary[employee.LastName] = Convert.ToInt32(employee.Id);
            }
            options.ToolTipImages = toolTipImageDictionary;
            options.Data = model;
            return DemoView("ToolTip", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ToolTip([Bind] ChartToolTipDemoOptions options) {
            var model = NorthwindDataProvider.GetEmployeesOrders();
            Dictionary<string, int> toolTipImageDictionary = new Dictionary<string, int>();
            foreach (EmployeeOrder employee in model) {
                toolTipImageDictionary[employee.LastName] = Convert.ToInt32(employee.Id);
            }
            options.ToolTipImages = toolTipImageDictionary;
            options.Data = model;
            return DemoView("ToolTip", options);
        }

        public ActionResult ShowImage(int id) {
            byte[] imageData = NorthwindDataProvider.GetEmployeePhoto(id).ToArray();
            return File(imageData, "image/jpg");
        }
    }
}
