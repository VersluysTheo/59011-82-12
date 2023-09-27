<?php 

class Employee
{
/*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateembauche;
    private $_salairebrutannuel;
    private $_service;
    public static $compteur;
    private $_agence;

/*****************Constructeur***************** */

    public function __construct(array $options = [])
{
    if (!empty($options)) // empty : renvoi vrai si le tableau est vide
    {
    $this->hydrate($options);
    }
    self::$compteur++; // Compter le nombre d'objet instancié 
}
    public function hydrate($data)
{
    foreach ($data as $key => $value)
    {
    $methode = 'set' . ucfirst($key); // changer la typographie pour les setters et getters
    if (is_callable([$this, $methode]))
        {
    $this->$methode($value);
        }
    }
}
/* Setter et Getter */
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateembauche()
    {
        return $this->_dateembauche;
    }

    public function setDateembauche($dateembauche)
    {
        $this->_dateembauche = $dateembauche;
    }

    public function getSalairebrutannuel()
    {
        return $this->_salairebrutannuel;
    }

    public function setSalairebrutannuel($salairebrutannuel)
    {
        $this->_salairebrutannuel = $salairebrutannuel;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }
    public static function getCompteur()
    {
        return self::$compteur;
    }

    public static function setCompteur($compteur)
    {
        return self::$compteur = $compteur;
    }
    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence($agence)
    {
        $this->_agence = $agence;
    }

        /*****************Autres Méthodes***************** */

    public function __toString()
    {
        return $this->getPrenom() . " " . $this->getNom() . " a été recruté il y a " . $this->recrutement() . " ans et fait parti du service " . $this->getService() . " et possède un salaire brut annuel de " . $this->getSalairebrutannuel() . " euros \n" . "et a pour de restauration : " . $this->getAgence()->getModeRestauration();
    }
    // fonction calcul du nombre d'années de recrutement
    public function recrutement(){
        $date = date_create($this->getDateembauche());
        $dateauj = date_create('now');
        $interval = date_diff($date, $dateauj);
       return $interval->format('%Y');
    }

    // Fonction de Tri
    public static function triparNom($a,$b){
        return ($a->getNom()) <=> ($b->getNom());
    }
    public static function triparPrenom($a,$b){
        return ($a->getPrenom()) <=> ($b->getPrenom());
    }

    public static function triparService($a,$b){
        return ($a->getService()) <=> ($b->getService());
    }

    /* Fonction pour indiquer les infos */
    public function infos(){
        echo $this->__toString();
    }

    /* Fonction pour indiquer le montant de la prime */
    public function prime(){
        return ($this->getSalairebrutannuel()*(0.05 + (0.02*$this->recrutement())));
    }

    /* Fonction pour indiquer que le versement a été fait */
    public function versement(){
        $jourvers = new DateTime('now');
        if ($jourvers->format('d-m') == "30-11" ){
            echo "Le versement de " . $this->prime() . " euros a été effectué" ;
        }
    }
    public static function masseSalariale($employe){
        $masseSalariale = 0;
        foreach ($employe as $employes) {
            $masseSalariale += $employes->getSalairebrutannuel() + $employes->prime();
        }
        return $masseSalariale;
    }
}