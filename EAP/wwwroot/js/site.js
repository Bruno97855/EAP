function openLatNav() {
    var navbar = document.getElementById("latNavbar");
    if (navbar.style.right === "-250px") {
        navbar.style.right = "0";
    } else {
        navbar.style.right = "-250px";
    }
}

$(document).ready(function () {
    var toggleButton = $(".custom-dropdown-toggle");
    var dropdownMenu = $(".custom-dropdown-menu");

    toggleButton.click(function () {
        dropdownMenu.toggle();
    });

    dropdownMenu.on("click", "li", function () {
        var selectedOption = $(this);
        var selectedOptionValue = selectedOption.data("value");
        var selectedOptionText = selectedOption.text();

        // Atualize o texto e o valor do botão de alternância com o texto e o valor da opção selecionada
        toggleButton.text(selectedOptionText);
        toggleButton.attr("value", selectedOptionValue);

        // Feche o menu suspenso
        dropdownMenu.hide();
    });

    $(document).click(function (e) {
        if (
            !toggleButton.is(e.target) &&
            !dropdownMenu.is(e.target) &&
            dropdownMenu.has(e.target).length === 0
        ) {
            dropdownMenu.hide();
        }
    });
});





