<?php 

$nbrattempts = 10;
$attempts = 0;
$final = 0;

do{
    $attempts++;
} while ($attempts < 10);
if ($attempts = $nbrattempts){
    $final = rand(0,1) ;
}

if ($final == 1){
    echo "Victoire...";
}else{
    echo "Perdu...";
}    



// Tant que $final == 0 le jeu continue
// Condition de défaite : $attempts = $nbrattempts ET $final != 1
// Condition de victoire : $attempts <= $nbrattempts ET $final == 1