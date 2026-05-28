using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public static class NorthwindContextProvider {
        const string NorthwindContextKey = "NorthwindContextKey";

        public static NorthwindContext Current {
            get {
                if(HttpContext.Current.Session[NorthwindContextKey] == null)
                    HttpContext.Current.Session[NorthwindContextKey] = new NorthwindContext();
                return (NorthwindContext)HttpContext.Current.Session[NorthwindContextKey];
            }
        }
        public static Employee[] GetEmployees() {
            return Current.Employees.ToArray();
        }
        public static Employee[] GetEmployeesByCity(string city) {
            return Current.Employees.Where(employee => employee.City == city).ToArray();
        }
    }
}
