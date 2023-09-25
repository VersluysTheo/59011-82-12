<?php 

class Trianglerectangle
{
/*****************Attributs***************** */
    private $_base;
    private $_hauteur;

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

    public function getBase()
    {
        return $this->_base;
    }

    public function setBase($base)
    {
        $this->_base = $base;
    }

    public function getHauteur()
    {
        return $this->_hauteur;
    }

    public function setHauteur($hauteur)
    {
        $this->_hauteur = $hauteur;
    }
        
    /*****************Autres Méthodes***************** */

        function perimetre(){
            $perimetre = round($this->getBase() + $this->getHauteur() + sqrt($this->getBase()**2 + $this->getHauteur()**2),2);
            return $perimetre;
        }

        function aire(){
            $aire = ($this->getBase()*$this->getHauteur())/2;
            return $aire;
        }

        function __toString()
    {
        return "Base : [" . $this->getBase() . "] - " . "Hauteur : [" . $this->getHauteur() . "] - " . "Perimetre : [" . $this->perimetre() . "] - " . "Aire : [" . $this->aire() . "] - ";
    }
        function afficherTriangle(){
        echo $this->__toString();
    }
}