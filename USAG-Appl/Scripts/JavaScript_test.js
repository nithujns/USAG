function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    //document.getElementById("main").style.marginLeft = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}
           //Display hiiden fields when specific field is selected
$('#ddlCompany').on('change', function () {
    if ($(this).val() === "47") {
        $("#otherType").show()
    }
    else {
        $("#otherType").hide()
    }
});

/* Set the width of the side navigation to 250px and the left margin of the page content to 250px */
function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.getElementById("main").style.marginLeft = "250px";
}

/* Set the width of the side navigation to 0 and the left margin of the page content to 0 */
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}

function manageToggleMenu() {
    if (document.getElementById("toggleMenu").title == "Open") {
        document.getElementById("mySidenav").style.width = "250px";
        document.getElementById("main").style.marginLeft = "250px";
        document.getElementById("toggleMenu").title = "Close";
    }
    else if (document.getElementById("toggleMenu").title == "Close") {
        document.getElementById("mySidenav").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";
        document.getElementById("toggleMenu").title = "Open";
    }
}

//Code to Hide/Show Sub menu Item on the side bar
$(document).ready(function () {
    $(".has-submenu ul").hide();
    $(".has-submenu").click(function () {
        $(this).children("ul").toggle();
    });
});