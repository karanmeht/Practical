
function createUser() {
    var name = document.forms[0].elements[0].value;
    var age = document.forms[0].elements["Age"].value;
    var date = document.forms[0].elements[2].value;
    let phone = document.forms[0].elements[3].value;

    if (name == "") {
        DisplayErrorMsg("msgName", "enter name");
    }
    else {
        cleanErrorMsg("msgName")
    }

    if (age == "") {
        DisplayErrorMsg("msgAge", "enter age");
    }
    else if (age < 18) {
        DisplayErrorMsg("msgAge", "Age should be 18 or greater");
    }
    else {
        cleanErrorMsg("msgAge")
    }

    if (phone.length == 0) {
        DisplayErrorMsg("msgPhone", "enter phone");
    }
    else if (phone.length != 10) {
        DisplayErrorMsg("msgPhone", "Enter valid number");
    }
    else {
        cleanErrorMsg("msgPhone")
    }

    if (date == "") {
        DisplayErrorMsg("msgDob", "Select Date");
    }
    else {
        cleanErrorMsg("msgDob")
    }

    if (name != "" && age != "" && phone != "" && date != "" && age > 18) {
        document.getElementsByTagName("lable").innerHTML = "";
        return true;
    }
    return false;
}

function cleanErrorMsg(cleanLable) {
    document.getElementById(cleanLable).innerHTML = "";
}

function DisplayErrorMsg(displayLable, msg) {
    document.getElementById(displayLable).innerHTML = msg;
}