using DevExpress.Web.ASPxDiagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Models {
    public class WorkflowDataProvider {
        const string FlowDataContextKey = "FlowContext";

        public static FlowContextSL DB {
            get {
                if (HttpContext.Current.Items[FlowDataContextKey] == null)
                    HttpContext.Current.Items[FlowDataContextKey] = new FlowContextSL();
                return (FlowContextSL)HttpContext.Current.Items[FlowDataContextKey];
            }
        }

        public static IList<EditableFlowObject> GetObjects() {
            IList<EditableFlowObject> objects = (IList<EditableFlowObject>)HttpContext.Current.Session["FlowObjects"];
            if (objects == null) {
                objects = (from node in DB.Nodes
                            select new EditableFlowObject {
                                ID = node.ID,
                                Type = node.Type,
                                Text = node.Text,
                                Width = node.Width,
                                Height = node.Height
                            }).ToList();
                HttpContext.Current.Session["FlowObjects"] = objects;
            }
            return objects;
        }

        public static void UpdateObject(EditableFlowObject item) {
            var editObject = GetEditableObject(item.ID);
            if(editObject != null) {
                editObject.Text = item.Text;
                editObject.Height = item.Height;
                editObject.Type = item.Type;
                editObject.Width = item.Width;
            }
        }

        static readonly object ObjectInsertLock = new object();

        public static EditableFlowObject InsertObject(EditableFlowObject item) {
            lock(ObjectInsertLock) {
                var editObject = new EditableFlowObject();
                editObject.ID = GetNextObjectID();
                editObject.Height = item.Height;
                editObject.Text = item.Text;
                editObject.Type = item.Type;
                editObject.Width = item.Width;
                GetObjects().Add(editObject);
                return editObject;
            }
        }
        static int GetNextObjectID() {
            var objects = GetObjects();
            return objects.Any() ? objects.Select(d => d.ID).Max() + 1 : 0;
        }

        public static EditableFlowConnection InsertConnection(EditableFlowConnection item) {
            lock(ObjectInsertLock) {
                var editConnection = new EditableFlowConnection();
                editConnection.ID = GetNextConnectionID();
                editConnection.FromID = item.FromID;
                editConnection.ToID = item.ToID;
                editConnection.Text = item.Text;
                GetConnections().Add(editConnection);
                return editConnection;
            }
        }

        public static int GetNextConnectionID() {
            var connections = GetConnections();
            return connections.Any() ? connections.Select(d => d.ID).Max() + 1 : 0;
        }

        public static void DeleteObject(int itemKey) {
            var editObject = GetEditableObject(itemKey);
            if(editObject != null)
                GetObjects().Remove(editObject);
        }

        public static void DeleteConnection(int itemKey) {
            var editConnection = GetEditableConnection(itemKey);
            if(editConnection != null)
                GetConnections().Remove(editConnection);
        }

        public static void UpdateConnection(EditableFlowConnection item) {
            var editObject = GetEditableConnection(item.ID);
            if(editObject != null) {
                editObject.Text = item.Text;
                editObject.FromID = item.FromID;
                editObject.ToID = item.ToID;
            }
        }

        public static IList<EditableFlowConnection> GetConnections() {
            IList<EditableFlowConnection> connections = (IList<EditableFlowConnection>)HttpContext.Current.Session["FlowConnections"];
            if (connections == null) {
                connections = (from edge in DB.Edges
                           select new EditableFlowConnection {
                               ID = edge.ID,
                               Text = edge.Text,
                               FromID = edge.FromID,
                               ToID = edge.ToID
                           }).ToList();
                HttpContext.Current.Session["FlowConnections"] = connections;
            }
            return connections;
        }

        static EditableFlowObject GetEditableObject(int objectID) {
            return (from obj in GetObjects() where obj.ID == objectID select obj).FirstOrDefault();
        }
        static EditableFlowConnection GetEditableConnection(int connectionID) {
            return (from connection in GetConnections() where connection.ID == connectionID select connection).FirstOrDefault();
        }

        public static WorkflowModel LoadData() {
            return new WorkflowModel() {
                Connections = GetConnections(),
                Objects = GetObjects()
            };
        }
    }

    public class WorkflowModel {
        public IList<EditableFlowConnection> Connections { get; set; }
        public IList<EditableFlowObject> Objects { get; set; }
    }

    public class EditableFlowObject {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
    }

    public class EditableFlowConnection {
        public int ID { get; set; }
        public int? FromID { get; set; }
        public int? ToID { get; set; }
        public string Text { get; set; }
        public ConnectorLineType LT { get; set; }
    }
}
