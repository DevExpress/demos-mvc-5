function PerformSelection(s, e) {
    gvProducts.cpOldProductCount = gvProducts.cpProductCount;
    gvProducts.PerformCallback();
}

function OnEndCallback() {
	var message = "Accepted products table updated.";
    if(gvProducts.cpOldProductCount !== gvProducts.cpProductCount) {
        message += " Elements count changed from " + gvProducts.cpOldProductCount + " to " + gvProducts.cpProductCount;
        gvProducts.cpOldProductCount = gvProducts.cpProductCount;
    }
	ASPxClientUtils.SendMessageToAssistiveTechnology(message);
}