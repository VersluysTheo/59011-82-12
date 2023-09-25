<?php

class Cercle
{
/*****************Attributs***************** */
    private $_diametre;

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

    public function getDiametre()
    {
        return $this->_diametre;
    }

    public function setDiametre($diametre)
    {
        $this->_diametre = $diametre;
    }

        /*****************Autres Méthodes***************** */

        function perimetre(){
            $perimetre = round(2*pi()*($this->getDiametre()/2),2);
            return $perimetre;
        }

        function aire(){
            $aire = round(pi()*(($this->getDiametre()/2)**2),2);
            return $aire;
        }

        function __toString()
    {
        return "Diametre : [" . $this->getDiametre() . "] - " . "Perimetre : [" . $this->perimetre() . "] - " . "Aire : [" . $this->aire() . "]";
    }
        function afficherCercle(){
        echo $this->__toString();
    }
}