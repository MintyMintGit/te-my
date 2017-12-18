
function verifyOTP() {
    var params = $.extend({}, doAjax_params_default);
    params['url'] = $_VerifyOtp;
    params['data'] = { OTPNumber: $("#OTPNo").val() };
    params['successCallbackFunction'] = enableTabs();
    params['dataType'] = "application/json";
    params['requestType'] = "POST";
    doAjax(params);
}
function enableTabs() {
    $("#tabContents").ejTab({ enabled: true });
}

function UserRegister(e) {
    if (e.status) {
        alert("User Registered Sucessfully");
        window.location.href = $_Registration;

    }
}

