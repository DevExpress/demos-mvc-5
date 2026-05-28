function onButtonClick(s, e) {
    if (!ListBox.GetEnabled()) {
        ListBox.SetEnabled(true);
        HtmlEditor.SetVisible(false);
        RoundPanel.SetVisible(true);
        s.SetText("Edit Template");
        RoundPanel.PerformCallback({ selectedItemValue: ListBox.GetValue(), html: escape(HtmlEditor.GetHtml()) });
    }
    else {
        ListBox.SetEnabled(false);
        HtmlEditor.SetVisible(true);
        RoundPanel.SetVisible(false);
        s.SetText("Preview Results");
    }
}
function onSelectedIndexChanged(s, e) {
    RoundPanel.PerformCallback({ selectedItemValue: s.GetValue(), html: escape(HtmlEditor.GetHtml()) });
}