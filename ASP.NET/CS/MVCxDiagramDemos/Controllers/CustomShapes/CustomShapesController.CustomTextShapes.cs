using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.ASPxDiagram;

namespace DevExpress.Web.Demos.Controllers {
    public partial class CustomShapesController : DemoController {
        static CompanyEmployeesDataProviderSL employeesDataProvider;
        static CompanyEmployeesDataProviderSL EmployeesDataProvider {
            get { return employeesDataProvider ?? (employeesDataProvider = new CompanyEmployeesDataProviderSL()); }
        }

        public ActionResult CustomTextShapes() {
            ViewBag.EmployeeShapes = GetEmployeesShapes();

            var diagrammContent = System.IO.File.ReadAllText(
                Request.MapPath("~/App_Data/diagram-employees.json")
            );
            return DemoView("CustomTextShapes", "CustomTextShapes", diagrammContent);
        }

        static IEnumerable<DiagramCustomShape> GetEmployeesShapes() {
            return EmployeesDataProvider.GetCompanyEmployees()
                .Select(e => new DiagramCustomShape {
                    Type = "emp" + e.EmployeeID,
                    BaseType = DiagramShapeType.Rectangle,
                    DefaultText = e.FirstName + " " + e.LastName,
                    CategoryName = "CategoryEmployees"
                });
        }
    }
}
