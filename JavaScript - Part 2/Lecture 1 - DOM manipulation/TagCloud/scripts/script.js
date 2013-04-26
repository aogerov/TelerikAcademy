Array.prototype.shuffle = function () {
    for (var i = this.length - 1; i > 0; i--) {
        var j = Math.floor(Math.random() * (i + 1));
        var tmp = this[i];
        this[i] = this[j];
        this[j] = tmp;
    }

    return this;
}

function generateTagCloud() {
    var minFontSize = 17;
    var maxFontSize = 42;
    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css",
    "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC",
    "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];
    var occurrences = [];

    var tagsLength = tags.length;
    for (var i = 0; i < tagsLength; i++) {
        var current = tags[i].toLowerCase();
        var alreadyExists = checkIfAlreadyExists(occurrences, current);
        if (!alreadyExists) {
            occurrences.push(current);
        }
    }

    var minOccurrence = new Number(tagCounter(tags, occurrences[0]));
    var maxOccurrence = new Number(tagCounter(tags, occurrences[0]));

    var occurrencesLength = occurrences.length;
    for (var i = 1; i < occurrencesLength; i++) {
        var current = occurrences[i];
        var counter = tagCounter(tags, current);

        if (counter < minOccurrence) {
            minOccurrence = counter;
        }

        if (counter > maxOccurrence) {
            maxOccurrence = counter
        }
    }

    var fontSizeStep = calculateFontSizeStep(minFontSize, maxFontSize, minOccurrence, maxOccurrence);
    occurrences.shuffle();
    createTextArea();

    for (var i = 0; i < occurrencesLength; i++) {
        var current = occurrences[i];
        var counter = tagCounter(tags, current);
        var currentFontSize = calculateCurrentFontSize(minFontSize, fontSizeStep, minOccurrence, counter);
        printOutput(current, currentFontSize);
    }
}

function checkIfAlreadyExists(occurrences, current) {
    var foundCurrent = false;

    var occurrencesLength = occurrences.length;
    for (var i = 0; i < occurrencesLength; i++) {
        if (current === occurrences[i]) {
            foundCurrent = true;
            break;
        }
    }

    return foundCurrent;
}

function tagCounter(tags, current) {
    var counter = 0;

    var tagsLength = tags.length;
    for (var i = 0; i < tagsLength; i++) {
        if (current === tags[i].toLowerCase()) {
            counter++;
        }
    }

    return counter;
}

function calculateFontSizeStep(minFontSize, maxFontSize, minOccurrence, maxOccurrence) {
    var fontSizeDifference = maxFontSize - minFontSize;
    var occurrenceDifference = maxOccurrence - minOccurrence;
    var fontSizeStep = fontSizeDifference / occurrenceDifference;
    return fontSizeStep;
}

function calculateCurrentFontSize(minFontSize, fontSizeStep, minOccurrence, counter) {
    var difference = counter - minOccurrence;
    var currentFontSize = minFontSize + (difference * fontSizeStep);
    return currentFontSize;
}

function createTextArea() {
    var textArea = document.createElement("div");
    document.body.appendChild(textArea);
}

function printOutput(tag, fontSize) {
    var currentTag = document.createElement("span");
    currentTag.innerHTML = tag + " ";
    currentTag.style.fontSize = fontSize + "px";

    var textArea = document.getElementsByTagName("div")[0];
    textArea.appendChild(currentTag);
}