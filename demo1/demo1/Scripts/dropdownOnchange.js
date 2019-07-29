function onChange() {
    var e = document.getElementById("itemId");
    console.log(e.options[e.selectedIndex].value);
    var etochange = document.getElementById("itemCode");
    etochange.value = e.options[e.selectedIndex].value;
}
