using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        public ActionResult AjaxActionLink() {
            return DemoView("AjaxActionLink", NorthwindDataProvider.GetProducts());
        }
        public ActionResult AjaxActionLinkPartial() {
            return PartialView("AjaxActionLinkPartial", NorthwindDataProvider.GetProducts());
        }
        public ActionResult AjaxActionLinkCategoryPartial(int categoryID) {
            return PartialView("AjaxActionLinkCategoryPartial", GetViewCategoryModel(categoryID));
        }
        protected object GetViewCategoryModel(int categoryID) {
            var dbCategory = NorthwindDataProvider.GetCategoryByID(categoryID);
            return new {
                Photo = ((System.Data.Linq.Binary)dbCategory.Picture).ToArray(),
                CategoryName = dbCategory.CategoryName,
                Description = dbCategory.Description
            };
        }
    }
}
