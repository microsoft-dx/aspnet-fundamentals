var map;
var hub;


function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng(45, 26),
        zoom: 8
    };
    map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);
    initializeSignalR();
}

google.maps.event.addDomListener(window, 'load', initialize);

function initializeSignalR() {

    hub = $.connection.mapHub;

    hub.client.placeMarker = function (latitude, longitude) {
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(latitude, longitude),
            map: map
        });
    }

    $.connection.hub.start().done(function () {
        google.maps.event.addListener(map, 'click', function (event) {
            hub.server.placeMarker(event.latLng.lat(), event.latLng.lng());
        })
    });

}