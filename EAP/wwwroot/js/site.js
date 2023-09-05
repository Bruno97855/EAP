function openLatNav() {
    var navbar = document.getElementById("latNavbar");
    if (navbar.style.right === "-250px") {
        navbar.style.right = "0";
    } else {
        navbar.style.right = "-250px";
    }
}