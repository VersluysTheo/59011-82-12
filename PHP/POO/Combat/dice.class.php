<?php

class Dice
{

#region Attributs    

/*****************Attributs***************** */


#endregion Attributs

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
#endregion Constructeur

/*****************Autres Méthodes***************** */
    public static function Lancerlede(){
        return rand(1,6);
    }
}