using System.Collections.Generic;
using DevExpress.Web.ASPxHtmlEditor;
namespace DevExpress.Web.Demos {
    public class HtmlEditorFilterOptions {
        public List<string> List { get; set; }
        public List<string> FilteringList { get; set; }
        public HtmlEditorFilterMode FilterMode { get; set; }
        public void Sort() {
            if(List != null)
                List.Sort();
            if(FilteringList != null)
                FilteringList.Sort();
        }
    }
    public class HtmlEditorTagFilterOptions: HtmlEditorFilterOptions {
        public HtmlEditorTagFilterOptions() {
            List = new List<string>(new string[] { "div", "p", "h1", "h2", "h3", "h4", "h5", "h6", "span", "font", "br", "ol", "ul", "li", "table", "tbody", "thead", "td", "tr", "th", "img", "address", "a", "b", "strong", "i", "em" });
            FilteringList = new List<string>(new string[] { "a", "div", "img", "li", "p", "ul", "span", "font", "table", "tbody", "td", "tr" });
            FilterMode = HtmlEditorFilterMode.WhiteList;
            Sort();
        }
    }
    public class HtmlEditorAttributeFilterOptions: HtmlEditorFilterOptions {
        public HtmlEditorAttributeFilterOptions() {
            List = new List<string>(new string[] { "align", "class", "cellspacing", "cellpadding", "colspan", "id", "scope", "style", "src", "href", "rowspan", "title", "width", "height" });
            FilteringList = new List<string>(new string[] { "cellspacing", "cellpadding", "href", "style", "src" });
            FilterMode = HtmlEditorFilterMode.WhiteList;
            Sort();
        }
    }
    public class HtmlEditorStyleAttributeFilterOptions: HtmlEditorFilterOptions {
        public HtmlEditorStyleAttributeFilterOptions() {
            List = new List<string>(new string[] { "font-size", "font-family", "border", "padding", "margin-top", "vertical-align", "text-align", "width", "height", "color", "background-color", "box-shadow", "line-height" });
            FilteringList = new List<string>(new string[] { "background-color", "float" });
            FilterMode = HtmlEditorFilterMode.BlackList;
            Sort();
        }
    }

    public class HtmlEditorContentElementFilteringOptions {
        public HtmlEditorContentElementFilteringOptions() {
            Tags = new HtmlEditorTagFilterOptions();
            Attributes = new HtmlEditorAttributeFilterOptions();
            StyleAttributes = new HtmlEditorStyleAttributeFilterOptions();
            Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("Blueberry.htm", false);
        }
        public HtmlEditorTagFilterOptions Tags { get; set; }
        public HtmlEditorAttributeFilterOptions Attributes { get; set; }
        public HtmlEditorStyleAttributeFilterOptions StyleAttributes { get; set; }
        public string Html { get; set; }
    }
}
