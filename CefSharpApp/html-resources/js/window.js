$("#btn1").click(function () {
    cefCustomObject.showDevTools();
});

$("#btn2").click(function () {
    cefCustomObject.opencmd();
});

$("#devtools").click(function () {
    cefCustomObject.showDevTools();
});

$(".top-bar").bind("mousedown", function () {
    cefCustomObject.dragWindow();
    console.log("drag");
});

$("#closeWindow").bind("click", function () {
    cefCustomObject.closeWindow();
    console.log("close");
});

$("#minimizeWindow").bind("click", function () {
    cefCustomObject.minimizeWindow();
});

$("#maximizeWindow").bind("click", function () {
    cefCustomObject.maximizeWindow();
});

