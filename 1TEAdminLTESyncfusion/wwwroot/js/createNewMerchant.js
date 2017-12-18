$("#save").on('click', function (event) {
    $("#dialogIconSave").ejDialog("open");
});

function onbeforeopen(e) {
    $("#btn2").on('click', function (event) {
        $("#dialogIconSave").ejDialog("close");
    });

    $("#btn1").ejButton({ size: "mini", height: 30, width: 70 });
    $("#btn2").ejButton({ size: "mini", height: 30, width: 70 });

    $("#btn1").on('click', function (event) {
        $("#dialogIconSave").ejDialog("close");
        $("#createMerchantForm").submit();
    });
}

$("#back").on('click', function (event) {
    $("#dialogIconBack").ejDialog("open");
});

function onbeforeopenBack(e) {
    $("#btn2Back").on('click', function (event) {
        $("#dialogIconBack").ejDialog("close");
    });

    $("#btn1Back").ejButton({ size: "mini", height: 30, width: 70 });
    $("#btn2Back").ejButton({ size: "mini", height: 30, width: 70 });

    $("#btn1Back").on('click', function (event) {
        $("#dialogIconBack").ejDialog("close");
    });
}