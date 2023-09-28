<?php

class Enfant
{
/*****************Attributs***************** */
    private $_prenom;
    private $_age;

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

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($nom)
    {
        $this->_prenom = $nom;
    }

    public function getAge()
    {
        return $this->_age;
    }

    public function setAge($age)
    {
        $this->_age = $age;
    }
}