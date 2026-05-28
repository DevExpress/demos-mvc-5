function onPopupInit(s, e) {
    setPopupWidth(s, true);
    ASPxClientControl.GetControlCollection().BrowserWindowResized.AddHandler(function(win, evt) {
        setPopupWidth(s, false);
    });
}
function setPopupWidth(popup, allowGrowing) {
    var placeHolderWidth = document.getElementById("PopupPlaceHolder").clientWidth;
    if(popup.GetWidth() > placeHolderWidth || allowGrowing) 
        popup.SetWidth(placeHolderWidth);
    popup.UpdatePosition();
}
function onWindowResize(s, e) {
    Ribbon.AdjustControl();
}
