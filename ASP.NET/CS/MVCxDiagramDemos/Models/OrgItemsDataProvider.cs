using DevExpress.Web.ASPxDiagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Models {
    public class OrgItemsDataProvider {
        const string OrgItemsDataContextKey = "OrgItemsContext";

        public static OrgItemsContextSL DB {
            get {
                if (HttpContext.Current.Items[OrgItemsDataContextKey] == null)
                    HttpContext.Current.Items[OrgItemsDataContextKey] = new OrgItemsContextSL();
                return (OrgItemsContextSL)HttpContext.Current.Items[OrgItemsDataContextKey];
            }
        }

        public static IList<EditableOrgItem> GetItems() {
            IList<EditableOrgItem> items = (IList<EditableOrgItem>)HttpContext.Current.Session["OrgItems"];
            if (items == null) {
                items = (from node in DB.Nodes
                            select new EditableOrgItem {
                                ID = node.ID,
                                Type = node.Type,
                                Text = node.Text,
                                Picture = node.Picture
                            }).ToList();
                HttpContext.Current.Session["OrgItems"] = items;
            }
            return items;
        }

        public static void UpdateItem(EditableOrgItem item) {
            var editItem = GetEditableItem(item.ID);
            if(editItem != null) {
                editItem.Text = item.Text;
                editItem.Type = item.Type;
                editItem.Picture = item.Picture;
            }
        }

        static readonly object ObjectInsertLock = new object();

        public static EditableOrgItem InsertItem(EditableOrgItem item) {
            lock(ObjectInsertLock) {
                var editObject = new EditableOrgItem();
                editObject.ID = GetNextItemID();
                editObject.Text = item.Text;
                editObject.Type = item.Type;
                editObject.Picture = item.Picture;
                GetItems().Add(editObject);
                return editObject;
            }
        }
        static int GetNextItemID() {
            var objects = GetItems();
            return objects.Any() ? objects.Select(d => d.ID).Max() + 1 : 0;
        }

        public static EditableOrgLink InsertLink(EditableOrgLink item) {
            lock(ObjectInsertLock) {
                var editLink = new EditableOrgLink();
                editLink.ID = GetNextLinkID();
                editLink.FromID = item.FromID;
                editLink.ToID = item.ToID;
                GetLinks().Add(editLink);
                return editLink;
            }
        }

        public static int GetNextLinkID() {
            var connections = GetLinks();
            return connections.Any() ? connections.Select(d => d.ID).Max() + 1 : 0;
        }

        public static void DeleteItem(int itemKey) {
            var editItem = GetEditableItem(itemKey);
            if(editItem != null)
                GetItems().Remove(editItem);
        }

        public static void DeleteLink(int itemKey) {
            var editLink = GetEditableLink(itemKey);
            if(editLink != null)
                GetLinks().Remove(editLink);
        }

        public static void UpdateLink(EditableOrgLink item) {
            var editObject = GetEditableLink(item.ID);
            if(editObject != null) {
                editObject.FromID = item.FromID;
                editObject.ToID = item.ToID;
            }
        }

        public static IList<EditableOrgLink> GetLinks() {
            IList<EditableOrgLink> links = (IList<EditableOrgLink>)HttpContext.Current.Session["OrgLinks"];
            if (links == null) {
                links = (from edge in DB.Edges
                           select new EditableOrgLink {
                               ID = edge.ID,
                               FromID = edge.FromID,
                               ToID = edge.ToID
                           }).ToList();
                HttpContext.Current.Session["OrgLinks"] = links;
            }
            return links;
        }

        static EditableOrgItem GetEditableItem(int id) {
            return (from item in GetItems() where item.ID == id select item).FirstOrDefault();
        }
        static EditableOrgLink GetEditableLink(int id) {
            return (from link in GetLinks() where link.ID == id select link).FirstOrDefault();
        }

        public static OrgItemsModel LoadData() {
            return new OrgItemsModel() {
                Links = GetLinks(),
                Items = GetItems()
            };
        }
    }

    public class OrgItemsModel {
        public IList<EditableOrgLink> Links { get; set; }
        public IList<EditableOrgItem> Items { get; set; }
    }

    public class EditableOrgItem {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
    }

    public class EditableOrgLink {
        public int ID { get; set; }
        public int? FromID { get; set; }
        public int? ToID { get; set; }
    }
}
