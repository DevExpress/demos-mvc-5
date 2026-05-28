using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace DevExpress.Web.Demos {
    public static class BinaryImages {
        public static IEnumerable GetData(int? categoryId = null) {
            using(var context = new BinaryImagesContext()) {
                if(categoryId != null)
                    return context.BinaryImages.Where(bi => bi.CategoryID == categoryId.Value).ToList();
                return context.BinaryImages.ToList();
            }
        }
    }
}
