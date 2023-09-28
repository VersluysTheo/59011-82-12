<?php

class Joueur
{
#region Attribut

/*****************Attributs***************** */
    private $_pointdevie;
    private $_dice ;

#endregion Attribut

#region Constructeur

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

    public function getPointdevie()
    {
        return $this->_pointdevie;
    }

    public function setPointdevie()
    {
        $this->_pointdevie = 50;
    }
    public function getDice()
    {
        return $this->_dice;
    }

    public function setDice($dice)
    {
        $this->_dice = $dice;
    }

#endregion Constructeur

#region Autres Methodes

    /*****************Autres Méthodes***************** */
    public function estVivant(){
        if ($this->getPointdevie() == 0){
            return " Vous êtes mort ";
        }
    }

    public function Attaque(){
        return "Heros (resultat dice)" ;
    }

    public function Bouclier(){
        return "Bouclier ( Resultat dice )" ;
    }

    public function Subitdegats(){
        return "Heros subit N degats. Il vous reste N point de vie" ;
    }
    public function Lancerlede(){
        return Dice::Lancerlede();
    }

#endregion Autres Methodes
}