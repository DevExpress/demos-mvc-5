using System.Drawing;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class HyperlinksAndBookmarksDemoOptions {
        public HyperlinksAndBookmarksDemoOptions() {
            ShowBookmarks = true;
            BookmarkColor = Color.Blue;
        }
        const string BookmarksDemoOptionsKey = "HyperlinksAndBookmarksDemoOptions";
        public static HyperlinksAndBookmarksDemoOptions Current {
            get {
                if(HttpContext.Current.Session[BookmarksDemoOptionsKey] == null)
                    HttpContext.Current.Session[BookmarksDemoOptionsKey] = new HyperlinksAndBookmarksDemoOptions();
                return (HyperlinksAndBookmarksDemoOptions)HttpContext.Current.Session[BookmarksDemoOptionsKey];
            }
            set { HttpContext.Current.Session[BookmarksDemoOptionsKey] = value; }
        }
        [Display(Name = "Show bookmarks")]
        public bool ShowBookmarks{ get; set; }
        [Display(Name = "Bookmark color")]
        public Color BookmarkColor { get; set; }
    }
}
