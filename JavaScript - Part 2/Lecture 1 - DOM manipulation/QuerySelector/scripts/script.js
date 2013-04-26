function changeElements() {
    if (typeof document.querySelector != 'function') {
        document.querySelectorAll = function (selectorString) {
            return $(selectorString);
        }

        document.querySelector = function (selectorString) {
            return $(selectorString)[0];
        }
    }

    var listItems = document.querySelectorAll("#wrapper #section .strong");
    var listItemsLength = listItems.length;

    for (var i = 0; i < listItemsLength; i++) {
        var current = document.createElement("p");
        current.innerHTML = "<strong>" + listItems[i].innerHTML + " - item changed with query selector all</strong>";
        document.body.appendChild(current);
    }
}