using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult LinkedControls() {            
            return DemoView("LinkedControls", NorthwindDataProvider.GetCategories());
        }
        public ActionResult LinkedControlsPartial(int[] categories) {
            var model = FilterProducts(categories);
            return PartialView(model);
        }

        public ActionResult LinkedControlsCustomActionPartial(int[] categories) {
            var model = FilterProducts(categories);
            return PartialView("LinkedControlsPartial", model);
        }

        private List<Product> FilterProducts(int[] categories) {
            var filteredProducts = new List<Product>();
            if (categories == null)
                return filteredProducts;

            using (var context = new NorthwindContext()) {
                filteredProducts = context.Products.Where(product => categories.Contains((int)product.CategoryID)).ToList();                
            }
            return filteredProducts;
        }
    }
}
