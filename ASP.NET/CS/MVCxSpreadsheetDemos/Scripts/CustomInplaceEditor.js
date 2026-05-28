(function() {
    ASPxClientSpreadsheetInplaceEditorHelper = (function() {
        var ASPxClientSpreadsheetInplaceEditorHelper = {},
            activeCell = null,
            activeEditor = null,
            activeSpreadsheet = null;

        var selectionChangedEvent = function(s, e) { onSpreadsheetSelectionChanged(s, e); },
            valueChangedEvent = function(s, e) { editorValueChanged(s, e); },
            keyDownEvent = function(s, e) { onCustomEditorKeyDown(s, e); };


        ASPxClientSpreadsheetInplaceEditorHelper.AssignEditor = function(spreadsheet, customEditor, eventArgs) {
            captureCell(eventArgs);
            captureParams(spreadsheet, customEditor);

            var activeCellRect = activeSpreadsheet.GetCellBounds(eventArgs.columnIndex, eventArgs.rowIndex);
            showInplaceEditor(eventArgs.value, activeCellRect);
        };

        // Events
        function subscribeEvents() {
            activeSpreadsheet.SelectionChanged.AddHandler(selectionChangedEvent);
            activeEditor.ValueChanged.AddHandler(valueChangedEvent);
            activeEditor.KeyDown.AddHandler(keyDownEvent);
        }
        function unsubscribeEvents() {
            activeSpreadsheet.SelectionChanged.RemoveHandler(selectionChangedEvent);
            activeEditor.ValueChanged.RemoveHandler(valueChangedEvent);
            activeEditor.KeyDown.RemoveHandler(keyDownEvent);
        }

        function editorValueChanged(s, args) {
            var value = getEditorValue(s);
            s.SetVisible(false);
            commitValue(value);
        }
        function onCustomEditorKeyDown(s, args) {
            if(ASPx.Key.Esc == args.htmlEvent.keyCode) {
                stopEditing();
            }
        }
        function onSpreadsheetSelectionChanged(spreadsheet, args) {
            if(activeCell) {
                var selection = args.selection;
                if(activeCell.columnIndex !== selection.activeCellColumnIndex || activeCell.rowIndex !== selection.activeCellRowIndex) {
                    stopEditing();
                }
            }
        }

        function getEditorValue(editor) {
            return editor.GetText ? editor.GetText() : editor.GetValue();
        }

        // Editing
        function commitValue(value) {
            activeSpreadsheet.SetCellEditorText(value);
            activeSpreadsheet.ApplyCellEdit();
            activeSpreadsheet.Focus();
            releaseCell();
            releaseParams();
        }
        function stopEditing() {
            releaseCell();

            activeEditor.SetVisible(false);
            activeSpreadsheet.Focus();
            activeSpreadsheet.CancelCellEdit();

            releaseParams();
        }

        // Helpers
        function showInplaceEditor(value, cellRect) {
            var editorMainElement = activeEditor.GetMainElement();
            activeEditor.SetText(value);
            changeElementPostiton(editorMainElement, cellRect);
            activeEditor.SetVisible(true);
            focusInplaceEditor();
        }
        function focusInplaceEditor() {
            setTimeout(function() {
                activeEditor.Focus();
            }, 100);
        }
        function changeElementPostiton(customEditor, rect) {
            var borderWidth = 2,
                width = rect.width - borderWidth,
                height = rect.height - borderWidth;

            ASPx.SetStyles(customEditor, { width: width, height: height, position: "absolute", zIndex: 12001 });
            ASPxClientUtils.SetAbsoluteX(customEditor, rect.left);
            ASPxClientUtils.SetAbsoluteY(customEditor, rect.top);
        }

        function captureParams(spreadsheet, customEditor, args) {
            activeEditor = customEditor;
            activeSpreadsheet = spreadsheet;

            subscribeEvents();
        }
        function releaseParams() {
            unsubscribeEvents();

            activeEditor = null;
            activeSpreadsheet = null;
        }

        function captureCell(args) {
            activeCell = { columnIndex: args.columnIndex, rowIndex: args.rowIndex };
        }
        function releaseCell() {
            activeCell = null;
        }

        return ASPxClientSpreadsheetInplaceEditorHelper;
    })();
})();