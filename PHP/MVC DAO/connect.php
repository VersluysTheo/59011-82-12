<?php 


// exemple trouvé dans une doc json ( sans doute faux )
$jsonStr = file_get_contents("config.json");
$config = json_decode($jsonStr);

$con = mysqli_connect(
    $config->database->host,
    $config->database->port,
    $config->database->user,
    $config->database->password,
    $config->database->dbname
);

if (mysqli_connect_errno())
{
    echo "Erreur de connexion a " . $config->database->dbname . mysqli_connect_error() . "\n";
}
else 
{
    echo "Connecté à la base de données" . $config->database->dbname . "\n";
}