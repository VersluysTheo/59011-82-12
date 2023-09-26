<?php 

class Employee
{
/*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateembauche;
    private $_salairebrutannuel;
    private $_service;

/*****************Constructeur***************** */

    public function __construct(array $options = [])
{
    if (!empty($options)) // empty : renvoi vrai si le tableau est vide
    {
    $this->hydrate($options);
    }
}
    public function hydrate($data)
{
    foreach ($data as $key => $value)
    {
    $methode = 'set' . ucfirst($key);
    if (is_callable([$this, $methode]))
        {
    $this->$methode($value);
        }
    }
}

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

        /*****************Autres Méthodes***************** */

    public function __toString()
    {
        return $this->getPrenom() . " a été recruté il y a " . $this->recrutement() . " ans et recevra une prime de " . $this->prime() . " euros \n";
    }

    public function recrutement(){
        $date = date_create($this->getDateembauche());
        $dateauj = date_create('now');
        $interval = date_diff($date, $dateauj);
       return $interval->format('%Y');

    }
    public function infos(){
        echo $this->__toString();
    }
    public function prime(){
        return ($this->getSalairebrutannuel()*(0.05 + (0.02*$this->recrutement())));
    }
    public function versement(){
        $jourvers = new DateTime('now');
        if ($jourvers->format('d-m') == "30-11" ){
            echo "Le versement de " . $this->prime() . " euros a été effectué" ;
        }
    }
    
}