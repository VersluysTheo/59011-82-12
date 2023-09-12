var ampoule1 = document.getElementById("amp1");
var ampoule2 = document.getElementById("amp2");

ampoule1.addEventListener("click", function() {
    if (ampoule1.style.display === "block") {
        ampoule1.style.display = "none";
        ampoule2.style.display = "block";
    } else {
        ampoule1.style.display = "block";
        ampoule2.style.display = "none";
    }
});

ampoule2.addEventListener("click", function() {
    if (ampoule2.style.display === "block") {
        ampoule2.style.display = "none";
        ampoule1.style.display = "block";
    } else {
        ampoule2.style.display = "block";
        ampoule1.style.display = "none";
    }
});

