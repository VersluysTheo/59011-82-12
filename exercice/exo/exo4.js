let boutonDessert = document.getElementById("boutondessert");
let liste = document.querySelectorAll("li");

// Ajouter

boutonDessert.addEventListener("click", () => {
    unDessert = prompt("Ajouter un Dessert");
    let li = document.createElement("li");
    let leDessert = document.createTextNode(unDessert);
    li.appendChild(leDessert);
    let listerle = document.getElementById("lister");
    listerle.appendChild(li);

    let liste = document.querySelectorAll("li");
    liste.forEach(element => {
        element.addEventListener("click", () =>{
            element.remove();
        });
    });
});


// Supprimer

liste.forEach(element => {
    element.addEventListener("click", () =>{
        element.remove();
    });
});


// Supprimer
// let liste = document.querySelector("li");
// liste.addEventListener("click", () =>{
//     liste.remove();
// });
