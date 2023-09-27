<?php

include './employee.class.php';

$employe[] = new Employee(["nom" => "Mergli" , "prenom" => "Laurent" , "dateembauche" => "15-06-2018" , "salairebrutannuel" => 42424 , "service" => "comptabilite" ]);
$employe[] = new Employee(["nom" => "Bouchard" , "prenom" => "Patricia" , "dateembauche" => "01-12-2010" , "salairebrutannuel" => 39000 , "service" => "Ressources Humaines" ]);
$employe[] = new Employee(["nom" => "Galomp" , "prenom" => "Florian" , "dateembauche" => "11-08-2023" , "salairebrutannuel" => 28000 , "service" => "Informatique" ]);
$employe[] = new Employee(["nom" => "Vandeeburschee" , "prenom" => "Alicia" , "dateembauche" => "26-02-2015" , "salairebrutannuel" => 35500 , "service" => "Secretaire" ]);
$employe[] = new Employee(["nom" => "Royer" , "prenom" => "Jean-christophe" , "dateembauche" => "21-04-1999" , "salairebrutannuel" => 69800 , "service" => "Patron Directeur General" ]);
$employe[] = new Employee(["nom" => "Handekouloudjoko" , "prenom" => "Joachim" , "dateembauche" => "15-11-2021" , "salairebrutannuel" => 30420, "service" => "Developpeur Web"]);
$employe[] = new Employee(["nom" => "Bouchard" , "prenom" => "Louis" , "dateembauche" => "30-01-2022" , "salairebrutannuel" => 26060 , "service" => "Responsable Embauche" ]);


// echo "Tri par nom: \n";
// usort($employe, ["Employee", "triparNom"]); // Tri par nom
// echo "\n";

// foreach ($employe as $employes){
//     echo $employes->infos() . "\n";
// }
// echo "\n";
// echo "Tri par Prenom: \n ";
// usort($employe, ["Employee", "triparPrenom"]); // Tri par prenom
// echo "\n";

//     foreach ($employe as $employes){
//     echo $employes->infos() . "\n";
// }

// echo "\n";
// echo "Tri par Service: \n ";
// usort($employe, ["Employee", "triparService"]); // Tri par prenom
// echo "\n";

//     foreach ($employe as $employes){
//     echo $employes->infos() . "\n";
// }

echo "Il y a " . Employee::getCompteur() . " Employés ";