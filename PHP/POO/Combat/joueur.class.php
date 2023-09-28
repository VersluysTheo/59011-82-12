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
    public function estVivant(){ // Fonction pour savoir si le joueur est en vie
        if ($this->getPointdevie() > 0){
            return true;
        } else {
            return false;
        }
    }

    public function Attaque(){ // Fonction d'attaque (avec le lancer de des)
        return "";
    }

    public static function Bouclier(){ // Fonction du Bouclier pour bloquer potentiellement les degats
        $bouclier = Dice::Lancerlede();
        if ($bouclier <= 2){
            return true;
        } else {
            return false ;
        }
    }

    public function Subitdegats(){ // Fonction pour savoir les degats infliges
        return "";
    }
    public static function Lancerlede(){ // Fonction Lancer le de
        return Dice::Lancerlede();
    }

#endregion Autres Methodes
}