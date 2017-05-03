$("#btn1").click(function () {
    cefCustomObject.showDevTools();
});

$("#btn2").click(function () {
    var data = cefCustomObject.opencmd();
    console.log(data);
});

$("#devtools").click(function () {
    cefCustomObject.showDevTools();
});

$(".top-bar").bind("mousedown", function () {
    cefCustomObject.dragWindow();
});

$("#closeWindow").bind("click", function () {
    cefCustomObject.closeWindow();
});

$("#minimizeWindow").bind("click", function () {
    cefCustomObject.minimizeWindow();
});

$("#maximizeWindow").bind("click", function () {
    cefCustomObject.maximizeWindow();
});

