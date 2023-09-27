<?php

include './employee.class.php';
include './agence.class.php';
// Tableau Objet
//Agence
$a1 = new Agence(["nom" => "Koulmi", "adresse" => "75 Rue Moulin bleu", "codepostal" => "59750" , "ville" => "Lille" , "modeRestauration" => "Restaurant d'entreprise"]);
$a2 = new Agence(["nom" => "Complund", "adresse" => "21 Boulevard du Papillon de nuit", "codepostal" => "06200" , "ville" => "Nice" , "modeRestauration" => "Aucun"]);
$a3 = new Agence(["nom" => "Atros", "adresse" => "62 Avenue Billboul", "codepostal" => "78900" ,"ville" => "Yvelines" , "modeRestauration" => "Aucun"]);

//Employe
$employe[] = new Employee(["nom" => "Mergli" , "prenom" => "Laurent" , "dateembauche" => "15-06-2018" , "salairebrutannuel" => 42424 , "service" => "comptabilite" , "agence" => $a3 , "vacances" => ""]);
$employe[] = new Employee(["nom" => "Bouchard" , "prenom" => "Patricia" , "dateembauche" => "01-12-2010" , "salairebrutannuel" => 39000 , "service" => "Ressources Humaines" , "agence" => $a1, "vacances" => ""]);
$employe[] = new Employee(["nom" => "Galomp" , "prenom" => "Florian" , "dateembauche" => "11-08-2023" , "salairebrutannuel" => 28000 , "service" => "Informatique" , "agence" => $a2, "vacances" => ""]);
$employe[] = new Employee(["nom" => "Vandeeburschee" , "prenom" => "Alicia" , "dateembauche" => "26-02-2015" , "salairebrutannuel" => 35500 , "service" => "Secretaire" , "agence" => $a1, "vacances" => ""]);
$employe[] = new Employee(["nom" => "Royer" , "prenom" => "Jean-christophe" , "dateembauche" => "21-04-1999" , "salairebrutannuel" => 69800 , "service" => "Patron Directeur General" , "agence" => $a1, "vacances" => ""]);
$employe[] = new Employee(["nom" => "Handekouloudjoko" , "prenom" => "Joachim" , "dateembauche" => "15-11-2021" , "salairebrutannuel" => 30420, "service" => "Developpeur Web", "agence" => $a3, "vacances" => ""]);
$employe[] = new Employee(["nom" => "Bouchard" , "prenom" => "Louis" , "dateembauche" => "30-01-2022" , "salairebrutannuel" => 26060 , "service" => "Responsable Embauche", "agence" => $a2, "vacances" => ""]);


// echo "Tri par nom: \n";;
// usort($employe, ["Employee", "triparNom"]); // Tri par nom
// echo "\n";

// foreach ($employe as $employes){
//     echo $employes->infos() . "\n";
// }
// echo "\n";
// echo "Tri par Prenom: \n ";
// usort($employe, ["Employee", "triparPrenom"]); // Tri par prenom
// echo "\n";

//     foreach ($employe as $employes){ // Recuperation des infos
//     echo $employes->infos() . "\n";
// }

// echo "\n";
// echo "Tri par Service: \n ";
// usort($employe, ["Employee", "triparService"]); // Tri par prenom
// echo "\n";

//     foreach ($employe as $employes){ // Affichage infos 
//     echo $employes->infos() . "\n";
// }

// echo "Il y a " . Employee::getCompteur() . " Employés \n"; // Affichage du nombre d'employés
// echo "La masse salariale est de " . Employee::masseSalariale($employe) . " euros "; // Affichage de la masse salariale 

echo $employes->vacances($employe);