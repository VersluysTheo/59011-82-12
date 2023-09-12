<?php 

for ($i = 1; $i < 6; $i++){
    $lettres = array_merge(range('A','E'));

    echo $lettres[rand(0,4)];
}

