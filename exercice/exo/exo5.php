<?php

// $age=readline("Conducteur plus de 25 ans ? : ");
// $permis=readline("Permis depuis plus de 2 ans ? : ");
// $accident=readline("Jamais eu d'accident ? : ");
// $point = $age + $permis + $accident;

// if($point == 3){
//     echo "Tarif Vert";
// } elseif($point == 2){
//     echo "Tarif Orange";
// } elseif ($point == 1){
//     echo "Tarif Rouge";
// } else {
//     echo "vous n'êtes pas assuré";
// }


// Solution 

$age = readLine('Age : ');
$permis = readLine('Années de permis : ');
$accident = readLine('Nombre d\'accidents : ');
$gold = readLine('Client depuis plus d\'un an ? : ');

$score = 0;

$couleur = ['rouge', 'orange', 'verte', 'bleue'];

    if($age>25){
        $score ++;
    }

    if($permis>2){
        $score ++;
    }

    $score -= $accident;

    if($gold && $score >= 0){
        $score ++;
    }

    if($score >= 0){
        echo 'Vous avez droit à l\'assurance de couleur '.$couleur[$score];
    }
    else{
        echo 'Vous ne pouvez pas souscrire à une assurance';
    }