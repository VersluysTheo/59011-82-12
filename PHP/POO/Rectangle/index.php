<?php 

include './Rectangle.class.php';
include './TriangleRectangle.class.php';
include './Cercle.class.php';
include './Pave.class.php';

$rectangle = new Rectangle(array("longueur" => 12, "largeur" => 15));
$rectangle->AfficherRectangle();
echo '<br>';
$triangle = new Trianglerectangle(array("base" => 6, "hauteur" => 11));
$triangle->afficherTriangle();
echo '<br>';
$cercle = new Cercle(array("diametre" => 10));
$cercle->afficherCercle();
echo '<br>';
$pave = new Pave(array("longueur" => 6, "largeur" => 7, "hauteur" => 9));
$pave->AfficherRectangle();