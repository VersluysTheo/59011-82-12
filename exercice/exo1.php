<?php
$age = '';
$categorie = '';
if ($age >= 6 and $age <= 7) {
    $categorie = "Poussin " ;
}
elseif ($age >= 8 and $age <= 9) {
    $categorie = "Pupille " ;
}
elseif ($age >= 10 and $age <= 11) {
    $categorie = "" ;
}
elseif ($age >= 12) {
    $categorie = "Cadet " ;
}
else {
    $categorie = 'Aucune ' ;
}
echo $categorie; 


/* Correction */

$age2 = readline("ton age : 18 ans ");
$message = '';

if($age2 > 11){
    $message = 'Cadet ';
}elseif($age2 > 9){
    $message = 'Minime ';
}elseif($age2 > 7){
    $message = 'Pupille ';
}elseif($age2 > 5){
    $message = 'Poussin ';
}else{
    $message ='trop jeune ';
}

echo $message;

?>


