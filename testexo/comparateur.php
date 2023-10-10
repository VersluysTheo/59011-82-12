<?php

$essais = readline('Code : ? ');
$code = rand(1,9);

if ($code == $essais) {
    echo "Le code était :  $code \n, Votre code est :  $essais \n";
    echo 'Vous avez gagné';
}else {
    echo "Le code était : $code \n. Votre code est : $essais \n";
    echo 'Vous avez perdu';
}

//Demande d'un chiffre entre 1 et 9 et si c'est le même alors on a gagné, sinon on a perdu.