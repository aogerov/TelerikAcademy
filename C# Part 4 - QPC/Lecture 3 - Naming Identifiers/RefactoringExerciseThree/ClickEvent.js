function onButtonClick(e, args) {
    var myWindow = window;
    var myBrowser = myWindow.navigator.appCodeName;
    var isMozilla = (myBrowser == "Mozilla");

    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}