(function() {
    var minRowIndex = 9, maxRowIndex = 17;
    var currencyColumns = [3, 5, 6, 7],
        discountColumns = [6],
        weightColumns = [2];
    var convertCurrencyCommand = { name: "ConvertCurrency", text: "Get Value In Euros", conversionRate: 0.87},
        discountCommand = {name: "GetDiscountStructure", text: "How the discount is calculated?"},
        convertUnitsCommand = {name: "ConvertUnits", text: "Get Value In Lbs", conversionRate: 2.20462};

    function SpreadsheetPopupMenuShowing(s, e) {
        if(e.menuType === ASPxClientSpreadsheetPopupMenuType.Cell) {
            e.menuItems.Clear();
            if(needToAddCustomMenuItems(s)) {
                if(isSelectedCellOfType(s, currencyColumns))
                    addCustomMenuItem(e.menuItems, convertCurrencyCommand);
                if(isSelectedCellOfType(s, discountColumns))
                    addCustomMenuItem(e.menuItems, discountCommand);
                if(isSelectedCellOfType(s, weightColumns))
                    addCustomMenuItem(e.menuItems, convertUnitsCommand);
            }
        }
        else if(e.menuType !== ASPxClientSpreadsheetPopupMenuType.AutoFilter)
            e.cancel = true;
    }
    function SpreadsheetCustomCommandExecuted(s, e) {
        if (e.commandName === convertCurrencyCommand.name || e.commandName === convertUnitsCommand.name){
            var command = (e.commandName === convertCurrencyCommand.name) ? convertCurrencyCommand : convertUnitsCommand;
            ASPxClientHint.Show(getActiveCellElement(s), {
                content: convertActiveCellValue(s, command),
                position: "right",
                className: "cellHint",
                onShowing: function(sender, e) {
                    hideHintOnTimeout(e.hintElement);
                }
            });
        }
        else if(e.commandName === discountCommand.name) {
            ASPxClientHint.Show(getActiveCellElement(s), {
                position: "right",
                className: "cellHint",
                onShowing: function(sender, e) {
                    PerformCallback(e.hintElement);
                    return "loading...";
                }
            });
        }
    }
    function ShowCallbackResultInHint(hintElement, callbackResult) {
        hintElement.lastElementChild.innerHTML = callbackResult;
        hideHintOnTimeout(hintElement);
    }
    function hideHintOnTimeout(hintElement) {
        window.setTimeout(function() {
            ASPxClientHint.Hide(hintElement);
        }, 3000);
    }
    function needToAddCustomMenuItems(spreadsheet){
        var selection = spreadsheet.GetSelection();
        return isSingleCellSelected(selection) && isSelectionWithinTable(selection) && spreadsheet.GetActiveCellValue() !== null;
    }
    function isSingleCellSelected(selection){
        return selection.leftColumnIndex === selection.rightColumnIndex && selection.topRowIndex === selection.bottomRowIndex;
    }
    function isSelectionWithinTable(selection){
        return selection.activeCellRowIndex >= minRowIndex && selection.activeCellRowIndex <= maxRowIndex;
    }
    function isSelectedCellOfType(spreadsheet, typedColumnsIndices) {
        var selection = spreadsheet.GetSelection();
        return typedColumnsIndices.indexOf(selection.activeCellColumnIndex) >= 0
    }
    function addCustomMenuItem(menuItems, command) {
        var item = new ASPxClientSpreadsheetPopupMenuItem(command.name, command.text, null, null);
        menuItems.Add(item);
    }
    function getActiveCellElement(spreadsheet) {
        var renderHelper = spreadsheet.getRenderHelper();
        return renderHelper.getActiveCellElement();
    }
    function convertActiveCellValue(spreadsheet, command) {
        var convertedValue = convertNumericValue(getActiveCellNumericValue(spreadsheet), command);
        if(command.name === convertUnitsCommand.name)
            convertedValue = convertedValue + " lbs";
        else
            convertedValue = "€" + convertedValue;
        return convertedValue;
    }
    function getActiveCellNumericValue(spreadsheet) {
        return spreadsheet.GetActiveCellValue().replace(/\$|(?:\skg)/g, "");
    }
    function convertNumericValue(value, conversionCommand) {
        return Math.round(value * conversionCommand.conversionRate * 100) / 100;
    }
    
    window.SpreadsheetPopupMenuShowing = SpreadsheetPopupMenuShowing;
    window.SpreadsheetCustomCommandExecuted = SpreadsheetCustomCommandExecuted;
    window.ShowCallbackResultInHint = ShowCallbackResultInHint;
})();
