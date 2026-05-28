using System.Collections;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DevExpress.Utils;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos {
    public static class ImagesDataLarge {
        public static IEnumerable GetData(string xmlFileName) {
            XDocument doc = SafeXml.CreateXDocument(File.ReadAllText(HttpContext.Current.Server.MapPath(xmlFileName)));
            var items = from xe in doc.Element("items").Elements("item")
                        select new {
                            ImageUrl = xe.Attribute("ImageUrl").Value,
                            ThumbnailUrl = xe.Attribute("ThumbnailUrl").Value
                        };
            return Enumerable.Range(0, 100).Select(l => items.Select(f => new {
                ImageUrl = UrlUtils.MakeVirtualPathAppAbsolute(f.ImageUrl),
                ThumbnailUrl = UrlUtils.MakeVirtualPathAppAbsolute(f.ThumbnailUrl)
            })).SelectMany(l => l).ToList();
        }
    }
}
