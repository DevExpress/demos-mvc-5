using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Models {
    public class DevelopmentOrgItemsDataProvider {
        const string DevelopmentOrgItemsDataContextKey = "DevelopmentOrgItemsContext";

        public static DevelopmentOrgItemsContextSL DB {
            get {
                if (HttpContext.Current.Items[DevelopmentOrgItemsDataContextKey] == null)
                    HttpContext.Current.Items[DevelopmentOrgItemsDataContextKey] = new DevelopmentOrgItemsContextSL();
                return (DevelopmentOrgItemsContextSL)HttpContext.Current.Items[DevelopmentOrgItemsDataContextKey];
            }
        }

        public static IList<EditableDevelopmentOrgItem> GetItems() {
            IList<EditableDevelopmentOrgItem> items = (IList<EditableDevelopmentOrgItem>)HttpContext.Current.Session["DevelopmentOrgItems"];
            if (items == null) {
                items = (from item in DB.DevelopmentOrgItems
                            select new EditableDevelopmentOrgItem {
                                Id = item.Id,
                                Type = item.Type,
                                Text = item.Text,
                                ParentId = item.ParentId
                            }).ToList();
                HttpContext.Current.Session["DevelopmentOrgItems"] = items;
            }
            return items;
        }

        public static void UpdateItem(EditableDevelopmentOrgItem item) {
            var editItem = GetEditableItem(item.Id);
            if(editItem != null) {
                editItem.Text = item.Text;
                editItem.Type = item.Type;
                editItem.ParentId = item.ParentId;
            }
        }

        static readonly object ObjectInsertLock = new object();

        public static EditableDevelopmentOrgItem InsertItem(EditableDevelopmentOrgItem item) {
            lock(ObjectInsertLock) {
                var editObject = new EditableDevelopmentOrgItem();
                editObject.Id = GetNextItemID();
                editObject.Text = item.Text;
                editObject.Type = item.Type;
                editObject.ParentId = item.ParentId;
                GetItems().Add(editObject);
                return editObject;
            }
        }
        static int GetNextItemID() {
            var objects = GetItems();
            return objects.Any() ? objects.Select(d => d.Id).Max() + 1 : 0;
        }

        public static void DeleteItem(int itemKey) {
            var editItem = GetEditableItem(itemKey);
            if(editItem != null)
                GetItems().Remove(editItem);
        }

        static EditableDevelopmentOrgItem GetEditableItem(int id) {
            return (from item in GetItems() where item.Id == id select item).FirstOrDefault();
        }

        public static DevelopmentOrgItemsModel LoadData() {
            return new DevelopmentOrgItemsModel() {
                Items = GetItems()
            };
        }
    }

    public class DevelopmentOrgItemsModel {
        public IList<EditableDevelopmentOrgItem> Items { get; set; }
    }

    public class EditableDevelopmentOrgItem {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
    }
}
