let enBas = document.getElementById("bas");
let enHaut = document.getElementById("haut");
let laGauche = document.getElementById("gauche");
let laDroite = document.getElementById("droite");
let leCarre = document.getElementById("carré");


// Clic sur Bouton

enBas.addEventListener("click", moveBas);
function moveBas() {
    leCarre.style.transform = "translateY(80px)";
}


enHaut.addEventListener("click",moveHaut);
function moveHaut() {
    leCarre.style.transform = "translateY(-80px)";
}


laDroite.addEventListener("click",moveDroite);
function moveDroite() {
    leCarre.style.transform = "translateX(80px)";
}


laGauche.addEventListener("click",moveGauche);
function moveGauche() {
    leCarre.style.transform = "translateX(-80px)";
}


// Keyboard

let positionCarre = {
    x: 0,
    y: 0,
};

function updatePosition(){
    let xPos = positionCarre.x;
    let yPos = positionCarre.y;
    let transform =  `translate(${xPos}px,${yPos}px)`;

    leCarre.setAttribute("transform", transform);
}

updatePosition();


// Fonction Update Haut
function updateHposition() {
    positionCarre.y -= 20;
};

// Fonction Update Bas
function updateBposition(){
    positionCarre.y += 20;
}

// Fonction Update Gauche

function updateGposition(){
    positionCarre.x -= 20;
}

// Fonction Update Droite

function updateDposition(){
    positionCarre.x += 20;
}

document.addEventListener("keydown", function(event) {
    switch (event.code) {
        case "ArrowUp":
        case "KeyZ":
            updateHposition(positionCarre.y);
            console.log(positionCarre);
        break;
        case "ArrowDown":
        case "KeyS":
            updateBposition(positionCarre.y);
            console.log(positionCarre);
        break;
        case "ArrowLeft":
        case "KeyQ":
            updateGposition(positionCarre.x);
            console.log(positionCarre);
        break;
        case "ArrowRight":
        case "KeyD":
            updateDposition(positionCarre.x);
            console.log(positionCarre);
// break pour stopper
        break;
    }
    updatePosition();

    if (event.code !== "Tab"){
        event.preventDefault();
    }
},
    true,    
);