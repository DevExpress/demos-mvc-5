var isDirty = false;
var initialState = { };
function onControlsInitialized() {
    ASPxClientEdit.AttachEditorModificationListener(onEditorsChanged, function(control) {
            return control.GetParentControl() === FormLayout // Gets standalone editors nested inside the form layout control
        });
    ASPxClientUtils.AttachEventToElement(window, "beforeunload", onBeforeUnload);
    initialState = ASPxClientUtils.GetEditorValuesInContainer(FormLayout.GetMainElement());
}
function onEditorsChanged(s, e) {
    SaveButton.SetEnabled(true);
    CancelButton.SetEnabled(true);
    isDirty = true;
}

function cancelChanges(s, e) {
    ASPxClientUtils.SetEditorValues(initialState);
    isDirty = false;
    SaveButton.SetEnabled(false);
    CancelButton.SetEnabled(false);
}
function onBeforeUnload(e) {
    if(!isDirty)
        return;
    e.returnValue = true;
}
function onSubmitForm() {
    isDirty = false;
}