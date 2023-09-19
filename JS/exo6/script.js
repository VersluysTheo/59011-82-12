var enBas = document.getElementById("bas");
var enHaut = document.getElementById("haut");
var laGauche = document.getElementById("gauche");
var laDroite = document.getElementById("droite");
var leCarre = document.getElementById("carre");

//Position du carre

var positionCarre = {
    x: 0,
    y: 0,
};

var xCarre = positionCarre.x;
var yCarre = positionCarre.y;



// Clic sur Bouton


// Bas
enBas.addEventListener("click", moveBas);
function moveBas() {
    xCarre = xCarre;
    yCarre += 10;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}


// Haut
enHaut.addEventListener("click",moveHaut);
function moveHaut() {
    xCarre = xCarre;
    yCarre -= 10;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}


// Droite
laDroite.addEventListener("click",moveDroite);
function moveDroite() {
    xCarre += 10;
    yCarre = yCarre;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}

// Gauche
laGauche.addEventListener("click",moveGauche);
function moveGauche() {
    xCarre -= 10;
    yCarre = yCarre;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}


// Keyboard


// Fonction Update Haut
function updateHposition() {
    xCarre = xCarre;
    yCarre -= 10;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
};

// Fonction Update Bas
function updateBposition(){
    xCarre = xCarre;
    yCarre += 10;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}

// Fonction Update Gauche

function updateGposition(){
    xCarre -= 10;
    yCarre = yCarre;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}

// Fonction Update Droite

function updateDposition(){
    xCarre += 10;
    yCarre = yCarre;
    leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
    // console.log(xCarre,yCarre);
}

document.addEventListener("keydown", function(event) {
    switch (event.code) {
        case "ArrowUp":
        case "KeyW":
            updateHposition(positionCarre.y);
        break;
        case "ArrowDown":
        case "KeyS":
            updateBposition(positionCarre.y);
        break;
        case "ArrowLeft":
        case "KeyA":
            updateGposition(positionCarre.x);
        break;
        case "ArrowRight":
        case "KeyD":
            updateDposition(positionCarre.x);
// break pour stopper
        break;
    }

    if (event.code !== "Tab"){
        event.preventDefault();
    }
},
    true,    
);


// Souris

var body = document.querySelector("body");
var bodySize = body.getBoundingClientRect();
var holdCurseur = 0;


function moveCarre() {
    holdCurseur = 0;
    // console.log(xCarre,yCarre);
    // console.log("tu relaches");
}

function moveCurseur(event) {
    if (holdCurseur == 1) {
        xCurseur = event.clientX - leCarre.style.left.substring(0, leCarre.style.left.length - 2);
        yCurseur = event.clientY - leCarre.style.top.substring(0, leCarre.style.top.length - 2);
        xCarre = xCurseur;
        yCarre = yCurseur;
        leCarre.style.transform = `translate(${xCarre}px,${yCarre}px)`;
        // console.log(xCarre,yCarre);
    }

}

function enfonceClic() {
    holdCurseur = 1 ;
    // console.log(xCarre,yCarre);
    // console.log("tu enfonces");
}

leCarre.addEventListener("mousedown", enfonceClic);
document.addEventListener("mousemove", moveCurseur);
document.addEventListener("mouseup", moveCarre);



// Obstacles

function deplace(dx, dy) {
    var deplacement_ok = true;
    var styleCarre = window.getComputedStyle(document.getElementById('carre'), null);
    var t = parseInt(styleCarre.top);
    var l = parseInt(styleCarre.left);
    var w = parseInt(styleCarre.width);
    var h = parseInt(styleCarre.height);
    var listeObs = document.querySelectorAll('.obst');
    listeObs.forEach(function (elt) {
        var styleObst = window.getComputedStyle(elt, null);
        var tob = parseInt(styleObst.top);
        var lob = parseInt(styleObst.left);
        var wob = parseInt(styleObst.width);
        var hob = parseInt(styleObst.height);
        deplacement_ok = deplacement_ok && depl_ok(tob, lob, wob, hob, t + dy, l + dx, w, h);

    });
    if (deplacement_ok) {
        document.getElementById('carre').style.top = t + dy + 'px';
        document.getElementById('carre').style.left = l + dx + 'px';
    }
}

function depl_ok(t, l, w, h, tob, lob, wob, hob) {
    if (l < lob + wob && l + w > lob && t < tob + hob && t + h > tob) {
        return false
    }
    return true;
}
document.onkeydown = function (event) {
    var event = event || window.event, // pour la compatibilite avec tous les navigateurs
        keyCode = event.keyCode;

    // On détecte l'événement puis selon la fleche, on appelle deplace
    switch (keyCode) {
        case 38:
            deplace(0, -5);
            break;
        case 40:
            deplace(0, 5);
            break;
        case 37:
            deplace(-5, 0);
            break;
        case 39:
            deplace(5, 0);
            break;
    }
}
