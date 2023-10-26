<?php 
if (($genre == "hommes" && $ages > 20) || ($genre == "femmes" && ($ages > 17 && $ages < 36))){
    echo "Vous payez des impôts";
} else {
    echo "Vous ne payez pas d'impôts";
}



//correction

if (($genre == "H" && $ages > 20) || ($genre == "F" && ($ages > 17 && $ages < 36))){
}

?>