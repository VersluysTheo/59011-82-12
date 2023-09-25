/*******  Variables   *************************************/
var nbrclick = 0;
var compteurClick = document.getElementById('compteur');
var lesCases = document.getElementsByClassName("case");
var caseBlanche = document.getElementsByClassName("caseblanche");




/***************Listeners**********************************/
window.addEventListener('click', unClic);
caseBlanche[0].addEventListener("click", move);



/*****************Fonctions ******************************/

function unClic()
{
    nbrclick++ ;
    compteurClick.innerHTML = nbrclick;
}

function initGame() 
{
    var tab= [];
    for (let i = 1; i < 9; i++) {
        tab[i - 1] = i;
    }
    for (let i = 0; i < 8; i++) {
        rand = Math.ceil(Math.random() * tab.length-1);
        lesCases[i].innerHTML = tab[rand];
        tab.splice(rand,1);
    }
}
initGame();

function move()
{
    alert('oui');
}
