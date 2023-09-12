// TITRES Version 1

let Titre1 = document.querySelectorAll("h1,h2,h3");

function changerdeCouleur(){
    Titre1.forEach(titre => {
        if(titre.style.color == "magenta" ){
            titre.style.color = "purple";
        }else if(titre.style.color == "purple") {
            titre.style.color = "salmon"; 
        }else {
            titre.style.color = "magenta";
        }
    });
}

Titre1.forEach(titre => {
    titre.addEventListener("click", () => {
        changerdeCouleur();
    });
});





// PARAGRAPHES Version 2

let Paragraphe = document.querySelectorAll("p");

function changerCouleur(){
    Paragraphe.forEach(element => {
        if(element.style.color == "red") {
            element.style.color = "blue";
        }else if(element.style.color == "blue") {
            element.style.color = "black"; 
        }else {
            element.style.color = "red";
        }
    });
}

Paragraphe.forEach(element => {
    element.addEventListener("click", () => {
        changerCouleur(element);
    });
});


// 2)

// let para1 = document.querySelector("p");

// para1.addEventListener("click", () => {
//     para1.style.color = "blue";
// });

