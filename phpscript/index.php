<?php 
require 'attributes.php';

$oui = GenPoco::createPoco("toto",["id","nom","prenom","date_naissance"]);
echo $oui;