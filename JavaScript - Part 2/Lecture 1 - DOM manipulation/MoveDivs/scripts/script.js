function start() {
    for (var i = 0; i < 5; i++) {
        createDiv();
    }

    allDivs = document.getElementsByTagName("div");
    radius = 50;
    angle = 0;
    maxAngle = false;

    runEngine();
}

function createDiv() {
    var width = 80;
    var height = 80;
    var positionX = 50;
    var positionY = 50;
    var radius = 10;
    var div = document.createElement("div");

    div.style.position = "absolute";
    div.style.left = positionX + "px";
    div.style.top = positionY + "px";
    div.style.margin = 250 + "px";
    div.style.width = width + "px";
    div.style.height = height + "px";
    div.style.borderRadius = radius + "px";
    div.style.backgroundColor = getColor();

    document.body.appendChild(div);
}

function getColor() {
    var rangeStart = 0;
    var rangeEnd = 255;

    var red = getDimension(rangeStart, rangeEnd);
    var green = getDimension(rangeStart, rangeEnd);
    var blue = getDimension(rangeStart, rangeEnd);

    var color = "rgb(" + red + ", " + green + ", " + blue + ")";
    return color;
}

function getDimension(rangeStart, rangeEnd) {
    var size = Math.floor((Math.random() * rangeEnd) + rangeStart);
    return size;
}

function runEngine() {
    for (i = 0; i < 5; i++) {
        allDivs[i].style.left = Math.cos(angle + 2 * Math.PI / allDivs.length * i) / radius * 5000 + "px";
        allDivs[i].style.top = Math.sin(angle + 2 * Math.PI / allDivs.length * i) / radius * 5000 + "px";
    }

    angle = angle + 0.005;
    setTimeout(runEngine, 5);
}