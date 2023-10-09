<?php

function ChargerClasse($classe)
{
    if (file_exists("./CONTROLLER/".$classe.".Class.php"))
    require "./CONTROLLER/".$classe.".Class.php";
    else if (file_exists("./MODEL/".$classe.".Class.php"))
    require "./MODEL/".$classe.".Class.php";
}
spl_autoload_register("ChargerClasse");

DbConnect::init();


// Ajout d'une personne
// $perso = new Personnes(["idPersonne"=>1,"nom"=>"pol","prenom"=>"toit"]);
// PersonnesManager::add($perso);

// Update d'une personne
// $perso = new Personnes();
// $perso->setIdPersonne(5);
// $perso->setNom("jesuisnilahsaran");
// $perso->setPrenom("Oulala");
// PersonnesManager::update($perso);

// Delete d'une personne
$perso = PersonnesManager::findById(7);
var_dump($perso);
PersonnesManager::delete($perso);




// $tab = ["idPersonne"=>1,"nom"=>"dupond2","prenom"=>"toto"];
// echo json_encode($tab);
// var_dump(PersonnesManager::getList("Personnes",["idPersonne","nom","prenom"],null,["nom"=>true,"prenom"=>false],"2,3",true));