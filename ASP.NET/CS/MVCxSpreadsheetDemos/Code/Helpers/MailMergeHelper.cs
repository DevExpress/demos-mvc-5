using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class MailMergeDemoHelper {
        public static List<SelectListItem> GetMailMergeModes() {
            return new List<SelectListItem>() {
                new SelectListItem() {
                    Text = "Single Sheet (merged ranges for all data source records are inserted one after another into a single worksheet)", 
                    Value = "OneWorksheet"
                },
                new SelectListItem() { 
                    Text = "Multiple Sheets (the merged range for each data source record is inserted into a separate worksheet in a single workbook)", 
                    Value = "Worksheets" 
                }
            };
        }
    }
}
