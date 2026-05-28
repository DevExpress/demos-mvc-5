using System.Linq;
using DevExpress.Web.Demos;

public class PivotGridServerModeDataGenerator {
    static DatabaseGenerator.TableData table;

    public static DatabaseGenerator.TableData Table { get { return table; } }

    public static void Register() {
        table = new DatabaseGenerator.TableData();
        table.Name = "Sales";
        table.ConnectionStringName = "PivotGridServerModeDemoConnectionString";
        table.Fields.Add(new DatabaseGenerator.FieldData("Order", Enumerable.Range(1, 600).ToArray()));
        table.Fields.Add(new DatabaseGenerator.FieldData("Product", Enumerable.Range(1, 83).ToArray()));
        table.Fields.Add(new DatabaseGenerator.FieldData("Quantity", Enumerable.Range(1, 100).ToArray()));
        table.Fields.Add(new DatabaseGenerator.FieldData("UnitPrice", Enumerable.Range(1, 100).Select((v) => v / 10).ToArray()));
        table.RecordCount = 300000;
        DatabaseGenerator.RegisterTable("GeneratedServerModeTable", table);
    }
}
