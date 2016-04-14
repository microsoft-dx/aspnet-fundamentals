var simpleButton = document.getElementById("simpleButton");

simpleButton.addEventListener("click", function () {
    alert("You pressed a button using JavaScript!");
});

var helloButton = document.getElementById("helloButton");

helloButton.addEventListener("click", function () {
    alert("Hello, " + document.getElementById("nameInput").value + " from JavaScript!");
});