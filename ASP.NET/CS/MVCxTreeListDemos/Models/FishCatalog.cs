using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public static class FishCatalog {
        public static IEnumerable<BioLife> GetData() {
            using(var context = new FishContext())
                return context.BioLives.ToList();
        }
        public static BioLife GetByKey(int Id) {
            using (var context = new FishContext())
                return context.BioLives.FirstOrDefault(f => f.ID == Id);
        }
    }
}
