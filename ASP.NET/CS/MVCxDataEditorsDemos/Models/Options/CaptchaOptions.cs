using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class CaptchaDemoOptions {
        public string CharacterSet { get; set; }
        public int CodeLength { get; set; }
        public static CaptchaDemoOptions Default {
            get {
                return new CaptchaDemoOptions() {
                    CharacterSet = "abcdefhjklmnpqrstuvxyz23456789",
                    CodeLength = 5
                };
            }
        }
    }
}
