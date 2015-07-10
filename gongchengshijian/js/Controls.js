function onmouseovered(id) {
    if (id == "LinkButton1") {
        document.getElementById("LinkButton1").setAttribute("style", "Font-Size=13pt; color:#FF0000;");
    }
}
function onmouseouted(id) {
    if (id == "LinkButton1") {
        document.getElementById("LinkButton1").setAttribute("style", "Font-Size=13pt; color:#FFFFFF;");
    }
}