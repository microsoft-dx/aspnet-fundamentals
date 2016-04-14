var simpleButton = $("#simpleButton");

simpleButton.click(function () {
    alert("You pressed a button from jQuery!!");
});


var helloButton = $("#helloButton");

helloButton.click(function () {
    alert("Hello, " + $("#nameInput").val());
});