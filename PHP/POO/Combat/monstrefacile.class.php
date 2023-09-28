<?php 

class MonstreFacile
{
#region Attribut

/*****************Attributs***************** */
    private $_Estenvie;

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

    public function getEstenvie()
    {
        return $this->_Estenvie;
    }

    public function setEstenvie($Estenvie)
    {
        $this->_Estenvie = $Estenvie;
    }

#endregion Constructeur
}