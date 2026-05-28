var textSeparator = ";";
var tempText = "";
function updateText() {
    var selectedItems = listBox.GetSelectedItems();
    ddeExtraServices.SetText(getSelectedItemsText(selectedItems));
}
function synchronizeListBoxValues(dropDown, args) {
    listBox.UnselectAll();
    var texts = dropDown.GetText().split(textSeparator);
    var values = getValuesByTexts(texts);
    listBox.SelectValues(values);
    updateText();
}
function getSelectedItemsText(items) {
    var texts = [];
    for (var i = 0; i < items.length; i++)
        texts.push(items[i].text);
    return texts.join(textSeparator);
}
function getValuesByTexts(texts) {
    var actualValues = [];
    var item;
    for (var i = 0; i < texts.length; i++) {
        item = listBox.FindItemByText(texts[i]);
        if (item != null)
            actualValues.push(item.value);
    }
    return actualValues;
}
function onDropDownCommandButtonClick(s, e) {
    if (e.commandName == "Apply")
        s.HideDropDown();
    if (e.commandName == "Close") {
        s.SetText(tempText);
        s.HideDropDown();
    }
}
function onDropDown(s, e) {
    tempText = s.GetText();
    synchronizeListBoxValues(s, e);
}