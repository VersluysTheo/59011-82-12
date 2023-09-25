<?php 

include './Voiture.class.php';
$voiture = new Voiture(array("couleur" => "", "marque" => "Citröen", "modele" => "Citröen C4", "motorisation" => "", "nbDeKm" => 10000));
$voiture2 = new Voiture(array("couleur" => "Rouge", "marque" => "Renault", "modele" => "Renault Kadjar", "motorisation" => "" , "nbDeKm" => ""));
$voiture->concatenation();
$voiture2->concatenation();
$voiture->rouler(1);
$voiture->concatenation();