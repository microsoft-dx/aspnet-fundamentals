var baseUrl = 'api/Hello/Greet'

var simpleButton = $("#simpleButton");
simpleButton.click(function () {

    $.ajax({
        url: baseUrl,
        dataType: 'json',
        success: alertMessage
    });
});

var firstNameButton = $("#firstNameButton");
firstNameButton.click(function () {
    var url = baseUrl + '?name=' + $("#simpleInput").val();

    $.ajax({
        url: url,
        dataType: 'json',
        success: alertMessage
    });
});


var fullNameButton = $("#fullNameButton");
//fullNameButton.click(function () {
//    var url = baseUrl + '?firstName=' + $("#firstNameInput").val() + '&lastName=' + $("#lastNameInput").val();

//    $.ajax({
//        url: url,
//        dataType: 'json',
//        success: alertMessage
//    });
//});

fullNameButton.click(function () {
   var url = baseUrl + '?firstName=' + $("#firstNameInput").val() + '&lastName=' + $("#lastNameInput").val();

   createAjaxCallOnButtonClick(this, url, alertMessage);
})

function alertMessage(message) {
    alert(message);
}

function createAjaxCallOnButtonClick(button, url, onSuccessMethod) {
    $.ajax({
        url: url,
        dataType: 'json',
        success: onSuccessMethod
    });
}