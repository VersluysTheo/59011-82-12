<?php 

// $nombre = readline("Nombre ? : ");
// $somme = 0;
// $i = 1 ;

// do{
//     $sommefin = $somme + $i;
//     $i++;
// } while($i <= $nombre);


// echo $sommefin;

// Solution de Clement

$nombre = readline('entrez un nombre : ');
for($i=1;$i<$nombre;$i++){
    $resultat += $i;
    echo $i . "+";
}
$resultat += $nombre;
echo $nombre . "=" . $resultat;