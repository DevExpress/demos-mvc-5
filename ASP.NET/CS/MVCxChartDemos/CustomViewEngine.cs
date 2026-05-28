using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public class CustomViewEngine : WebFormViewEngine {
        public CustomViewEngine() {
            var viewLocations = new[] {  
            "~/Views/AreaTypes/{0}.cshtml",  
            "~/Views/{1}/{0}.cshtml",  
            "~/Views/Shared/{0}.cshtml",  
            "~/Views/Shared/{0}.cshtml",  
            "~/AnotherPath/Views/{0}.cshtml"
        };
            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }
    }
}
