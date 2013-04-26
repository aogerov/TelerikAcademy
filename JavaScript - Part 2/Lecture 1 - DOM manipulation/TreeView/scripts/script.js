function showAndHide() {
    $("li").addClass('hiddenList');

    $("li").click(function (e) {
        e.stopPropagation();

        if ($(this).hasClass('showedList')) {
            $(this).removeClass('showedList').addClass('hiddenList');
        }
        else {
            $(this).removeClass('hiddenList').addClass('showedList');
        }
    });
}