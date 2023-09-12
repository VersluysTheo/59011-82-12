<?php
$tab = [];

for ($i = 1; $i < 6; $i++){
    $lettres = array_merge(range('A','E'));

    $secret[] = $lettres[rand(0,4)];
}

$final = implode("", $secret);

do {
$code = readline('Code : ? ');



// print_r($secret);

if ($code == $final) {
    echo "Le code était :  $final \n, Votre code est :  $code \n";
    echo 'Vous avez gagné';
}else {
    echo "Votre code est : $code \n";
    echo 'Vous pouvez réessayer ';
}
} while ($code!= $final);
