<?php
$code = readline('Code : ? ');

for ($i = 1; $i < 6; $i++){
    $lettres = array_merge(range('A','E'));

    $secret = $lettres[rand(0,4)];
}


if ($code == $lettres) {
    echo "Le code était :  $secret \n, Votre code est :  $code \n";
    echo 'Vous avez gagné';
}else {
    echo "Le code était : $secret \n. Votre code est : $code \n";
    echo 'Vous avez perdu';
}