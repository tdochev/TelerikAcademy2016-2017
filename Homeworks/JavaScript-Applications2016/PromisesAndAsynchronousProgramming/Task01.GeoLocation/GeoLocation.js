(function() {
    'use strict';
    var locationElement = document.getElementById("location-element");

    function getGeolocationPositionPromise() {
        return new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(
                (position) => { resolve(position); },
                (error) => { reject(error); });
        });
    }

    function parseLatAndLongCoords(geolocationPosition) {
        if (geolocationPosition.coords) {
            return { lat: geolocationPosition.coords.latitude, long: geolocationPosition.coords.longitude };
        } else {
            throw { message: "No coords element found", name: "UserException" };
        }
    }

    function createGeolocationImage(coordsObj) {
        var imgElement = document.createElement("img"),
            imgSrc = "https://maps.googleapis.com/maps/api/staticmap?center=" + coordsObj.lat + "," + coordsObj.long + "&zoom=18&size=800x800&markers=color:red|label:None|" + coordsObj.lat + "," + coordsObj.long;

        imgElement.setAttribute("src", imgSrc);

        locationElement.appendChild(imgElement);
    }

    getGeolocationPositionPromise()
        .then(parseLatAndLongCoords)
        .then(createGeolocationImage);
}());