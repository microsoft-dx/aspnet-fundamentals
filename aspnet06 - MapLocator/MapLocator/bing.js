var map;
function getMap() {

    var mapOptions = {
        credentials: 'Your Bing Maps API Key Here',
        enableClickableLogo: false,
        center: new Microsoft.Maps.Location(45, 26),
        zoom: 8,
        disableBirdseye: true,
        mapTypeId: Microsoft.Maps.MapTypeId.road,
        showDashboard: false

    };

    map = new Microsoft.Maps.Map(document.getElementById('myMap'), mapOptions);
    initializeSignalR();

}

function initializeSignalR() {
    hub = $.connection.mapHub;

    hub.client.placeMarker = function (latitude, longitude) {
        var pin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(latitude, longitude));
        map.entities.push(pin);
    };

    $.connection.hub.start().done(function () {
        Microsoft.Maps.Events.addHandler(map, 'click', function (event) {
            var point = new Microsoft.Maps.Point(event.getX(), event.getY());
            var coordinates = event.target.tryPixelToLocation(point);

            hub.server.placeMarker(coordinates.latitude, coordinates.longitude);
        });
    });
}