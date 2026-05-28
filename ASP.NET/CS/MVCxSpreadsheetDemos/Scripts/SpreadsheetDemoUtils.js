(function () {
    function StartEditSpreadsheetFormula(spreadsheet) {
        if(IsCellActive(spreadsheet, 6, 2) && spreadsheet.isActiveCellVisible()) {
            SetActiveCellValue(spreadsheet);
            HighlightFormulaRanges(spreadsheet);
            DisplayFunctionsList(spreadsheet);
        }
        ClearStartEditSpreadsheetFormulaHandler();
    }
    function IsCellActive(spreadsheet, colIndex, rowIndex) {
        var selection = spreadsheet.GetSelection();
        return selection.activeCellColumnIndex === colIndex && selection.activeCellRowIndex === rowIndex;
    }
    function SetActiveCellValue(spreadsheet) {
        var stateController = spreadsheet.getStateController(),
            cellValue = "=SUM(E3:E10,C3:C10,\"<>\",D3:D10,\"=\")";
        stateController.setEditMode(ASPxClientSpreadsheet.StateController.Modes.Edit);
        spreadsheet.setElementsValue(cellValue);
    }
    function HighlightFormulaRanges(spreadsheet) {
        var stateController = spreadsheet.getStateController(),
            inputController = spreadsheet.getInputController(),
            editingHelper = spreadsheet.getEditingHelper();
        inputController.setCaretPosition(6);
        stateController.onCellEditorChanged();
        editingHelper.updateInplaceEditingCellElementSize();
        inputController.setCaretPosition(4);
    }
    function DisplayFunctionsList(spreadsheet) {
        spreadsheet.getFormulaIntelliSenseManager().displayPossibleFunctionNamesInListBox();
        var functionsListBox = spreadsheet.getFunctionsListBox();
        functionsListBox.SetSelectedItem(functionsListBox.FindItemByText("SUMIFS"));
    }
    function ClearStartEditSpreadsheetFormulaHandler() {
        this.StartEditSpreadsheetFormula = function() { return false; }
    }
    function StartSpreadsheetCellEditing(spreadsheet) {
        if(IsCellActive(spreadsheet, 2, 6) && spreadsheet.isActiveCellVisible()) {
            var stateController = spreadsheet.getStateController();
            stateController.setEditMode(ASPxClientSpreadsheet.StateController.Modes.Edit);
        }
        ClearStartSpreadsheetCellEditingHandler();
    }
    function ClearStartSpreadsheetCellEditingHandler() {
        this.StartSpreadsheetCellEditing = function() { return false; }
    }

    window.StartEditSpreadsheetFormula = StartEditSpreadsheetFormula;
    window.StartSpreadsheetCellEditing = StartSpreadsheetCellEditing;
})();
