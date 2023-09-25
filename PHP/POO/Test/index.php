<?php 

class peraeze
{
/*****************Attributs***************** */
    private $_nom;

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
/**
* Get the value of _nom
*/ 
    public function get_nom()
    {
    return $this->_nom;
    }
/**
* Set the value of _nom
*
* @return  self
*/
    public function set_nom($_nom)
    {
    $this->_nom = $_nom;
    return $this;
    }
    /*****************Autres Méthodes***************** */

}