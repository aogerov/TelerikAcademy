function onFontColorChange() {
    var fontColor = document.getElementById("fontColor").value;
    var textArea = document.getElementById("textarea");
    textArea.style.color = fontColor;
}

function onBackgroundColorChange() {
    var backgroundColor = document.getElementById("backgroundColor").value;
    var textArea = document.getElementById("textarea");
    textArea.style.backgroundColor = backgroundColor;
}