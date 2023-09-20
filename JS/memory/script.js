/* Initialisation */
// Variables Cartes, Bouton etc
var lesCartes = document.querySelectorAll('.image');
var leBouton = document.querySelector('button');
var leReset = document.querySelector('.reset');
var paramCorrect = false;
var gameStarted = false;
var nbrJoueur = document.getElementById('player');
var nbrPair = document.getElementById('pairs');
var leChrono = document.getElementById('chrono');
var grille = document.querySelector(".container");
var temp = document.querySelector('#templatecard');

/* Nombre de Joueurs */
nbrJoueur.addEventListener("change", checkParameters);

/* Nombre de Pairs */
nbrPair.addEventListener('change', checkParameters);

/* Chrono */
leChrono.addEventListener('change', checkParameters);


/* CardGeneration */
leBouton.addEventListener('click', startGame);

/* Reload Page */
leReset.addEventListener('click', reLoad);


// Appel du template et l'endroit ou on le met


function generationTemplate(j){
    for (i = 1; i < j+1; i++) {
        // Cloner le Template
        const element2 = temp.content.cloneNode(true);
        // Ajout la ligne a la grille  
        grille.appendChild(element2);
        // On reclone et réeajoute 
        const element3 = temp.content.cloneNode(true);
        grille.appendChild(element3);
        grille.innerHTML = grille.innerHTML.replaceAll("VALEUR", i);
    }
}



/* function Shuffle */


/* Starting game */

function startGame(){
    if (paramCorrect = true && leChrono.value !== 'none' && nbrJoueur.value !== 'vide'){
        setTimer();
    }
    cardGeneration();
    inGame();
    initCard();
    return gameStarted = true ;
}

/* Fonction reload page */

function reLoad(){
    window.location.reload();
} 

/* Fonction disable les paramètre in game */
function inGame(){
    leBouton.setAttribute('disabled' , 'true');
    nbrJoueur.setAttribute('disabled' , 'true');
    nbrPair.setAttribute('disabled' , 'true');
    leChrono.setAttribute('disabled' , 'true');
}

/* Retourner les cartes au début de partie */
function initCard(){
    alert('Je suis censé retourné les cartes');
}

/* Function Card Generation */
function cardGeneration(){
    if (nbrPair.value == 'troisp'){
        j = 3;
    } else if (nbrPair.value == 'cinqp'){
        j = 5;
    } else if (nbrPair.value == 'huitp'){
        j = 8;
    } else if(nbrPair.value == 'dixp'){
        j = 10;
    }
    generationTemplate(j);
}


/* Checking parameter */
function checkParameters(){
    if (nbrJoueur.value == 'vide' || nbrPair.value == 'vide' || leChrono.value == 'vide') {
        leBouton.setAttribute('hidden', 'true');
        return paramCorrect = false;
    } else if(nbrJoueur.value !== 'vide' && nbrPair.value !== 'vide' && leChrono.value && 'vide'){
        leBouton.removeAttribute('hidden', 'true');
        return paramCorrect = true;
    }
}

function setTimer(){
    setTimeout(youLoose, 2000);
}

/* function FlipCard */


/* function checkCard */


/* function CheckOk */


/* function Victory */

function youWin(){
    alert('Simulation de Victoire');
}

/* Defeat */

function youLoose(){
    alert('Simulation de defaite :(');
}