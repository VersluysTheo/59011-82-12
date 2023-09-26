<?php 

class Rectangle
{
/*****************Attributs***************** */
    private $_longueur;
    private $_largeur;

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
    public function getLongueur()
    {
        return $this->_longueur;
    }

    public function setLongueur($longueur)
    {
        $this->_longueur = $longueur;
    }

    public function getLargeur()
    {
        return $this->_largeur;
    }

    public function setLargeur($largeur)
    {
        $this->_largeur = $largeur;
    }

        /*****************Autres Méthodes***************** */

        function perimetre(){
            $perimetre = $this->getLongueur() * 2 + $this->getLargeur() * 2;
            return $perimetre;
        }

        function aire(){
            $aire = $this->getLongueur() * $this->getLargeur();
            return $aire;
        }

        function isCarre(){
            if ($this->getLongueur() == $this->getLargeur()){
                return "Il s'agit d'un carré";
            } else {
                return "Il ne s'agit pas d'un carré";
            }
        }

        function __toString()
        {
            return "Rectangle => Longueur : [" . $this->getLongueur() . "] - " . "Largeur : [" . $this->getLargeur() . "] - " . "Perimetre : [" . $this->perimetre() . "] - " . "Aire : [" . $this->aire() . "] - " . $this->isCarre();
        }

        function Afficher(){
            echo $this->__toString();
        }
}