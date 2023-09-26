<?php

include './employee.class.php';

$employe = new Employee(["nom" => "Mergli" , "prenom" => "Laurent" , "dateembauche" => date_create('15-06-2018') , "salairebrutannuel" => 42000 , "service" => "comptabilite" ]);
$employe2 = new Employee(["nom" => "Bouchard" , "prenom" => "Patricia" , "dateembauche" => date_create('01-12-2010') , "salairebrutannuel" => 39000 , "service" => "Ressources Humaines" ]);
echo $employe->infos();