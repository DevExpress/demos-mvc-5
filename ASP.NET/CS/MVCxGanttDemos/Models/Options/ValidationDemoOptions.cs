using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class ValidationDemoOptions {
        public ValidationDemoOptions() {
            AutoUpdateParentTasks = true;
            EnableDependencyValidation = true;
            EnablePredecessorGap = false;

        }
        public bool AutoUpdateParentTasks { get; set; }
        public bool EnableDependencyValidation { get; set; }
        public bool EnablePredecessorGap { get; set; }

    }
}
