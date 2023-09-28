<?php

class Dice
{
/*****************Attributs***************** */
    private $_result; //Resultat lancé de dé

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
// Setter et Getter
    public function getResult()
    {
        return $this->_result;
    }

    public function setResult($result)
    {
        $this->_result = $result;
    }
}