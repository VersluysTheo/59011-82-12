<?php 
$score1 = readline("Score du Candidat n°1 : ");
$score2 = readline("Score du Candidat n°2 : ");
$score3 = readline("Score du Candidat n°3 : ");
$score4 = readline("Score du Candidat n°4 : ");

if ($score1 <12.5 || $score2 > 50 || $score3 > 50 || $score4 > 50){
    echo "Le candidat a été battu";
} elseif ($score1 > 50){
    "Le candidat n°1 a été élu";
} elseif ($score1 > $score2 && $score1 > $score3 && $score1 > $score4){
    "Le candidat n°1 se trouve en ballotage favorable";
} else {
    echo "le candidat numéro 1 se trouve en ballotage défavorable";
}



?>