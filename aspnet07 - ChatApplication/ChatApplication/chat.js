var userName = prompt("Enter your name: ");
var chat = $.connection.chatHub;
chat.client.messageReceived = function (originatorUser, message) {
    $("#messages").append('<li><strong>' + originatorUser + '</strong>: ' + message);
};

chat.client.getConnectedUsers = function (userList) {
    for (var i = 0; i < userList.length; i++)
        $("#userList").append('<li>' + userList[i] + '</li>');
};

chat.client.newUserAdded = function (newUser) {
    $("#userList").append('<li>' + newUser + '</li>');
}

$("#messageBox").focus();

$("#sendMessage").click(function () {
    chat.server.send(userName, $("#messageBox").val());
    $("#messageBox").val("");
    $("#messageBox").focus();
});

$("#messageBox").keyup(function (event) {
    if (event.keyCode == 13)
        $("#sendMessage").click();
});

$.connection.hub.logging = true;
$.connection.hub.start().done(function () {
    chat.server.connect(userName);
});
