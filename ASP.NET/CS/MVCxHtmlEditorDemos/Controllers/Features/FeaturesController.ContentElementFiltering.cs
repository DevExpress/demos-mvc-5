using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult ContentElementFiltering() {
            return DemoView("ContentElementFiltering", new HtmlEditorContentElementFilteringOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContentElementFiltering([Bind]HtmlEditorContentElementFilteringOptions options) {
            options.Tags.FilteringList = new List<string>(TokenBoxExtension.GetSelectedValues<string>("tagTokenBox"));
            options.Attributes.FilteringList = new List<string>(TokenBoxExtension.GetSelectedValues<string>("attributeTokenBox"));
            options.StyleAttributes.FilteringList = new List<string>(TokenBoxExtension.GetSelectedValues<string>("styleAttributeTokenBox"));
            options.Html = HtmlEditorExtension.GetHtml("HtmlEditor");
            return DemoView("ContentElementFiltering", options);
        }
        public ActionResult ContentElementFilteringPartial([Bind]HtmlEditorContentElementFilteringOptions options) {
            return PartialView("ContentElementFilteringPartial", options);
        }
        public ActionResult ContentElementFilteringHtmlContentLoad([Bind]HtmlEditorContentElementFilteringOptions options) {
            options.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("Blueberry.htm", false);
            return HtmlEditorExtension.GetCustomDataCallbackResult(options.Html);
        }
    }
}
