var hub = $.connection.hitCounterHub;

hub.client.updateCount = function (hitCount) {
    $("#counter").html("In acest moment sunt " + hitCount + " useri activi");
};

$.connection.hub.start().done(function () {
    hub.server.count();
});
