function OnSelectionChanged(s, e) {
    var selectedElement = GetSelectedElement();
    s.SetRibbonContextTabCategoryVisible("ImageFormat", IsImageElement(selectedElement));
}
function OnCustomCommand(s, e) {
    var selectedElement = GetSelectedElement();
    if(!IsImageElement(selectedElement))
        return;
    if(e.commandName == "AltText")
        UpdateImageAltText(selectedElement);
    else if(e.commandName == "BorderColor")
        selectedElement.style.borderColor = e.parameter;
    else if(e.commandName == "BackColor")
        selectedElement.style.backgroundColor = e.parameter;
    else if(IsBorderStyle(e.commandName))
        selectedElement.style.borderStyle = e.commandName;
}

function GetSelectedElement() {
    var selection = HtmlEditor.GetSelection();
    return selection ? selection.GetSelectedElement() : null;
}
function IsImageElement(element) {
    return element && element.tagName.toLowerCase() == "img";
}
function IsBorderStyle(value) {
    return /^(hidden|dotted|dashed|solid|ridge)$/gi.test(value);
}
function UpdateImageAltText(element) {
    var alt = prompt("Please specify the alternate text:", element.alt);
    if(alt != null)
        element.alt = alt;
}