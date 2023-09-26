<?php

include './employee.class.php';

$employe = new Employee(["nom" => "Mergli" , "prenom" => "Laurent" , "dateembauche" => "15-06-2018" , "salairebrutannuel" => 42424 , "service" => "comptabilite" ]);
$employe2 = new Employee(["nom" => "Bouchard" , "prenom" => "Patricia" , "dateembauche" => "01-12-2010" , "salairebrutannuel" => 39000 , "service" => "Ressources Humaines" ]);
$employe3 = new Employee(["nom" => "Galomp" , "prenom" => "Florian" , "dateembauche" => "11-08-2023" , "salairebrutannuel" => 28000 , "service" => "Informatique" ]);
$employe4 = new Employee(["nom" => "Vandeeburschee" , "prenom" => "Alicia" , "dateembauche" => "26-02-2015" , "salairebrutannuel" => 35500 , "service" => "Secretaire" ]);
$employe5 = new Employee(["nom" => "Royer" , "prenom" => "Jean-christophe" , "dateembauche" => "21-04-1999" , "salairebrutannuel" => 69800 , "service" => "Patron Directeur General" ]);
$employe6 = new Employee(["nom" => "Handekouloudjoko" , "prenom" => "Joachim" , "dateembauche" => "15-11-2021" , "salairebrutannuel" => 30420, "service" => "Developpeur Web"]);
// echo $employe->infos();
// echo $employe2->infos();
// echo $employe3->infos();
// echo $employe4->infos();
// echo $employe5->infos();
// echo $employe6->infos();
// echo $employe6->versement();

$employes = [$employe, $employe1, $employe2, $employe3, $employe4, $employe5, $employe6];
foreach($employes as $employe){
    function triParNom($a, $b)
    {
        if ($a['nom'] == $b['nom']){
            return ($a < $b);
        }
    }
}