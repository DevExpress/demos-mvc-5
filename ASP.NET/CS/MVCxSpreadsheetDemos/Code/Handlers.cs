using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Web.Demos {
    public static class SpreadsheetGlobalHandlers {
        public static void OnCellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            SpreadsheetDocumentInfo documentInfo = sender as SpreadsheetDocumentInfo;
            if (DocumentShouldBeProcessed(documentInfo) && TrackingNumberChanged(e))
                ShowShipmentInfo(e.Value, e.Worksheet);
        }

        static bool TrackingNumberChanged(SpreadsheetCellEventArgs e) {
            return e.Cell.GetReferenceA1() == "C3";
        }

        static bool DocumentShouldBeProcessed(SpreadsheetDocumentInfo documentInfo) {
            return documentInfo.DocumentId.StartsWith(DocumentIdGenerator.CellValueChangedDocumentIdPrefix);
        }

        static void ShowShipmentInfo(CellValue trackingNumber, Worksheet worksheet) {
            Shipment shipment = SampleDataSource.Lookup(trackingNumber.TextValue);
            worksheet.Cells["C6"].Value = shipment.GetShipmentWeight();
            worksheet.Cells["C7"].Value = shipment.Sender;
            worksheet.Cells["C8"].Value = shipment.Recipient;
            worksheet.Cells["C9"].Value = shipment.GetShippingDate();
            worksheet.Cells["C10"].Value = shipment.GetDeliveryDate();
        }
    }
}
