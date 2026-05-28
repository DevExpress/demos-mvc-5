using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController: DemoController {
        public ActionResult ExternalEditForm() {
            return DemoView("ExternalEditForm", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ExternalEditFormPartial() {
            return PartialView("ExternalEditFormPartial", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ExternalEditFormEdit(int productID = -1) {
            EditableProduct editProduct = NorthwindDataProvider.GetEditableProduct(productID);
            if(editProduct == null) {
                editProduct = new EditableProduct();
                editProduct.ProductID = -1;
            }
            return DemoView("ExternalEditForm", "EditingForm", editProduct);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalEditFormEdit([Bind] EditableProduct product) {
            if (!ModelState.IsValid)
                return DemoView("ExternalEditForm", "EditingForm", product);

            if (product.ProductID == -1)
                NorthwindDataProvider.InsertProduct(product);
            else
                NorthwindDataProvider.UpdateProduct(product);
            return RedirectToAction("ExternalEditForm");
        }
        public ActionResult ExternalEditFormDelete(int productID) {
            NorthwindDataProvider.DeleteProduct(productID);
            return RedirectToAction("ExternalEditForm");
        }
    }
}
