function GetStyleAttributes(commandName) {
    var result = [];
    result.push({ attrName: "font-weight", value: (cbBold.GetValue() ? "bold" : "") });
    result.push({ attrName: "font-style", value: (cbItalic.GetValue() ? "italic" : "") });
    result.push({ attrName: "text-decoration", value: (cbUnderline.GetValue() ? "underline" : "") });
    return result;
}
function BeforePasteHandler(s, e) {
    DXEventMonitor.Trace(s, e, 'BeforePaste', true);
    if (e.commandName != ASPxClientCommandConsts.PASTEHTMLPLAINTEXT_COMMAND) {
        var styleAttributes = GetStyleAttributes();
        var cssText = "";
        for (var i = 0, attr; attr = styleAttributes[i]; i++) {
            if (attr.value)
                cssText += attr.attrName + ": " + attr.value + ";";
        }
        if (cssText) {
            var array = e.html.match(/<(div|p|table|ol|ul|dl|h[1-6]|address|blockquote|center|pre)(?![^>]*display\s*:\s*inline)[^>]*/gi);
            var element = document.createElement(array && array.length > 0 ? "DIV" : "SPAN");
            element.innerHTML = e.html;
            element.style.cssText = cssText;
            e.html = element.outerHTML;
        }
    }
}