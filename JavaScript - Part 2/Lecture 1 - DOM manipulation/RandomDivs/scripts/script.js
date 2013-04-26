function onGenerate() {
    var minSizeDiv = 20;
    var maxSizeDiv = 100;
    var minBorderPixelValue = 1;
    var maxBorderPixelValue = 20;
    var windowWidth = window.innerWidth;
    var windowHeight = window.innerHeight;

    var length = Math.floor((Math.random() * 100) + 1);
    for (var i = 0; i < length; i++) {
        var width = getDimension(minSizeDiv, maxSizeDiv) + "px";
        var height = getDimension(minSizeDiv, maxSizeDiv) + "px";
        var positionX = getDimension(0, windowWidth - maxSizeDiv) + "px";
        var positionY = getDimension(0, windowHeight - maxSizeDiv) + "px";
        var borderWidth = getDimension(minBorderPixelValue, maxBorderPixelValue) + "px";
        var borderRadius = getDimension(minBorderPixelValue, maxBorderPixelValue) + "px";
        var borderColor = getColor();
        var fontColor = getColor();
        var backgroundColor = getColor();

        var strong = document.createElement("strong");
        strong.innerHTML = "div";

        var div = document.createElement("div");
        div.appendChild(strong);
        div.style.position = "absolute";
        div.style.textAlign = "center";

        div.style.width = width;
        div.style.height = height;
        div.style.left = positionX;
        div.style.top = positionY;
        div.style.borderStyle = "solid";
        div.style.borderWidth = borderWidth;
        div.style.borderRadius = borderRadius;
        div.style.borderColor = borderColor;
        div.style.color = fontColor;
        div.style.backgroundColor = backgroundColor;

        document.body.appendChild(div);
    }

    var button = document.getElementById("button");
    document.body.removeChild(button);
    button.style.position = "relative";
    document.body.appendChild(button);
}

function getDimension(rangeStart, rangeEnd) {
    var size = Math.floor((Math.random() * rangeEnd) + rangeStart);
    return size;
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