<?php

class User
{
/*****************Attributs***************** */
    private $_username;

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

    public function getUsername()
    {
        return $this->_username;
    }

    public function setUsername($username)
    {
        $this->_username = $username;
    }
        /*****************Autres Méthodes***************** */
        function __toString()
    {
        return $this->isReading();
    }
    function isReading(){
        rand(0,1) == 1 ? true : false;
    }
}