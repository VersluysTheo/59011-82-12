<?php 

include './Rectangle.class.php';
include './TriangleRectangle.class.php';
include './Cercle.class.php';
include './Pave.class.php';
include './Pyramide.class.php';
include './Sphere.class.php';

$rectangle = new Rectangle(array("longueur" => 12, "largeur" => 15));
$rectangle->Afficher();
echo '<br>';
$triangle = new Trianglerectangle(array("base" => 6, "hauteur" => 11));
$triangle->Afficher();
echo '<br>';
$cercle = new Cercle(array("diametre" => 10));
$cercle->Afficher();
echo '<br>';
$pave = new Pave(array("longueur" => 14, "largeur" => 15 ,"hauteur" => 9));
$pave->Afficher();
echo '<br>';
$pyramide = new Pyramide(array("base" => 8, "hauteur" => 15));
$pyramide->Afficher();
echo '<br>';
$sphere = new Sphere(array("diametre" => 9));
$sphere->Afficher();