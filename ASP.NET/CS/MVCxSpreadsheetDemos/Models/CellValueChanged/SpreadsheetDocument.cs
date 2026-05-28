using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Web.Demos {
    public class SpreadsheetDocument {
        public string DocumentId { get; private set; }
        public DocumentFormat DocumentFormat { get { return DocumentFormat.Xlsx; } }
        public byte[] Document { get; private set; }
        public SpreadsheetDocument() {
            var templatePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "CellValueChanged.xlsx");
            DocumentId = DocumentIdGenerator.GenerateDocumentId();
            if (File.Exists(templatePath))
                Document = File.ReadAllBytes(templatePath);
        }
    }

    public static class DocumentIdGenerator {
        public const string CellValueChangedDocumentIdPrefix = "CellValueChangedDemo_";

        public static string GenerateDocumentId() {
            return CellValueChangedDocumentIdPrefix + Guid.NewGuid().ToString();
        }
    }
}
