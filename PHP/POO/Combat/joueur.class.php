<?php

class Joueur
{
#region Attribut
/*****************Attributs***************** */
    private $_pointdevie;
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

    public function setPointdevie($pointdevie)
    {
        $this->_pointdevie = $pointdevie;
    }
#endregion Constructeur
}