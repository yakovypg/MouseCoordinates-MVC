let coordinates = [];
const coordinates_length_limit = 10000;

function capture_coordinates(event) {
    const x = event.clientX;
    const y = event.clientY;
    const t = new Date();

    const snapshot = [x, y, t]

    coordinates.push(snapshot);

    if (coordinates.length > coordinates_length_limit)
        coordinates = coordinates.slice(0, coordinates.length / 2);
}

function send_coordinates_to_server() {
    const json = JSON.stringify(coordinates);

    $.ajax({
        type: 'POST',
        url: '/Home/SaveCoordinates',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        data: json,
		complete: function () {
            coordinates = [];
        },
    });
}
