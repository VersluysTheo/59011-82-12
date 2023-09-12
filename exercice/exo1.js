var ampoule = document.querySelector("img");
ampoule.addEventListener('click', function() {
    if (ampoule.getAttribute("src") === "1 IMG/ampoule eteinte.PNG"){
    ampoule.setAttribute("src", "1 IMG/ampoule allumee.png");
    } else{
        ampoule.setAttribute("src", "1 IMG/ampoule eteinte.PNG");
    }
});

