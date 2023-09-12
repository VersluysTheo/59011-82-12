<<<<<<< HEAD
<?php 

// $somme = readline('Somme à payer : ');
// $payer = readline('Somme qu\'il a payé : ');

// Solution de clement

$tab =[];

do{
    $prix =readline('prix article : ');
    if ($prix < 0){
        echo "prix invalide \n";
    } else {
        $tab[] = $prix;
    }
    
} while ($prix != 0);

$article = count($tab)-1;
echo 'nombre d\'article -> ' . $article. "\n";
$total =array_sum($tab);
echo 'total -> '. $total. "\n";

do{
    $payer =readline("payer : ");
} while ($payer < $total);


// Ce que j'ai trouvé

$monnaie = $payer - $total ;

if($payer > $total){

    while ($monnaie > 10){
        $monnaie -= 10;
        echo "Billet de 10 euros \n";
    }
    
    if($monnaie >= 5){
        $monnaie -= 5;
        echo "Billet de 5 euros \n";
    }

    while ($monnaie > 0){
        $monnaie -= 1; 
        echo "Piece de 1 euros \n";
    }   
} else {
    echo "pas de monnaie";
=======
<?php 

// $somme = readline('Somme à payer : ');
// $payer = readline('Somme qu\'il a payé : ');

// Solution de clement

$tab =[];

do{
    $prix =readline('prix article : ');
    if ($prix < 0){
        echo "prix invalide \n";
    } else {
        $tab[] = $prix;
    }
    
} while ($prix != 0);

$article = count($tab)-1;
echo 'nombre d\'article -> ' . $article. "\n";
$total =array_sum($tab);
echo 'total -> '. $total. "\n";

do{
    $payer =readline("payer : ");
} while ($payer < $total);


// Ce que j'ai trouvé

$monnaie = $payer - $total ;

if($payer > $total){

    while ($monnaie > 10){
        $monnaie -= 10;
        echo "Billet de 10 euros \n";
    }
    
    if($monnaie >= 5){
        $monnaie -= 5;
        echo "Billet de 5 euros \n";
    }

    while ($monnaie > 0){
        $monnaie -= 1; 
        echo "Piece de 1 euros \n";
    }   
} else {
    echo "pas de monnaie";
>>>>>>> 3e240c6d82fe630496b19408b227ae280491c178
}