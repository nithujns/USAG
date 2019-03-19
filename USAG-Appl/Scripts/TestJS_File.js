function myFunction(x) {
    x.classList.toggle("change");
}

//function openNav() {
//    document.getElementById("mySidenav").style.width = "250px";
//}

//function closeNav() {
//    document.getElementById("mySidenav").style.width = "0";
//}

function w3_open() {
    document.getElementById("main").style.marginLeft = "25%";
    document.getElementById("mySidebar").style.width = "25%";
    document.getElementById("mySidebar").style.display = "block";
    document.getElementById("openNav").style.display = 'none';
}
function w3_close() {
    document.getElementById("main").style.marginLeft = "0%";
    document.getElementById("mySidebar").style.display = "none";
    document.getElementById("openNav").style.display = "inline-block";
}

var attempt = 3; // Variable to count number of attempts.
// Below function Executes on click of login button.
function validate() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    if (username == "nithya" && password == "123qwe") {
        alert("Login successfully");
        window.location = "success.html"; // Redirecting to other page.
        return false;
    }
    else {
        attempt--;// Decrementing by one.
        alert("You have left " + attempt + " attempt;");
        // Disabling fields after 3 attempts.
        if (attempt == 0) {
            document.getElementById("username").disabled = true;
            document.getElementById("password").disabled = true;
            document.getElementById("submit").disabled = true;
            return false;
        }
    }
}

$('.topnav').on('change', function () {
    if ($(this).val() === "Login") {
        $("#otherType").show()
    }
    else {
        $("#otherType").hide()
    }
});
//Next and previous button
//$('.continue').click(function () {
//    $('.pager > .active').next('li').find('a').trigger('click');
//});
//$('.back').click(function () {
//    $('.nav-tabs > .active').prev('li').find('a').trigger('click');
//});

//Pin Based and Pinless Processing. Switch between Radio buttons
$('.resultDetail').hide();
$('input[type=radio][name=choose-one]').change(function () {
  

    var value = $(this).val();

    if (value == 'Pin') {
        //$('#Pin').slideUp('500');
        $('.resultDetail').slideUp('500');
        $('.resultDetail.Pin').slideDown('500');
    }

    else if (value == 'Pinless') {
        $('.resultDetail').slideUp('500');
        $('.resultDetail.Pinless').slideDown('500');



    }
});


//Script to Change the title 

$(document).ready(function () {

    $(".Title").text;
});
